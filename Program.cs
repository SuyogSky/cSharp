﻿namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nExercise 1>");
            Car bmw = new Car("BMW", 2023, 30000);
            bmw.displayCarInfo();

            Console.WriteLine("\nExercise 2>");
            BankAccount suyog = new BankAccount("22016093");
            suyog.Deposit(1000);
            suyog.Withdraw(500);
            suyog.DisplayBalance();
        }
    }


}