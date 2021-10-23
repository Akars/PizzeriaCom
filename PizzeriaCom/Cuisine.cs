using System;
using System.Collections.Generic;
using PizzeriaCom.MessageHandler;

namespace PizzeriaCom
{
    public class Cuisine
    {
        private Action<MessagePayload<Commande>> getCommand;
        public Action<MessagePayload<Commande>> GetCommand => getCommand;
        
        private List<Commande> commandeAPreparer = new List<Commande>();

        public void Cuisiner()
        {
            getCommand = receiveCommande;
        }
        
        public void receiveCommande(MessagePayload<Commande> arg) //methods that implementing Action
        {
            if (arg.What.Status1 == "En préparation")
            {
                Console.WriteLine("En préparation");
                arg.What.Status1 = CommandeStatus.Préparation.ToString();
                commandeAPreparer.Add(arg.What);
                arg.What.DisplayCommande();
            }
        }
        
    }
}