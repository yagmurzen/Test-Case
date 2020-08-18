using System;
using System.Drawing;

namespace LocationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example input value : 1 1 N");
            int i = 10; // ??
            while (i <= 10)
            {
                string inputValue = Console.ReadLine();
                string steps = Console.ReadLine();

                string[] array = inputValue.Split(" ");

                if (array.Length == 3)
                {
                    Point p = new Point();
                    p.X = Convert.ToInt32(array[0]);
                    p.Y = Convert.ToInt32(array[1]);
                    string a = array[2];
                    string result = Location(p, a, steps);
                    Console.WriteLine(result);
                }
                else
                    Console.WriteLine("Error");
            }


        }

        static string _defaultAspect = "NESW";
        public static string Location(Point p, string pos, string steps)
        {

            for (int i = 0; i < steps.Length; i++)
            {
                if (steps[i].ToString() == "L")
                {
                    for (int j = 0; j < _defaultAspect.Length; j++)
                    {
                        if (_defaultAspect[j].ToString() == pos)
                        {
                            if (j == 0)
                                pos = _defaultAspect[_defaultAspect.Length - 1].ToString();
                            else pos = _defaultAspect[j - 1].ToString();
                        }
                    }
                }

                if (steps[i].ToString() == "R")
                {
                    for (int j = 0; j < _defaultAspect.Length; j++)
                    {
                        if (_defaultAspect[j].ToString() == pos)
                        {
                            if (j == _defaultAspect.Length - 1)
                                pos = _defaultAspect[0].ToString();
                            else pos = _defaultAspect[j + 1].ToString();
                        }
                    }
                }

                if (steps[i].ToString() == "M")
                {
                    if (pos == "N" || pos == "E")
                    {
                        p.X = p.X + 1;
                        p.Y = p.Y + 1;
                    }
                    else if (pos == "S" || pos == "W")
                    {
                        p.X = p.X - 1;
                        p.Y = p.Y - 1;
                    }
                }

            }

            return p.X.ToString() + "" + p.X.ToString() + pos;
        }
    }
}
