using System;

namespace PhoneNumbers
{
    public static class Ruler
    {
        public static Tuple<int, int> GetValidMovesFrom(int number)
        {
            // Calculate next available numbers (always 2) in a telephon keyboard following the
            // horse movement in the Chess game

            switch (number)
            {
                case 1: return new Tuple<int, int>(6, 8);
                case 2: return new Tuple<int, int>(7, 9);
                case 3: return new Tuple<int, int>(4, 8);
                case 4: return new Tuple<int, int>(3, 9);
                case 5: return null;
                case 6: return new Tuple<int, int>(1, 7);
                case 7: return new Tuple<int, int>(2, 6);
                case 8: return new Tuple<int, int>(1, 3);
                case 9: return new Tuple<int, int>(2, 4);
                default:
                    throw new ArgumentException($"Not valid input {number}!!");
            }
        }
    }
}
