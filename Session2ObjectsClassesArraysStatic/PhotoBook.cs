using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2ObjectsClassesArraysStatic
{
    class PhotoBook
    {
        private int numPages;

        public PhotoBook()
        {
            //default constructor but not implicit which will set numPages to 16
            numPages = 16;
        }
        //implicit constructor will take the numPages as params in Main
        public PhotoBook(int numPages)
        {
            this.numPages = numPages;
        }

        public int getNumPages()
        {
            return numPages;
        }
        public void setNumPages(int numPages)
        {
            this.numPages = numPages;
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
