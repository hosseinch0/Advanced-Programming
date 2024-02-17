namespace Hospital
{
    partial class schedulesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnsurgeries = new System.Windows.Forms.Button();
            this.btngeneralstaff = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbldata = new System.Windows.Forms.Label();
            this.btnnewstaff = new System.Windows.Forms.Button();
            this.btnnewsrg = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(55, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1287, 377);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose the schedule to show :";
            // 
            // btnsurgeries
            // 
            this.btnsurgeries.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsurgeries.Location = new System.Drawing.Point(55, 108);
            this.btnsurgeries.Name = "btnsurgeries";
            this.btnsurgeries.Size = new System.Drawing.Size(141, 68);
            this.btnsurgeries.TabIndex = 1;
            this.btnsurgeries.Text = "Surgeries";
            this.btnsurgeries.UseVisualStyleBackColor = true;
            this.btnsurgeries.Click += new System.EventHandler(this.btnsurgeries_Click);
            // 
            // btngeneralstaff
            // 
            this.btngeneralstaff.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngeneralstaff.Location = new System.Drawing.Point(55, 182);
            this.btngeneralstaff.Name = "btngeneralstaff";
            this.btngeneralstaff.Size = new System.Drawing.Size(141, 68);
            this.btngeneralstaff.TabIndex = 0;
            this.btngeneralstaff.Text = "Staff";
            this.btngeneralstaff.UseVisualStyleBackColor = true;
            this.btngeneralstaff.Click += new System.EventHandler(this.btngeneralstaff_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "name",
            "position",
            "day",
            "date"});
            this.comboBox1.Location = new System.Drawing.Point(1114, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 37);
            this.comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(945, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search By :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(973, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Search  :";
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(1114, 103);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(249, 36);
            this.txtsearch.TabIndex = 5;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1348, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 104);
            this.button1.TabIndex = 8;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbldata.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.Location = new System.Drawing.Point(397, 198);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(86, 34);
            this.lbldata.TabIndex = 9;
            this.lbldata.Text = "Start";
            this.lbldata.Visible = false;
            // 
            // btnnewstaff
            // 
            this.btnnewstaff.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewstaff.Location = new System.Drawing.Point(978, 182);
            this.btnnewstaff.Name = "btnnewstaff";
            this.btnnewstaff.Size = new System.Drawing.Size(238, 68);
            this.btnnewstaff.TabIndex = 2;
            this.btnnewstaff.Text = "Change Staff";
            this.btnnewstaff.UseVisualStyleBackColor = true;
            this.btnnewstaff.Click += new System.EventHandler(this.btnnewstaff_Click);
            // 
            // btnnewsrg
            // 
            this.btnnewsrg.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewsrg.Location = new System.Drawing.Point(734, 182);
            this.btnnewsrg.Name = "btnnewsrg";
            this.btnnewsrg.Size = new System.Drawing.Size(238, 68);
            this.btnnewsrg.TabIndex = 3;
            this.btnnewsrg.Text = "Change Sergury";
            this.btnnewsrg.UseVisualStyleBackColor = true;
            this.btnnewsrg.Click += new System.EventHandler(this.btnnewsrg_Click);
            // 
            // btnreport
            // 
            this.btnreport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.Location = new System.Drawing.Point(1222, 182);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(141, 68);
            this.btnreport.TabIndex = 6;
            this.btnreport.Text = "Reports";
            this.btnreport.UseVisualStyleBackColor = true;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 41);
            this.button2.TabIndex = 28;
            this.button2.Text = "<--";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // schedulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1388, 661);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.btnnewsrg);
            this.Controls.Add(this.btnnewstaff);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btngeneralstaff);
            this.Controls.Add(this.btnsurgeries);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "schedulesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedules";
            this.Load += new System.EventHandler(this.schedulesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsurgeries;
        private System.Windows.Forms.Button btngeneralstaff;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Button btnnewstaff;
        private System.Windows.Forms.Button btnnewsrg;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Button button2;
    }
}