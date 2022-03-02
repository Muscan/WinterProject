using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Driver
    {
        
        //[Serializable]
        public int _idnume;
        //fields

        public int Id1 { get { return _idnume; } set { } }
        public int Id { get; set; }
        public string Name { get; set; }
        public Driver(int Id, string Name)
        {//Instantiate object and initialize
            this.Id = Id;
            this.Name = Name;
        }

        public override string ToString()
        {
            return Id + " " + Name;
        }
        
    }
}
