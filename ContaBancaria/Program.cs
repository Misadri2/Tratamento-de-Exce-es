using System;
using System.Globalization;
using ContaBancaria.Entities;
using ContaBancaria.Entities.Exceptions;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Holder: ");
        String holder = Console.ReadLine();
        Console.Write("Initial balance: ");
        double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Withdraw limit: ");
        double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Conta contabancaria = new Conta(number, holder, balance, withdrawLimit);

        Console.WriteLine();
        Console.Write("Enter amount for withdraw: ");
        double amount= double.Parse(Console.ReadLine());

        try
        {
            contabancaria.WithDraw(amount);
            Console.WriteLine("New Balance: " + contabancaria.Balance.ToString("F2", CultureInfo.InvariantCulture));
        }
        catch (DomainException e)
        {
            Console.WriteLine("Withdraw error: " + e.Message);
        }

        }
    }
}
