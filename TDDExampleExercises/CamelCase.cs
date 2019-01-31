using System;
using System.Collections.Generic;
using System.Text;

namespace TDDExampleExercises
{
    public class CamelCase
    {
        public int CamelCase1(string s)
        {
            int countCamel = 1;

            if (s is null)
            {
                throw new ArgumentNullException();
            }
            foreach (char character in s)
            {
                if (char.IsUpper(character))
                {
                    countCamel++;
                }
            }

            return countCamel;
        }
    }
}
