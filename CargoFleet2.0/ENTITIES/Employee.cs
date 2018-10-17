using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class Employee
    {
        public int ID { get; set; }

        public string Username { get; set; }

        public string Name { get; set; }

        public string Numbers { get; set; }

        public string Position { get; set; }
    }

    public class Trip: Employee
    {
        public int tripID { get; set; }
        public DateTime tripDate { get; set; }
        public int tripDistance { get; set; }
        public string tripDeparture { get; set; }
        public string tripDestination { get; set; }                         
    }
}
