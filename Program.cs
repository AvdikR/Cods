using System;


namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            Num = 1;
            int[] mas = { 10, 11, 20, 56, 16, 44, 7, 18 };
            for(int i=0; i<mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }
            
            Console.WriteLine();
            Console.WriteLine(Num);
            
            for(int i=0; i<mas.Length; i++)
            {
                if (mas[i] >= 20)
                {
                    Console.WriteLine(mas[i]);
                }
            }
            Console.WriteLine();

            Color red = new Color();
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            red.ChooseColor(n);

            byte selection;
            do
            {
                Console.WriteLine("  ------------------------------------");
                Console.WriteLine("  1. Task 1");
                Console.WriteLine("  2. Task 2");
                Console.WriteLine("  0. Exit  ");
                Console.WriteLine("  ------------------------------------");
                Console.WriteLine("  Enter your selection: ");
                selection = Convert.ToByte(Console.ReadLine());
                switch (selection)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                 
                }
            } while (selection != 0);






        }
    }
    class Color
    {
        string color1 = "Red";
        string color2 = "Blue";
        string color3 = "Green";
        
        public void ChooseColor(int N)
        {
            string CurrentColor = "";
            if (N == 0)
            {
                CurrentColor = color1;
            }
            if (N == 1)
            {
                CurrentColor = color2;
            }
            if (N == 2)
            {
                CurrentColor = color3;
            }
            Console.WriteLine(CurrentColor);

        }
    }

    
}



