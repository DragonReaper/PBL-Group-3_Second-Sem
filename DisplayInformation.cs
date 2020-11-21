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
    public partial class DisplayInformation : Form
    {
        public DisplayInformation()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(0, bunifuImageButton1.Location.Y);
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            panel2.Location = new Point(0, bunifuImageButton2.Location.Y);
            TravelInfo travelInfo = new TravelInfo();
            travelInfo.Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            panel2.Location = new Point(0, bunifuImageButton3.Location.Y);
            InsertCustomer insertCustomer = new InsertCustomer();
            insertCustomer.Hide();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            panel2.Location = new Point(0, bunifuImageButton4.Location.Y);
            InsertEmployee insertEmployee = new InsertEmployee();
            insertEmployee.Show();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            panel2.Location = new Point(0, bunifuImageButton6.Location.Y);
            DisplayInformation displayInformation = new DisplayInformation();
            displayInformation.Show();
        }
    }
}
