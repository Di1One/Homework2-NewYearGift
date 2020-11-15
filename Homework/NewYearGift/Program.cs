using System;
using System.Collections.Generic;

namespace NewYearGift
{
    class Program
    {
        static void Main(string[] args)
        {
            IGift gift = new Gift();

            Sweet candy1 = new Candy("Кремка", "Russia", 33, 180, TypeOfCandy.Lollipop);
            Sweet candy2 = new Candy("Toffifee", "Germany", 41, 125, TypeOfCandy.ChocalateCandy);
            Sweet candy3 = new Chocalate("Nestle", "Switzerland", 15, 85, ColorOfChocalate.WhiteChocolate);
            Sweet candy4 = new Chocalate("Milka", "Switzerland", 13, 100, ColorOfChocalate.BlackChocolate);
            Sweet candy5 = new Biscuit("Thick&Crunchy Oatcakes", "The United Kingdom", 14, 300, TypeOfBiscuit.OatCookies);
            Sweet candy6 = new Biscuit("Leibniz Petit Beurre", "Poland", 22, 220, TypeOfBiscuit.Shortbread);

            gift.Add(candy1);
            gift.Add(candy2);
            gift.Add(candy3);
            gift.Add(candy4);
            gift.Add(candy5);
            gift.Add(candy6);

            gift.GiftPrint();

            gift.SortByWeight();

            Console.WriteLine("After sorting : \n");
            gift.GiftPrint();

            int left_border, right_border;
            do
            {
                Console.WriteLine("Enter borders of sugar content :");
                Console.Write("Left border : ");
                left_border = int.Parse(Console.ReadLine());

                Console.Write("Right border : ");
                right_border = int.Parse(Console.ReadLine());

                if (left_border < 0 || right_border < 0 || left_border > right_border)
                {
                    Console.Clear();
                    Console.WriteLine("Wrong Input!");
                }
            } while (left_border < 0 || right_border < 0 || left_border > right_border);

            Console.WriteLine($"\nSweets corresponding to the [{left_border}g ; {right_border}g] range of sugar content:");
            foreach (var item in gift.FindCandyBySugar(left_border, right_border))
            {
                Console.WriteLine($" Sweet name: { item.Name}, Sugar: {item.Sugar}g");
            }

            Console.WriteLine($"\nGift weight: {gift.GiftWeight()}g");
        }
    }
}
