using System;
namespace code_challenge
{
    public class DnaParsing
    {
        /*
         * The Problem
         * A string is simply an ordered collection of symbols selected from some alphabet and formed into a word; the length of a string is the number of symbols that it contains.
         * An example of a length 21 DNA string (whose alphabet contains the symbols 'A', 'C', 'G', and 'T') is "ATGCTTCAGAAAGGTCTTACG."
         * Given: A DNA string s of length at most 1000 nt.
         *
         * Return: Four integers (separated by spaces) counting the respective number of times that the symbols 'A', 'C', 'G', and 'T' occur in s.
         *
         * Sample Dataset
         * AGCTTTTCATTCTGACTGCAACGGGCAATATGTCTCTGTGTGGATTAAAAAAAGAGTGTCTGATAGCAGC
         *
         * Sample Output
         * 20 12 17 21
         */

        /*
         * The Challenge
         *
         * You will need to implement the counters as per the name in names in the return statement.
         * You will then need to create a loop to parse each Char within the string and count them
         * by passing the values to counters.
         *
         * To begin highlight the whole method skeleton below and uncomment using ctrl + / or cmd + /
         */

        // Uncomment the below method and begin to implement the sequence counter

        public string SequenceCount(string sequence)
        {

            // Implement the counters ensure the names are the same as in the return statement i.e. aCount
            int aCount = 0, cCount = 0, gCount = 0, tCount = 0;

            // Implement the loop to parse the string below here
            for(int i = 0; i < sequence.Length;i++)
            {
                //comapes the current letter
                switch(sequence[i])
                {
                    case 'A':
                        aCount++;
                        break;
                    case 'C':
                        cCount++;
                        break;
                    case 'G':
                        gCount++;
                        break;
                    case 'T':
                        tCount++;
                        break;
                    default:
                        //throws exception if there is an unkown letter in the sequence
                        throw new System.ArgumentException("Unknown string");
                }
            }

            // IMPORTANT - uncomment but do not change the below return statement
            return aCount + " " + cCount + " " + gCount + " " + tCount;
        }


    }
}
