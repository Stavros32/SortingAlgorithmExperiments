using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4.SortingAlgorithms
{
    public class QuickSort
    {
        public static void OrderByDeccendingColor(TShirt[] arr, int low, int high)
        {
            if (low < high)
            {

                int pi = partitionOrderByDeccending(arr, low, high);

                OrderByDeccendingColor(arr, low, pi - 1);
                OrderByDeccendingColor(arr, pi + 1, high);
            }
        }

        public static int partitionOrderByDeccending(TShirt[] arr, int low, int high)
        {
            TShirt pivot = arr[high];


            int i = (low - 1);
            for (int j = low; j < high; j++)
            {

                if (arr[j].Color < pivot.Color)
                {
                    i++;

                    TShirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }


            TShirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        public static void OrderByAccendingColor(TShirt[] arr, int low, int high)
        {
            if (low < high)
            {

                int pi = partitionOrderByAccending(arr, low, high);

                OrderByAccendingColor(arr, low, pi - 1);
                OrderByAccendingColor(arr, pi + 1, high);
            }
        }

        public static int partitionOrderByAccending(TShirt[] arr, int low, int high)
        {
            TShirt pivot = arr[high];


            int i = (low - 1);
            for (int j = low; j < high; j++)
            {

                if (arr[j].Color > pivot.Color)
                {
                    i++;

                    TShirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }


            TShirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
    }
}
