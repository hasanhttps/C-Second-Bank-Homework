using Bank2.models;

namespace Bank2 {
    internal class Program {

        public static int Menu(List<string> choose) {
            Console.Clear();
            bool entered = false;
            int index = 0;
            while (true) {
                int y = 14 - choose.Count;
                for (int i = 0; i < choose.Count; i++) {
                    Console.SetCursorPosition(55, y + i);
                    if (index == i) Console.BackgroundColor = ConsoleColor.DarkGray;
                    else Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(choose[i]);
                }
                dynamic ascii = Console.ReadKey();
                if (ascii.Key == ConsoleKey.Escape) break;
                else if (ascii.Key == ConsoleKey.UpArrow) {
                    if (index > 0) index--;
                    else index = choose.Count - 1;
                }
                else if (ascii.Key == ConsoleKey.DownArrow) {
                    if (index < choose.Count - 1) index++;
                    else index = 0;
                }
                else if (ascii.Key == ConsoleKey.Enter) { 
                    entered = true;
                    break;
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            if (entered) return index;
            return -1;
        }

        public static void enter() {
            Console.Write("Please enter the any key to continue . . . ");
            dynamic var = Console.ReadKey();
        }

        static void Main() {
            CEO ceo = new CEO("Hesen", "Abdullazade", 14, "Ceo", 10000, "Kapital");
            Bank bank = new("Kapital", 100000, 15000, ceo);
            Worker w1 = new Worker("Rustem", "Hesenli", 16, "Worker", 2500, "9:00", "17:30");
            Worker w2 = new Worker("Ibrahim", "Kamalov", 18, "Worker", 2000, "9:00", "17:30");
            bank.addWorker(w1);
            bank.addWorker(w2);
            Manager manager = new Manager("Kamal", "Rehimov", 24, "Manager", 3500, "2 year");
            bank.addManager(manager);
            Client c1 = new("Mehemmed", "Quziyev", 26, "Client", 2000, "Baku, Ayna Sultanova 42.", "Koroglu Rehimov 45.");
            Client c2 = new("Ismayil", "Musayev", 28, "Client", 4000, "Baku, Bineqedi Koroglu 45.", "Koroglu Rehimov 45.");
            bank.addClient(c1);
            bank.addClient(c2);
            Credit credit = new(c2, 1800.5f, 2.3f, 4);
            bank.addCredit(credit);

            List<string> mainmenu = new();
            mainmenu.Add("Show Client Credit");
            mainmenu.Add("Show All Credit");
            mainmenu.Add("Pay Credit");
            mainmenu.Add("Exit");
            var choose = 1;

            while (choose != -1) {
                choose = Menu(mainmenu);

                if (choose == 0) {
                    Console.Write("Please enter the client name : ");
                    string name = Console.ReadLine();

                    bank.showClientCredit(name);
                    enter();
                }
                else if (choose == 1) {
                    bank.showAllCredits();
                    enter();
                }
                else if (choose == 2) {
                    Console.Write("Please enter client name : ");
                    string clientName = Console.ReadLine();
                    Console.Write("Please enter the pay amount : ");
                    int money =Convert.ToInt32(Console.ReadLine());

                    bank.payCredit(clientName, money);
                }else { break; }
            }
        }
    }
}