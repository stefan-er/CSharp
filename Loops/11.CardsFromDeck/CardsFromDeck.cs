using System;

class CardsFromDeck
{
    static void Main()
    {

        for (int i = 2; i <= 14; i++)
        {
            string cardNumber = "";

            switch (i)
            {
                case 2: cardNumber = "2"; break;
                case 3: cardNumber = "3"; break;
                case 4: cardNumber = "4"; break;
                case 5: cardNumber = "5"; break;
                case 6: cardNumber = "6"; break;
                case 7: cardNumber = "7"; break;
                case 8: cardNumber = "8"; break;
                case 9: cardNumber = "9"; break;
                case 10: cardNumber = "10"; break;
                case 11: cardNumber = "J"; break;
                case 12: cardNumber = "Q"; break;
                case 13: cardNumber = "K"; break;
                case 14: cardNumber = "A"; break;
            }

            for (int j = 1; j <= 4; j++)
            {
                string sign = "";

                switch (j)
                {
                    case 1: sign = "clubs"; break;
                    case 2: sign = "diamond"; break;
                    case 3: sign = "heart"; break;
                    case 4: sign = "spade"; break;
                }

                Console.WriteLine(cardNumber + " " + sign);
            }
        }
    }
}