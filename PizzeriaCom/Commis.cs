using System;
using System.Collections.Generic;
using PizzeriaCom.MessageHandler;

namespace PizzeriaCom
{
    public class Commis
    {
        private static int ID = 1;
        private int commisID;
        private string nom;
        private List<Commande> commandeGerer;
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

        public void preparerCommande(Commande arg)
        {
            MessageBrokerImpl.Instance.Publish(this, arg);
        }
        public void receiveCommande(MessagePayload<Commande> arg) //methods that implementing Action
        {
            if (arg.What.NomCommis == null)
            {
                Console.WriteLine("On a bien reçu votre commande. Vous serez livré dans peu de temps!");
                arg.What.NomCommis = this.nom;
                arg.What.Status1 = "En préparation";
                commandeGerer.Add(arg.What);
                arg.What.DisplayCommande();
            }
        }
    }
}