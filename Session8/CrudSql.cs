using Session8.Controller;
using Session8.Data.DPO;
using Session8.Data.Persistance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session8
{
    public partial class CrudSql : Form
    {
        public CrudSql()
        {
            InitializeComponent();

            CarRentalEntities carRentalEntities = new CarRentalEntities();
           /* var firstCar = carRentalEntities.Cars.FirstOrDefault();

            CarDPO carDPO = new CarDPO();
            carDPO.Name = "Renalut";
            carDPO.Engine = 2;
            carDPO.SeriesYear = 2001;
            carRentalEntities.Cars.Add(carDPO); 
           
            carRentalEntities.SaveChanges();*/
            /*  CarController carController = new CarController();
              carController.ReturnAllCars();*/
        }

        private void btnReadAll_Click(object sender, EventArgs e)
        {
            CarRentalEntities carRentalEntities = new CarRentalEntities();


            var firstCar = carRentalEntities.Cars.FirstOrDefault();

            
            carRentalEntities.SaveChanges();
            lstView.Clear();
            lstView.Columns.Add("ID", 200, HorizontalAlignment.Left);
            lstView.Columns.Add("Name", 200, HorizontalAlignment.Left);
            lstView.Columns.Add("Engine cmc", 200, HorizontalAlignment.Left);
            lstView.Columns.Add("Series Year", 200, HorizontalAlignment.Left);

            foreach (CarDPO car in carRentalEntities.Cars)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.SubItems.Add(car.SeriesYear.ToString());
                listItem.Text = car.ID.ToString();
                listItem.SubItems.Add(car.Name);
                listItem.SubItems.Add(car.Engine.ToString());
                lstView.Items.Add(listItem);
            }

        }

        private void lstViewDB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CarRentalEntities carRentalEntities = new CarRentalEntities();

            var firstCar = carRentalEntities.Cars.FirstOrDefault();

            //firstCar.Name = "Mercedes";

            carRentalEntities.SaveChanges();

            //string newCar = "";
            CarDPO newCar = new CarDPO();
            //newCar.ID = 3;
            if (txtBoxName.Text != "")
            {
                newCar.Name = txtBoxName.Text;

            }
            else { 
                MessageBox.Show("Name cannot be empty");
                return;
            }
       

            try
            {  
                newCar.Engine = decimal.Parse(txtBoxEngine.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Engine not valid");
                return;
            }
            try
            {
                newCar.SeriesYear = int.Parse(txtBoxSeriesYear.Text);
            }
            catch(System.FormatException)
            {
                MessageBox.Show("Series year not valid");
                return;
            }

            var createCar = carRentalEntities.Cars.Add(newCar);
            carRentalEntities.SaveChanges();
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            CarRentalEntities carRentalEntities = new CarRentalEntities();
            var firstCar = carRentalEntities.Cars.FirstOrDefault();
            int id;
            try
            {
                id = int.Parse(txtBoxDeleteCar.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("ID not valid");
                return ;
            }
            foreach (CarDPO car in carRentalEntities.Cars)
            {
                if(car.ID == id)
                {
                    carRentalEntities.Cars.Remove(car);
                }
            }
                carRentalEntities.SaveChanges();
        }
    }
}
