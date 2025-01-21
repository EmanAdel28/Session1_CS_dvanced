using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_CS_dvanced
{
   
        internal class Helper<T> where T : IComparable<T>
        {

            public static void Swap(ref T X, ref T Y)
            {
                T temp = X;
                X = Y;
                Y = temp;
            }


            public static void BubbleSort(T[] arr)
            {
                bool Swapped = false;
                if (arr is not null)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        for (int j = 0; j < arr.Length - i - 1; j++)
                        {
                            if (arr[j].CompareTo(arr[j + 1]) == 1)
                                Swap(ref arr[j], ref arr[j + 1]);
                            Swapped = true;
                        }

                        if (!Swapped)
                            break;
                    }
                }
            }
        }
    }

