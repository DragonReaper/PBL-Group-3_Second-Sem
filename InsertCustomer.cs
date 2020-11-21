using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COVIDDashboard
{
    public partial class InsertCustomer : Form
    {
        public string imgLoc=string.Empty;
        public string gender = string.Empty;
        public InsertCustomer()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            panel2.Location = new Point(0, bunifuImageButton1.Location.Y);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TravelInfo travelInfo = new TravelInfo();
            travelInfo.Show();
            panel2.Location = new Point(0, bunifuImageButton2.Location.Y);
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertEmployee insertCustomer = new InsertEmployee();
            insertCustomer.Show();
            panel2.Location = new Point(0, bunifuImageButton4.Location.Y);
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            DisplayInformation displayInformation = new DisplayInformation();
            displayInformation.Show();
            panel2.Location = new Point(0, bunifuImageButton5.Location.Y);
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(0, bunifuImageButton6.Location.Y);
            this.Hide();
            DisplayEmployer displayEmployer = new DisplayEmployer();
            displayEmployer.Show();
        }

        private void InsertCustomer_Load(object sender, EventArgs e)
        {
            label16.Text = DateTime.Today.ToString();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string name = nameMetroBox.Text;
            string address = addressMetroTextbox2.Text;
            string passport = passportMetroTextbox3.Text;
            string age = ageMetroTextbox4.Text;
            string nationality = nationalityMetroTextbox5.Text;
            string noofCompany = companyTextBox.Text;
            string departing = departingMetroTextbox8.Text;
            string entering = enteringMetroTextbox7.Text;

            if(maleCheckBox1.Checked==true)
            {
                gender = maleCheckBox1.Text;
                femaleCheckBox2.Checked = false;
                othersCheckBox3.Checked = false;
                femaleCheckBox2.Enabled = false;
                othersCheckBox3.Enabled = false;
            }
            else if (femaleCheckBox2.Checked==true)
            {
                gender = femaleCheckBox2.Text;
                maleCheckBox1.Checked = false;
                othersCheckBox3.Checked = false;
                maleCheckBox1.Enabled = false;
                othersCheckBox3.Enabled = false;
            }
            else if(othersCheckBox3.Checked==true)
            {
                gender = othersCheckBox3.Text;
                maleCheckBox1.Checked = false;
                femaleCheckBox2.Checked = false;
                maleCheckBox1.Enabled = false;
                othersCheckBox3.Enabled = false;
            }
           
      

            bool checkIfall= nameMetroBox.Text!=string.Empty && addressMetroTextbox2.Text!=string.Empty && passportMetroTextbox3.Text!=string.Empty && ageMetroTextbox4.Text!= string.Empty && nationalityMetroTextbox5.Text!= string.Empty && companyTextBox.Text!=string.Empty && departingMetroTextbox8.Text!=string.Empty && enteringMetroTextbox7.Text!=string.Empty && imgLoc!=string.Empty && gender!=string.Empty;

        }

        private void nameMetroBox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "Choose an image.";
            if(opf.ShowDialog()== DialogResult.OK)
            {
                imgLoc = opf.FileName.ToString();
                pictureBox1.ImageLocation = imgLoc;
            }

        }

        private void nationalityMetroTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void maleCheckbox1_OnChange(object sender, EventArgs e)
        {

        }

        private void otherLabel_Click(object sender, EventArgs e)
        {

        }

        private void femaleCheckbox2_OnChange(object sender, EventArgs e)
        {

        }

        private void maleCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (maleCheckBox1.Checked == true)
            {
                gender = maleCheckBox1.Text;
                femaleCheckBox2.Checked = false;
                othersCheckBox3.Checked = false;
                femaleCheckBox2.Enabled = false;
                othersCheckBox3.Enabled = false;
            }
            else if(maleCheckBox1.Checked!=true)
            {
                femaleCheckBox2.Enabled = true;
                othersCheckBox3.Enabled = true;
            }
        
        }

        private void femaleCheckBox2_CheckedChanged(object sender, EventArgs e)
        {

           
           if (femaleCheckBox2.Checked == true)
           {
                gender = femaleCheckBox2.Text;
                maleCheckBox1.Checked = false;
                othersCheckBox3.Checked = false;
                maleCheckBox1.Enabled = false;
                othersCheckBox3.Enabled = false;
           }
           else if(femaleCheckBox2.Checked!=true)
            {
                maleCheckBox1.Enabled = true;
                othersCheckBox3.Enabled = true;
            }
         
        }

        private void othersCheckBox3_CheckedChanged(object sender, EventArgs e)
        {

          
           if (othersCheckBox3.Checked == true)
           {
                gender = othersCheckBox3.Text;
                maleCheckBox1.Checked = false;
                femaleCheckBox2.Checked = false;
                maleCheckBox1.Enabled = false;
                femaleCheckBox2.Enabled = false;
           }
           else if(othersCheckBox3.Checked!=true)
           {
                maleCheckBox1.Enabled = true;
                femaleCheckBox2.Enabled = true;
           }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
