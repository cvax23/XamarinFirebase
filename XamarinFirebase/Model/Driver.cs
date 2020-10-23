using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFirebase.Model
{
    public class Driver
    {
        public string DriverId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public IEnumerable<Vehicle> Vehicles { get; set; }
    }
}
