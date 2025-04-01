
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using Microsoft.Extensions.Configuration;
using OfficeOpenXml;
using Mysqlx.Connection;

namespace umniabank

{
    public partial class activite : Form

    {


        const string mysqlcon = "server=10.110.0.179 ;user=finance; database=finapp_db;pwd=Db@Pr3p#79";
        MySqlConnection mysqlconn = new MySqlConnection(mysqlcon);



        public activite()
        {
            InitializeComponent();
            txtReference.TextChanged += new EventHandler(this.textBox1_TextChanged_1);
            modifier.Click += new EventHandler(modifier_Click);
            printDocument1.BeginPrint += new PrintEventHandler(PrintDocument_BeginPrint);
            printDocument1.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            dataGridView1.SelectionChanged += new EventHandler(dataGridView_SelectionChanged);
            InitializeDataGridView();


        }



        private string userRole;

        public activite(string role)
        {
            InitializeComponent();
            userRole = role;
            ManageAccess();
            printDocument1.BeginPrint += new PrintEventHandler(PrintDocument_BeginPrint);
            printDocument1.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            dataGridView1.SelectionChanged += new EventHandler(dataGridView_SelectionChanged);

        }
        // Exemple : Redimensionner les colonnes apr�s avoir import� les donn�es
        private void InitializeDataGridView()
        {

            if (dataGridView1.Columns.Contains("id"))
            {
                dataGridView1.Columns["id"].Visible = false;
            }
        }
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Assurez-vous qu'une ligne est s�lectionn�e
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                acc_txt.Text = selectedRow.Cells["activit�"].Value.ToString();
                evt_combo.Text = selectedRow.Cells["evt_de_gestion"].Value.ToString();
                acc_txt.Text = selectedRow.Cells["acc"].Value.ToString();
                dv_combo.Text = selectedRow.Cells["devise"].Value.ToString();
                lib_txt.Text = selectedRow.Cells["libell�"].Value.ToString();
                sens_combo.Text = selectedRow.Cells["sens"].Value.ToString();
                mnt_txt.Text = selectedRow.Cells["montant"].Value.ToString();
                ref_txt.Text = selectedRow.Cells["ref"].Value.ToString();
                ID_txt.Text = selectedRow.Cells["id"].Value.ToString();
            }
        }

        private void ManageAccess()
        { // Exemple de gestion d'acc�s en fonction du r�le
            switch (userRole)
            {
                case "admin":
                    // Activer tous les boutons pour l'administrateur
                    ajouter.Visible = true;
                    supprimer.Visible = true;
                    modifier.Visible = true;
                    Imp_btn.Visible = true;
                    btnExport.Visible = true;
                    button1.Visible = true;
                    break;

                case "user":
                    // D�sactiver certains boutons pour les utilisateurs normaux
                    ajouter.Visible = false;
                    supprimer.Visible = false;
                    modifier.Visible = false;
                    Imp_btn.Visible = true;
                    btnExport.Visible = false;
                    button1.Visible = true;
                    recharge_button.Visible = false;
                    break;

                default:
                    // D�faut : masquer tous les boutons par pr�caution
                    ajouter.Visible = false;
                    supprimer.Visible = false;
                    modifier.Visible = false;
                    Imp_btn.Visible = false;
                    btnExport.Visible = false;
                    button1.Visible = false;
                    break;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void activite_Load(object sender, EventArgs e)
        {

            afficher_info();
        }
        void afficher_info()
        {
            try
            {

                string query = "SELECT * FROM xn";
                MySqlCommand cmd = new MySqlCommand(query, mysqlconn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur MySQL : " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string activit� = act_txt.Text;
            string evt_de_gestion = evt_combo.Text;
            string acc = acc_txt.Text;
            string devise = dv_combo.Text;
            string libelle = lib_txt.Text;
            string sens = sens_combo.Text;
            string montant = mnt_txt.Text;
            string id = ref_txt.Text;
            try
            {

                mysqlconn.Open();
                string query = "INSERT INTO xn (activit�, evt_de_gestion, acc, devise, libell�, sens, montant, ref) VALUES(@activit� , @evt_de_gestion, @acc, @devise, @libelle, @sens, @montant, @id)";
                MySqlCommand cmd = new MySqlCommand(query, mysqlconn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@activit�", act_txt.Text);
                cmd.Parameters.AddWithValue("@evt_de_gestion", evt_combo.Text);
                cmd.Parameters.AddWithValue("@acc", acc_txt.Text);
                cmd.Parameters.AddWithValue("@devise", dv_combo.Text);
                cmd.Parameters.AddWithValue("@libelle", lib_txt.Text);
                cmd.Parameters.AddWithValue("@sens", sens_combo.Text);
                cmd.Parameters.AddWithValue("@montant", mnt_txt.Text);
                cmd.Parameters.AddWithValue("@id", ref_txt.Text);
                cmd.ExecuteNonQuery();
                afficher_info();
                act_txt.Clear();
                acc_txt.Clear();
                lib_txt.Clear();
                mnt_txt.Clear();
                ref_txt.Clear();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mysqlconn.Close();
            }
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string reference = txtReference.Text;
            SearchData(reference);

        }
        private void SearchData(string reference)
        {
            try
            {

                mysqlconn.Open();
                string query = "SELECT * FROM xn WHERE ref LIKE @reference";
                MySqlCommand cmd = new MySqlCommand(query, mysqlconn);

                cmd.Parameters.AddWithValue("@reference", "%" + reference + "%");
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mysqlconn.Close();
            }


        }
        int a;
        private void dataGridView1CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void recharge_button_Click(object sender, EventArgs e)
        {
            archivage archivage = new archivage();
            archivage.Show();
            this.Hide();
        }

        private void activite_DpiChangedAfterParent(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void modifier_Click(object sender, EventArgs e)
        {
            ModifySelectedRow();
        }
        private void ModifySelectedRow()
        {
            // V�rifiez qu'une ligne est s�lectionn�e
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // R�cup�rer l'ID de la ligne s�lectionn�e et le convertir en entier
                int id = Convert.ToInt32(selectedRow.Cells["id"].Value);

                // R�cup�rer les nouvelles valeurs des TextBox
                string newActivite = act_txt.Text;
                string newEvtDeGestion = evt_combo.Text;
                string newAcc = acc_txt.Text;
                string newDevise = dv_combo.Text;
                string newLibelle = lib_txt.Text;
                string newSens = sens_combo.Text;
                decimal newMontant = decimal.Parse(mnt_txt.Text);
                string newReference = ref_txt.Text;

                // Mise � jour de la base de donn�es
                try
                {
                    mysqlconn.Open();
                    string query = "UPDATE xn SET activit�=@newActivite, evt_de_gestion=@newEvtDeGestion, acc=@newAcc, devise=@newDevise, libell�=@newLibelle, sens=@newSens, montant=@newMontant, ref=@newReference WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, mysqlconn);

                    cmd.Parameters.AddWithValue("@newActivite", newActivite);
                    cmd.Parameters.AddWithValue("@newEvtDeGestion", newEvtDeGestion);
                    cmd.Parameters.AddWithValue("@newAcc", newAcc);
                    cmd.Parameters.AddWithValue("@newDevise", newDevise);
                    cmd.Parameters.AddWithValue("@newLibelle", newLibelle);
                    cmd.Parameters.AddWithValue("@newSens", newSens);
                    cmd.Parameters.AddWithValue("@newMontant", newMontant);
                    cmd.Parameters.AddWithValue("@newReference", newReference);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    // Mettre � jour la ligne dans le DataGridView
                    selectedRow.Cells["activit�"].Value = newActivite;
                    selectedRow.Cells["evt_de_gestion"].Value = newEvtDeGestion;
                    selectedRow.Cells["acc"].Value = newAcc;
                    selectedRow.Cells["devise"].Value = newDevise;
                    selectedRow.Cells["libell�"].Value = newLibelle;
                    selectedRow.Cells["sens"].Value = newSens;
                    selectedRow.Cells["montant"].Value = newMontant;
                    selectedRow.Cells["ref"].Value = newReference;
                    selectedRow.Cells["id"].Value = id;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Erreur de format : " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue : " + ex.Message);
                }
                finally
                {
                    mysqlconn.Close();
                }
            }
            else
            {
                MessageBox.Show("Veuillez s�lectionner une ligne � modifier.");
            }
        }

        private void Imp_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                DataTable importedDataTable = ImportExcelToDataTable(filePath);

                // V�rifiez si la colonne "sens" existe dans le DataTable import�
                if (!importedDataTable.Columns.Contains("sens"))
                {
                    MessageBox.Show("La colonne 'sens' n'existe pas dans le DataTable import�.");
                    return;
                }

                // Assurez-vous que le DataTable existant li� � dataGridView1 est disponible
                DataTable existingDataTable = (DataTable)dataGridView1.DataSource;

                // Ajouter la colonne 'id' si elle n'existe pas d�j�
                if (!existingDataTable.Columns.Contains("id"))
                {
                    existingDataTable.Columns.Add("id", typeof(int));
                }

                // Ajouter la colonne 'id' au DataTable import� si elle n'existe pas d�j�
                if (!importedDataTable.Columns.Contains("id"))
                {
                    importedDataTable.Columns.Add("id", typeof(int));
                }

                // Attribuer des valeurs uniques � la colonne 'id'
                int idCounter = existingDataTable.Rows.Count > 0 ? Convert.ToInt32(existingDataTable.Compute("MAX(id)", string.Empty)) + 1 : 1;
                foreach (DataRow row in importedDataTable.Rows)
                {
                    row["id"] = idCounter++;
                    existingDataTable.ImportRow(row);
                }

                // Mettre � jour le DataGridView pour afficher les donn�es combin�es
                dataGridView1.DataSource = existingDataTable;

                try
                {
                    mysqlconn.Open();
                    foreach (DataRow row in existingDataTable.Rows)
                    {
                        string query = "INSERT INTO xn (activit�, evt_de_gestion, acc, devise, libell�, sens, montant, ref) " +
                                       "VALUES(@activit�, @evt_de_gestion, @acc, @devise, @libell�, @sens, @montant, @ref)";
                        MySqlCommand cmd = new MySqlCommand(query, mysqlconn);
                        cmd.Parameters.AddWithValue("@activit�", row["activit�"]);
                        cmd.Parameters.AddWithValue("@evt_de_gestion", row["evt_de_gestion"]);
                        cmd.Parameters.AddWithValue("@acc", row["acc"]);
                        cmd.Parameters.AddWithValue("@devise", row["devise"]);
                        cmd.Parameters.AddWithValue("@libell�", row["libell�"]);
                        cmd.Parameters.AddWithValue("@sens", row["sens"]);
                        cmd.Parameters.AddWithValue("@montant", row["montant"]);
                        cmd.Parameters.AddWithValue("@ref", row["ref"]);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Les donn�es ont �t� ins�r�es avec succ�s.");
                }
                catch (Exception ex)
                {
                    // G�rer les exceptions ici
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    mysqlconn.Close();
                }
            }
        }

        private DataTable ImportExcelToDataTable(string filePath)
        {
            DataTable dataTable = new DataTable();
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                for (int i = 1; i <= worksheet.Dimension.End.Column; i++)
                {
                    string columnName = worksheet.Cells[1, i].Text.Trim(); // Supprime les espaces autour des noms de colonnes
                    dataTable.Columns.Add(columnName);
                }
                for (int i = 2; i <= worksheet.Dimension.End.Row; i++)
                {
                    DataRow row = dataTable.NewRow();
                    for (int j = 1; j <= worksheet.Dimension.End.Column; j++)
                    {
                        row[j - 1] = worksheet.Cells[i, j].Text;
                    }
                    dataTable.Rows.Add(row);
                }
            }
            return dataTable;
        }




        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                if (selectedRow.Cells["id"].Value != null) // Assurez-vous que "ref" est le nom de votre colonne de r�f�rence
                {
                    string id = selectedRow.Cells["id"].Value.ToString();

                    // Supprimez la ligne de la base de donn�es
                    DeleteData(id);
                    ArchiveData(selectedRow);

                    // Supprimez la ligne du DataGridView

                    dataGridView1.Rows.Remove(selectedRow);


                }
            }
            else
            {

            }


        }
        private void DeleteData(string id)
        {
            try
            {
                mysqlconn.Open();

                string query = "DELETE FROM xn WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(query, mysqlconn);

                cmd.Parameters.AddWithValue("@id", id);

                int rowsAffected = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression : {ex.Message}");
            }
            finally
            {
                mysqlconn.Close();
            }
        }
        private void ArchiveData(DataGridViewRow selectedRow)
        {
            try
            {
                mysqlconn.Open();

                // Exemple : ins�rer dans la table d'archivage
                string query = "INSERT INTO archivage (activit�, evt_de_gestion, account, devise, libell�, sens, montant, ref) VALUES(@activit� , @evt_de_gestion, @acc, @devise, @libell�, @sens, @montant, @ref)";
                MySqlCommand cmd = new MySqlCommand(query, mysqlconn);

                // Ajoutez les valeurs archiv�es � partir de la ligne s�lectionn�e
                cmd.Parameters.AddWithValue("@activit�", selectedRow.Cells["activit�"].Value.ToString());
                // Ajoutez les autres valeurs n�cessaires � archiver
                cmd.Parameters.AddWithValue("@evt_de_gestion", selectedRow.Cells["evt_de_gestion"].Value.ToString());
                cmd.Parameters.AddWithValue("@acc", selectedRow.Cells["acc"].Value.ToString());
                cmd.Parameters.AddWithValue("@devise", selectedRow.Cells["devise"].Value.ToString());
                cmd.Parameters.AddWithValue("@libell�", selectedRow.Cells["libell�"].Value.ToString());
                cmd.Parameters.AddWithValue("@sens", selectedRow.Cells["sens"].Value.ToString());
                cmd.Parameters.AddWithValue("@montant", selectedRow.Cells["montant"].Value.ToString());
                cmd.Parameters.AddWithValue("@ref", selectedRow.Cells["ref"].Value.ToString());

                int rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'archivage : {ex.Message}");
            }
            finally
            {
                mysqlconn.Close();
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {// Amarrage du contr�le en haut du conteneur// Amarrage du contr�le en haut du conteneur
         // Ancrage du contr�le � gauche et � droite du conteneur


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Save an Excel File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExportDataGridViewToExcel(filePath);
            }
        }
        private void ExportDataGridViewToExcel(string filePath)
        {
            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

                // Ajouter les en-t�tes de colonnes
                for (int col = 1; col <= dataGridView1.Columns.Count; col++)
                {
                    worksheet.Cells[1, col].Value = dataGridView1.Columns[col - 1].HeaderText;
                }

                // Ajouter les lignes de donn�es
                for (int row = 1; row <= dataGridView1.Rows.Count; row++)
                {
                    for (int col = 1; col <= dataGridView1.Columns.Count; col++)
                    {
                        worksheet.Cells[row + 1, col].Value = dataGridView1.Rows[row - 1].Cells[col - 1].Value;
                    }
                }

                // Sauvegarder le fichier Excel
                FileInfo file = new FileInfo(filePath);
                package.SaveAs(file);

                MessageBox.Show("Donn�es export�es avec succ�s !");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Cr�er une nouvelle instance de LoginForm
            LoginForm loginForm = new LoginForm();

            // Afficher le formulaire LoginForm
            loginForm.Show();

            // Cacher le formulaire actuel (activite)
            this.Hide();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument1;

            // Afficher la pr�visualisation d'impression
            if (printPreviewDialog.ShowDialog() == DialogResult.OK)
            {
                // D�marrer l'impression
                printDocument1.Print();
            }
        }

        private void PrintDocument_BeginPrint(object sender, PrintEventArgs e)
        {
            PrintDocument printDoc = (PrintDocument)sender;
            printDoc.DefaultPageSettings.Landscape = true; // Mode paysage
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int yPos = e.MarginBounds.Top;
            int xPos = e.MarginBounds.Left;
            int rowHeight = 22; // Hauteur des lignes
            int columnWidth = 0;

            // D�finir les polices
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font cellFont = new Font("Arial", 10);
            StringFormat stringFormat = new StringFormat
            {
                FormatFlags = StringFormatFlags.LineLimit,
                Trimming = StringTrimming.EllipsisCharacter
            };

            // Imprimer les en-t�tes des colonnes
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                columnWidth = column.Width;
                e.Graphics.DrawRectangle(Pens.Black, xPos, yPos, columnWidth, rowHeight);
                e.Graphics.DrawString(column.HeaderText, headerFont, Brushes.Black, xPos, yPos);
                xPos += columnWidth; // Ajuster en fonction de la largeur de la colonne
            }

            yPos += rowHeight; // Passer � la ligne suivante
            xPos = e.MarginBounds.Left; // R�initialiser la marge gauche

            // Imprimer les lignes de donn�es
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue; // Ignorer la ligne de nouvelle ligne

                foreach (DataGridViewCell cell in row.Cells)
                {
                    columnWidth = dataGridView1.Columns[cell.ColumnIndex].Width; // Largeur r�elle de la colonne
                    e.Graphics.DrawRectangle(Pens.Black, xPos, yPos, columnWidth, rowHeight);
                    string cellText = cell.Value?.ToString() ?? "";

                    // Imprimer le texte avec gestion du retour � la ligne
                    e.Graphics.DrawString(cellText, cellFont, Brushes.Black, new RectangleF(xPos, yPos, columnWidth, rowHeight), stringFormat);

                    xPos += columnWidth; // Ajuster en fonction de la largeur de la colonne
                }

                yPos += rowHeight; // Passer � la ligne suivante
                xPos = e.MarginBounds.Left; // R�initialiser la marge gauche

                // V�rifier si une nouvelle page est n�cessaire
                if (yPos + rowHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false; // Indiquer que toutes les pages sont imprim�es
        }




        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Amarrage du contr�le en haut du conteneur

        }




        private void activite_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
        private void activite_FormClosed(object sender, FormClosedEventArgs e)
        {

            mysqlconn.Close();
        }

        private void dv_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void evt_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void mnt_txt_TextChanged(object sender, EventArgs e)
        {
        }

        private void montant_Click(object sender, EventArgs e)
        {
        }

        private void devise_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

        }


    }


}