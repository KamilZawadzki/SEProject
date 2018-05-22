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
        public static int operation;

        public Charts()
        {
            server = "localhost";
            database = "electronicstore_projekt";
            uid = "root";
            password = "";
            string connString;
            connString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
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

        }

        private void button_generuj_wykres_Click(object sender, EventArgs e)
        {
           
            switch (listBox_szablony.SelectedIndex)
            {
                case 0:
                    
                    operation = 0;
                    Diagram f = new Diagram();
                    f.ShowDialog();
                    break;
                case 1:
         
                    operation = 1;
                    Diagram g = new Diagram();
                    g.ShowDialog();
                    break;
                case 2:
                    MessageBox.Show("option 3");
                    operation = 2;
                    break;
                case 3:
                    MessageBox.Show("option 4");
                    operation = 3;
                    break;
                    
                case 4:
                    MessageBox.Show("option 5");
                    operation = 4;
                    break;
                case 5:
                    MessageBox.Show("option 6");
                    operation = 5;
                    break;
                default:
                   MessageBox.Show("Nie wybrano szablonu!"); 
                    break;

            }
        }
    }
}
