﻿using System;

namespace ValidateTheName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please input you name:");
                string nameInput = Console.ReadLine();

                if (nameInputIsInvalid(nameInput))
                {
                    Console.WriteLine($"The name {nameInput} is a valid name");
                }
                else
                {
                    Console.WriteLine($"The name {nameInput} is an Invalid name");
                }

            }
        }

        static bool nameInputIsInvalid(string? nameInput)
        {
             //insert validation code here.
            return true;
        }



    }
}





