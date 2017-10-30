using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GebruikerToevoegen : Form
    {
       string MyConnectionString2 = ("Data Source=ahdb;Initial Catalog=temperatuur;Persist Security Info=True;User ID=temperatuur;Password=t3mperatuur");

        public GebruikerToevoegen()
        {
            InitializeComponent();
        }

        public void BtnVerzenden_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(MyConnectionString2);
            SqlCommand cmd;

            connection.Open();
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = ("INSERT INTO tbl_EmailAdress (Email, Voornaam, Achternaam, Tussenvoegsel) VALUES (@email,@voornaam,@achternaam, @tussenvoegsel);");
                cmd.Parameters.AddWithValue("@email", TxbEmail.Text);
                cmd.Parameters.AddWithValue("@voornaam", txbVoornaam.Text);
                cmd.Parameters.AddWithValue("@achternaam", TxbAchternaam.Text);
                cmd.Parameters.AddWithValue("@tussenvoegsel", TxbTussenvoegsel.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }

            Close();
        }

        public void Aanmaken_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowForm2();
        }

        private void Aanmaken_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Aanmaken_Load(object sender, EventArgs e)
        {

        }

        private void ShowForm2()
        {
            //GebruikersBeheren form2 = new GebruikersBeheren();
            //form2.Show();
        }
    }
}
