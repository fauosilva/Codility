using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Iterations
{
    //https://app.codility.com/programmers/lessons/2-arrays/odd_occurrences_in_array/
    public class OddOccurrencesInArray
    {
        public int Solution(int[] A)
        {
            var resultDictionary = new Dictionary<int, IList<int>>();
            for(int i =0; i < A.Length; i++)
            {
                AddToDictionary(resultDictionary, A[i], i);
            }
            return resultDictionary.Keys.First();
        }

        private void AddToDictionary(Dictionary<int,IList<int>> resultDictionary, int value, int index)
        {
            if (!resultDictionary.ContainsKey(value))
            {
                resultDictionary[value] = new List<int>() { index };
            }
            else
            {
                //Found a duplicate of the odd number.
                resultDictionary.Remove(value);
            }
        }
    }
}
