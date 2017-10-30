using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using System.Net.Http;
using System.Configuration;
using System.IO;
using pasLogger;
using pasTemp;

namespace WindowsFormsApp1
{
    public partial class Temperatuur : Form
    {
        string MyConnectionString2 = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        Timer Timer = new Timer();
        Label label = new Label();
        double timeLeft = 99999999999999;
        HttpClient HC = new HttpClient();
        DateTime NextMailAllowed = DateTime.Now;
        string location = "";

        // begin test

        // eind test

        // programma start
        public Temperatuur()
        {
            InitializeComponent();

            IsServerConnected();
        }
        public bool IsServerConnected()
        {
            using (var l_oConnection = new SqlConnection(MyConnectionString2))
            {
                try
                {
                    l_oConnection.Open();
                    Logger.Log(LogType.ltInfo, "Connectie verbonden.");
                    return true;
                }
                catch (SqlException)
                {
                    MessageBox.Show("De database is niet bereikbaar");
                    Logger.Log(LogType.ltError, "De database is niet bereikbaar");
                    return false;
                }
            }
        }
        public void NewUpdate()
        {
            MessageBox.Show("Er is een update beschikbaar.");
        }    
        private void Temperatuur_Load(object sender, EventArgs e)
        {
        }
        private void Temperatuur_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.DtpVan = DtpVan.Value;
            Properties.Settings.Default.TbMinimumTemperatuur = TbMinimumTemperatuur.Text;
            Properties.Settings.Default.TbMaximumTemperatuur = TbMaximumtemperatuur.Text;
            Properties.Settings.Default.CbLocatie = CbLocatie.Text;
            Properties.Settings.Default.Save();
            Application.Exit();
        }
        private void Temperatuur_Shown(object sender, EventArgs e)
        {
            IsServerConnected();
            bool laasteversie = true;
            if (laasteversie == false)
            {
                NewUpdate();
            }

            BtnOpvragenVanTot.PerformClick();

            this.tbl_TemperatureTableAdapter.Fill(this.temperatuurDataSet.tbl_Temperature);

            TbLocatie.Text = Properties.Settings.Default.TbLocatie;
            Properties.Settings.Default.TbLocatie = TbLocatie.Text;
            try
            {
                DtpVan.Value = Properties.Settings.Default.DtpVan;
            }
            catch
            {
                DtpVan.Value = DateTime.Today;
            }
            Properties.Settings.Default.DtpVan = DtpVan.Value;

            TbMinimumTemperatuur.Text = Properties.Settings.Default.TbMinimumTemperatuur;
            Properties.Settings.Default.TbMinimumTemperatuur = TbMinimumTemperatuur.Text;

            TbMaximumtemperatuur.Text = Properties.Settings.Default.TbMaximumTemperatuur;
            Properties.Settings.Default.TbMaximumTemperatuur = TbMaximumtemperatuur.Text;

            CbLocatie.Text = Properties.Settings.Default.CbLocatie;
            Properties.Settings.Default.CbLocatie = CbLocatie.Text;

            Properties.Settings.Default.Save();

            // om te testen altijd  celsius laden met opstarten
            //begin test
             celsiusToolStripMenuItem.PerformClick();
            if (GrafiekTemperatuur.ChartAreas[0].AxisY.Maximum == GrafiekTemperatuur.ChartAreas[0].AxisY.Minimum)
            {
                GrafiekTemperatuur.ChartAreas[0].AxisY.Maximum = GrafiekTemperatuur.ChartAreas[0].AxisY.Minimum + 1;
            }
            GrafiekTemperatuur.ChartAreas[0].AxisY.LabelStyle.Format = "0";
            GrafiekTemperatuur.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "dd/MM/yyy \n HH:mm";
            // einde test

            DtpVan.Format = DateTimePickerFormat.Custom;
            DtpVan.CustomFormat = "dd/MM/yyyy HH:mm";
            DtpTot.Format = DateTimePickerFormat.Custom;
            DtpTot.CustomFormat = "dd/MM/yyyy HH:mm";

            timer2.Enabled = true;
            // rechten gebruiker of admin
            if (Rights.rights == 0)
            {
                BtnLocatieSensorOpslaan.Visible = false;
                TbLocatie.Visible = false;
                LblLocatieSensor.Visible = false;
            }

            this.tbl_TemperatureTableAdapter.Fill(this.temperatuurDataSet.tbl_Temperature);

            SqlConnection connection = new SqlConnection(MyConnectionString2);
            SqlCommand cmd;
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandText = ("SELECT (Location) FROM tbl_Location");
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
               CbLocatie.Items.Add(dr["Location"].ToString());
            }
        }
        // programmma stop
        // alleen voor admin
        public void BtnLocatieSensorOpslaan_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(MyConnectionString2);
            SqlCommand cmd;
            connection.Open();
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = ("INSERT INTO tbl_Location (Location, MaximumTemperatureCelsius, MinimumTemperatureCelsius) VALUES (@Location, @MaximumTemperatureCelsius, @MinimumTemperatureCelsius)");
                cmd.Parameters.AddWithValue("@MinimumTemperatureCelsius", int.Parse(TbMinimumTemperatuur.Text));
                cmd.Parameters.AddWithValue("@MaximumTemperatureCelsius", int.Parse(TbMaximumtemperatuur.Text));
                cmd.Parameters.AddWithValue("@Location", TbLocatie.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            TempMgrUpdateMinMax.MinTempK();
            TempMgrUpdateMinMax.MaxTempK();
            TempMgrUpdateMinMax.MinTempF();
            TempMgrUpdateMinMax.MaxTempF();               
            MessageBox.Show("Locatie, minimum en maximum temperatuur zijn opgeslagen");
        }
        // einde admin
        // begin instellingen
        private void RoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            roodToolStripMenuItem.Checked = true;
            this.BackColor = Color.Red;
            witToolStripMenuItem.Checked = false;
            blauwToolStripMenuItem.Checked = false;
            grijsToolStripMenuItem.Checked = false;
            groenToolStripMenuItem.Checked = false;
            geelToolStripMenuItem.Checked = false;
            orgineelToolStripMenuItem.Checked = false;
        }
        private void WitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            witToolStripMenuItem.Checked = true;
            this.BackColor = Color.White;
            roodToolStripMenuItem.Checked = false;
            blauwToolStripMenuItem.Checked = false;
            grijsToolStripMenuItem.Checked = false;
            groenToolStripMenuItem.Checked = false;
            geelToolStripMenuItem.Checked = false;
            orgineelToolStripMenuItem.Checked = false;
        }
        private void BlauwToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blauwToolStripMenuItem.Checked = true;
            this.BackColor = Color.Blue;
            roodToolStripMenuItem.Checked = false;
            witToolStripMenuItem.Checked = false;
            grijsToolStripMenuItem.Checked = false;
            groenToolStripMenuItem.Checked = false;
            geelToolStripMenuItem.Checked = false;
            orgineelToolStripMenuItem.Checked = false;
        }
        private void GrijsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grijsToolStripMenuItem.Checked = true;
            this.BackColor = Color.Gray;
            roodToolStripMenuItem.Checked = false;
            witToolStripMenuItem.Checked = false;
            blauwToolStripMenuItem.Checked = false;
            groenToolStripMenuItem.Checked = false;
            geelToolStripMenuItem.Checked = false;
            orgineelToolStripMenuItem.Checked = false;
        }
        private void GroenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groenToolStripMenuItem.Checked = true;
            this.BackColor = Color.Green;
            roodToolStripMenuItem.Checked = false;
            witToolStripMenuItem.Checked = false;
            blauwToolStripMenuItem.Checked = false;
            grijsToolStripMenuItem.Checked = false;
            geelToolStripMenuItem.Checked = false;
            orgineelToolStripMenuItem.Checked = false;
        }
        private void GeelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            geelToolStripMenuItem.Checked = true;
            this.BackColor = Color.Yellow;
            witToolStripMenuItem.Checked = false;
            roodToolStripMenuItem.Checked = false;
            blauwToolStripMenuItem.Checked = false;
            grijsToolStripMenuItem.Checked = false;
            groenToolStripMenuItem.Checked = false;
            orgineelToolStripMenuItem.Checked = false;
        }
        private void OrigineelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orgineelToolStripMenuItem.Checked = true;
            blauwToolStripMenuItem.Checked = false;
            this.BackColor = Color.FromArgb(240, 240, 240);
            roodToolStripMenuItem.Checked = false;
            witToolStripMenuItem.Checked = false;
            grijsToolStripMenuItem.Checked = false;
            groenToolStripMenuItem.Checked = false;
            geelToolStripMenuItem.Checked = false;
        }
        private void WebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.google.com/");
        }
        private void MobieleApplicatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.google.com/");
        }
        private void ContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.Show();
        }
        private void CelsiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            celsiusToolStripMenuItem.Checked = true;
            kelvinToolStripMenuItem.Checked = false;
            farhenheidToolStripMenuItem.Checked = false;

            GrafiekTemperatuur.Visible = true;
            grafiekFarhenheid1.Visible = false;
            GrafiekKelvin1.Visible = false;

            this.tbl_TemperatureTableAdapter.Fill(this.temperatuurDataSet.tbl_Temperature);

            GrafiekTemperatuur.ResetAutoValues();

            GrafiekTemperatuur.ChartAreas[0].AxisY.Minimum = TempMgrAxis.YMinTempC1();
            GrafiekTemperatuur.ChartAreas[0].AxisY.Maximum = TempMgrAxis.YMaxTempC1();

            if (GrafiekTemperatuur.ChartAreas[0].AxisY.Maximum == GrafiekTemperatuur.ChartAreas[0].AxisY.Minimum)
            {
                GrafiekTemperatuur.ChartAreas[0].AxisY.Maximum = GrafiekTemperatuur.ChartAreas[0].AxisY.Minimum + 1;
            }

            GrafiekTemperatuur.ChartAreas[0].AxisY.LabelStyle.Format = "0";

            GrafiekTemperatuur.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "dd/MM/yyy \n HH:mm";
        }
        private void KelvinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            celsiusToolStripMenuItem.Checked = false;
            kelvinToolStripMenuItem.Checked = true;
            farhenheidToolStripMenuItem.Checked = false;

            GrafiekTemperatuur.Visible = false;
            grafiekFarhenheid1.Visible = false;
            GrafiekKelvin1.Visible = true;

            this.tbl_TemperatureTableAdapter.Fill(this.temperatuurDataSet.tbl_Temperature);

            GrafiekKelvin1.ResetAutoValues();

            GrafiekKelvin1.ChartAreas[0].AxisY.Maximum = TempMgrAxis.YMaxTempK1();
            GrafiekKelvin1.ChartAreas[0].AxisY.Minimum = TempMgrAxis.YMinTempK1();

            if (GrafiekKelvin1.ChartAreas[0].AxisY.Maximum == GrafiekKelvin1.ChartAreas[0].AxisY.Minimum)
            {
                GrafiekKelvin1.ChartAreas[0].AxisY.Maximum = GrafiekKelvin1.ChartAreas[0].AxisY.Minimum + 1;
            }

            GrafiekKelvin1.ChartAreas[0].AxisY.LabelStyle.Format = "0";

            GrafiekKelvin1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "dd/MM/yyy \n HH:mm";
        }
        private void FarhenheidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            celsiusToolStripMenuItem.Checked = false;
            kelvinToolStripMenuItem.Checked = false;
            farhenheidToolStripMenuItem.Checked = true;

            GrafiekTemperatuur.Visible = false;
            grafiekFarhenheid1.Visible = true;
            GrafiekKelvin1.Visible = false;

            grafiekFarhenheid1.ResetAutoValues();

            this.tbl_TemperatureTableAdapter.Fill(this.temperatuurDataSet.tbl_Temperature);

            grafiekFarhenheid1.ChartAreas[0].AxisY.Maximum = TempMgrAxis.YMaxTempF1();
            grafiekFarhenheid1.ChartAreas[0].AxisY.Minimum = TempMgrAxis.YMinTempF1();

            if (grafiekFarhenheid1.ChartAreas[0].AxisY.Maximum == grafiekFarhenheid1.ChartAreas[0].AxisY.Minimum)
            {
                grafiekFarhenheid1.ChartAreas[0].AxisY.Maximum = grafiekFarhenheid1.ChartAreas[0].AxisY.Minimum + 1;
            }

            grafiekFarhenheid1.ChartAreas[0].AxisY.LabelStyle.Format = "0";

            grafiekFarhenheid1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "dd/MM/yyy \n HH:mm";
        }
        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }
        private void ExportDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CbLocatie.SelectedIndex == 0)
            {
                if (celsiusToolStripMenuItem.Checked == true)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "PNG Image|*.png|JPeg Image|*.jpg",
                        Title = "Save Chart As Image File",
                        FileName = "Picture.png"
                    };
                    DialogResult result = saveFileDialog.ShowDialog();
                    saveFileDialog.RestoreDirectory = true;
                    if (result == DialogResult.OK && saveFileDialog.FileName != "")
                    {
                        try
                        {
                            if (saveFileDialog.CheckPathExists)
                            {
                                if (saveFileDialog.FilterIndex == 2)
                                {
                                    GrafiekTemperatuur.SaveImage(saveFileDialog.FileName, ChartImageFormat.Jpeg);
                                }
                                else if (saveFileDialog.FilterIndex == 1)
                                {
                                    GrafiekTemperatuur.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Given Path does not exist");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                if (kelvinToolStripMenuItem.Checked == true)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "PNG Image|*.png|JPeg Image|*.jpg",
                        Title = "Save Chart As Image File",
                        FileName = "Sample.png"
                    };
                    DialogResult result = saveFileDialog.ShowDialog();
                    saveFileDialog.RestoreDirectory = true;
                    if (result == DialogResult.OK && saveFileDialog.FileName != "")
                    {
                        try
                        {
                            if (saveFileDialog.CheckPathExists)
                            {
                                if (saveFileDialog.FilterIndex == 2)
                                {
                                    GrafiekKelvin1.SaveImage(saveFileDialog.FileName, ChartImageFormat.Jpeg);
                                }
                                else if (saveFileDialog.FilterIndex == 1)
                                {
                                    GrafiekKelvin1.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Given Path does not exist");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                if (farhenheidToolStripMenuItem.Checked == true)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "PNG Image|*.png|JPeg Image|*.jpg",
                        Title = "Save Chart As Image File",
                        FileName = "Sample.png"
                    };
                    DialogResult result = saveFileDialog.ShowDialog();
                    saveFileDialog.RestoreDirectory = true;
                    if (result == DialogResult.OK && saveFileDialog.FileName != "")
                    {
                        try
                        {
                            if (saveFileDialog.CheckPathExists)
                            {
                                if (saveFileDialog.FilterIndex == 2)
                                {
                                    grafiekFarhenheid1.SaveImage(saveFileDialog.FileName, ChartImageFormat.Jpeg);
                                }
                                else if (saveFileDialog.FilterIndex == 1)
                                {
                                    grafiekFarhenheid1.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Given Path does not exist");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            if (CbLocatie.SelectedIndex == 1)
            {
                if (celsiusToolStripMenuItem.Checked == true)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "PNG Image|*.png|JPeg Image|*.jpg",
                        Title = "Save Chart As Image File",
                        FileName = "Picture.png"
                    };
                    DialogResult result = saveFileDialog.ShowDialog();
                    saveFileDialog.RestoreDirectory = true;
                    if (result == DialogResult.OK && saveFileDialog.FileName != "")
                    {
                        try
                        {
                            if (saveFileDialog.CheckPathExists)
                            {
                                if (saveFileDialog.FilterIndex == 2)
                                {
                                    GrafiekTemperatuur2.SaveImage(saveFileDialog.FileName, ChartImageFormat.Jpeg);
                                }
                                else if (saveFileDialog.FilterIndex == 1)
                                {
                                    GrafiekTemperatuur2.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Given Path does not exist");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                if (kelvinToolStripMenuItem.Checked == true)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "PNG Image|*.png|JPeg Image|*.jpg",
                        Title = "Save Chart As Image File",
                        FileName = "Sample.png"
                    };
                    DialogResult result = saveFileDialog.ShowDialog();
                    saveFileDialog.RestoreDirectory = true;
                    if (result == DialogResult.OK && saveFileDialog.FileName != "")
                    {
                        try
                        {
                            if (saveFileDialog.CheckPathExists)
                            {
                                if (saveFileDialog.FilterIndex == 2)
                                {
                                    //GrafiekKelvin2.SaveImage(saveFileDialog.FileName, ChartImageFormat.Jpeg);
                                }
                                else if (saveFileDialog.FilterIndex == 1)
                                {
                                    //GrafiekKelvin2.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Given Path does not exist");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                if (farhenheidToolStripMenuItem.Checked == true)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "PNG Image|*.png|JPeg Image|*.jpg",
                        Title = "Save Chart As Image File",
                        FileName = "Sample.png"
                    };
                    DialogResult result = saveFileDialog.ShowDialog();
                    saveFileDialog.RestoreDirectory = true;
                    if (result == DialogResult.OK && saveFileDialog.FileName != "")
                    {
                        try
                        {
                            if (saveFileDialog.CheckPathExists)
                            {
                                if (saveFileDialog.FilterIndex == 2)
                                {
                                    //grafiekFarhenheid2.SaveImage(saveFileDialog.FileName, ChartImageFormat.Jpeg);
                                }
                                else if (saveFileDialog.FilterIndex == 1)
                                {
                                    //grafiekFarhenheid2.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Given Path does not exist");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }
        private void EngelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Temperature temperature = new Temperature();
            temperature.Show();
        }
        private void OntvangerToevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gebruiker gebruikersBeheren = new Gebruiker();
            gebruikersBeheren.Show();
        }
        // einde instellingen
        // begin buttons
        private void Button1_Click(object sender, EventArgs e)
        {
            Instellingen.Show(btnInstellingen.Left + this.Left, btnInstellingen.Top + btnInstellingen.Height + this.Top);
        }   
        private void BtnOpvragenVanTot_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(MyConnectionString2);
            SqlCommand cmd;
            connection.Open();
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = ("SELECT * FROM dbo.tbl_Temperature WHERE (DateTime) BETWEEN ('" + DtpVan.Value.ToString("MM/dd/yyyy HH:mm:ss") + "') and ('" + DtpTot.Value.ToString("MM/dd/yyyy HH:mm:ss") + "');");
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                GrafiekTemperatuur.DataSource = ds.Tables[0].DefaultView;
                GrafiekKelvin1.DataSource = ds.Tables[0].DefaultView;
                grafiekFarhenheid1.DataSource = ds.Tables[0].DefaultView;
                grafiekFarhenheid1.DataBind();
                GrafiekTemperatuur.DataBind();
                GrafiekKelvin1.DataBind();
            }
                catch (Exception)
                {
                    throw;
                }
        }
        private void BtnTimerStart_Click(object sender, EventArgs e)
        {
            location = TbLocatie.Text;
            Timer1_Tick(sender, e);
            timer1.Enabled = true;
            timer1.Interval = 35000;
            MessageBox.Show("De grafiek is nu 'real time'");         
        }
        private void BtnTimerStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Stop();
            MessageBox.Show("De grafiek werkt de grafiek niet automatisch bij. Klik op 'Start' om de grafiek automatisch bij te werken");
        }
        private void BtnTimerStart_MouseClick(object sender, MouseEventArgs e)
        {
            BtnTimerStart.Text = "Gestart";
            BtnTimerStop.Text = "Stop";
        }
        private void BtnTimerStop_MouseClick(object sender, MouseEventArgs e)
        {
            BtnTimerStart.Text = "Start";
            BtnTimerStop.Text = "Gestopt";
        }
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin fl = new frmLogin();
            fl.Show();
            MessageBox.Show("U bent uitgelogd");
        }
        // einde buttons
        // begin timers
        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (timeLeft == 0)
            {
                timer1.Enabled = !timer1.Enabled;
                label1.Text = "Time's out.";
            }
            else
            {
                timeLeft--;
                DateTime dt1 = DateTime.Now.AddMinutes(-2);
                DateTime dt2 = DateTime.Now;
                SqlConnection connection = new SqlConnection(MyConnectionString2);
                SqlConnection connection2 = new SqlConnection(MyConnectionString2);
                SqlConnection connection3 = new SqlConnection(MyConnectionString2);
                SqlCommand cmd;
                SqlCommand command;
                SqlCommand sql;
                connection.Open();
                connection2.Open();
                connection3.Open();
                try
                {
                    BtnOpvragenVanTot.PerformClick();
                    cmd = connection.CreateCommand();
                    command = connection2.CreateCommand();
                    sql = connection3.CreateCommand();
                    cmd.CommandText = ("SELECT * FROM dbo.tbl_Temperature WHERE (DateTime) BETWEEN ('" + DtpVan.Value.ToString("MM/dd/yyyy HH:mm:ss") + "') and ('" + DtpTot.Value.ToString("MM/dd/yyyy HH:mm:ss") + "');");
                    command.CommandText = ("SELECT (TemperatureCelsius) FROM tbl_Temperature WHERE (DateTime BETWEEN @dt1 AND @dt2) AND Location_id=1;");
                    sql.CommandText = ("SELECT (TemperatureCelsius) FROM tbl_Temperature WHERE (DateTime BETWEEN @dt1 AND @dt2) AND Location_id=2;");
                    sql.Parameters.AddWithValue("@dt1", dt1);
                    sql.Parameters.AddWithValue("@dt2", dt2);
                    command.Parameters.AddWithValue("@dt1", dt1);
                    command.Parameters.AddWithValue("@dt2", dt2);
                    SqlDataAdapter adap = new SqlDataAdapter(cmd);
                    SqlDataAdapter adap2 = new SqlDataAdapter(command);
                    SqlDataAdapter adap3 = new SqlDataAdapter(sql);
                    DataSet ds = new DataSet();
                    DataSet ds2 = new DataSet();
                    DataSet ds3 = new DataSet();
                    adap.Fill(ds);
                    adap2.Fill(ds2);
                    adap3.Fill(ds3);
                    GrafiekTemperatuur.DataSource = ds.Tables[0].DefaultView;
                    GrafiekTemperatuur.DataBind();
                    GrafiekKelvin1.DataSource = ds.Tables[0].DefaultView;
                    GrafiekKelvin1.DataBind();
                    grafiekFarhenheid1.DataSource = ds.Tables[0].DefaultView;
                    grafiekFarhenheid1.DataBind();
                    string Action = Convert.ToString(ds2.Tables[0].Rows[0][0]);
                    string Action2 = Convert.ToString(ds3.Tables[0].Rows[0][0]);
                }
                catch (Exception)
                {
                    BtnStatusSensor1.BackColor = Color.Red;
                    BtnStatusSensor2.BackColor = Color.Red;
                    MessageBox.Show("Een en/ of meerder sensor(s) reageert niet");
                }
                DtpTot.Value = DateTime.Now;
                label1.Text = "Time Left: " + timeLeft;
                timer1.Enabled = true;
            }
        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            BtnOpvragenVanTot_Click(sender, e);
            Logger.Log(LogType.ltInfo, "Info melding");
            Logger.Log(LogType.ltWarning, "Waarschuwing melding");
            Logger.Log(LogType.ltError, "Fout melding");
        }
        // einde timers
        // wisselen locaties: loc + grafiek + eenheid veranderd
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // sensor 1
            if (CbLocatie.SelectedIndex == 0)
            {
                SqlConnection connection = new SqlConnection(MyConnectionString2);
                SqlCommand cmd;
                connection.Open();
                try
                {
                    cmd = connection.CreateCommand();
                    cmd.CommandText = ("SELECT * FROM dbo.tbl_Temperature WHERE (DateTime) BETWEEN ('" + DtpVan.Value.ToString("MM/dd/yyyy HH:mm:ss") + "') and ('" + DtpTot.Value.ToString("MM/dd/yyyy HH:mm:ss") + "') AND Location_id=1;");
                    SqlDataAdapter adap = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adap.Fill(ds);
                    GrafiekTemperatuur.DataSource = ds.Tables[0].DefaultView;
                    GrafiekTemperatuur.DataBind();
                    GrafiekKelvin1.DataSource = ds.Tables[0].DefaultView;
                    GrafiekKelvin1.DataBind();
                    grafiekFarhenheid1.DataSource = ds.Tables[0].DefaultView;
                    grafiekFarhenheid1.DataBind();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            // sensor 2
            if (CbLocatie.SelectedIndex == 1)
            {
                SqlConnection connection = new SqlConnection(MyConnectionString2);
                SqlCommand cmd;
                connection.Open();
                try
                {
                    cmd = connection.CreateCommand();
                    cmd.CommandText = ("SELECT * FROM dbo.tbl_Temperature WHERE (DateTime) BETWEEN ('" + DtpVan.Value.ToString("MM/dd/yyyy HH:mm:ss") + "') and ('" + DtpTot.Value.ToString("MM/dd/yyyy HH:mm:ss") + "') AND Location_id=2;");
                    SqlDataAdapter adap = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adap.Fill(ds);
                    GrafiekTemperatuur.DataSource = ds.Tables[0].DefaultView;
                    GrafiekTemperatuur.DataBind();
                    GrafiekKelvin1.DataSource = ds.Tables[0].DefaultView;
                    GrafiekKelvin1.DataBind();
                    grafiekFarhenheid1.DataSource = ds.Tables[0].DefaultView;
                    grafiekFarhenheid1.DataBind();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            // celsius checked 1 + 2 
            if (celsiusToolStripMenuItem.Checked == true)
            {
                SqlConnection connection = new SqlConnection(MyConnectionString2);
                SqlCommand cmd;
                connection.Open();
                try
                {
                    cmd = connection.CreateCommand();
                    cmd.CommandText = ("SELECT MaximumTemperatureCelsius, MinimumTemperatureCelsius FROM tbl_Location WHERE Location=@Location;");
                    cmd.Parameters.AddWithValue("@Location", CbLocatie.Text);
                    SqlDataAdapter adap = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adap.Fill(ds);
                    string MaximumTemperatureCelsius = Convert.ToString(ds.Tables[0].Rows[0]["MaximumTemperatureCelsius"]);
                    string MinimumTemperatureCelsius = Convert.ToString(ds.Tables[0].Rows[0]["MinimumTemperatureCelsius"]);
                    TbMaximumtemperatuur.Text = MaximumTemperatureCelsius;
                    TbMinimumTemperatuur.Text = MinimumTemperatureCelsius;
                }
                catch (Exception)
                {
                    throw;
                }
                // sensor 0
                if (CbLocatie.SelectedIndex == 0)
                {
                    GrafiekTemperatuur.Visible = true;
                    grafiekFarhenheid1.Visible = false;
                    GrafiekKelvin1.Visible = false;
                }
                // sensor 1
                if (CbLocatie.SelectedIndex == 1)
                {
                    // om te testen naar F1, wordt later naar grafieken sensor 2
                    GrafiekTemperatuur2.Visible = true; 
                    grafiekFarhenheid1.Visible = false;
                    GrafiekKelvin1.Visible = false;
                }
            }    
            // kelvin checked 1 + 2
            if(kelvinToolStripMenuItem.Checked == true)
            {
                SqlConnection connection = new SqlConnection(MyConnectionString2);
                SqlCommand cmd;
                connection.Open();
                try
                {
                    cmd = connection.CreateCommand();
                    cmd.CommandText = ("SELECT MaximumTemperatureKelvin, MinimumTemperatureKelvin FROM tbl_Location WHERE Location=@Location;");
                    cmd.Parameters.AddWithValue("@Location", CbLocatie.Text);
                    SqlDataAdapter adap = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adap.Fill(ds);
                    string MaximumTemperatureCelsius = Convert.ToString(ds.Tables[0].Rows[0]["MaximumTemperatureKelvin"]);
                    string MinimumTemperatureCelsius = Convert.ToString(ds.Tables[0].Rows[0]["MinimumTemperatureKelvin"]);
                    TbMaximumtemperatuur.Text = MaximumTemperatureCelsius;
                    TbMinimumTemperatuur.Text = MinimumTemperatureCelsius;
                }
                catch (Exception)
                {
                    throw;
                }
                if (CbLocatie.SelectedIndex == 0)
                {
                    GrafiekTemperatuur.Visible = false;
                    grafiekFarhenheid1.Visible = false;
                    GrafiekKelvin1.Visible = true;
                }
                // sensor 1
                if (CbLocatie.SelectedIndex == 1)
                {
                    GrafiekTemperatuur2.Visible = false;
                    grafiekFarhenheid1.Visible = false;
                    GrafiekKelvin1.Visible = true;
                }
            }
            // farhenheid checked 1 + 2
            if(farhenheidToolStripMenuItem.Checked == true)
            {
                SqlConnection connection = new SqlConnection(MyConnectionString2);
                SqlCommand cmd;
                connection.Open();
                try
                {
                    cmd = connection.CreateCommand();
                    cmd.CommandText = ("SELECT MaximumTemperatureFarhenheid, MinimumTemperatureFarhenheid FROM tbl_Location WHERE Location=@Location;");
                    cmd.Parameters.AddWithValue("@Location", CbLocatie.Text);
                    SqlDataAdapter adap = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adap.Fill(ds);
                    string MaximumTemperatureCelsius = Convert.ToString(ds.Tables[0].Rows[0]["MaximumTemperatureFarhenheid"]);
                    string MinimumTemperatureCelsius = Convert.ToString(ds.Tables[0].Rows[0]["MinimumTemperatureFarhenheid"]);
                    TbMaximumtemperatuur.Text = MaximumTemperatureCelsius;
                    TbMinimumTemperatuur.Text = MinimumTemperatureCelsius;
                }
                catch (Exception)
                {
                    throw;
                }
                if (CbLocatie.SelectedIndex == 0)
                {
                    GrafiekTemperatuur.Visible = false;
                    grafiekFarhenheid1.Visible = true;
                    GrafiekKelvin1.Visible = false;
                }
                // sensor 1
                if (CbLocatie.SelectedIndex == 1)
                {
                    GrafiekTemperatuur2.Visible = false;
                    grafiekFarhenheid1.Visible = true;
                    GrafiekKelvin1.Visible = false;
                }
            }
        }
    }
}