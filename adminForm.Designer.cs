namespace Hospital
{
    partial class adminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.btnedit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtposition = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnpre = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnschedules = new System.Windows.Forms.Button();
            this.btnpatients = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(223, 76);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(319, 41);
            this.txtusername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password :";
            // 
            // datagridview
            // 
            this.datagridview.AllowUserToAddRows = false;
            this.datagridview.AllowUserToDeleteRows = false;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.Location = new System.Drawing.Point(928, 193);
            this.datagridview.Name = "datagridview";
            this.datagridview.ReadOnly = true;
            this.datagridview.RowHeadersWidth = 62;
            this.datagridview.RowTemplate.Height = 28;
            this.datagridview.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.datagridview.Size = new System.Drawing.Size(546, 329);
            this.datagridview.TabIndex = 15;
            this.datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_CellContentClick);
            this.datagridview.KeyUp += new System.Windows.Forms.KeyEventHandler(this.datagridview_KeyUp);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(297, 364);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(117, 70);
            this.btnedit.TabIndex = 6;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "id",
            "username\t",
            "password",
            "position"});
            this.comboBox1.Location = new System.Drawing.Point(1085, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 37);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(1085, 106);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(228, 41);
            this.txtsearch.TabIndex = 16;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(437, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 70);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(1347, 37);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(127, 110);
            this.btnsearch.TabIndex = 17;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Visible = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnnew
            // 
            this.btnnew.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Location = new System.Drawing.Point(157, 364);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(124, 70);
            this.btnnew.TabIndex = 5;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnbrowse
            // 
            this.btnbrowse.Enabled = false;
            this.btnbrowse.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowse.Location = new System.Drawing.Point(667, 364);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(160, 70);
            this.btnbrowse.TabIndex = 12;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnsave
            // 
            this.btnsave.Enabled = false;
            this.btnsave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(17, 364);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(124, 70);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtposition
            // 
            this.txtposition.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtposition.Location = new System.Drawing.Point(223, 214);
            this.txtposition.Name = "txtposition";
            this.txtposition.Size = new System.Drawing.Size(319, 41);
            this.txtposition.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 34);
            this.label5.TabIndex = 15;
            this.label5.Text = "Position :";
            // 
            // btnfirst
            // 
            this.btnfirst.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfirst.Location = new System.Drawing.Point(21, 452);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(124, 70);
            this.btnfirst.TabIndex = 8;
            this.btnfirst.Text = "First";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnpre
            // 
            this.btnpre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpre.Location = new System.Drawing.Point(301, 452);
            this.btnpre.Name = "btnpre";
            this.btnpre.Size = new System.Drawing.Size(124, 70);
            this.btnpre.TabIndex = 10;
            this.btnpre.Text = "Pre";
            this.btnpre.UseVisualStyleBackColor = true;
            this.btnpre.Click += new System.EventHandler(this.btnpre_Click);
            // 
            // btnnext
            // 
            this.btnnext.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.Location = new System.Drawing.Point(161, 452);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(124, 70);
            this.btnnext.TabIndex = 9;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnlast
            // 
            this.btnlast.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlast.Location = new System.Drawing.Point(441, 452);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(124, 70);
            this.btnlast.TabIndex = 11;
            this.btnlast.Text = "Last";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(909, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 34);
            this.label6.TabIndex = 22;
            this.label6.Text = "Search :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(891, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 34);
            this.label7.TabIndex = 21;
            this.label7.Text = "Search By :";
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(223, 147);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.ReadOnly = true;
            this.txtpassword.Size = new System.Drawing.Size(319, 41);
            this.txtpassword.TabIndex = 2;
            // 
            // btnschedules
            // 
            this.btnschedules.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnschedules.Location = new System.Drawing.Point(581, 452);
            this.btnschedules.Name = "btnschedules";
            this.btnschedules.Size = new System.Drawing.Size(156, 70);
            this.btnschedules.TabIndex = 13;
            this.btnschedules.Text = "Schedules";
            this.btnschedules.UseVisualStyleBackColor = true;
            this.btnschedules.Click += new System.EventHandler(this.btnschedules_Click);
            // 
            // btnpatients
            // 
            this.btnpatients.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpatients.Location = new System.Drawing.Point(752, 452);
            this.btnpatients.Name = "btnpatients";
            this.btnpatients.Size = new System.Drawing.Size(154, 70);
            this.btnpatients.TabIndex = 14;
            this.btnpatients.Text = "Patients";
            this.btnpatients.UseVisualStyleBackColor = true;
            this.btnpatients.Click += new System.EventHandler(this.btnpatients_Click);
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(223, 12);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(319, 41);
            this.txtid.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 34);
            this.label3.TabIndex = 26;
            this.label3.Text = "ID  :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(7, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 41);
            this.button1.TabIndex = 27;
            this.button1.Text = "<--";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(645, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hospital.Properties.Resources.schedule1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1486, 534);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnpatients);
            this.Controls.Add(this.btnschedules);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.btnpre);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.txtposition);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "adminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "General Information";
            this.Load += new System.EventHandler(this.adminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView datagridview;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtposition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnpre;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnschedules;
        private System.Windows.Forms.Button btnpatients;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}