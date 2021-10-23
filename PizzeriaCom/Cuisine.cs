using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using PizzeriaCom.MessageHandler;

namespace PizzeriaCom
{
    public class Cuisine
    {
        public static void Cuisiner(Commande arg) //methods that implementing Action
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("En préparation.....");
            Thread.Sleep(20000);
        }

        public static async Task CuisinerAsync(Commande arg)
        {
            await Task.Run(() => Cuisiner(arg));
            arg.Status = CommandeStatus.Livraison.ToString();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("La commande est prête !");
        }
    }
}