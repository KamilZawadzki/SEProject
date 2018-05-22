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
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;
        public static string username;
        public static string operation;
        private string connString;
        public Charts()
        {
            server = "localhost";
            database = "electronicstore_projekt";
            uid = "root";
            password = "";

            connString = $"SERVER={server};UID={uid};PASSWORD={password};DATABASE={database};";
            conn = new MySqlConnection(connString);
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
        }

        private void listBox_atrybuty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox_szablony_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_model.Items.Clear();
            switch (listBox_szablony.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    load_telephone_model();
                    //MessageBox.Show("option 3");
                    break;
                case 3:
                    load_telephone_model();
                    break;
                case 4:
                    //MessageBox.Show("option 5");
                    break;
                case 5:
                    //MessageBox.Show("option 6");
                    break;
            }
        }

        private void load_telephone_model()
        {

                conn.Open();
                string query = "SELECT * FROM product WHERE productType='smartfon'";              
               
             
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listBox_model.Items.Add(reader.GetString("productModel"));
                }

                //foodGreetingsLabel2.Text = reader.GetString("Wyzywienie");
                reader.Close();


                conn.Close();
             
            


        }

        private void button_generuj_wykres_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox_szablony.Text);
            switch (listBox_szablony.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("option 1");

                    break;
                case 1:
                    MessageBox.Show("option 2");
                    break;
                case 2:
                    MessageBox.Show("option 3");
                    break;
                case 3:
                    MessageBox.Show("option 4");
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
    }
}
