using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata
{
    class Solution
    {
        public static void Main(string[] args)
        {
            var input = "milkshakepizzachickenfriescokeburgerpizzasandwichmilkshakepizza";
            Console.WriteLine(GetOrder(input));
        }

        public static string GetOrder(string input)
        {
            Dictionary<string, string> menu = new Dictionary<string, string>
           {
            {"burger", "Burger"},
            {"fries", "Fries"},
            {"chicken", "Chicken"},
            {"pizza", "Pizza"},
            {"sandwich", "Sandwich"},
            {"onionrings", "Onionrings"},
            {"milkshake", "Milkshake"},
            {"coke", "Coke"}
           };

            string items = input.Aggregate(string.Empty, (menuItem, currentCharacter) =>
            {
                string currentString = menuItem + currentCharacter;
                if (menu.TryGetValue(currentString, out string properName))
                {
                    menuItem = menuItem + properName + " ";
                }
                return menuItem;
            });
            return items.Trim();
        }

    }
}