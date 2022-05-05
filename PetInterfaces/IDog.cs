using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetInterfaces {
    internal interface IDog {
        //anything interacting with interface will have to have these properties
        public string Color { get; set; }
        public bool IsLarge { get; set; }
        public string Name { get; set; }

        public string Bark();
    }
}
