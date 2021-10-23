using System;
using System.Collections.Generic;

namespace PizzeriaCom
{
    public class Commande
    {
        private static int ID = 1;
        private int commandeID;
        private int heure;
        private DateTime date;
        private string nomClient;
        private string nomCommis;
        private List<Item> items;
        private string status;

        public Commande(string nomClient)
        {
            this.nomClient = nomClient;
            commandeID = ID;
            date = DateTime.Now;
            heure = DateTime.Now.Hour;
            items = new List<Item>();
            ID++;
        }

        public List<Item> Items => items;

        public int CommandeId => commandeID;

        public int Heure => heure;

        public DateTime Date => date;

        public string NomClient => nomClient;

        public string NomCommis
        {
            get => nomCommis;
            set => nomCommis = value;
        }
        
        public string Status
        {
            get => status;
            set => status = value;
        }

        public void DisplayCommande()
        {
            Console.WriteLine("Commande n°" + commandeID);
            Console.WriteLine("Nom Client: " + nomClient);
            Console.WriteLine("Nom Commis: " + nomCommis);
            Console.WriteLine("Date de la commande: " + date);
            Console.WriteLine("Articles: ");
            foreach (var item in items)
            {
                Console.WriteLine(item.Type);
            }
            Console.WriteLine("Status: " + status);
        }

        public float GetPrice()
        {
            float somme = 0;

            foreach (var item in items)
            {
                somme += item.Prix;
            }

            return somme;
        }
    }
}