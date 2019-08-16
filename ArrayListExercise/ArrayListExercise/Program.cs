using System;
using System.Collections.Generic;




    class Program
    {
        static void Main()
        {

        string[] colorArray = {"Blue", "Purple", "Yellow", "Green", "Red", "Orang"};
        int[] moneyArray = { 100, 500, 1000, 2000, 10000 };

        List<string> names = new List<string>();
        names.Add("Michael");
        names.Add("James");
        names.Add("Adriana");
        names.Add("Danielle");

        try
        {

            Console.WriteLine("Pick an Indecies Number to select a Color");
            int pickColor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(colorArray[pickColor]);
        }
        catch
        {
            Console.WriteLine("Index does not exist, pick again");
            int pickColor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(colorArray[pickColor]);
        }


        try
        {
            Console.WriteLine("Pick an Indecies Number find out your Cash Reward");
            int moneyPick = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(moneyArray[moneyPick]);
        }
        catch
        {
            Console.WriteLine("Index does not exist, pick again");
            int moneyPick = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(moneyArray[moneyPick]);
        }


        try
        {
            Console.WriteLine("Pick an Indecies Number to select a Partner");
            int personPicked = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(names[personPicked]);

        }
        catch
        {
            Console.WriteLine("Index does not exist, pick again");
            int personPicked = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(names[personPicked]);

        }

        Console.ReadLine();





        }

        
    }

