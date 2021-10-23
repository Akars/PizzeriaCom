using System;
using System.Threading.Tasks;
using PizzeriaCom.MessageHandler;

namespace PizzeriaCom
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Commis commis = new Commis("Amaury");
            Livreur livreur = new Livreur("Titouan");
            MessageBrokerImpl.Instance.Subscribe(commis.GetCommand);
            MessageBrokerImpl.Instance.Subscribe(livreur.GetItem);
            string choice;
            bool stop = false;
            Menu menu = new Menu();
            Client clientActuel = new Client("William", "LI", "30 avenue de la République", "010101010");
            
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

                    clientActuel = new Client(prenom, nom, adresse, tel);
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

            if (!stop)
            {
                clientActuel.Commander(menu);
                await commis.preparerCommande();
                await commis.envoyerCommande();
            }
        }

    }
}