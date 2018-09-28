using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelter
{
    abstract class Employee
    {
        //PROPERTIES
        public string EmployeeName { get; set; }

        //CONSTRUCTOR
        public Employee()
        {
        }

        //abstract method      
        abstract public void ClockIn();
        abstract public void ShowID();
    }
}
