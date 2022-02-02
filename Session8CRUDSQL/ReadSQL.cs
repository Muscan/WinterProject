using Microsoft.Extensions.Configuration;
using Session8CRUDSQL.Classes;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
namespace Session8CRUDSQL
    
{
    public partial class ReadSQL : Form

    {
        private readonly IConfiguration _configuration;
        public ReadSQL()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //read entity
        private void btnRead_Click(object sender, EventArgs e)
        {
            CarsManager manager = new CarsManager();
            IEnumerable<Car> cars = manager.GetAllCarsWithEF();
          
        }

        //read ado.net
        private void btnReadAdoNet_Click(object sender, EventArgs e)
        {
            CarsManager manager = new CarsManager();
            IEnumerable<CreatedCar> cars = manager.GetAllCars();

            lstView.Clear();
            lstView.Columns.Add("ID", 200, HorizontalAlignment.Left);
            lstView.Columns.Add("Name", 200, HorizontalAlignment.Left);
            lstView.Columns.Add("Engine cmc", 200, HorizontalAlignment.Left);
            lstView.Columns.Add("Series Year", 200, HorizontalAlignment.Left);
            foreach (CreatedCar car in cars)

            {
                ListViewItem listItem = new ListViewItem();//Instanitate and call the constructor ListViewItem
                
                listItem.Text = car.ID.ToString();
                listItem.SubItems.Add(car.Name);
                listItem.SubItems.Add(car.Engine.ToString());
                listItem.SubItems.Add(car.SeriesYear.ToString());
                lstView.Items.Add(listItem);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void lstView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}