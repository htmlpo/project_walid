using System.Data;
using System.Drawing.Printing;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using OfficeOpenXml;

namespace umniabank
{
    public partial class LoginForm : Form
    {
        const string mysqlcon = "server=10.110.0.179 ;user=finance; database=finapp_db;pwd=Db@Pr3p#79";

        MySqlConnection mysqlconn = new MySqlConnection(mysqlcon);


        public LoginForm()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = user_txt.Text;
            string password = pwd_txt.Text;
            string role = AuthenticateUser(username, password);
            if (!string.IsNullOrEmpty(role))
            {
                // Si l'authentification réussit, ouvrez le formulaire principal
                activite mainForm = new activite(role);
                mainForm.Show();
                this.Hide(); // Cachez le formulaire de connexion
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect .");
            }
        }

        private string AuthenticateUser(string username, string password)
        {
            try
            {
                mysqlconn.Open();

                string query = "SELECT role FROM users WHERE username = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, mysqlconn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password); // Note : Il est recommandé de hacher le mot de passe avant de le stocker et de le comparer

                return cmd.ExecuteScalar() as string;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
                return null;
            }
            finally
            {
                mysqlconn.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Créer une nouvelle instance de LoginForm
            inscription inscription = new inscription();

            // Afficher le formulaire LoginForm
            inscription.Show();
            // Cacher le formulaire actuel (activite)
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}


