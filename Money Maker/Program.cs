using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        { //introduction
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("We will change the value you enter into the smallest possable coin count. Gold coins are worth 10, silver coins are worth 5, and bonze coins are worth 1.");
            //enter value to convert
            Console.WriteLine("Enter the value you wish calculate: ");
            double value = Math.Floor(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine($"Converting {value} into gold, silver, and bronze coins");
            //converting
            double gold = Math.Floor(value / 10);
            double goldRemain = value % 10;
            double silver = Math.Floor(goldRemain / 5);
            double bronze = goldRemain % 5;
            Console.WriteLine($"The value of {value} becomes:");
            Console.WriteLine($"{gold} gold, {silver} silver, and {bronze} bronze coins!");
        }
    }
}