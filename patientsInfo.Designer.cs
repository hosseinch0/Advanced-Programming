namespace Hospital
{
    partial class patientsInfo
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
            this.txtreport = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtblood = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtsex = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtoperation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtephone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtweigth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtssn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtheaddoctor = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtreport
            // 
            this.txtreport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreport.Location = new System.Drawing.Point(569, 445);
            this.txtreport.Multiline = true;
            this.txtreport.Name = "txtreport";
            this.txtreport.ReadOnly = true;
            this.txtreport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtreport.Size = new System.Drawing.Size(384, 391);
            this.txtreport.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(564, 375);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(215, 29);
            this.label12.TabIndex = 53;
            this.label12.Text = "Patient Reports :";
            // 
            // txtblood
            // 
            this.txtblood.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtblood.Location = new System.Drawing.Point(240, 800);
            this.txtblood.Name = "txtblood";
            this.txtblood.ReadOnly = true;
            this.txtblood.Size = new System.Drawing.Size(250, 36);
            this.txtblood.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(50, 800);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 29);
            this.label11.TabIndex = 51;
            this.label11.Text = "Blood Type :";
            // 
            // txtsex
            // 
            this.txtsex.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsex.Location = new System.Drawing.Point(240, 730);
            this.txtsex.Name = "txtsex";
            this.txtsex.ReadOnly = true;
            this.txtsex.Size = new System.Drawing.Size(250, 36);
            this.txtsex.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(99, 730);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 29);
            this.label10.TabIndex = 49;
            this.label10.Text = "Sex :";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ICU",
            "CCU",
            "HDU",
            "General"});
            this.comboBox1.Location = new System.Drawing.Point(240, 590);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 37);
            this.comboBox1.TabIndex = 48;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Location = new System.Drawing.Point(654, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // txtoperation
            // 
            this.txtoperation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoperation.Location = new System.Drawing.Point(240, 660);
            this.txtoperation.Name = "txtoperation";
            this.txtoperation.ReadOnly = true;
            this.txtoperation.Size = new System.Drawing.Size(250, 36);
            this.txtoperation.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 667);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 29);
            this.label9.TabIndex = 45;
            this.label9.Text = "Operation  :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 590);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 29);
            this.label8.TabIndex = 44;
            this.label8.Text = "Section  :";
            // 
            // txtephone
            // 
            this.txtephone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtephone.Location = new System.Drawing.Point(240, 512);
            this.txtephone.Name = "txtephone";
            this.txtephone.ReadOnly = true;
            this.txtephone.Size = new System.Drawing.Size(250, 36);
            this.txtephone.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 519);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 29);
            this.label7.TabIndex = 42;
            this.label7.Text = "Emergency Calls :";
            // 
            // txtphone
            // 
            this.txtphone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.Location = new System.Drawing.Point(240, 445);
            this.txtphone.Name = "txtphone";
            this.txtphone.ReadOnly = true;
            this.txtphone.Size = new System.Drawing.Size(250, 36);
            this.txtphone.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 29);
            this.label6.TabIndex = 40;
            this.label6.Text = "Phone No :";
            // 
            // txtweigth
            // 
            this.txtweigth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtweigth.Location = new System.Drawing.Point(240, 368);
            this.txtweigth.Name = "txtweigth";
            this.txtweigth.ReadOnly = true;
            this.txtweigth.Size = new System.Drawing.Size(250, 36);
            this.txtweigth.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 29);
            this.label5.TabIndex = 38;
            this.label5.Text = "Weight  :";
            // 
            // txtlastname
            // 
            this.txtlastname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastname.Location = new System.Drawing.Point(240, 306);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.ReadOnly = true;
            this.txtlastname.Size = new System.Drawing.Size(250, 36);
            this.txtlastname.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 29);
            this.label4.TabIndex = 36;
            this.label4.Text = "Last Name :";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(240, 246);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(250, 36);
            this.txtname.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 29);
            this.label3.TabIndex = 34;
            this.label3.Text = "Name :";
            // 
            // txtssn
            // 
            this.txtssn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtssn.Location = new System.Drawing.Point(240, 182);
            this.txtssn.Name = "txtssn";
            this.txtssn.Size = new System.Drawing.Size(250, 36);
            this.txtssn.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "SSN :";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(240, 121);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(250, 36);
            this.txtid.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(113, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 29);
            this.label13.TabIndex = 30;
            this.label13.Text = "ID :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(282, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(178, 29);
            this.label14.TabIndex = 55;
            this.label14.Text = "Head Doctor :";
            // 
            // txtheaddoctor
            // 
            this.txtheaddoctor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtheaddoctor.Location = new System.Drawing.Point(479, 46);
            this.txtheaddoctor.Name = "txtheaddoctor";
            this.txtheaddoctor.ReadOnly = true;
            this.txtheaddoctor.Size = new System.Drawing.Size(250, 36);
            this.txtheaddoctor.TabIndex = 56;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(865, -35);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(106, 150);
            this.dataGridView.TabIndex = 57;
            this.dataGridView.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(522, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 97);
            this.button1.TabIndex = 58;
            this.button1.Text = "Verify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(753, -35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(106, 150);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.Visible = false;
            // 
            // patientsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 865);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txtheaddoctor);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtreport);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtblood);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtsex);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtoperation);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtephone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtweigth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtssn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label13);
            this.Name = "patientsInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "patientsInfo";
            this.Load += new System.EventHandler(this.patientsInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtreport;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtblood;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtsex;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtoperation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtephone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtweigth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtssn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtheaddoctor;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}