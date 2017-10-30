using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Gebruiker : Form
    {
        string MyConnectionString2 = ("Data Source=ahdb;Initial Catalog=temperatuur;Persist Security Info=True;User ID=temperatuur;Password=t3mperatuur");


        public new Gebruiker ParentForm { get; set; }
        public Gebruiker ParentForm2 { get; set; }

        public Gebruiker()
        {
            InitializeComponent();
        }

        public void AddMailUsers_Load(object sender, EventArgs e)
        {
            Select();
        }

        private void Btnverwijder_Click(object sender, EventArgs e)
        {

        }

        public new void Select()
        {
            SqlConnection connection2 = new SqlConnection(MyConnectionString2);
            SqlCommand command;

            connection2.Open();
            try
            {
                command = connection2.CreateCommand();
                command.CommandText = "SELECT * FROM tbl_EmailAdress";
                SqlDataAdapter adap = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void BtnSAfeAddEmailUser_Click_1(object sender, EventArgs e)
        {
            GebruikerToevoegen aanmaken = new GebruikerToevoegen();
            aanmaken.Show();

            if (ParentForm != null)
                ParentForm.Refresh();

            Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            GebruikerBewerken edit = new GebruikerBewerken();
            edit.Show();

            if (ParentForm2 != null)
                ParentForm2.Refresh();

            Close();
        }

        private void DeleteRecord()
        {
            SqlConnection connection2 = new SqlConnection(MyConnectionString2);

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                int rowID = int.Parse(dataGridView1[0, selectedIndex].Value.ToString());
                string sql = "DELETE FROM tbl_EmailAdress WHERE id = @RowID";

                SqlCommand deleteRecord = new SqlCommand
                {
                    Connection = connection2,
                    CommandType = CommandType.Text,
                    CommandText = sql
                };

                SqlParameter RowParameter = new SqlParameter
                {
                    ParameterName = "@RowID",
                    SqlDbType = SqlDbType.Int,
                    IsNullable = false,
                    Value = rowID
                };
                deleteRecord.Parameters.Add(RowParameter);
                deleteRecord.Connection.Open();
                deleteRecord.ExecuteNonQuery();
                deleteRecord.Connection.Close();
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Select();
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnverwijder.Visible = true;        
        }

        private void BtnSAfeAddEmailUser_Click_2(object sender, EventArgs e)
        {
            GebruikerToevoegen gebruikersToevoegen = new GebruikerToevoegen();
            gebruikersToevoegen.Show();
            Select();
        }

        private void BtnEdit_Click_1(object sender, EventArgs e)
        {
            GebruikerBewerken gebruikerBewerken = new GebruikerBewerken();
            gebruikerBewerken.Show();
        }

        private void btnverwijder_Click_1(object sender, EventArgs e)
        {
            DeleteRecord();
            Select();
        }
    }
}