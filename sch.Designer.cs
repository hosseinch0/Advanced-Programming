namespace Hospital
{
    partial class sch
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtposition = new System.Windows.Forms.TextBox();
            this.txtrespon = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txtday = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Position :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Responsebility :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Day :";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(196, 22);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(300, 36);
            this.txtname.TabIndex = 0;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(196, 76);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(300, 36);
            this.txtlastname.TabIndex = 1;
            // 
            // txtposition
            // 
            this.txtposition.Location = new System.Drawing.Point(196, 138);
            this.txtposition.Name = "txtposition";
            this.txtposition.Size = new System.Drawing.Size(300, 36);
            this.txtposition.TabIndex = 2;
            // 
            // txtrespon
            // 
            this.txtrespon.Location = new System.Drawing.Point(252, 303);
            this.txtrespon.Multiline = true;
            this.txtrespon.Name = "txtrespon";
            this.txtrespon.Size = new System.Drawing.Size(244, 118);
            this.txtrespon.TabIndex = 5;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(139, 192);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(300, 36);
            this.txtdate.TabIndex = 3;
            // 
            // txtday
            // 
            this.txtday.Location = new System.Drawing.Point(139, 252);
            this.txtday.Name = "txtday";
            this.txtday.Size = new System.Drawing.Size(300, 36);
            this.txtday.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 428);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(666, 305);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(547, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 74);
            this.button1.TabIndex = 6;
            this.button1.Text = "NEW";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(547, 127);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(131, 74);
            this.btndel.TabIndex = 7;
            this.btndel.Text = "DEL";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 41);
            this.button2.TabIndex = 29;
            this.button2.Text = "<--";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(547, 234);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(131, 74);
            this.btnclear.TabIndex = 30;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // sch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 761);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtday);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtrespon);
            this.Controls.Add(this.txtposition);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "sch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Manuplation";
            this.Load += new System.EventHandler(this.sch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtposition;
        private System.Windows.Forms.TextBox txtrespon;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.TextBox txtday;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnclear;
    }
}