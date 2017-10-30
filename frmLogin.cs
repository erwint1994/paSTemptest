using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        string cs = ("Data Source=ahdb;Initial Catalog=temperatuur;Persist Security Info=True;User ID=temperatuur;Password=t3mperatuur");
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            {
                if (txt_UserName.Text == "" || txt_Password.Text == "")
                {
                    MessageBox.Show("Enter UserName and Password");
                    return;
                }
                try
                {
                    SqlConnection connection = new SqlConnection(cs);
                    SqlConnection connection2 = new SqlConnection(cs);
                    SqlCommand cmd;
                    SqlCommand command;
                    connection.Open();
                    connection2.Open();

                    cmd = connection.CreateCommand();
                    command = connection2.CreateCommand();
                    command.CommandText = ("SELECT (Rights) FROM tbl_Login WHERE UserName=@username AND Password=@password");
                    cmd.CommandText = ("Select * from tbl_Login where UserName=@UserName COLLATE Latin1_General_CS_AS and Password=@Password COLLATE Latin1_General_CS_AS");
                    cmd.Parameters.AddWithValue("@UserName", txt_UserName.Text);
                    cmd.Parameters.AddWithValue("@Password", txt_Password.Text);
                    command.Parameters.AddWithValue("@username", txt_UserName.Text);
                    command.Parameters.AddWithValue("@password", txt_Password.Text);
                    cmd.ExecuteNonQuery();
                    command.ExecuteNonQuery();
                    SqlDataAdapter adapt2 = new SqlDataAdapter(command);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    DataSet ds2 = new DataSet();
                    adapt.Fill(ds);
                    adapt2.Fill(ds2);
                    int rights = Convert.ToInt32(ds2.Tables[0].Rows[0][0]);
                    Rights.rights = rights;
                    int count = ds.Tables[0].Rows.Count;

                    if (count == 1)
                    {
                        MessageBox.Show("Login gelukt, klik op OK om naar de applicatie te gaan");
                        this.Hide();

                        Temperatuur fm = new Temperatuur();
                        fm.Show();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Login mislukt, de gebruikersnaam en/ of het wachtwoord is verkeerd probeer opnieuw");
                    txt_UserName.Clear();
                    txt_Password.Clear();
                    this.ActiveControl = txt_UserName;
                }
            }
        }
    }
}