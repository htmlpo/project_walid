using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace umniabank
{
    public partial class inscription : Form
    {
       
            const string mysqlcon = "server=10.110.0.179 ;user=finance; database=finapp_db;pwd=Db@Pr3p#79";
            MySqlConnection mysqlconn = new MySqlConnection(mysqlcon);

      

        public inscription()
        {
            InitializeComponent();
           
        }
      
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string confirmPassword = textBox3.Text;
            bool isAdmin = checkBox1.Checked;
            bool isUser = checkBox2.Checked;

           
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Les mots de passe ne correspondent pas.");
                return;
            }
            string role;
            if (isAdmin)
            {
                role = "admin";
            }
            else if (isUser)
            {
                role = "user";
            }
            else
            {
               
                MessageBox.Show("Veuillez sélectionner un rôle valide.");
                return;
            }


            mysqlconn.Open();

            string query = "INSERT INTO `users`( `username`, `password`, `role`) VALUES (@username, @password, @role)";
            MySqlCommand command = new MySqlCommand(query, mysqlconn);

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@role", role);


            try
            {
                command.ExecuteNonQuery();
                // Créer une nouvelle instance de LoginForm
                LoginForm loginForm = new LoginForm();

                // Afficher le formulaire LoginForm
                loginForm.Show();

                // Cacher le formulaire actuel (activite)
                this.Hide();
                MessageBox.Show("Inscription réussie!");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'inscription : " + ex.Message);
            }
            finally { mysqlconn.Close(); }
        }

        private void inscription_Load(object sender, EventArgs e)
        {

        }

        private void inscription_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}



