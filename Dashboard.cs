using Newtonsoft.Json;
using RestSharp;
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
    public partial class Dashboard : Form
    {
        DataTable countriesDataTable= new DataTable();
        string HttpFeedBack;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(0, bunifuImageButton1.Location.Y);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            TravelInfo travelInfo = new TravelInfo();
            travelInfo.Show();
            this.Hide();
            panel2.Location = new Point(0, bunifuImageButton2.Location.Y);
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            InsertCustomer insertCustomer = new InsertCustomer();
            insertCustomer.Show();
            this.Hide();
            panel2.Location = new Point(0, bunifuImageButton3.Location.Y);
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            InsertEmployee insertEmployee = new InsertEmployee();
            insertEmployee.Show();
            this.Hide();
            panel2.Location = new Point(0, bunifuImageButton4.Location.Y);
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            DisplayInformation displayInformation = new DisplayInformation();
            displayInformation.Show();
            this.Hide();
            panel2.Location = new Point(0, bunifuImageButton5.Location.Y);
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            DisplayEmployer displayEmployer = new DisplayEmployer();
            displayEmployer.Show();
            this.Hide();
            panel2.Location = new Point(0, bunifuImageButton6.Location.Y);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            gunaDataGridView1.ScrollBars = ScrollBars.None;
            for (int x=0; x<=8;x++)
            {
                gunaDataGridView1.Rows.Add("2020-01-4", "Afghanistan", "Red", "54");
            }
            gunaDataGridView1.ClearSelection();
            loadingScreen1.Visible = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuCustomDataGrid1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
            SearchButton searchButton = new SearchButton();
            searchButton.countryData = countriesDataTable;
            searchButton.StartPosition = FormStartPosition.Manual;
            searchButton.Location =new Point( countryBunifuButton.Location.X+235,countryBunifuButton.Location.Y+215);
            searchButton.Show();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void countryBunifuButton_DoubleClick(object sender, EventArgs e)
        {
            SearchButton searchButton = new SearchButton();
            searchButton.Close();
        }

        private void loadingScreen1_Load(object sender, EventArgs e)
        {

        }
        

        private void getAllCountries()
        {
            var client = new RestClient("https://restcountries-v1.p.rapidapi.com/all");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "1988653984mshf4117a59927ac63p1444d8jsn9b0bca7ad496");
            request.AddHeader("x-rapidapi-host", "restcountries-v1.p.rapidapi.com");
            IRestResponse response = client.Execute(request);

            if(response.StatusCode==System.Net.HttpStatusCode.OK)
            {
                var content = response.Content;
                var countries = JsonConvert.DeserializeObject<List<Country>>(content);
                countriesDataTable.Columns.Add("name");
                foreach(var country in countries)
                {
                    countriesDataTable.Rows.Add(country.name);
                }
            }
            else
            {
                HttpFeedBack = response.ErrorMessage;
                backgroundWorker1.CancelAsync();
            }

        }
        
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            getAllCountries();
            if(backgroundWorker1.CancellationPending==true)
            {
                e.Cancel = true;
                loadingScreen1.Visible = true;
                return;
            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled) {
                timer1.Start();
                MessageBox.Show(HttpFeedBack);
                
            }
            else
            {
                timer1.Start();
                MessageBox.Show("Data loaded.");  
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            loadingScreen1.Visible = false ;
        }

        private void bunifuDataViz1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
