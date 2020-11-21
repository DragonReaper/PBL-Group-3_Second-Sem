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
    public partial class DisplayEmployer : Form
    {
        public DisplayEmployer()
        {
            InitializeComponent();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(0, bunifuImageButton3.Location.Y);
            this.Hide();
            InsertCustomer insertCustomer = new InsertCustomer();
            insertCustomer.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            panel2.Location = new Point(0, bunifuImageButton2.Location.Y);
            TravelInfo travelInfo = new TravelInfo();
            travelInfo.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            panel2.Location = new Point(0, bunifuImageButton1.Location.Y);
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(0, bunifuImageButton4.Location.Y);
            InsertEmployee insertEmployee = new InsertEmployee();
            insertEmployee.Show();
            this.Hide();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            panel2.Location = new Point(0, bunifuImageButton5.Location.Y);
            DisplayInformation displayInformation = new DisplayInformation();
            displayInformation.Show();
        }
    }
}
