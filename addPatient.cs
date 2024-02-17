using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class addPatient : Form
    {
        public addPatient()
        {
            InitializeComponent();
        }

        private void addPatient_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            DialogResult image;
            image = openFileDialog1.ShowDialog();
            if(image == DialogResult.Cancel) 
            {
                return;
            } 
            else
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        { 
            mainClass main = new mainClass();
            main.addPatient(txtid.Text, txtssn.Text, txtname.Text, txtlastname.Text, txtsex.Text, txtweigth.Text, txtphone.Text, txtephone.Text, comboBox1.Text, txtoperation.Text, txtblood.Text, txtreport.Text, pictureBox1.ImageLocation);
            MessageBox.Show("Patient Added Successfully");
            this.Close();
        }
    }
}
