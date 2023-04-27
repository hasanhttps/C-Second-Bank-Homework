using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2.models {
    public class Credit {

        // Private Fields

        private readonly Guid _id;
        private Client _client;
        private float _amount;
        private int _months;
        private float _percent;

        // Properties

        public Guid Id { get { return _id; } }
        public Client Client { get { return _client; } set { _client = value; } }
        public float Amount { get { return _amount; } 
            set {
                try {
                    if (value > 0) _amount = value;
                    else throw new Exception("You can't give amount negative !");
                }catch(Exception e) {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public float Percent { get { return _percent; } set { _percent = value; } }
        public int Months { get { return _months; } set { _months = value; } }

        // Constructors

        public Credit() {
            _id = Guid.NewGuid();
        }
        public Credit(Client client, float amount, float percent, int months) { 
            Client = client; 
            Amount = amount;
            Months = months;
            Percent = percent;
        }

        // Functions

        public override string ToString() {
            string credit = $"Client\n\n{Client}\nAmount : {Amount}\nPercent : {Percent}\nMonths : {Months}";
            return credit;
        }
        public float calculatePercent() {
            return Amount + (Amount * (Percent / 100f));
        }
        public void payment(int money) {
            if (_months > 0) {
                _months--;
                Amount = calculatePercent();
                Amount -= money;
            }
        }

    }
}
