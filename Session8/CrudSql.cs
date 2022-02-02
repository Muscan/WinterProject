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
           

            var firstCar = carRentalEntities.Cars.FirstOrDefault();

            firstCar.Name = "Mercedes";

            carRentalEntities.SaveChanges();

            //string newCar = "";
            CarDPO newCar = new CarDPO();
            //newCar.ID = 3;
            newCar.Name = "VWALB";
            newCar.Engine = 4;
            newCar.SeriesYear = 2021;

            var createCar = carRentalEntities.Cars.Add(newCar);
            carRentalEntities.SaveChanges();
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

            foreach (object car in carRentalEntities.Cars)
            {
                ListViewItem listItem = new ListViewItem();
                
            }

        }

        private void lstViewDB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
