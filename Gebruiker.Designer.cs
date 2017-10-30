namespace WindowsFormsApp1
{
    partial class Gebruiker
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnSAfeAddEmailUser = new System.Windows.Forms.Button();
            this.btnverwijder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(524, 343);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_RowHeaderMouseClick);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(377, 12);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 11;
            this.BtnEdit.Text = "Bewerken";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click_1);
            // 
            // BtnSAfeAddEmailUser
            // 
            this.BtnSAfeAddEmailUser.Location = new System.Drawing.Point(290, 12);
            this.BtnSAfeAddEmailUser.Name = "BtnSAfeAddEmailUser";
            this.BtnSAfeAddEmailUser.Size = new System.Drawing.Size(75, 23);
            this.BtnSAfeAddEmailUser.TabIndex = 10;
            this.BtnSAfeAddEmailUser.Text = "Toevoegen";
            this.BtnSAfeAddEmailUser.UseVisualStyleBackColor = true;
            this.BtnSAfeAddEmailUser.Click += new System.EventHandler(this.BtnSAfeAddEmailUser_Click_2);
            // 
            // btnverwijder
            // 
            this.btnverwijder.Location = new System.Drawing.Point(461, 12);
            this.btnverwijder.Name = "btnverwijder";
            this.btnverwijder.Size = new System.Drawing.Size(75, 23);
            this.btnverwijder.TabIndex = 9;
            this.btnverwijder.Text = "Verwijderen";
            this.btnverwijder.UseVisualStyleBackColor = true;
            this.btnverwijder.Visible = false;
            this.btnverwijder.Click += new System.EventHandler(this.btnverwijder_Click_1);
            // 
            // Gebruiker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 396);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnSAfeAddEmailUser);
            this.Controls.Add(this.btnverwijder);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Gebruiker";
            this.Text = "Gebruikers beheren";
            this.Load += new System.EventHandler(this.AddMailUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnSAfeAddEmailUser;
        private System.Windows.Forms.Button btnverwijder;
    }
}