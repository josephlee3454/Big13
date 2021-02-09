using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            // int[] array={1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
            // LoopArray(array);
            // int[] array={1,2,3,4,5,6,7,8,34,10,11,12,13,55,15,16,17,72,19,20};
            // FindMax(array);
            // int[] array={3,6,4};
            // GetAverage(array);
            // OddArray();
            // int[] numbers={3,6,4};
            // int y = 3;
            // GreaterThanY(numbers,y);
            int[] numbers={3,6,4,0,-3,-4};
            // SquareArrayValues( numbers);
            // EliminateNegatives(numbers);
            // MinMaxAverage(numbers);
            // ShiftValues(numbers);
            NumToString(numbers);

        }
    // Print all of the integers from 1 to 255.
        public static void PrintNumbers()
        {
            for (var idx = 1; idx < 255 ; idx++)
            {
                Console.WriteLine(idx);
            }

        }
        // Print all of the odd integers from 1 to 255.
        public static void PrintOdds()
        {
            for (var idx = 1; idx <= 255 ; idx++)
                if(idx%3==0)
                {
                    Console.WriteLine(idx);
                }
        }
        // Print all of the numbers from 0 to 255, 
        // but this time, also print the sum as you go. 
        // For example, your output should be something like this:

        // New number: 0 Sum: 0
        // New number: 1 Sum: 1
        // New Number: 2 Sum: 3
        public static void PrintSum()
        {
            int sum = 0; 
            for (var idx = 1; idx <= 255 ; idx++)
                {   
                    Console.WriteLine(idx);
                    sum = sum + idx;
                    Console.WriteLine( sum);
                }


        }

        // Write a function that would iterate through each item of the given integer array and 
        // print each value to the console. 
        public static void LoopArray(int[] array)
        {
            for (var idx = 1; idx <array.Length + 1; idx++){
                 Console.WriteLine(idx);
            }
            
        }


    // Write a function that takes an integer array and prints and returns the maximum value in the array. 
    // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
    // or even a mix of positive numbers, negative numbers and zero.
       
       
        public static int[] FindMax(int[] array)
        {
            int greatest = array[0];
            for (var idx = 1; idx <array.Length; idx++)
            if(array[idx] > greatest )
            {       
                greatest = array[idx];
            }
            Console.WriteLine(greatest);
            return array;
        }


    // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
    // For example, with an array [2, 10, 3], your program should write 5 to the console.
        public static void GetAverage(int[] array)
            {       
            int sum = 0;
            int count = array.Length;

          for (var idx = 0; idx <array.Length; idx++)
                sum = sum+array[idx];
            {
                Console.WriteLine(count);
                Console.WriteLine(sum/count);

            }
                int num = sum/count;
                
            }



    /////
    // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
    // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
    public static int[] OddArray()

    {
        int [] array = new int[255];
        for (var idx = 0; idx <255; idx++){
        if (idx%2==1){
            array[idx] = idx;
            Console.WriteLine(array[idx]);
        }
            } 
        
        return array;
    }

            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
    public static int GreaterThanY(int[] numbers, int y)
             {       
              
                int count = 0;

            for (var idx = 0; idx <numbers.Length; idx++)
                   if (numbers[idx]>y)
                {
                    count+=1;

                }   
                    Console.WriteLine(count);
                    return count;
                
            }

        // Write a function that takes an integer array "numbers", and then multiplies each value by itself.copy
        // For example, [1,5,10,-10] should become [1,25,100,100]
            public static void SquareArrayValues(int[] numbers)
                {       

            for (var idx = 0; idx <numbers.Length; idx++)
                {
                    int mul = numbers[idx] * numbers[idx];
                    numbers[idx] = mul;
                    Console.WriteLine(mul);
                }   
                        
                // return numbers;
            }

            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            public static int[] EliminateNegatives(int[] numbers)
                {
                for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] < 0) {
                    numbers[i] = 0;
                }
                Console.WriteLine(numbers[i]);
                }
                Console.WriteLine("[{0}]", string.Join(", ", numbers));
                return numbers;
                }

        // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
        // the minimum value in the array, and the average of the values in the array.
            public static string MinMaxAverage(int[] numbers)
                {
                int sum = 0;
                int min = numbers[0];
                int greatest = numbers[0];
                for (int i = 0; i < numbers.Length; i++)
                
                 {
                    if (numbers[i] < min) 
                    {
                        min = numbers[i];
                    }
                    else if(numbers[i] > greatest)
                    {       
                        greatest = numbers[i];
                    }
                    sum = sum + numbers[i];

                        Console.WriteLine(sum);
                        Console.WriteLine(greatest);
                        Console.WriteLine(min);
                  }

                float average = ((float) sum / numbers.Length);
                string everything = $"Min: {min}, Max: {greatest}, Average: {average}";

                    Console.WriteLine (everything);
                    return everything;
                }

            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].
                public static void ShiftValues(int[] numbers)
                {
                    // int temp = 0;
                for (int i = 0; i < numbers.Length; i++) {



                    if(i == numbers.Length-1)
                   {
                       numbers[i] = 0;

                   }
                   else{
                       numbers[i] = numbers[i+1];
                   }
                   Console.WriteLine (numbers[i]);
                }
                }


                // Write a function that takes an integer array and returns an object array 
                // that replaces any negative number with the string 'Dojo'.
                // For example, if array "numbers" is initially [-1, -3, 2] 
                // your function should return an array with values ['Dojo', 'Dojo', 2].
                 public static List<object> NumToString (int[] arr) {
                    List<object> dojoList = new List<object> ();
                    for (var i = 0; i < arr.Length; i++) {
                        if (arr[i] < 0) {
                            dojoList.Add ("Dojo");
                        } else {
                            dojoList.Add (arr[i]);
                        }
                        Console.WriteLine (dojoList[i]);
                    }
                    return dojoList;
                }




    }
}