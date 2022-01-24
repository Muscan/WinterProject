using Session8CRUDSQL.Classes;

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
            //IEnumerable<Car> cars =  manager.GetAllCars();
            //IEnumerable<HandMadeAccount> handMadeAccounts = manager.GetAllAccounts();
            IEnumerable<Car> cars = manager.GetAllCarsWithEF();
        }
    }
}