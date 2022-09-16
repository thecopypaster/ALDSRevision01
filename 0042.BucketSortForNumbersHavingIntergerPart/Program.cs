// See https://aka.ms/new-console-template for more information

float[] arr = { (float)9.8, (float)0.6, (float)10.1, (float)1.9, (float)4.8,
                (float)3.07, (float)3.04, (float)5.0, (float)8.0,(float)7.68 };

int noOfBuckets = 5;
//BucketSort(arr, noOfBuckets);

// Bucket sort for numbers
// having integer part
//static void BucketSort(float[] arr, int noOfBuckets)
//{
//    var max_ele = arr.Max();teradata
//    var min_ele = arr.Min();
//    // range(for buckets)
//    var rnge = (max_ele - min_ele) / noOfBuckets;
//    var temp = new List<float>[arr.Length];
//    // create empty buckets
//    for (int i = 0; i < arr.Length; i++)
//    {
//        temp[i] = new List<float>();
//    }

//    // scatter the array elements
//    // into the correct bucket
//    for (int i = 0; i < arr.Length; i++)
//    {
//        //<parser-error>
//        // append the boundary elements to the lower array
//        if (diff == 0 && arr[i] != min_ele)
//        {
//            temp[Convert.ToInt32((arr[i] - min_ele) / rnge) - 1].append(arr[i]);
//        }
//        else
//        {
//            temp[Convert.ToInt32((arr[i] - min_ele) / rnge)].append(arr[i]);
//        }
//    }
//    // Sort each bucket individually
//    foreach (var i in Enumerable.Range(0, temp.Count))
//    {
//        if (temp[i].Count != 0)
//        {
//            temp[i].sort();
//        }
//    }
//    // Gather sorted elements
//    // to the original array
//    var k = 0;
//    foreach (var lst in temp)
//    {
//        if (lst)
//        {
//            foreach (var i in lst)
//            {
//                arr[k] = i;
//                k = k + 1;
//            }
//        }
//    }
//}

