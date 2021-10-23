using System;
using PizzeriaCom.MessageHandler;

namespace PizzeriaCom
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Commis commis = new Commis("Amaury");
            Cuisine cuisine = new Cuisine();
            MessageBrokerImpl.Instance.Subscribe(cuisine.GetCommand);
            MessageBrokerImpl.Instance.Subscribe(commis.GetCommand);
            Client client = new Client("William", "Li", "24 rue ERIK SATIE", "010102101");
            client.Commander();
            commis.preparerCommande(new Commande("William"));
            CommandeStatus status = CommandeStatus.Fermé;
            Console.WriteLine(status);
            System.Threading.Thread.Sleep(50000);
            */
            string choice;
            bool stop = false;
            Menu menu = new Menu();
            Client newClient;
            
            menu.PrintWelcomeClient();
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                {
                    Console.WriteLine("Saisissez vos informations");
                    Console.WriteLine("Prénom: ");
                    string prenom = Console.ReadLine();
                    Console.WriteLine("Nom: ");
                    string nom = Console.ReadLine();
                    Console.WriteLine("Adresse: ");
                    string adresse = Console.ReadLine();
                    Console.WriteLine("Numéro: ");
                    string tel = Console.ReadLine();

                    newClient = new Client(prenom, nom, adresse, tel);
                    Console.WriteLine("Hello " + prenom);
                } 
                    break;
                case "2":
                {
                    //Print list client et selector
                }
                    break;
                case "0":
                {
                    stop = true;
                }
                    break;
            }
            
            while (!stop)
            {
                
            }
            
            Console.WriteLine("the end");
        }

    }
}