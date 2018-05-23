using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SEProject
{
    public partial class Charts : Form
    {
        public static int descasc;
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;
        public static string username;
        public static int operation;
        private string connString;
        private String[] laptopProducents;
        private String[] smartfonProducents;
        private String[] productAttributes;
        private DataTable dt;
        public Charts()
        {
            laptopProducents = new string[]{ "Lenovo", "HP", "ASUS","DELL","MSI","Apple"};
            smartfonProducents = new string[] { "Lenovo", "XIAOMI", "NOKIA", "SAMSUNG", "Apple" };
            productAttributes = new string[] { "Cena", "Waga", "Rozmiar pamięci RAM", "Rozmiar dysku twardego", "Częstotliwość zegara procesora","Ilość rdzeni procesora" };

            server = "localhost";
            database = "electronicstore_projekt";
            uid = "root";
            password = "";

            connString = $"SERVER={server};UID={uid};PASSWORD={password};DATABASE={database};";
            conn = new MySqlConnection(connString);

            dt = new DataTable();
            dt.Columns.Add("XXX");
          
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_wyczysc_zazn_Click(object sender, EventArgs e)
        {
            listBox_atrybuty.ClearSelected();
            listBox_szablony.ClearSelected();
            textBox_wyszukaj.Text = "";
        }

        private void listBox_atrybuty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox_szablony_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            listBox_model.DataSource = dt;
            dt.Columns.Add("XXX");
            listBox_model.DisplayMember = "XXX";
            // listBox_model.Items.Clear();
            listBox_atrybuty.Items.Clear();
            listBox_model.Enabled = true;
            switch (listBox_szablony.SelectedIndex)
            {
                case 0:
                    listBox_atrybuty.Items.Add("Najlepiej się sprzedające");
                    listBox_atrybuty.Items.Add("Najgorzej się sprzedające");
                    listBox_model.Enabled = false;
                    break;
                case 1:
                    listBox_atrybuty.Items.Add("Najlepiej się sprzedające");
                    listBox_atrybuty.Items.Add("Najgorzej się sprzedające");
                    listBox_model.Enabled = false;
                    break;
                case 2:
                    load_attributes("smartfon");
                    load_model("smartfon",dt);             
                    break;
                case 3:
                    load_attributes("laptop");
                    load_model("laptop", dt);
                    break;
                case 4:
                    load_producer("smartfon", dt);
                    break;
                case 5:
                    load_producer("laptop", dt);
                    break;
            }
        }

        private void load_attributes(string v)
        {
            int x = productAttributes.Length;
            for (int i = 0; i < x; i++)
            {
                listBox_atrybuty.Items.Add(productAttributes[i]);
            }
            if (v.Equals("laptop"))
            {
                listBox_atrybuty.Items.Add("Posiadanie dedykowanej karty graficznej");
            }
           
        }

        private void load_producer(string v,DataTable dt)
        {
          
            if (v.Equals("laptop"))
            {
                int x = laptopProducents.Length;
                for (int i = 0; i < x; i++)
                {
                    dt.Rows.Add(laptopProducents[i]);
                    //listBox_model.Items.Add(laptopProducents[i]);
                }
            }
            else
            {
                int x = smartfonProducents.Length;
                for (int i = 0; i < x; i++)
                {
                    dt.Rows.Add(smartfonProducents[i]);
                    //listBox_model.Items.Add(smartfonProducents[i]);
                }
            }       
        }

        private void load_model(String productType, DataTable dt)
        {
                conn.Open();
                string query = $"SELECT * FROM product WHERE productType='{productType}'";                  
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                dt.Rows.Add(reader.GetString("producer") + " " + reader.GetString("productModel"));
                    //listBox_model.Items.Add(reader.GetString("producer") + " "+reader.GetString("productModel"));
                }
                reader.Close();


                conn.Close();
             
            


        }

        private void button_generuj_wykres_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox_szablony.Text);
            switch (listBox_szablony.SelectedIndex)
            {
                case 0:              
                        operation = 0;
                        descasc = listBox_atrybuty.SelectedIndex;
                        Diagram f = new Diagram();
                        f.ShowDialog();                     
                    break;

                case 1:
                    operation = 1;
                    descasc = listBox_atrybuty.SelectedIndex;
                    Diagram g = new Diagram();
                    g.ShowDialog();

                    break;
                case 2:
                    if (czy_tylko_dwa_zaznaczenia())
                    {
                        MessageBox.Show("option 3");
                    }
                    break;
                case 3:
                    if (czy_tylko_dwa_zaznaczenia())
                    {
                        MessageBox.Show("option 4");
                    }
                    break;
                case 4:
                    MessageBox.Show("option 5");
                    break;
                case 5:
                    MessageBox.Show("option 6");
                    break;
                default:
                    MessageBox.Show("Nie wybrano szablonu!");
                    break;

            }
        }

        private bool czy_tylko_dwa_zaznaczenia()
        {
            var lst = listBox_model.SelectedItems.Cast<DataRowView>();
            List<string> list = new List<string>();
            foreach (var item in lst)
            {
                list.Add(item.Row[0].ToString());
            }
            int a = list.Count();
            if (a == 2)
            {
                return true;
            }
            else
            {
                if (a < 2)
                {
                    MessageBox.Show("Za mało zaznaczonych modeli.");
                }
                else
                {
                    MessageBox.Show("Za dużo zaznaczonych modeli.");
                }
                return false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox_model_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_wyszukaj_TextChanged(object sender, EventArgs e)
        {
           
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format($"XXX LIKE '%{textBox_wyszukaj.Text}%'");
            
          
                
            

        }

        private void textBox_wyszukaj_Click(object sender, EventArgs e)
        {
            textBox_wyszukaj.Text = "";
        }
    }
}
