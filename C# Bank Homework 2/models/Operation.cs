using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2.models {
    public class Operation {

        // Private Fields

        private readonly Guid _id;
        private readonly DateTime _date;
        private string _processName;

        // Properties

        public Guid Id { get { return _id; } }
        public DateTime Date { get { return _date; } }
        public string ProcessName { get { return _processName; } set { _processName = value; } }

        // Constructors

        public Operation() { 
            _id = Guid.NewGuid();
            _date = DateTime.Now;
        }
        public Operation(string processName) : this() { 
            ProcessName = processName;
        }

        // Functions

    }
}
