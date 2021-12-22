using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2ObjectsClassesArraysStatic
{
    class PhotoBookTest
    {
        public void Afisare()
        {
            PhotoBook photoBookDefault = new PhotoBook();
            Console.WriteLine(photoBookDefault.getNumPages());
            int pages = 24;
            PhotoBook photoBookWithPages = new PhotoBook(pages);
            Console.WriteLine(photoBookWithPages.getNumPages());

        }
    }
}
