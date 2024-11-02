using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LessonStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int crystalPriceInGold = 15;

            Console.WriteLine("Введите ваше количество золота...");
            int numGold = int.Parse(Console.ReadLine());

            Console.WriteLine($"Приобрести кристалл по цене: {crystalPriceInGold}/шт");
            int numCrystal = int.Parse(Console.ReadLine());

            СurrencyExchanger(numGold, numCrystal, crystalPriceInGold);
        }
        private static void СurrencyExchanger(int numGold, int numCrystal, int crystalPriceInGold)
        {
            double totalNumGold = numGold - (numCrystal * crystalPriceInGold);

            Console.WriteLine($"У вас осталось: {totalNumGold} золота\nКристаллов: {numCrystal}шт.");
        }
    }
}
