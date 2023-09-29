using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaLocadora.Entities {
    class CarRental {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; private set; }
        public Invoice invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle) {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
        }

    }
}
