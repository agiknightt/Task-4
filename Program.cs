using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int countGold;
            int priceCrystal = 15;
            int countCrystal;
            bool enoughGold;
            Console.Write("Сколько у вас золота? : ");
            countGold = Convert.ToInt32(Console.ReadLine());

            Console.Write("Сколько кристаллов вы хотите купить? : ");
            countCrystal = Convert.ToInt32(Console.ReadLine());

            enoughGold = countGold >= priceCrystal * countCrystal;

            countCrystal *= Convert.ToInt32(enoughGold);
            countGold -= priceCrystal * countCrystal;

            Console.WriteLine($"У вас осталось {countGold} золота,  у вас появилось {countCrystal} кристаллов");
            Console.ReadKey();                
        }
    }
}
