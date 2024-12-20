// See https://aka.ms/new-console-template for more information
using System;

namespace palindrom;

class Palindrom
{
    static void Main(string[] args)
    {
        bool Gameover = false;
        
        int Score = 0;
        Console.WriteLine("Game Started");
        while (!Gameover)
        {
            Console.WriteLine("Please Enter a Text : ");
            string text = Console.ReadLine();
            string word = "";
            char[] chararayye = text.ToCharArray();

            for (int i = chararayye.Length - 1; i >= 0; i--)
            {
                 word = word + chararayye[i];
            }
            if (word == text)
            {
                Score++;
                Console.WriteLine("Yes , You can Get a Score");

            }
            else
            {
                Console.WriteLine("Faild Word GameOver");
                Score = 0;
                Gameover = true;
                break;
            }
            Console.WriteLine("Score: " + Score);


        }

        Console.WriteLine("Final Score is : " + Score);
    }


}
