using OfficeOpenXml;
using Session7CRUDExcel.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session7CRUDExcel.Controller
{
    internal class ControllerPerson
    {
        //declare PersonList
        public static List<Person> persons;
        public ControllerPerson()
        {
            //default classController
            //Initialize the list of Persons
            persons = GetSetupData();
            Task task = CreateExcel();
        }

        public static List<Person> GetSetupData()
        {
            List<Person> output = new()
            {
                new() { Id = 1, FirstName = "Vlas" },
                new() { Id = 2, FirstName = "Bogdan" }
            };
            return output;
        }

        public static async Task CreateExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            var file = new FileInfo(@"/../../Files/Test.xlsx");
            await SaveExcelFile(persons, file);
        }
        public static async Task SaveExcelFile(List<Person> people, FileInfo file)
        {
            DeleteIfExists(file);
            var package = new ExcelPackage(file);
            var ws = package.Workbook.Worksheets.Add("MainReport");

            var range = ws.Cells["A1"].LoadFromCollection(people, true);
            range.AutoFitColumns();
            await package.SaveAsync();
        }

        private static void DeleteIfExists(FileInfo file)
        {
            if (file.Exists)
            {
                file.Delete();
            }
        }
    }
}
