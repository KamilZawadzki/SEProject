using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SEProject
{
    public partial class Diagram : Form
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;
        public Diagram()
        {
            server = "localhost";
            database ="electronicstore_projekt";
            uid = "root";
            password = "";
            string connString;
            connString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
            conn = new MySqlConnection(connString);
            InitializeComponent();
           
            switch (Charts.operation)
            {
                case 0:
                   
                    ilosc_sprzed_tel_podz_marki();
                    label_nazwa_szablonu.Text="Ilość sprzedanych telefonów z podziałem na ich marki";
                    break;
                case 1:
                    
                    ilosc_sprzed_laptopow_podz_marki();
                    label_nazwa_szablonu.Text = "Ilość sprzedanych laptopów z podziałem na ich marki";
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    MessageBox.Show("Podano zły szablon operacji");
                    break;
            }

            

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        public void ilosc_sprzed_tel_podz_marki()
        {
            string querry="";
            if (Charts.descasc==0)
            {
                querry = $"SELECT product.producer, SUM(sale.amount) as 'Ilosc' FROM sale INNER JOIN product ON sale.productID = product.ID WHERE product.productType='smartfon' GROUP BY product.producer ORDER BY Ilosc DESC LIMIT 4;";
            }
            else
            {
                if (Charts.descasc==1)
                    querry = $"SELECT product.producer, SUM(sale.amount) as 'Ilosc' FROM sale INNER JOIN product ON sale.productID = product.ID WHERE product.productType='smartfon' GROUP BY product.producer ORDER BY Ilosc ASC LIMIT 4;";
                else
                {
                    querry = $"SELECT product.producer, SUM(sale.amount) as 'Ilosc' FROM sale INNER JOIN product ON sale.productID = product.ID WHERE product.productType='smartfon' GROUP BY product.producer  LIMIT 4;";
                }
            }
            

            MySqlDataReader reader;
            MySqlCommand cmd = new MySqlCommand(querry, conn);

            chart1_diagram.Series.Clear();
            chart1_diagram.Series.Add("Ilość sprzedanych smartfonów");
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                this.chart1_diagram.Series["Ilość sprzedanych smartfonów"].Points.AddXY(reader.GetString("producer"), reader.GetString("Ilosc"));
            }
            conn.Close();
           
        }

        private void ilosc_sprzed_laptopow_podz_marki()
        {
            string querry = "";
            if (Charts.descasc == 0)
            {
                querry = $"SELECT product.producer, SUM(sale.amount) as 'Ilosc' FROM sale INNER JOIN product ON sale.productID = product.ID WHERE product.productType='laptop' GROUP BY product.producer ORDER BY Ilosc DESC LIMIT 4;";
            }
            else
            {
                if (Charts.descasc == 1)
                    querry = $"SELECT product.producer, SUM(sale.amount) as 'Ilosc' FROM sale INNER JOIN product ON sale.productID = product.ID WHERE product.productType='laptop' GROUP BY product.producer ORDER BY Ilosc ASC LIMIT 4;";
                else
                {
                    querry = $"SELECT product.producer, SUM(sale.amount) as 'Ilosc' FROM sale INNER JOIN product ON sale.productID = product.ID WHERE product.productType='laptop' GROUP BY product.producer  LIMIT 4;";
                }
            }

            MySqlDataReader reader;
            MySqlCommand cmd = new MySqlCommand(querry, conn);

            chart1_diagram.Series.Clear();
            chart1_diagram.Series.Add("Ilość sprzedanych laptopów");
            chart1_diagram.Series["Ilość sprzedanych laptopów"].Color = Color.Red;
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                this.chart1_diagram.Series["Ilość sprzedanych laptopów"].Points.AddXY(reader.GetString("producer"), reader.GetString("Ilosc"));
            }
            conn.Close();
            
        }

        

        private void Diagram_Load(object sender, EventArgs e)
        {

        }

        private void button_zapisz_Click(object sender, EventArgs e)
        {
            string startupPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            this.chart1_diagram.SaveImage(startupPath + "\\diagram.jpeg", System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Jpeg);
        }
    }
}
