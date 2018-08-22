using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {

            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
            (string product, double amount, int quantity) hammer = ("hammer", 19.99, 25);
            (string product, double amount, int quantity) nails = ("nails", 7.99, 100);
            (string product, double amount, int quantity) nailGun = ("nailGun", 189.99, 1);
            (string product, double amount, int quantity) bandaids = ("bandaids", 6.72, 250);
            (string product, double amount, int quantity) staples = ("staples", 3.98, 50);

            transactions.Add(hammer);
            transactions.Add(nails);
            transactions.Add(nailGun);
            transactions.Add(bandaids);
            transactions.Add(staples);

            int TotalProductsSold = 0;
            double TotalRevenue = 0;

            foreach ((string product, double amount, int quantity) t in transactions)
            {
                // Logic goes here to look up quantity and amount in each transaction
                TotalProductsSold += t.quantity;
                TotalRevenue += t.quantity * t.amount;
            }
            Console.WriteLine($"We sold {TotalProductsSold} products for a total revenue of ${TotalRevenue}");
        }
    }
}
