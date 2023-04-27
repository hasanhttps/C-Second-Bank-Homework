using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2.models {
    public class Bank {

        // Private Fields

        private CEO _ceo;
        private List<Worker> _workers = new();
        private List<Manager> _managers = new();
        private List<Client> _clients = new();
        private List<Credit> _credits = new();
        private string _name;
        private int _profit;
        private int _budget;

        // Properties

        public string Name { get { return _name; }
            set {
                try
                {
                    if (value.Length >= 3) _name = value;
                    else throw new Exception("Name must be at least 3 characters !");
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw ex;
                }

            }
        }
        public int Profit { get { return _profit; } set { _profit = value; } }
        public int Budget { get { return _budget; } set { _budget = value; } }
        public CEO Ceo { get { return _ceo; } set { _ceo = value; } }
        public List<Worker> Workers { get { return _workers; } set { _workers = value; } }
        public List<Manager> Managers { get { return _managers; } set { _managers = value; } }
        public List<Client> Clients { get { return _clients; } set { _clients = value; } }
        public List<Credit> Credits { get { return _credits; } set { _credits = value; } }

        // Constructors

        public Bank(string name, int budget, int profit, CEO ceo) {
            Name = name;
            Budget = budget;
            Profit = profit;
            Ceo = ceo;
        }

        // Functions

        public void addWorker(Worker worker) {
            Workers.Add(worker);
        }
        public void addClient(Client client) {
            Clients.Add(client);
        }
        public void addManager(Manager manager) {
            Managers.Add(manager);
        }
        public void addCredit(Credit credit) {
            Credits.Add(credit);
        }

        public void showClients() {
            foreach (Client client in Clients) {
                Console.WriteLine(client);
            }
        }
        public void showClientCredit(string name) {
            foreach (Credit credit in Credits) {
                if (credit.Client.Name == name) {
                    Console.WriteLine(credit);
                }
            }
        }
        public void payCredit(string clientName, int money) {
            foreach (Credit credit in Credits) {
                if (credit.Client.Name == clientName) {
                    credit.payment(money);
                }
            }
        }
        public void showAllCredits() {
            foreach (Credit credit in Credits) {
                Console.WriteLine(credit);
            }
        }
    }
}
