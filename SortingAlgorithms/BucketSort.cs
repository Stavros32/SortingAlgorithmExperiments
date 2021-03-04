using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_4.SortingAlgorithms
{


    class BucketSort
    {


        public static TShirt[] BucketSortAsc(TShirt[] array)
        {
            List<List<TShirt>> buckets = new List<List<TShirt>>();
            InitializeBucketsAsc(buckets);

            ScatterAsc(array, buckets);

            int i = 0;
            foreach (List<TShirt> bucket in buckets)
            {
                TShirt[] arr = bucket.ToArray();

                foreach (TShirt d in arr)
                {
                    array[i++] = d;
                }
            }

            return array;
        }

        private static void ScatterAsc(TShirt[] array, List<List<TShirt>> buckets)
        {
            foreach (TShirt value in array)
            {
                int bucketFabric = GetBucketFabricKeyAsc(value);
                buckets[bucketFabric].Add(value);
            }
        }


        private static int GetBucketFabricKeyAsc(TShirt tshirt)
        {
            int key = (int)tshirt.Fabric;
            return key;
        }

        private static void InitializeBucketsAsc(List<List<TShirt>> buckets)
        {
            for (int i = 0; i < 10; i++)
            {
                List<TShirt> a = new List<TShirt>();
                buckets.Add(a);
            }
        }

        public static TShirt[] BucketSortDec(TShirt[] array)
        {
            List<List<TShirt>> buckets = new List<List<TShirt>>();
            InitializeBucketsDec(buckets);

            ScatterDec(array, buckets);

            int i = array.Length -1;

            foreach (List<TShirt> bucket in buckets)
            {
                TShirt[] arr = bucket.ToArray();

                foreach (TShirt d in arr)
                {
                    array[i--] = d;

                }
            }



            return array;
        }

        private static void ScatterDec(TShirt[] array, List<List<TShirt>> buckets)
        {
            foreach (TShirt value in array)
            {
                int bucketFabric = GetBucketFabricKeyDec(value);
                buckets[bucketFabric].Add(value);
            }
        }


        private static int GetBucketFabricKeyDec(TShirt tshirt)
        {
            int key = (int)tshirt.Fabric;
            return key;
        }

        private static void InitializeBucketsDec(List<List<TShirt>> buckets)
        {
            for (int i = 0; i < 10; i++)
            {
                List<TShirt> a = new List<TShirt>();
                buckets.Add(a);
            }
        }
    }


}
