using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TDDExampleExercises
{
    public class ArraySum
    {
        public int SimpleArraySum(int[] arr)
        {            
            try
            {
                return arr.Sum();
            }
            catch (OverflowException)
            {
                throw new OverflowException();
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException();
            }
               
        }
    }
}
