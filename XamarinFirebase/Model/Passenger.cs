using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFirebase.Model
{
    public class Passenger
    {
        public string PassengerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public bool State { get; set; }
    }
}
