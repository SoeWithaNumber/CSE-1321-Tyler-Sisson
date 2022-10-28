using System;
class Lab9B{
    public static int[] bubbleSort(int[] inputArr){
        int[] arr = inputArr.Clone() as int[];
        bool allInOrder = true;
        int temp;
        for (int i = 1; i < arr.Length; i++)
        {
            if(arr[i] < arr[i-1]){
                allInOrder = false;
                temp = arr[i];
                arr[i] = arr[i-1];
                arr[i-1] = temp;
            }
        }
        if(allInOrder){
            return arr;
        }
        return bubbleSort(arr);
    }

    public static bool binarySearch(int[] arr, int target, int min, int max){
        int mid = min + (max - min)/2;
        Console.WriteLine("Searching\nLow is {0}\nHigh is {1}\nMid is {2}\n", min, max, mid);
        if(min > max){
            return false;
        }
        else if(arr[mid] == target){
            return true;
        }
        else if(target > arr[mid]){
            return binarySearch(arr, target, mid+1, max);
        }
        else if(target < arr[mid]){
            return binarySearch(arr, target, min, mid-1);
        }
        return false;
    }

    public static void Main(String[] args){
        Console.WriteLine("Please enter 11 numbers:");
        int[] numbers = new int[11]; 
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Integer {0}: ", i+1);
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        int[] sortedArray = bubbleSort(numbers);
        Console.WriteLine();
        Console.Write("What is the target number: ");
        int target = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("The sorted set is: {0}", string.Join(", ", sortedArray));


        bool isInSet = binarySearch(sortedArray, target, 0, sortedArray.Length);

        Console.WriteLine();
        Console.WriteLine(isInSet ? "The target is in the set." : "The target is not in the set.");


    }
}