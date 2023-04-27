using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2.models {
    public class Manager : Person {

        // Private Field

        private string _managementExperience;

        // Property

        public string ManagmentExperience { get { return _managementExperience; } set { _managementExperience = value; } }

        // Constructors

        public Manager() : base() { }
        public Manager(string name, string surname, int age, string position, int salary, string managmentExperience) 
        : base(name, surname, age, position, salary) { 
            ManagmentExperience = managmentExperience;
        }

        // Functions



    }
}
