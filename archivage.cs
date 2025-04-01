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
using System.Drawing;
using System.Drawing.Printing;
using Microsoft.Extensions.Configuration;

namespace umniabank
{
    public partial class archivage : Form
    {
        const string mysqlcon = "server=10.110.0.179 ;user=finance; database=finapp_db;pwd=Db@Pr3p#79";
         MySqlConnection mysqlconn = new MySqlConnection(mysqlcon);
        public archivage()
        {
            InitializeComponent();
            LoadArchivageData();
           
        }
      

        private void FormArchivage_Load(object sender, EventArgs e)
        {
            // Charger les données archivées dans DataGridView

        }


        private void LoadArchivageData()
        {
            try
            {
                mysqlconn.Open();
                string query = "SELECT * FROM archivage";
                MySqlCommand cmd = new MySqlCommand(query, mysqlconn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
            }
            finally
            {
                mysqlconn.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            activite activite = new activite();
            activite.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();

            }
        }
    }
}
