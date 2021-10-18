using System;

namespace Moderate.Problem06
{
    public class SmallestDifference
    {
        public int FindSmallestDifference(int[] array1, int[] array2)
        {
            int[] sortedArray1 = new int[array1.Length];
            Array.Copy(array1, sortedArray1, array1.Length);

            int[] sortedArray2 = new int[array2.Length];
            Array.Copy(array2, sortedArray2, array2.Length);

            Array.Sort(sortedArray1);
            Array.Sort(sortedArray2);

            int smallestDifference = Int32.MaxValue;
            int pos1 = 0, pos2 = 0;

            while ((pos1 < sortedArray1.Length)&&(pos2 < sortedArray2.Length))
            {
                int val1;
                int val2;

                if (pos1 >= sortedArray1.Length)
                {
                    val1 = sortedArray1[sortedArray1.Length - 1];
                }
                else
                {
                    val1 = sortedArray1[pos1];
                }

                if (pos2 >= sortedArray2.Length)
                {
                    val2 = sortedArray2[sortedArray2.Length - 1];
                }
                else
                {
                    val2 = sortedArray2[pos2];
                }

                if (val1 <= val2)
                {
                    if ((val2 - val1) < smallestDifference)
                    {
                        smallestDifference = val2 - val1;
                    }

                    if (pos1 < sortedArray1.Length)
                    {
                        pos1++;
                    }
                    else
                    {
                        pos2++;
                    }
                }
                else if (val1 > val2)
                {
                    if ((val1 - val2) < smallestDifference)
                    {
                        smallestDifference = val1 - val2;
                    }

                    if (pos2 < sortedArray2.Length)
                    {
                        pos2++;
                    }
                    else
                    {
                        pos1++;
                    }
                }
            }


            return smallestDifference;
        }
    }
}
