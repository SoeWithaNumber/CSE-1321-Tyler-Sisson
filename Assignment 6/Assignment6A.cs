using System;
class Assignment6A{
    static void create_random_array(int[] array){

        Random rand = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-500, 500);
        }
    }

    static bool is_array_sorted(int[] array){
        for (int i = 1; i < array.Length; i++)
        {
            if(array[i-1] > array[i]){
                return false;
            }
        }
            return true;
    }

    static void sort_array(int[] array){ 
        for (int i = 0; i < array.Length - 1; i++)
        {
            int indexOfSmallest = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if(array[j] < array[indexOfSmallest]){indexOfSmallest = j;}
            }

            int temp = array[indexOfSmallest];
            array[indexOfSmallest] = array[i];
            array[i] = temp;

        }
    }

    public static void Main(String[] args){
        int[] arr = new int[10];
        create_random_array(arr);
        bool finished = false;
        while (!finished)
        {
            Console.WriteLine("Array: [{0}]", String.Join(", ", arr));
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1) Generate new random array");
            Console.WriteLine("2) Is the array sorted?");
            Console.WriteLine("3) Sort the array");
            Console.WriteLine("4) Quit");
            Console.WriteLine();
            Console.Write("Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: 
                    create_random_array(arr);
                    break;
                case 2: 
                    Console.WriteLine(is_array_sorted(arr) ? "The array is sorted" : "The array is not sorted");
                    break;
                case 3:
                    sort_array(arr);
                    break;
                case 4: 
                    finished = true;
                    break;
            }
            if(finished){
                break;
            }
        }
    }        
}
