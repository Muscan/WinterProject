using Session7CRUDExcel.Controller;

namespace Session7CRUDExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateExcel_Click(object sender, EventArgs e)
        {
            new ControllerPerson();
            
        }

        /*Exercise 1
        Write a program which creates an excel file and writes some data into it. 
        When opening the file in Excel, everything must look fine. 
        
        Exercise 2
        Same as Exercise 1, but write the data in the CSV format. 
        When opening the file in Excel, everything must look fine. 
        
        Exercise 3
        Write a program which creates an object, serializes it and saves it to a JSON file, then reads the content of the file and deserializes it back to an object. 
        Check that the original object and the deserialized object are the same.
        Check the content of the json file and try to understand what's in there.*/
    }
}