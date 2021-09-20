/**
Name    : Windu Nursetyadi
NPM     : 140810190041
Date    : 19 September 2021
*/
using System;
using System.Text;

public class ShiftCipher
{
    public static StringBuilder Encrypt(String text, int key)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            char ch = (char)(((int)text[i] + key - 65) % 26 + 65);
            result.Append(ch);
        }

        return result;
    }

    public static StringBuilder Decrypt(String text, int key)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            char ch = (char)(((int)text[i] - key - 65 + 26) % 26 + 65);
            result.Append(ch);
        }

        return result;
    }

    public static void Main(String[] args)
    {
        String text, yesInput, menuInput;
        int key;

        while(true) 
        {
            Console.Clear();
            Console.WriteLine("Select an option");
            Console.WriteLine("1. Encryption");
            Console.WriteLine("2. Decryption");
            Console.Write("Your option : ");
            menuInput = Console.ReadLine();

            if (menuInput == "1")
            {
                Console.WriteLine("");
                Console.Write("Enter Text : ");
                text = Console.ReadLine();
                Console.Write("Enter Key : ");
                key = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Cipher : " + Encrypt(text, key));
            }
            else if (menuInput == "2")
            {
                Console.WriteLine("");
                Console.Write("Enter Cipher : ");
                text = Console.ReadLine();
                Console.Write("Enter Key : ");
                key = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Cipher : " + Decrypt(text, key));
            }
            else
            {
                continue;
            }

            Console.WriteLine("Want to try again? (Y/N) : ");
            yesInput = Console.ReadLine();
            switch (yesInput)
            {
                case "Y":
                    continue;
                case "y":
                    continue;
                default:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
            }
        }

    }
}

