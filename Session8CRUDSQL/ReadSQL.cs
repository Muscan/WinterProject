using Session8CRUDSQL.Classes;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
namespace Session8CRUDSQL
{
    public partial class ReadSQL : Form
    {
        public ReadSQL()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            CarsManager manager = new CarsManager();
            IEnumerable<Car> cars = manager.GetAllCarsWithEF();
        }

        private void btnReadAdoNet_Click(object sender, EventArgs e)
        {
            CarsManager manager = new CarsManager();
            IEnumerable<CreatedCar> cars = manager.GetAllCars(); 

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}