using System.Buffers.Binary;

namespace Enigma;

internal class Programm
{
    static int[] pervayaoctavochka = { 32, 34, 39, 40, 41, 43, 46, 49, 55, 58, 61, 63 };
    static int[] vtorayaoctavocha = { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 };
    static int[] tretyaoctavochka = { 130, 138, 146, 155, 165, 174, 185, 196, 207, 220, 233, 246 };
    static int[] chetvertayaoctavochka = { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
    static int[] pyatayaoctavochka = { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
    static void Main(string[] args)
    {
        Console.WriteLine("Вы попали в программу, симулирующую пианино, для продолжения выберите действие: ");
        Console.WriteLine("Клавиши F1/F2/F3/F4/F5 - первая октава, вторая октава, третья октава, четвёртая октава и пятая октава соответственно");
        Console.WriteLine("Клавиши для игры на пианино - Z/S/X/D/C/F/V/G/B/H/N/J");
        Console.WriteLine("Завершить работу программы - F10");
        Console.WriteLine("Удачной игры на пианино! <3");
        int[] octavi = pervayaoctavochka;
        bool b = true;
        while (b == true)
        {
            var key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.F1:
                    {
                        Console.Clear();
                        Console.WriteLine("Вами была выбрана первая октава!");
                        octavi = pervayaoctavochka;
                        continue;
                    }
                case ConsoleKey.F2:
                    {
                        Console.Clear();
                        Console.WriteLine("Вами была выбрана вторая октава!");
                        octavi = vtorayaoctavocha;
                        continue;
                    }
                case ConsoleKey.F3:
                    {
                        Console.Clear();
                        Console.WriteLine("Вами была выбрана третья октава!");
                        octavi = tretyaoctavochka;
                        continue;
                    }
                case ConsoleKey.F4:
                    {
                        Console.Clear();
                        Console.WriteLine("Вами была выбрана четвёртая октава!");
                        octavi = chetvertayaoctavochka;
                        continue;
                    }
                case ConsoleKey.F5:
                    {
                        Console.Clear();
                        Console.WriteLine("Вами была выбрана пятая октава!");
                        octavi = pervayaoctavochka;
                        continue;
                    }
                case ConsoleKey.F10:
                    {
                        b = false;
                        Console.Clear();
                        Console.WriteLine("Работа пианино завершена");
                        break;
                    }
            }
            vivodzvuka();
            void vivodzvuka()
            {
                if (key.Key == ConsoleKey.Z)
                {
                    Console.Beep(octavi[0] + 1000, 400);
                    Console.Clear();

                }
                else if (key.Key == ConsoleKey.S)
                {

                    Console.Beep(octavi[1] + 1000, 400);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.X)
                {
                    Console.Beep(octavi[2] + 1000, 400);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.D)
                {
                    Console.Beep(octavi[3] + 1000, 400);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.C)
                {
                    Console.Beep(octavi[4] + 1000, 400);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.F)
                {
                    Console.Beep(octavi[5] + 1000, 400);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.V)
                {
                    Console.Beep(octavi[6] + 1000, 400);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.G)
                {
                    Console.Beep(octavi[7] + 1000, 400);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.B)
                {
                    Console.Beep(octavi[8] + 1000, 400);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.H)
                {
                    Console.Beep(octavi[9] + 1000, 400);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.N)
                {
                    Console.Beep(octavi[10] + 1000, 400);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.J)
                {
                    Console.Beep(octavi[11] + 1000, 400);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.F10)
                {
                    
                }
                else
                {
                    Console.Clear();
                }
            }

        }
    }
}
