//Program 1
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] transactions = { 200, -150, 340, 500, -100 };
//        int sum = 0;

//        for (int i = 0; i < transactions.Length; i++)
//        {
//            sum += transactions[i];
//        }

//        Console.WriteLine("Total sum of transactions: " + sum);
//    }
//}

//Program 2
//using System;

//class Program
//{
//    static void Main()
//    {
//        float[] scores = { 85.5f, 90.3f, 78.4f, 88.9f, 92.1f };
//        float sum = 0;

//        for (int i = 0; i < scores.Length; i++)
//        {
//            sum += scores[i];
//        }

//        float average = sum / scores.Length;
//        Console.WriteLine("Average score: " + average);
//    }
//}

//Program 3
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] prices = { 1500, 2300, 999, 3200, 1750 };
//        int max = prices[0];

//        for (int i = 1; i < prices.Length; i++)
//        {
//            if (prices[i] > max)
//            {
//                max = prices[i];
//            }
//            else
//            {
//                // do nothing, keep current max
//            }
//        }

//        Console.WriteLine("Most expensive item price: " + max);
//    }
//}

//Program 4
//    using System;

//class Program
//{
//    static void Main()
//    {
//        int[] participantCodes = { 102, 215, 324, 453, 536 };
//        int maleCount = 0, femaleCount = 0;

//        for (int i = 0; i < participantCodes.Length; i++)
//        {
//            if (participantCodes[i] % 2 == 0)
//            {
//                maleCount++;
//            }
//            else
//            {
//                femaleCount++;
//            }
//        }

//        Console.WriteLine("Number of male participants: " + maleCount);
//        Console.WriteLine("Number of female participants: " + femaleCount);
//    }
//}

//Program 5
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] searchHistory = { 101, 202, 303, 404, 505 };
//        int n = searchHistory.Length;

//        for (int i = 0; i < n / 2; i++)
//        {
//            int temp = searchHistory[i];
//            searchHistory[i] = searchHistory[n - 1 - i];
//            searchHistory[n - 1 - i] = temp;
//        }

//        Console.WriteLine("Reversed search history:");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write(searchHistory[i] + " ");
//        }
//    }
//}

//Program 6
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] measurements = { 2, 4, 6, 8 };
//        int factor = 3;

//        for (int i = 0; i < measurements.Length; i++)
//        {
//            measurements[i] *= factor;
//        }

//        Console.WriteLine("Adjusted measurements:");
//        for (int i = 0; i < measurements.Length; i++)
//        {
//            Console.Write(measurements[i] + " ");
//        }
//    }
//}

//Program 7
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] bookCodes = { 101, 203, 304, 405, 506 };
//        int searchCode = 304;
//        int index = -1;

//        for (int i = 0; i < bookCodes.Length; i++)
//        {
//            if (bookCodes[i] == searchCode)
//            {
//                index = i;
//                break;
//            }
//        }

//        if (index != -1)
//        {
//            Console.WriteLine("Book found at index: " + index);
//        }
//        else
//        {
//            Console.WriteLine("Book not found in the system.");
//        }
//    }
//}

//Program 8
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] grades = { 56, 78, 89, 45, 67 };

//        // Sort the array in ascending order
//        Array.Sort(grades);

//        // Second smallest will be at index 1 after sorting
//        int secondSmallest = grades[1];

//        Console.WriteLine("Second smallest grade: " + secondSmallest);
//    }
//}

//Program 9
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        int[] ids = { 102, 215, 102, 324, 215 };
//        HashSet<int> uniqueIds = new HashSet<int>();

//        for (int i = 0; i < ids.Length; i++)
//        {
//            uniqueIds.Add(ids[i]);
//        }

//        Console.WriteLine("Unique IDs:");
//        foreach (int id in uniqueIds)
//        {
//            Console.Write(id + " ");
//        }
//    }
//}

//Program 10
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] dataset1 = { 1, 2, 3, 4, 5 };
//        int[] dataset2 = { 3, 4, 5, 6, 7 };

//        Console.WriteLine("Common elements:");
//        for (int i = 0; i < dataset1.Length; i++)
//        {
//            for (int j = 0; j < dataset2.Length; j++)
//            {
//                if (dataset1[i] == dataset2[j])
//                {
//                    Console.Write(dataset1[i] + " ");
//                }
//            }
//        }
//    }
//}












