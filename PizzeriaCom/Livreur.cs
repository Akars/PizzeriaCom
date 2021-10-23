using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using PizzeriaCom.MessageHandler;

namespace PizzeriaCom
{
    public class Livreur
    {
        private string nom;
        public string Nom => nom;
        
        private Action<MessagePayload<List<Item>>> getItem;
        public Action<MessagePayload<List<Item>>> GetItem => getItem;

        private List<Item> items;

        public Livreur(string nom)
        {
            this.nom = nom;
        }

        public static void Livrer(Commande arg) //methods that implementing Action
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("En Livraison.....");
            Thread.Sleep(20000);
        }

        public static async Task LivrerAsync(Commande arg)
        {
            await Task.Run(() => Livrer(arg));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("La commande est livré !");
            arg.Status = CommandeStatus.Fermé.ToString();
            Console.WriteLine("Le client a payé : " + arg.GetPrice() + " €");
        }
    }
}