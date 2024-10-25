using System.Runtime.CompilerServices;
using System;

namespace Challenge__1
{
    class MainClass
    {
        static void Main(string[] args)
        {
            GameBoard board = new GameBoard();
        }
    }
    class GameBoard
    {
        char[] randomChars;
        public GameBoard()
        {
            randomChars = new char[0];
            Exercize1();
            Exercize2();
            Exercize3();
            Exercize4();
        }
        
        private void Exercize1() 
        {
            char key;
            Console.WriteLine("Enter a character");
            key = Console.ReadLine()[0];
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
                for (int z = 0; z < 10; z++)
                {
                    Console.Write("[" + key + "]");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write("  " + i);
            }
            Console.WriteLine();
        }
        private void Exercize2()
        {
            char key;
            char key2;
            Console.WriteLine("Enter a character");
            key = Console.ReadLine()[0];
            Console.WriteLine("Enter a 2nd character");
            key2 = Console.ReadLine()[0];
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
                for (int z = 0; z < 10; z++)
                {
                    if ((z + i) % 2 != 0)
                    {
                        Console.Write("[" + key + "]");
                    }
                    else
                    {
                        Console.Write("[" + key2 + "]");
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write("  " + i);
            }
            Console.WriteLine();
        }
        private void Exercize3()
        {
            char key;
            Random random = new Random();
            var chars = " ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=-[];`~,.<>";
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
                for (int z = 0; z < 10; z++)
                {
                    key = chars[random.Next(chars.Length)];
                    Console.Write("[" + key + "]");
                    randomChars = randomChars.Append(key).ToArray();
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write("  " + i);
            }
            Console.WriteLine();
        }
        private void Exercize4()
        {
            char key;
            char key2;
            Console.WriteLine("Enter a character to search");
            key = Console.ReadLine()[0];
            Console.WriteLine("Enter a character to replace the searched character");
            key2 = Console.ReadLine()[0];
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
                for (int z = 0; z < 10; z++)
                {
                    if (randomChars[(i*10) + z] == key)
                    {
                        randomChars[(i * 10) + z] = key2;
                    }
                    Console.Write("[" + randomChars[(i * 10) + z] + "]");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write("  " + i);
            }
            Console.WriteLine();
        }
    }
}
