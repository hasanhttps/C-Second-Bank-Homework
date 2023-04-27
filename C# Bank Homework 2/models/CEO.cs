using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2.models { 
    public class CEO : Person {

        // Private Fields

        private string _company;

        // Properties

        public string Company { get { return _company; } set { _company = value; } }

        // Constructors

        public CEO() : base() { }

        public CEO(string name, string surname, int age, string position, int salary, string company) 
            : base(name, surname, age, position, salary)
        { 
            Company = company;
        }

        // Functions



    }
}
