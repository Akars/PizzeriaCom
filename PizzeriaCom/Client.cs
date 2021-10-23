using System;
using System.Collections.Generic;
using PizzeriaCom.MessageHandler;

namespace PizzeriaCom
{
    public class Client
    {
        private int clientID;
        private string prenom;
        private string nom;
        private string adresse;
        private string tel;
        private DateTime datePremiereCommande;
        private List<Commande> commandes;

        public Client(string prenom, string nom, string adresse, string tel)
        {
            this.prenom = prenom;
            this.nom = nom;
            this.adresse = adresse;
            this.tel = tel;
            datePremiereCommande = DateTime.Now;
            commandes = new List<Commande>();
        }

        public void Commander(Menu menu)
        {
            Console.WriteLine("Bonjour bienvenue !");
            Commande newCommande = new Commande(this.prenom);
            bool stop = false;
            string choice;
            
            while (!stop)
            {
                menu.PrintPizza();
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": newCommande.Items.Add(Menu.pizzas[0]);
                        break;
                    case "2": newCommande.Items.Add(Menu.pizzas[1]);
                        break;
                    case "3": newCommande.Items.Add(Menu.pizzas[2]);
                        break;
                }
                
                Console.WriteLine("Voulez-vous une boisson ?");
                
                Console.WriteLine("Est-ce que c'est tout ? y/n");
            }
            MessageBrokerImpl.Instance.Publish(this, newCommande);
        }
    }
}