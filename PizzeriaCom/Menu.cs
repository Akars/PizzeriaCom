using System;
using System.Collections.Generic;

namespace PizzeriaCom
{
    public class Menu
    {
        public static List<Pizza> pizzas;
        public static List<Boisson> boissons;

        public Menu()
        {
            pizzas = new List<Pizza>();
            boissons = new List<Boisson>();
            pizzas.Add(new Pizza("Tomate et fromage", 12));
            pizzas.Add(new Pizza("Végétarienne", 12));
            pizzas.Add(new Pizza("Toutes garnies", 15));

            boissons.Add(new Boisson("Coca", 3));
            boissons.Add(new Boisson("Jus d'orange", 2));
        }
        public void PrintWelcomeClient()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to the Pizzeria");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter: ");
            Console.WriteLine("1: If you are a new client");
            Console.WriteLine("2: If you are already client");
            Console.WriteLine("0: Quit");
        }

        public void PrintPizza()
        {
            Console.WriteLine("Choose your Pizza: ");
            Console.WriteLine("1: Tomate et fromage");
            Console.WriteLine("2: Végétarienne");
            Console.WriteLine("3: Toutes garnies");
        }

        public void PrintBoisson()
        {
            Console.WriteLine("Choose your drink: ");
            Console.WriteLine("1: Coca");
            Console.WriteLine("2: Jus d'orange");
        }

        public void PrintPizzaTaille()
        {
            Console.WriteLine("Choose your size: ");
            Console.WriteLine("1: Petite");
            Console.WriteLine("2: Moyenne");
            Console.WriteLine("3: Grande");
        }
    }
}