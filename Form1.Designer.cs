namespace WindowsFormsApp1
{
    partial class Temperatuur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Temperatuur));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.messageQueue1 = new System.Messaging.MessageQueue();
            this.LblMaximumTemperatuur = new System.Windows.Forms.Label();
            this.LblMinimumTemperatuur = new System.Windows.Forms.Label();
            this.TbMaximumtemperatuur = new System.Windows.Forms.TextBox();
            this.TbMinimumTemperatuur = new System.Windows.Forms.TextBox();
            this.BtnOpvragenVanTot = new System.Windows.Forms.Button();
            this.DtpTot = new System.Windows.Forms.DateTimePicker();
            this.LblTot = new System.Windows.Forms.Label();
            this.LblVan = new System.Windows.Forms.Label();
            this.DtpVan = new System.Windows.Forms.DateTimePicker();
            this.TbLocatie = new System.Windows.Forms.TextBox();
            this.LblLocatieSensor = new System.Windows.Forms.Label();
            this.BtnLocatieSensorOpslaan = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.Instellingen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.test2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.witToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blauwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grijsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orgineelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mobieleApplicatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eenheidAanpassenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.celsiusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farhenheidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kelvinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beschikbareTalenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nederlandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meldingenUitschakelenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inschakelenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ontvangerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInstellingen = new System.Windows.Forms.Button();
            this.GrafiekTemperatuur = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tblTemperatureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.temperatuurDataSet = new WindowsFormsApp1.temperatuurDataSet();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnTimerStart = new System.Windows.Forms.Button();
            this.BtnTimerStop = new System.Windows.Forms.Button();
            this.LblRealTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.CbLocatie = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbl_TemperatureTableAdapter = new WindowsFormsApp1.temperatuurDataSetTableAdapters.tbl_TemperatureTableAdapter();
            this.BtnStatusSensor2 = new System.Windows.Forms.Button();
            this.BtnStatusSensor1 = new System.Windows.Forms.Button();
            this.GrafiekKelvin1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grafiekFarhenheid1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GrafiekTemperatuur2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Instellingen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrafiekTemperatuur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTemperatureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatuurDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrafiekKelvin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafiekFarhenheid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrafiekTemperatuur2)).BeginInit();
            this.SuspendLayout();
            // 
            // messageQueue1
            // 
            this.messageQueue1.MessageReadPropertyFilter.LookupId = true;
            this.messageQueue1.SynchronizingObject = this;
            // 
            // LblMaximumTemperatuur
            // 
            this.LblMaximumTemperatuur.AutoSize = true;
            this.LblMaximumTemperatuur.Location = new System.Drawing.Point(267, 47);
            this.LblMaximumTemperatuur.Name = "LblMaximumTemperatuur";
            this.LblMaximumTemperatuur.Size = new System.Drawing.Size(114, 13);
            this.LblMaximumTemperatuur.TabIndex = 119;
            this.LblMaximumTemperatuur.Text = "Maximum Temperatuur";
            // 
            // LblMinimumTemperatuur
            // 
            this.LblMinimumTemperatuur.AutoSize = true;
            this.LblMinimumTemperatuur.Location = new System.Drawing.Point(266, 12);
            this.LblMinimumTemperatuur.Name = "LblMinimumTemperatuur";
            this.LblMinimumTemperatuur.Size = new System.Drawing.Size(115, 13);
            this.LblMinimumTemperatuur.TabIndex = 118;
            this.LblMinimumTemperatuur.Text = "Minumum Temperatuur";
            // 
            // TbMaximumtemperatuur
            // 
            this.TbMaximumtemperatuur.Location = new System.Drawing.Point(387, 44);
            this.TbMaximumtemperatuur.Name = "TbMaximumtemperatuur";
            this.TbMaximumtemperatuur.Size = new System.Drawing.Size(142, 20);
            this.TbMaximumtemperatuur.TabIndex = 115;
            // 
            // TbMinimumTemperatuur
            // 
            this.TbMinimumTemperatuur.Location = new System.Drawing.Point(387, 10);
            this.TbMinimumTemperatuur.Name = "TbMinimumTemperatuur";
            this.TbMinimumTemperatuur.Size = new System.Drawing.Size(142, 20);
            this.TbMinimumTemperatuur.TabIndex = 114;
            // 
            // BtnOpvragenVanTot
            // 
            this.BtnOpvragenVanTot.Location = new System.Drawing.Point(181, 66);
            this.BtnOpvragenVanTot.Name = "BtnOpvragenVanTot";
            this.BtnOpvragenVanTot.Size = new System.Drawing.Size(75, 23);
            this.BtnOpvragenVanTot.TabIndex = 93;
            this.BtnOpvragenVanTot.Text = "Opvragen";
            this.BtnOpvragenVanTot.UseVisualStyleBackColor = true;
            this.BtnOpvragenVanTot.Click += new System.EventHandler(this.BtnOpvragenVanTot_Click);
            // 
            // DtpTot
            // 
            this.DtpTot.Location = new System.Drawing.Point(56, 40);
            this.DtpTot.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.DtpTot.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.DtpTot.Name = "DtpTot";
            this.DtpTot.Size = new System.Drawing.Size(200, 20);
            this.DtpTot.TabIndex = 92;
            // 
            // LblTot
            // 
            this.LblTot.AutoSize = true;
            this.LblTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTot.Location = new System.Drawing.Point(12, 39);
            this.LblTot.Name = "LblTot";
            this.LblTot.Size = new System.Drawing.Size(26, 13);
            this.LblTot.TabIndex = 91;
            this.LblTot.Text = "Tot:";
            // 
            // LblVan
            // 
            this.LblVan.AutoSize = true;
            this.LblVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVan.Location = new System.Drawing.Point(12, 9);
            this.LblVan.Name = "LblVan";
            this.LblVan.Size = new System.Drawing.Size(29, 13);
            this.LblVan.TabIndex = 90;
            this.LblVan.Text = "Van:";
            // 
            // DtpVan
            // 
            this.DtpVan.Location = new System.Drawing.Point(56, 10);
            this.DtpVan.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.DtpVan.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.DtpVan.Name = "DtpVan";
            this.DtpVan.Size = new System.Drawing.Size(200, 20);
            this.DtpVan.TabIndex = 89;
            // 
            // TbLocatie
            // 
            this.TbLocatie.BackColor = System.Drawing.SystemColors.Window;
            this.TbLocatie.Location = new System.Drawing.Point(387, 114);
            this.TbLocatie.Name = "TbLocatie";
            this.TbLocatie.Size = new System.Drawing.Size(142, 20);
            this.TbLocatie.TabIndex = 62;
            // 
            // LblLocatieSensor
            // 
            this.LblLocatieSensor.AutoSize = true;
            this.LblLocatieSensor.Location = new System.Drawing.Point(305, 114);
            this.LblLocatieSensor.Name = "LblLocatieSensor";
            this.LblLocatieSensor.Size = new System.Drawing.Size(76, 13);
            this.LblLocatieSensor.TabIndex = 61;
            this.LblLocatieSensor.Text = "Locatie sensor";
            // 
            // BtnLocatieSensorOpslaan
            // 
            this.BtnLocatieSensorOpslaan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnLocatieSensorOpslaan.Location = new System.Drawing.Point(535, 112);
            this.BtnLocatieSensorOpslaan.Name = "BtnLocatieSensorOpslaan";
            this.BtnLocatieSensorOpslaan.Size = new System.Drawing.Size(73, 23);
            this.BtnLocatieSensorOpslaan.TabIndex = 60;
            this.BtnLocatieSensorOpslaan.Text = "Opslaan";
            this.BtnLocatieSensorOpslaan.UseVisualStyleBackColor = false;
            this.BtnLocatieSensorOpslaan.Click += new System.EventHandler(this.BtnLocatieSensorOpslaan_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLogout.BackgroundImage")));
            this.BtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.Location = new System.Drawing.Point(929, 9);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(50, 50);
            this.BtnLogout.TabIndex = 130;
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // Instellingen
            // 
            this.Instellingen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test2ToolStripMenuItem,
            this.linksToolStripMenuItem,
            this.eenheidAanpassenToolStripMenuItem,
            this.exportDataToolStripMenuItem,
            this.beschikbareTalenToolStripMenuItem,
            this.meldingenUitschakelenToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.contactToolStripMenuItem});
            this.Instellingen.Name = "contextMenuStrip1";
            this.Instellingen.Size = new System.Drawing.Size(175, 180);
            // 
            // test2ToolStripMenuItem
            // 
            this.test2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roodToolStripMenuItem,
            this.witToolStripMenuItem,
            this.blauwToolStripMenuItem,
            this.grijsToolStripMenuItem,
            this.groenToolStripMenuItem,
            this.geelToolStripMenuItem,
            this.orgineelToolStripMenuItem});
            this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            this.test2ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.test2ToolStripMenuItem.Text = "Kleur achtergrond";
            // 
            // roodToolStripMenuItem
            // 
            this.roodToolStripMenuItem.Name = "roodToolStripMenuItem";
            this.roodToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.roodToolStripMenuItem.Text = "Rood";
            this.roodToolStripMenuItem.Click += new System.EventHandler(this.RoodToolStripMenuItem_Click);
            // 
            // witToolStripMenuItem
            // 
            this.witToolStripMenuItem.Name = "witToolStripMenuItem";
            this.witToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.witToolStripMenuItem.Text = "Wit";
            this.witToolStripMenuItem.Click += new System.EventHandler(this.WitToolStripMenuItem_Click);
            // 
            // blauwToolStripMenuItem
            // 
            this.blauwToolStripMenuItem.Name = "blauwToolStripMenuItem";
            this.blauwToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.blauwToolStripMenuItem.Text = "Blauw";
            this.blauwToolStripMenuItem.Click += new System.EventHandler(this.BlauwToolStripMenuItem_Click);
            // 
            // grijsToolStripMenuItem
            // 
            this.grijsToolStripMenuItem.Name = "grijsToolStripMenuItem";
            this.grijsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.grijsToolStripMenuItem.Text = "Grijs";
            this.grijsToolStripMenuItem.Click += new System.EventHandler(this.GrijsToolStripMenuItem_Click);
            // 
            // groenToolStripMenuItem
            // 
            this.groenToolStripMenuItem.Name = "groenToolStripMenuItem";
            this.groenToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.groenToolStripMenuItem.Text = "Groen";
            this.groenToolStripMenuItem.Click += new System.EventHandler(this.GroenToolStripMenuItem_Click);
            // 
            // geelToolStripMenuItem
            // 
            this.geelToolStripMenuItem.Name = "geelToolStripMenuItem";
            this.geelToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.geelToolStripMenuItem.Text = "Geel";
            this.geelToolStripMenuItem.Click += new System.EventHandler(this.GeelToolStripMenuItem_Click);
            // 
            // orgineelToolStripMenuItem
            // 
            this.orgineelToolStripMenuItem.Name = "orgineelToolStripMenuItem";
            this.orgineelToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.orgineelToolStripMenuItem.Text = "Origineel";
            this.orgineelToolStripMenuItem.Click += new System.EventHandler(this.OrigineelToolStripMenuItem_Click);
            // 
            // linksToolStripMenuItem
            // 
            this.linksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.websiteToolStripMenuItem,
            this.mobieleApplicatieToolStripMenuItem});
            this.linksToolStripMenuItem.Name = "linksToolStripMenuItem";
            this.linksToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.linksToolStripMenuItem.Text = "Links";
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.websiteToolStripMenuItem.Text = "Website";
            this.websiteToolStripMenuItem.Click += new System.EventHandler(this.WebsiteToolStripMenuItem_Click);
            // 
            // mobieleApplicatieToolStripMenuItem
            // 
            this.mobieleApplicatieToolStripMenuItem.Name = "mobieleApplicatieToolStripMenuItem";
            this.mobieleApplicatieToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.mobieleApplicatieToolStripMenuItem.Text = "Mobiele Applicatie";
            this.mobieleApplicatieToolStripMenuItem.Click += new System.EventHandler(this.MobieleApplicatieToolStripMenuItem_Click);
            // 
            // eenheidAanpassenToolStripMenuItem
            // 
            this.eenheidAanpassenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.celsiusToolStripMenuItem,
            this.farhenheidToolStripMenuItem,
            this.kelvinToolStripMenuItem});
            this.eenheidAanpassenToolStripMenuItem.Name = "eenheidAanpassenToolStripMenuItem";
            this.eenheidAanpassenToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.eenheidAanpassenToolStripMenuItem.Text = "Eenheid aanpassen";
            // 
            // celsiusToolStripMenuItem
            // 
            this.celsiusToolStripMenuItem.Checked = true;
            this.celsiusToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.celsiusToolStripMenuItem.Name = "celsiusToolStripMenuItem";
            this.celsiusToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.celsiusToolStripMenuItem.Text = "Celsius";
            this.celsiusToolStripMenuItem.Click += new System.EventHandler(this.CelsiusToolStripMenuItem_Click);
            // 
            // farhenheidToolStripMenuItem
            // 
            this.farhenheidToolStripMenuItem.Name = "farhenheidToolStripMenuItem";
            this.farhenheidToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.farhenheidToolStripMenuItem.Text = "Fahrenheit";
            this.farhenheidToolStripMenuItem.Click += new System.EventHandler(this.FarhenheidToolStripMenuItem_Click);
            // 
            // kelvinToolStripMenuItem
            // 
            this.kelvinToolStripMenuItem.Name = "kelvinToolStripMenuItem";
            this.kelvinToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.kelvinToolStripMenuItem.Text = "Kelvin";
            this.kelvinToolStripMenuItem.Click += new System.EventHandler(this.KelvinToolStripMenuItem_Click);
            // 
            // exportDataToolStripMenuItem
            // 
            this.exportDataToolStripMenuItem.Name = "exportDataToolStripMenuItem";
            this.exportDataToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exportDataToolStripMenuItem.Text = "Export data";
            this.exportDataToolStripMenuItem.Click += new System.EventHandler(this.ExportDataToolStripMenuItem_Click);
            // 
            // beschikbareTalenToolStripMenuItem
            // 
            this.beschikbareTalenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nederlandsToolStripMenuItem});
            this.beschikbareTalenToolStripMenuItem.Name = "beschikbareTalenToolStripMenuItem";
            this.beschikbareTalenToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.beschikbareTalenToolStripMenuItem.Text = "Beschikbare talen";
            // 
            // nederlandsToolStripMenuItem
            // 
            this.nederlandsToolStripMenuItem.Checked = true;
            this.nederlandsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nederlandsToolStripMenuItem.Name = "nederlandsToolStripMenuItem";
            this.nederlandsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.nederlandsToolStripMenuItem.Text = "Nederlands";
            // 
            // meldingenUitschakelenToolStripMenuItem
            // 
            this.meldingenUitschakelenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inschakelenToolStripMenuItem,
            this.ontvangerToolStripMenuItem});
            this.meldingenUitschakelenToolStripMenuItem.Name = "meldingenUitschakelenToolStripMenuItem";
            this.meldingenUitschakelenToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.meldingenUitschakelenToolStripMenuItem.Text = "Meldingen ";
            // 
            // inschakelenToolStripMenuItem
            // 
            this.inschakelenToolStripMenuItem.Checked = true;
            this.inschakelenToolStripMenuItem.CheckOnClick = true;
            this.inschakelenToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.inschakelenToolStripMenuItem.Name = "inschakelenToolStripMenuItem";
            this.inschakelenToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.inschakelenToolStripMenuItem.Text = "Ingeschakeld";
            // 
            // ontvangerToolStripMenuItem
            // 
            this.ontvangerToolStripMenuItem.Name = "ontvangerToolStripMenuItem";
            this.ontvangerToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ontvangerToolStripMenuItem.Text = "Ontvangers beheren";
            this.ontvangerToolStripMenuItem.Click += new System.EventHandler(this.OntvangerToevoegenToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.contactToolStripMenuItem.Text = "Contact";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.ContactToolStripMenuItem_Click);
            // 
            // btnInstellingen
            // 
            this.btnInstellingen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInstellingen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInstellingen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInstellingen.BackgroundImage")));
            this.btnInstellingen.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnInstellingen.Location = new System.Drawing.Point(870, 9);
            this.btnInstellingen.Name = "btnInstellingen";
            this.btnInstellingen.Size = new System.Drawing.Size(50, 50);
            this.btnInstellingen.TabIndex = 131;
            this.btnInstellingen.UseVisualStyleBackColor = false;
            this.btnInstellingen.Click += new System.EventHandler(this.Button1_Click);
            // 
            // GrafiekTemperatuur
            // 
            this.GrafiekTemperatuur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrafiekTemperatuur.BackColor = System.Drawing.SystemColors.Control;
            this.GrafiekTemperatuur.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.GrafiekTemperatuur.ChartAreas.Add(chartArea4);
            this.GrafiekTemperatuur.DataSource = this.tblTemperatureBindingSource;
            legend4.Name = "Legend1";
            this.GrafiekTemperatuur.Legends.Add(legend4);
            this.GrafiekTemperatuur.Location = new System.Drawing.Point(0, 177);
            this.GrafiekTemperatuur.Name = "GrafiekTemperatuur";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Sensor 1: Celsius";
            series4.XValueMember = "DateTime";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series4.YValueMembers = "TemperatureCelsius";
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.GrafiekTemperatuur.Series.Add(series4);
            this.GrafiekTemperatuur.Size = new System.Drawing.Size(993, 488);
            this.GrafiekTemperatuur.TabIndex = 135;
            title4.Name = "Title1";
            this.GrafiekTemperatuur.Titles.Add(title4);
            // 
            // tblTemperatureBindingSource
            // 
            this.tblTemperatureBindingSource.DataMember = "tbl_Temperature";
            this.tblTemperatureBindingSource.DataSource = this.temperatuurDataSet;
            // 
            // temperatuurDataSet
            // 
            this.temperatuurDataSet.DataSetName = "temperatuurDataSet";
            this.temperatuurDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // BtnTimerStart
            // 
            this.BtnTimerStart.Location = new System.Drawing.Point(624, 79);
            this.BtnTimerStart.Name = "BtnTimerStart";
            this.BtnTimerStart.Size = new System.Drawing.Size(75, 23);
            this.BtnTimerStart.TabIndex = 138;
            this.BtnTimerStart.Text = "Start ";
            this.BtnTimerStart.UseVisualStyleBackColor = true;
            this.BtnTimerStart.Click += new System.EventHandler(this.BtnTimerStart_Click);
            this.BtnTimerStart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnTimerStart_MouseClick);
            // 
            // BtnTimerStop
            // 
            this.BtnTimerStop.Location = new System.Drawing.Point(624, 114);
            this.BtnTimerStop.Name = "BtnTimerStop";
            this.BtnTimerStop.Size = new System.Drawing.Size(75, 23);
            this.BtnTimerStop.TabIndex = 139;
            this.BtnTimerStop.Text = "Stop ";
            this.BtnTimerStop.UseVisualStyleBackColor = true;
            this.BtnTimerStop.Click += new System.EventHandler(this.BtnTimerStop_Click);
            this.BtnTimerStop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnTimerStop_MouseClick);
            // 
            // LblRealTime
            // 
            this.LblRealTime.AutoSize = true;
            this.LblRealTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRealTime.Location = new System.Drawing.Point(621, 63);
            this.LblRealTime.Name = "LblRealTime";
            this.LblRealTime.Size = new System.Drawing.Size(86, 13);
            this.LblRealTime.TabIndex = 140;
            this.LblRealTime.Text = "Realtime grafiek:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(931, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 141;
            this.label1.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // CbLocatie
            // 
            this.CbLocatie.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblTemperatureBindingSource, "Location_Id", true));
            this.CbLocatie.FormattingEnabled = true;
            this.CbLocatie.Location = new System.Drawing.Point(387, 79);
            this.CbLocatie.Name = "CbLocatie";
            this.CbLocatie.Size = new System.Drawing.Size(142, 21);
            this.CbLocatie.TabIndex = 142;
            this.CbLocatie.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 143;
            this.label2.Text = "Locatie sensor";
            // 
            // tbl_TemperatureTableAdapter
            // 
            this.tbl_TemperatureTableAdapter.ClearBeforeFill = true;
            // 
            // BtnStatusSensor2
            // 
            this.BtnStatusSensor2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnStatusSensor2.BackColor = System.Drawing.Color.Lime;
            this.BtnStatusSensor2.DialogResult = System.Windows.Forms.DialogResult.No;
            this.BtnStatusSensor2.Location = new System.Drawing.Point(812, 9);
            this.BtnStatusSensor2.Name = "BtnStatusSensor2";
            this.BtnStatusSensor2.Size = new System.Drawing.Size(50, 50);
            this.BtnStatusSensor2.TabIndex = 144;
            this.BtnStatusSensor2.Text = "Sensor 2";
            this.BtnStatusSensor2.UseVisualStyleBackColor = false;
            // 
            // BtnStatusSensor1
            // 
            this.BtnStatusSensor1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnStatusSensor1.BackColor = System.Drawing.Color.Lime;
            this.BtnStatusSensor1.DialogResult = System.Windows.Forms.DialogResult.No;
            this.BtnStatusSensor1.Location = new System.Drawing.Point(753, 9);
            this.BtnStatusSensor1.Name = "BtnStatusSensor1";
            this.BtnStatusSensor1.Size = new System.Drawing.Size(50, 50);
            this.BtnStatusSensor1.TabIndex = 145;
            this.BtnStatusSensor1.Text = "Sensor 1";
            this.BtnStatusSensor1.UseVisualStyleBackColor = false;
            // 
            // GrafiekKelvin1
            // 
            this.GrafiekKelvin1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrafiekKelvin1.BackColor = System.Drawing.SystemColors.Control;
            this.GrafiekKelvin1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.GrafiekKelvin1.ChartAreas.Add(chartArea3);
            this.GrafiekKelvin1.DataSource = this.tblTemperatureBindingSource;
            legend3.Name = "Legend1";
            this.GrafiekKelvin1.Legends.Add(legend3);
            this.GrafiekKelvin1.Location = new System.Drawing.Point(0, 177);
            this.GrafiekKelvin1.Name = "GrafiekKelvin1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Sensor 1: Kelvin";
            series3.XValueMember = "DateTime";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series3.YValueMembers = "TemperatureKelvin";
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.GrafiekKelvin1.Series.Add(series3);
            this.GrafiekKelvin1.Size = new System.Drawing.Size(993, 488);
            this.GrafiekKelvin1.TabIndex = 147;
            title3.Name = "Title1";
            this.GrafiekKelvin1.Titles.Add(title3);
            this.GrafiekKelvin1.Visible = false;
            // 
            // grafiekFarhenheid1
            // 
            this.grafiekFarhenheid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grafiekFarhenheid1.BackColor = System.Drawing.SystemColors.Control;
            this.grafiekFarhenheid1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.grafiekFarhenheid1.ChartAreas.Add(chartArea2);
            this.grafiekFarhenheid1.DataSource = this.tblTemperatureBindingSource;
            legend2.Name = "Legend1";
            this.grafiekFarhenheid1.Legends.Add(legend2);
            this.grafiekFarhenheid1.Location = new System.Drawing.Point(0, 177);
            this.grafiekFarhenheid1.Name = "grafiekFarhenheid1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Sensor 1: Farhenheid";
            series2.XValueMember = "DateTime";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.YValueMembers = "TemperatureFarhenheid";
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.grafiekFarhenheid1.Series.Add(series2);
            this.grafiekFarhenheid1.Size = new System.Drawing.Size(993, 488);
            this.grafiekFarhenheid1.TabIndex = 148;
            title2.Name = "Title1";
            this.grafiekFarhenheid1.Titles.Add(title2);
            this.grafiekFarhenheid1.Visible = false;
            // 
            // GrafiekTemperatuur2
            // 
            this.GrafiekTemperatuur2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrafiekTemperatuur2.BackColor = System.Drawing.SystemColors.Control;
            this.GrafiekTemperatuur2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.GrafiekTemperatuur2.ChartAreas.Add(chartArea1);
            this.GrafiekTemperatuur2.DataSource = this.tblTemperatureBindingSource;
            legend1.Name = "Legend1";
            this.GrafiekTemperatuur2.Legends.Add(legend1);
            this.GrafiekTemperatuur2.Location = new System.Drawing.Point(0, 177);
            this.GrafiekTemperatuur2.Name = "GrafiekTemperatuur2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Sensor 2: Celsius";
            series1.XValueMember = "DateTime";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueMembers = "TemperatureCelsius";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.GrafiekTemperatuur2.Series.Add(series1);
            this.GrafiekTemperatuur2.Size = new System.Drawing.Size(993, 488);
            this.GrafiekTemperatuur2.TabIndex = 149;
            title1.Name = "Title1";
            this.GrafiekTemperatuur2.Titles.Add(title1);
            this.GrafiekTemperatuur2.Visible = false;
            // 
            // Temperatuur
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(993, 700);
            this.Controls.Add(this.GrafiekTemperatuur2);
            this.Controls.Add(this.grafiekFarhenheid1);
            this.Controls.Add(this.GrafiekKelvin1);
            this.Controls.Add(this.BtnStatusSensor1);
            this.Controls.Add(this.BtnStatusSensor2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbLocatie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblRealTime);
            this.Controls.Add(this.BtnTimerStop);
            this.Controls.Add(this.BtnTimerStart);
            this.Controls.Add(this.GrafiekTemperatuur);
            this.Controls.Add(this.btnInstellingen);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.LblMaximumTemperatuur);
            this.Controls.Add(this.LblMinimumTemperatuur);
            this.Controls.Add(this.TbMaximumtemperatuur);
            this.Controls.Add(this.TbMinimumTemperatuur);
            this.Controls.Add(this.BtnOpvragenVanTot);
            this.Controls.Add(this.DtpTot);
            this.Controls.Add(this.LblTot);
            this.Controls.Add(this.LblVan);
            this.Controls.Add(this.DtpVan);
            this.Controls.Add(this.TbLocatie);
            this.Controls.Add(this.LblLocatieSensor);
            this.Controls.Add(this.BtnLocatieSensorOpslaan);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Temperatuur";
            this.Text = "Temperatuur";
            this.TransparencyKey = System.Drawing.Color.Navy;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Temperatuur_FormClosed);
            this.Shown += new System.EventHandler(this.Temperatuur_Shown);
            this.Instellingen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrafiekTemperatuur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTemperatureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatuurDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrafiekKelvin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafiekFarhenheid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrafiekTemperatuur2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Messaging.MessageQueue messageQueue1;
        private System.Windows.Forms.Label LblMaximumTemperatuur;
        private System.Windows.Forms.Label LblMinimumTemperatuur;
        private System.Windows.Forms.TextBox TbMaximumtemperatuur;
        private System.Windows.Forms.TextBox TbMinimumTemperatuur;
        private System.Windows.Forms.Button BtnOpvragenVanTot;
        private System.Windows.Forms.DateTimePicker DtpTot;
        private System.Windows.Forms.Label LblTot;
        private System.Windows.Forms.Label LblVan;
        private System.Windows.Forms.DateTimePicker DtpVan;
        private System.Windows.Forms.TextBox TbLocatie;
        private System.Windows.Forms.Label LblLocatieSensor;
        private System.Windows.Forms.Button BtnLocatieSensorOpslaan;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.ContextMenuStrip Instellingen;
        private System.Windows.Forms.ToolStripMenuItem test2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem witToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blauwToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grijsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mobieleApplicatieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eenheidAanpassenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beschikbareTalenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nederlandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meldingenUitschakelenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.Button btnInstellingen;
        private System.Windows.Forms.ToolStripMenuItem celsiusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farhenheidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kelvinToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart GrafiekTemperatuur;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblRealTime;
        private System.Windows.Forms.Button BtnTimerStop;
        private System.Windows.Forms.Button BtnTimerStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem inschakelenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ontvangerToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem orgineelToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbLocatie;
        private temperatuurDataSet temperatuurDataSet;
        private System.Windows.Forms.BindingSource tblTemperatureBindingSource;
        private temperatuurDataSetTableAdapters.tbl_TemperatureTableAdapter tbl_TemperatureTableAdapter;
        private System.Windows.Forms.Button BtnStatusSensor1;
        private System.Windows.Forms.Button BtnStatusSensor2;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafiekFarhenheid1;
        private System.Windows.Forms.DataVisualization.Charting.Chart GrafiekKelvin1;
        private System.Windows.Forms.DataVisualization.Charting.Chart GrafiekTemperatuur2;
    }
}

