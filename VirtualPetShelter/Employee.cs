using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelter
{
    public abstract class Employee
    { 
        //properties
        public string EmployeeName { get; set; }

        //constructor
        public Employee()
        {
        }

        //abstract methods      
        abstract public void ClockIn();
        abstract public void ShowID();
    }
}
