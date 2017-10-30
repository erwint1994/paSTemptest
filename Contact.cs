﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }
        string BasePath = "http://api.pasys.nl/msgcenter/api/MsgJob/PostMsgJob";
        HttpClient HC = new HttpClient();
        DateTime NextMailAllowed = DateTime.Now;

        public async Task<string> SendEMail()
        {
            HC = new HttpClient();
            HC.DefaultRequestHeaders.Accept.Clear();
            HC.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            BasePath = ConfigurationManager.AppSettings["APIBasePath"];
            JavaScriptSerializer JS = new JavaScriptSerializer();

            List<string> FromAddrs = new List<string>();
            string FromAddr = TxbEmail.Text;
            FromAddrs.Add(FromAddr);

            List<string> ToAddrs = new List<string>();
            string ToAddr = "nordinvanderleije@gmail.com";
            ToAddrs.Add(ToAddr);

            List<string> CCAddrs = new List<string>();

            List<string> BCCAddrs = new List<string>();

            string body = TxbBericht.Text;

            RootObject rootObject = new RootObject
            {
                Id = 0,
                Addr_from = FromAddrs,
                Addr_to = ToAddrs,
                Addr_cc =  CCAddrs,
                Addr_bcc = BCCAddrs,
                Subject = "Van een klant",
                Body = body,
                Description = "Van een klant",
                Eventtype_ad = "EMAIL",
                Docref_ad = "1",
                Rel_ad = "0",
                Msg_status_id = 0,
                Dt_sent = DateTime.Now,
                SendLog = "string",
                Dt_created = DateTime.Now,
                Dt_modified = DateTime.Now,
                Syshumres_id = 0,
                Systerminal_id = 0,
                Syscompany_id = 0
            };
            string json = new JavaScriptSerializer().Serialize(rootObject);
            return await HTTPPost("a", json);
        }

        public async Task<string> HTTPPost(string ARequest, string AParams)
        {
            if (NextMailAllowed <= DateTime.Now)
            {
                NextMailAllowed = DateTime.Now.AddMinutes(1);
            }
            else
            {
                return "";
            }

            string BasePath = "http://api.pasys.nl/msgcenter/api/MsgJob/PostMsgJob";
            HttpClient HC = new HttpClient(); // Centrale plek opslaan
            string LPath = BasePath + ARequest;
            StringContent S = new StringContent(AParams, Encoding.UTF8, "application/json");
            HttpResponseMessage HR = await HC.PostAsync(BasePath, S);
            try
            {
                if (HR.IsSuccessStatusCode)
                {
                   // MessageBox.Show("Mail verzonden");
                    string HCRes = await HR.Content.ReadAsStringAsync();
                    return HCRes;
                }
                else
                {
                    return "FOUT !";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return "";
            }
        }

        private void TxbVoornaam_TextChanged(object sender, EventArgs e)
        {
            // voornaam
            string voornaam = txbVoornaam.Text;
            if (String.IsNullOrEmpty(txbVoornaam.Text))
            {
                MessageBox.Show("Voornaam is niet ingevuld.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxbTussenvoegsel_TextChanged(object sender, EventArgs e)
        {
            // tussenvoegsel
            string tussenvoegsel = TxbTussenvoegsel.Text;
        }

        private void TxbAchternaam_TextChanged(object sender, EventArgs e)
        {
            // achternaam
            string achternaam = TxbAchternaam.Text;
            if (String.IsNullOrEmpty(TxbAchternaam.Text))
            {
                MessageBox.Show("Achternaam is niet ingevuld.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxbBedrijf_TextChanged(object sender, EventArgs e)
        {
            // bedrijf
            string bedrijf = TxbBedrijf.Text;
            if (String.IsNullOrEmpty(TxbBedrijf.Text))
            {
                MessageBox.Show("Bedrijf is niet ingevuld.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxbTelefoonnummer_TextChanged(object sender, EventArgs e)
        {
            // telefoonnummer
            string telefoonnummer = TxbTelefoonnummer.Text;
            if (String.IsNullOrEmpty(TxbTelefoonnummer.Text))
            {
                MessageBox.Show("Telefoonnummer is niet ingevuld.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxbEmail_TextChanged(object sender, EventArgs e)
        {
            // email
            string[] emails = new string[] { TxbEmail.Text };
            if (String.IsNullOrEmpty(TxbEmail.Text))
            {
                MessageBox.Show("Email is niet ingevuld.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxbBericht_TextChanged(object sender, EventArgs e)
        {
            // bericht
            string message = TxbBericht.Text;
            if (String.IsNullOrEmpty(TxbBericht.Text))
            {
                MessageBox.Show("Bericht is niet ingevuld.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void BtnVerzenden_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbVoornaam.Text))
            {
                MessageBox.Show("Voornaam is niet ingevuld.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(TxbAchternaam.Text))
            {
                MessageBox.Show("Achternaam is niet ingevuld.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else if (String.IsNullOrEmpty(TxbBedrijf.Text))
            {
                MessageBox.Show("Bedrijf is niet ingevuld.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(TxbTelefoonnummer.Text) /*|| Regex.IsMatch(TxbTelefoonnummer.Text.Trim(), "^[0-9]*")*/)
            {
                MessageBox.Show("Telefoonnummer is niet ingevuld.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(TxbEmail.Text) || Regex.IsMatch(TxbEmail.Text.Trim(), "^[a-zA-Z]*@") && TxbEmail.Text == ".")
            {
                MessageBox.Show("Email is niet ingevuld.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(TxbBericht.Text))
            {
                MessageBox.Show("Bericht is niet ingevuld.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                await SendEMail();
                MessageBox.Show("Email is verzonden.");
            }
            this.Close();
        }
        private void Contact_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txbVoornaam;
        }
    }
}
