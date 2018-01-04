using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class MergeSort
    {
        public static int[] Sort(int[] arrayForSort)
        {
            if (arrayForSort.Length == 1)
            {
                return arrayForSort;
            }
            int[] firsArray;
            int[] secondArray;
            Split(arrayForSort, out firsArray, out secondArray);

            return Merge(Sort(firsArray), Sort(secondArray));
        }

        public static int[] Merge(int[] firstArray, int[] secondArray)
        {
            int arrayLength = firstArray.Length + secondArray.Length;
            int[] resultArray = new int[arrayLength];
            int countFirstArray = 0;
            int countSecondArray = 0;
            for (int i = 0; i < resultArray.Length; i++)
            {
                if (firstArray.Length == countFirstArray)
                {
                    resultArray[i] = secondArray[countSecondArray];
                    countSecondArray++;
                }
                else
                {
                    if (secondArray.Length == countSecondArray)
                    {
                        resultArray[i] = secondArray[countFirstArray];
                        countFirstArray++;
                    }
                    else
                    {
                        if (firstArray[countFirstArray] < secondArray[countSecondArray])
                        {
                            resultArray[i] = firstArray[countFirstArray];
                            countFirstArray++;
                        }
                        else
                        {
                            if (firstArray[countFirstArray] == secondArray[countSecondArray])
                            {
                                resultArray[i] = firstArray[countFirstArray];
                                i++;
                                resultArray[i] = firstArray[countSecondArray];
                                countFirstArray++;
                                countSecondArray++;
                            }
                            else
                            {
                                resultArray[i] = secondArray[countSecondArray];
                                countSecondArray++;
                            }
                        }
                    }
                }
            }
            return resultArray;
        }

        public static void Split<T>(T[] array, out T[] first, out T[] second)
        {
            int index = array.Length / 2;
            first = array.Take(index).ToArray();
            second = array.Skip(index).ToArray();
        }

        static void Main(string[] args)
        {
            int[] array = new int[] { 6, 3, 9, 9 };
            Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
