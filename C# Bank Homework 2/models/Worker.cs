using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2.models {
    public class Worker : Person {

        // Private Fields

        private string _startTime;
        private string _endTime;
        private List<Operation> _operations = new();

        // Properties

        public List<Operation> Operations { get { return _operations; } set { _operations = value; } }
        public string StartTime { get { return _startTime; } set { _startTime = value; } }
        public string EndTime { get { return _endTime; } set { _endTime = value; } }

        // Constructors

        public Worker() : base() { }
        public Worker(string name, string surname, int age, string position,
            int salary, string startTime, string endTime) 
            : base (name, surname, age, position, salary)
        { 
            StartTime = startTime;
            EndTime = endTime;
        }

        // Functions

        public void addOperation(Operation operation) {
            _operations.Add(operation);
        }

    }
}
