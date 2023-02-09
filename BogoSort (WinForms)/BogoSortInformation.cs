using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogoSort__WinForms_
{
    internal class BogoSortInformation
    {
        private int itteration { get; set; }
        private List<int> sortedList { get; set; }
        private bool isComplete { get; set; }
        private int threadNumber { get; set; }

        public BogoSortInformation(int p_itteration, List<int> p_sortedList, bool p_isComplete) {
            itteration = p_itteration;
            if (p_sortedList != null)
            {
                sortedList = p_sortedList;
            } else
            {
                sortedList = new List<int>();
            }
            isComplete = p_isComplete;
            threadNumber = 0;
        }

        public override string ToString()
        {
            string outputString = $"Itteration {itteration} = [";
            foreach (int i in sortedList)
            {
                if (sortedList[sortedList.Count - 1] != i) outputString += $" {i}, ";
                else outputString += $" {i} ]";
            }
            return outputString ;
        }
    
        public bool IsSorted()
        {
            for (int i = 0; i < sortedList.Count - 1; i++)
            {
                if (sortedList[i] > sortedList[i + 1])
                {
                    return false;
                }
            }

            isComplete = true;
            return true;
        }

        public void ShuffleList()
        {
            int temp;
            List<int> newList = new List<int>();
            Random r = new Random();

            while (sortedList.Count > 0)
            {
                temp = (int)r.Next(sortedList.Count);
                newList.Add(sortedList[temp]);
                sortedList.RemoveAt(temp);
            }

            itteration++;
            sortedList = newList;
        }
    }
}
