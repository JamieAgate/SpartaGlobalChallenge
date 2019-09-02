using System;
using System.Collections.Generic;
using System.Linq;

namespace code_challenge.Challenges
{
    public class ScrabbleScoreCalculator
    {

        /*
         * Given the below scoring list create a Scrabble word calculator that will provide the correct scores dependent on the string provided.
         *         
         * Letter                             Value
         * A, E, I, O, U, L, N, R, S, T       1
         * D, G                               2
         * B, C, M, P                         3
         * F, H, V, W, Y                      4
         * K                                  5
         * J, X                               8
         * Q, Z                               10
         */

        // The character arrays have already been set up for you below
        private char[] OnePointValues = { 'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't' };
        private char[] TwoPointValues = { 'd', 'g' };
        private char[] ThreePointValues = { 'b', 'c', 'm', 'p' };
        private char[] FourPointValues = { 'f', 'h', 'v', 'w', 'y' };
        private char[] FivePointValues = { 'k' };
        private char[] EightPointValues = { 'j', 'x' };
        private char[] TenPointValues = { 'q', 'z' };

        // uncomment the method below that will accept a string argument and expect an int to be returned

        public int WordScoreCheck(string word)
        {
            int rtn = 0;
            //loops over all letters in the word
            for(int i = 0; i < word.Length; i++)
            {
                //if the 10 point letters contains the current letter
                if (TenPointValues.Contains(word[i]))
                {
                    rtn += 10;
                }
                //if the 8 point letters contains the current letter
                else if (EightPointValues.Contains(word[i]))
                {
                    rtn += 8;
                }
                //if the 5 point letters contains the current letter
                else if (FivePointValues.Contains(word[i]))
                {
                    rtn += 5;
                }
                //if the 4 point letters contains the current letter
                else if (FourPointValues.Contains(word[i]))
                {
                    rtn += 4;
                }
                //if the 3 point letters contains the current letter
                else if (ThreePointValues.Contains(word[i]))
                {
                    rtn += 3;
                }
                //if the 2 point letters contains the current letter
                else if (TwoPointValues.Contains(word[i]))
                {
                    rtn += 2;
                }
                //else the letter must be a 1 point letter
                else
                {
                    rtn += 1;
                }
            }
            return rtn;
        }

    }
}
