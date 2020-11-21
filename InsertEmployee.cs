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
    public partial class InsertEmployee : Form
    {
        public InsertEmployee()
        {
            InitializeComponent();
        }

        private void InsertEmployee_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
           
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

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(0, bunifuImageButton3.Location.Y);
            this.Hide();
            InsertCustomer insert = new InsertCustomer();
            insert.Show();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(0, bunifuImageButton5.Location.Y);
            this.Hide();
            DisplayInformation displayInformation = new DisplayInformation();
            displayInformation.Show();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(0, bunifuImageButton6.Location.Y);
            this.Hide();
            DisplayEmployer displayEmployer = new DisplayEmployer();
            displayEmployer.Show();
        }

        private void bunifuMetroTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
