using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2.models {
    public class Person {

        // Private Fields

        private readonly Guid _id;
        private string _name;
        private string _surname;
        private string _position;
        private int _age;
        private int _salary;

        // Properties

        public Guid Id { get { return _id; } }
        public string Name { get { return _name; } 
            set {
                try
                {
                    if (value.Length >= 3) _name = value;
                    else throw new Exception("Name must be at least 3 characters !");
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw ex;
                }

            }
        }

        public string Surname { get { return _surname; } set { _surname = value; } }
        public string Position { get { return _position; } set { _position = value; } }
        public int Age { get { return _age; } 
            set {
                try {
                    if (value < 0 || value > 100) throw new Exception("Your age is not valid !");
                    _age = value;
                } catch(Exception ex) {
                    Console.WriteLine(ex.Message);
                    throw ex;
                }
            } 
        }
        public int Salary { get { return _salary; } set{ _salary = value; } }

        // Constructors

        public Person() {
            _id = Guid.NewGuid();
        }

        public Person(string name, string surname, int age, string position, int salary) 
            : this()
        { 
            Name = name;
            Surname = surname;
            Age = age;
            Position = position;
            Salary = salary;
        }
    }
}
