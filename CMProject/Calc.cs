using System;
using System.Collections.Generic;
using System.Text;

namespace CMProject
{
    class Calc
    {
        private int lower;
        private int upper;
        private int num1;
        private int num2;
        private string word1;
        private string word2;

        public Calc(int l, int u, int n1, int n2, string w1, string w2)
        {
            lower = l;
            upper = u;
            num1 = n1;
            num2 = n2;
            word1 = w1;
            word2 = w2;
        }
        
        public string result(int n)
        {
            if (n % (num1 * num2) == 0)
                return word1 + " " + word2;
            else if (n % num1 == 0)
                return word1;
            else if (n % num2 == 0)
                return word2;
            else
                return n.ToString();
        }

        public int getLower() { return lower; }

        public int getUpper() { return upper; }
    }
}
