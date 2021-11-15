using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Pet
    {
        public string name { get; set; }
        public string type { get; set; }
        public int age { get; set; }

        public Pet()
        {
            name = "none";
            type = "none";
            age = 0;
        }

        public Pet(string Name, string Type, int Age)
        {
            name = Name;
            type = Type;
            age = Age;
        }
    }
}
