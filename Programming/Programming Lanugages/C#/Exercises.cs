// Note: for all these exercises, ignore input validation unless otherwise directed. Assume the user enters a value in the format that the program expects. For example, if the program expects the user to enter a number, don't worry about validating if the input is a number or not. When testing your program, simply enter a number.

// 1- Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)

// 2- Write a program which takes two numbers from the console and displays the maximum of the two.

// 3- Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.

// 4- Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, program should display Ok on the console. If the value is above the speed limit, the program should calculate the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.

using System;

namespace CSharpExercises
{
	class Program
	{
		static void Main(string[] args)
		{
			// Exercise 1
			Console.WriteLine("Enter a number between 1 and 10: ");
			var number = Convert.ToInt32(Console.ReadLine());
			if (number >= 1 && number <= 10)
			{
				Console.WriteLine("Valid");
			}
			else
			{
				Console.WriteLine("Invalid");
			}

			// Exercise 2
			Console.WriteLine("Enter the first number: ");
			var firstNumber = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the second number: ");
			var secondNumber = Convert.ToInt32(Console.ReadLine());
			var maxNumber = (firstNumber > secondNumber) ? firstNumber : secondNumber;
			Console.WriteLine("The maximum number is: " + maxNumber);

			// Exercise 3
			Console.WriteLine("Enter the width of the image: ");
			var width = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the height of the image: ");
			var height = Convert.ToInt32(Console.ReadLine());
			var orientation = (width > height) ? "Landscape" : "Portrait";
			Console.WriteLine("The image is: " + orientation);

			// Exercise 4
			Console.WriteLine("Enter the speed limit: ");
			var speedLimit = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the speed of the car: ");
			var speed = Convert.ToInt32(Console.ReadLine());
			if (speed <= speedLimit)
			{
				Console.WriteLine("Ok");
			}
			else
			{
				const int kmPerDemeritPoint = 5;
				var demeritPoints = (speed - speedLimit) / kmPerDemeritPoint;
				if (demeritPoints > 12)
				{
					Console.WriteLine("License Suspended");
				}
				else
				{
					Console.WriteLine("Demerit points: " + demeritPoints);
				}
			}
		}
	}
}