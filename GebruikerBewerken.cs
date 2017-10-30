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
    public partial class GebruikerBewerken : Form
    {
        string MyConnectionString2 = ("Data Source=ahdb;Initial Catalog=temperatuur;Persist Security Info=True;User ID=temperatuur;Password=t3mperatuur");

        public GebruikerBewerken()
        {
            InitializeComponent();
        }

        private void BtnVerzenden_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(MyConnectionString2);
            SqlCommand cmd;

            connection.Open();
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = ("UPDATE tbl_EmailAdress SET Email=@email, Voornaam=@voornaam, Achternaam=@achternaam, Tussenvoegsel=@tussenvoegsel WHERE id=@id");
                cmd.Parameters.AddWithValue("@email", TxbEmail.Text);
                cmd.Parameters.AddWithValue("@voornaam", txbVoornaam.Text);
                cmd.Parameters.AddWithValue("@achternaam", TxbAchternaam.Text);
                cmd.Parameters.AddWithValue("@tussenvoegsel", TxbTussenvoegsel.Text);
                cmd.Parameters.AddWithValue("@id", TxbId.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            Close();
        }

        private void TxbId_TextChanged(object sender, EventArgs e)
        {
            BtnSelect.Visible = true;
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            SqlConnection connection2 = new SqlConnection(MyConnectionString2);
            SqlCommand command;

            connection2.Open();
            try
            {
                command = connection2.CreateCommand();
                command.CommandText = "SELECT * FROM tbl_EmailAdress WHERE id=@id";
                command.Parameters.AddWithValue("@id", TxbId.Text);
                SqlDataAdapter adap = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                string Email = Convert.ToString(ds.Tables[0].Rows[0]["Email"]);
                string voornaam = Convert.ToString(ds.Tables[0].Rows[0]["voornaam"]);
                string Achternaam = Convert.ToString(ds.Tables[0].Rows[0]["Achternaam"]);
                string Tussenvoegsel = Convert.ToString(ds.Tables[0].Rows[0]["Tussenvoegsel"]);
                string id = Convert.ToString(ds.Tables[0].Rows[0]["id"]);
                TxbEmail.Text = Email;
                txbVoornaam.Text = voornaam;
                TxbAchternaam.Text = Achternaam;
                TxbTussenvoegsel.Text = Tussenvoegsel;
                TxbId.Text = id;
            }
            catch (Exception)
            {
                MessageBox.Show("Deze gebruiker bestaat niet.");
            }         
        }

        private void ShowForm2()
        {
            Gebruiker form2 = new Gebruiker();
            form2.Show();
        }

        private void Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ShowForm2();
        }
    }
}
