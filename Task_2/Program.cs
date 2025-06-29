using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Numerics;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q_1 
            //1- Write a program that allows the user to enter a number then print it. 
            //Console.Write("Enter a number: ");
            //bool flag = int.TryParse(Console.ReadLine(), out int num);

            //if (flag)
            //{
            //    Console.WriteLine($"\nNumber is :{num}");
            //}
            //else
            //{
            //    Console.WriteLine("\nPlease Enter only Numbers");
            //}
            #endregion

            #region Q_2
            // Write C# program that converts a string to an integer, but the string contains non - numeric characters.And mention what will happen
            //Console.Write("Enter anything:");
            //int Massege = Console.ReadLine();       //Error Massege --> can not explicity convert string to int 
            #endregion

            #region Q_3
            // Write C# program that Perform a simple arithmetic operation with floating - point numbers And mention what will happen

            //Console.Write("Eneter First number:");
            //bool flag_num1 = float.TryParse(Console.ReadLine(),out float num1);
            //Console.Write("Eneter Second number:");
            //bool flag_num2 = float.TryParse(Console.ReadLine(),out float num2);

            //if (!flag_num1 || !flag_num2)
            //{
            //    Console.WriteLine("Enter only Numbers!");
            //}
            //else
            //{
            //    Console.Write("Choose the operator (+, -, /, *): ");
            //    string? operation = Console.ReadLine();
            //    switch (operation)
            //    {
            //        case "+":
            //            Console.WriteLine($"Results {num1} + {num2} = {num1 + num2}");
            //            break;
            //        case "*":
            //            Console.WriteLine($"Results {num1} * {num2} = {num1 * num2}");
            //            break;
            //        case "-":
            //            Console.WriteLine($"Results {num1} - {num2} = {num1 - num2}");
            //            break;
            //        case "/":
            //            Console.WriteLine($"Results {num1} / {num2} = {num1 / num2}");
            //            break;
            //        default:
            //            Console.WriteLine("Wrong Operation, only (+, -, /, *)");
            //            break;
            //    }
            //}
            #endregion

            #region Q_4
            //Write C# program that Extract a substring from a given string.
            //Console.Write("Enter Anything: ");
            //string? input = Console.ReadLine();
            //int Space_input = input.IndexOf(' ');
            //string? fisrt_word = input.Substring(0, Space_input);
            //Console.WriteLine(fisrt_word);
            //--------------------------------- OR -------------------------------------
            //Console.Write("Enter a sentence: ");
            //string? User_Input = Console.ReadLine();
            //Console.Write("Enter start index: ");
            //bool flag_start_index = int.TryParse(Console.ReadLine(), out int Start_idex);
            //Console.Write("Enter End index: ");
            //bool flag_End_Index = int.TryParse(Console.ReadLine(), out int End_idex);

            //if (!flag_start_index || !flag_End_Index)
            //{
            //    Console.WriteLine("Enter only number not character");
            //}
            //else {
            //    string Results = User_Input.Substring(Start_idex, End_idex);
            //    Console.Write($"Word : {Results}");
            //}
            #endregion

            #region Q_5
            // Write C# program that take two string variables and print them as one variable
            //Console.Write("Enter First Word : ");
            //string? First_Word = Console.ReadLine();
            //Console.Write("Enter Second Word : ");
            //string? Second_Word = Console.ReadLine();
            //Console.WriteLine($"{First_Word} {Second_Word}");
            #endregion

            #region Q_6
            //program calculates the simple interest given the principal amount, rate of interest, and time.The formula for simple interest is Interest = (principal * rate * time) / 100.

            //Console.WriteLine("Program that calculates the simple interest given the principal amount, rate of interest, and time\n");
            //Console.Write("Enter Principal Amount : ");
            //bool flag_principal_Amount = decimal.TryParse(Console.ReadLine(), out decimal principal_Amount);
            //Console.Write("Rate of interest (%) : ");
            //bool flag_Rate_of_interest = double.TryParse(Console.ReadLine(), out double Rate_of_interest);
            //Console.Write("Time per month: ");
            //bool flag_time_per_month = int.TryParse(Console.ReadLine(), out int time_per_month);
            //decimal formula = (principal_Amount * (decimal)Rate_of_interest * time_per_month) / 100;
            //if (!flag_principal_Amount || !flag_Rate_of_interest || !flag_time_per_month)
            //{
            //    Console.WriteLine("Wrong inputs");
            //}
            //else
            //{
            //    Console.WriteLine($"Interest = ({principal_Amount} * {Rate_of_interest} * {time_per_month} ) / 100 = {formula}");
            //}
            #endregion

            #region Q_7
            //program that calculates the Body Mass Index (BMI)given a person's weight in kilograms and height in meters.The formula for BMI is BMI = (Weight) / (Height * Height)

            //Console.WriteLine("Program that calculates the Body Mass Index (BMI)\n");
            //Console.Write("Enter weight in Kilograms (Kg) : ");
            //bool Flag_User_weight =float.TryParse(Console.ReadLine(), out float User_weight);
            //Console.Write("Enter height in Meters (M) : ");
            //bool Flag_User_hieght = float.TryParse(Console.ReadLine(), out float User_hieght);
            //float formula =  User_weight / (User_hieght * User_hieght);
            //if (!Flag_User_weight || !Flag_User_hieght)
            //{
            //    Console.WriteLine("Wrong Inputs!");
            //}
            //else if(User_hieght <= 0){
            //    Console.WriteLine("Height must be greater than 0");
            //}
            //else
            //{
            //    Console.WriteLine($"Your BMI : {formula}");
            //}
            #endregion

            #region Q_8
            /*Write a program that takes the date from the user and displays it in various formats using string interpolation. (Search) 
            Ex : 
            Today’s date : 20 , 11 , 2001 
            Today's date : 20 / 11 / 2001 
            Today's date : 20 – 11 – 2001 
             */
            //Console.Write("Enter the day : ");
            //bool flag_DayValid = int.TryParse(Console.ReadLine(), out int day);

            //Console.Write("Enter a number of Month : ");
            //bool flag_MonthValid = int.TryParse(Console.ReadLine(), out int month);

            //Console.Write("Enter the year : ");
            //bool flag_YearValid = int.TryParse(Console.ReadLine(), out int year);

            //if (!flag_DayValid || !flag_MonthValid || !flag_YearValid)
            //{
            //    Console.WriteLine("❌ Invalid input. Please enter numeric values.");
            //}
            //else if(month < 1 || month > 12 || day < 1 || day > 31 || year <=0)
            //{
            //    Console.WriteLine("Month should be between 1 and 12, Day between 1 and 31, and Year must be positive.");
            //}
            //else
            //{
            //    Console.Clear();
            //    Console.WriteLine($"\nToday's date: {day} , {month} , {year}\n");
            //    Console.WriteLine($"Today's date: {day} / {month} / {year}\n");
            //    Console.WriteLine($"Today's date: {day} – {month} – {year}");
            //}
            #endregion

            #region Q_9
            // What is the output of the following C# code?     DateTime date = new DateTime(2024, 6, 14);  Console.WriteLine($"The event is on {date:MM/dd/yyyy}");

            // Output : C) The event is on 6/14/2024 
            #endregion

            #region Q_10
            /* Which of the following statements is correct about the C#.NET code snippet given below?
            int d;
            d = Convert.ToInt32(!(30 < 20)); */
            // output : f) A value 1 will be assigned to d.
            #endregion

            #region Q_11
            /*Which of the following is the correct output for the C# code given below? 
            Console.WriteLine(13 / 2 + " " + 13 % 2); 
            */
                    // Output : d) 6 1
            #endregion
        }
    }
}
