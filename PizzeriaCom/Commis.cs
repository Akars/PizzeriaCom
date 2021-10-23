using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using PizzeriaCom.MessageHandler;

namespace PizzeriaCom
{
    public class Commis
    {
        private static int ID = 1;
        private int commisID;
        private string nom;
        private List<Commande> commandeGerer;
        public Commande commandeActuel;
        private Action<MessagePayload<Commande>> getCommand;

        public Action<MessagePayload<Commande>> GetCommand => getCommand;

        public Commis(string nom)
        {
            this.nom = nom;
            commisID = ID;
            commandeGerer = new List<Commande>();
            ID++;
            getCommand = this.receiveCommande;
        }

        public async Task preparerCommande()
        {
            Console.WriteLine("&&&");
            if (commandeActuel != null)
            {
                Console.WriteLine("&&&");
                await Cuisine.CuisinerAsync(commandeActuel);
            }
        }

        public async Task envoyerCommande()
        {
            Console.WriteLine("&&&");
            if (commandeActuel != null)
            {
                Console.WriteLine("&&&");
                await Livreur.LivrerAsync(commandeActuel);
            }
        }
        public void receiveCommande(MessagePayload<Commande> arg) //methods that implementing Action
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("On a bien reçu votre commande. Vous serez livré dans peu de temps!");
            arg.What.NomCommis = this.nom;
            arg.What.Status = CommandeStatus.Préparation.ToString();
            commandeGerer.Add(arg.What);
            commandeActuel = arg.What;
            arg.What.DisplayCommande();
        }
    }
}