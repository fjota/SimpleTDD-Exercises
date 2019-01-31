using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TDDExampleExercises
{
    public class LonelyInteger
    {
        public int LonelyInteger1(int[] arr)
        {
            try
            {
                if (arr.Length == 1)
                {
                    return arr[0];
                }
                Array.Sort(arr);
                foreach (int number in arr)
                {
                    if (Array.IndexOf(arr, number) == Array.LastIndexOf(arr, number))
                    {
                        return number;
                    }
                }
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException();
            }

            return -1;
        }        
    }
}
