using System;

namespace GuessMyNumberGame
{
    class Program
    {
        public static int count = 0;
        public static int BisectionSearch(int[] list, int userNum)

        {
            int middle = (list.Length) / 2;
            int result = 0;
            int[] narrowedList = new int[middle];


                if (list.Length % 2 == 0)
                {
                    if (userNum == list[middle - 1])
                    {
                        Console.WriteLine($"Your number {userNum} was found in the list after {count} iterations.");
                        return result;
                    }
                    else if (userNum > list[middle - 1])
                    {
                        Console.WriteLine($"Your number is greater than {middle}");
                        //Console.WriteLine($"Your serch has been narrowed down to this list:");
                        for (int i = middle; i < list.Length; i++)
                        {
                            narrowedList[i - middle] += list[i];
                        }
                        //PrintArray(narrowedList);
                        //for (int i = middle + 1; i < list.Length; i++)
                        //{
                        //    narrowedList[i - middle - 1] = list[i];
                        //}
                    }
                    else if (userNum < list[middle - 1])
                    {
                        Console.WriteLine($"Your number is less than {middle}");
                        for (int i = 0; i < middle; i++)
                        {
                            narrowedList[i] += list[i];
                        }
                        //for (int i = 0; i < middle; i++)
                        //{
                        //    narrowedList[i] = list[i];
                        //}
                    }
                    else
                    {
                        Console.WriteLine("Your number could not be found in the list.");
                    }
                }
                
                if (list.Length % 2 == 1)
                {
                    if (userNum == list[middle])
                    {
                        Console.WriteLine($"Your number {userNum} was found in the list after {count} iterations.");
                        return result;
                    }
                    else if (userNum > list[middle])
                    {
                        Console.WriteLine($"Your number is greater than {middle}");
                        //Console.WriteLine($"Your serch has been narrowed down to this list:");
                        for (int i = middle + 1; i < list.Length; i++)
                        {
                            narrowedList[i - middle - 1] += list[i];
                        }
                        //PrintArray(narrowedList);
                    
                        //for (int i = middle + 1; i < list.Length; i++)
                        //{
                        //    narrowedList[i - middle - 1] = list[i];
                        //}
                    }
                    else if (userNum < list[middle])
                    {
                        Console.WriteLine($"Your number is less than {middle}");
                        for (int i = 0; i < middle; i++)
                        {
                            narrowedList[i] += list[i];
                        }
                        //for (int i = 0; i < middle; i++)
                        //{
                        //    narrowedList[i] = list[i];
                        //}
                    }
                    else
                    {
                        Console.WriteLine("Your number could not be found in the list.");
                    }
                
                } 
                count++;
                return BisectionSearch(narrowedList, userNum);
        }
        public static void PrintArray(int[] list)
        {
            foreach (int num in list)
            {
                Console.Write($"{num} ");
            }
        }
        static void Main(string[] args)
        {
            //int[] numList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //PrintArray(numList);
            //Console.WriteLine("\n Enter the number you need to find in the list");
            //int userNum = Int32.Parse(Console.ReadLine());
            //Console.WriteLine(BisectionSearch(numList, userNum));
            //GuessingGame.PlayerGuess();
            GuessingGame.ComputerGuess();
        }
    }
}
