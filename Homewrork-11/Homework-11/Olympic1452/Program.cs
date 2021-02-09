using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympic1452
{
    class Program
    {
        /// <summary>
        /// Простите за этот код хD
        /// </summary>
        public static int amount;
        static void Main(string[] args)
        {
            AmountWork();

            while (amount != 0)
            {
                Console.WriteLine("\n\n\n");

                int boxes = AmountOfBox();

                int[] balls = new int[boxes];

                AmountOfBall(balls);

                switch (boxes)
                {
                    case 2:
                        TwoBoxes(balls);
                        break;
                    case 3:
                        ThreeBoxes(balls);
                        break;
                    default:
                        MoreBoxes(balls);
                        break;
                }
                amount--;
            }
        }
        public static void AmountWork()
        {
            Console.WriteLine("Количество наборов входных данных");
            amount = int.Parse(Console.ReadLine());
        }
        public static int AmountOfBox()
        {
            Console.WriteLine("Введите количество коробок, не менее 2");
            int boxes = int.Parse(Console.ReadLine());
            return boxes;
        }
        public static void AmountOfBall(int [] balls)
        {
            for (int i = 0; i < balls.Length; i++)
            {
                Console.WriteLine($"Введите количество мячей для {i + 1} коробки");
                balls[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void TwoBoxes(int [] balls)
        {
            if (balls[0] == balls[1])
            {
                Console.WriteLine(0); 
            }
            else if (balls[0] > balls[1])
            {
                Console.WriteLine(balls[0] - balls[1]); 
            }
            else
            {
                Console.WriteLine(balls[1] - balls[0]);
            }
        }
        public static void ThreeBoxes(int [] balls)
        {
            Array.Sort(balls);
            int maxAmount = MaxAmount(balls);
            int minAmount = MinAmount(balls);
            if (balls.Length == maxAmount)
            {
                Console.WriteLine(0);
            }
            else if (balls[0] == balls[1])
            {
                if (balls[2] % 2 == 0 && balls[0] + balls[1] >= balls[2])
                {
                    Console.WriteLine(0);
                }
                else if (balls[2] % 2 == 0 && balls[0] + balls[1] < balls[2])
                {
                    Console.WriteLine(balls[2] - balls[1] - balls[0]);
                }
                else if (balls[2] % 2 != 0 && balls[2] + 1 >= balls[1] + balls[2])
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(balls[2] - balls[1] - balls[0]);
                }
            }
            else if (balls[1] == balls[2])
            {
                if (balls[0] % 2 == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(1);
                }
            }
            else
            {
                if (balls[0] % 2 == 0 )
                {
                    Console.WriteLine(balls[2] - balls[1]);
                }
                else
                {
                    Console.WriteLine(balls[2] - balls[1] + 1);
                }
            }
        }
        public static void MoreBoxes(int [] balls)
        {
            Array.Sort(balls);
            int maxAmount = MaxAmount(balls);
            int minAmount = MinAmount(balls);
            if (balls.Length == maxAmount)
            {
                Console.WriteLine(0);
            }
            else if (maxAmount == balls.Length - 1)
            {
                if (balls[0] % maxAmount == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    int timer = 0;
                    while (balls[0] % maxAmount != 0 || balls[0] == balls[1])
                    {
                        balls[0]++;
                        timer++;
                    }
                    Console.WriteLine(timer);
                }
            }
            else if (minAmount == balls.Length - 1)
            {
                if (balls[balls.Length-1] % minAmount == 0 && balls[0] * minAmount >= balls[balls.Length - 1])
                {
                    Console.WriteLine(0);
                }
                else if (balls[balls.Length - 1] % minAmount == 0 && balls[0] * minAmount < balls[balls.Length - 1])
                {
                    int finish = 0;
                    for (int i = balls.Length - 1; i > 1; i++)
                    {
                        finish += (balls[balls.Length - 1] - balls[i]);
                    }
                    finish += balls[balls.Length - 1] - balls[1] - balls[0];
                    Console.WriteLine(finish);
                }
                else if(balls[balls.Length - 1] % minAmount != 0 && balls[0] * minAmount < balls[balls.Length - 1])
                {
                    int finish = 0;
                    int inc = 0;
                    while (balls[balls.Length - 1] % minAmount != 0)
                    {
                        balls[balls.Length - 1]++;
                        inc++;
                    }
                    if (balls[0] * minAmount >= balls[balls.Length - 1])
                    {
                        Console.WriteLine(inc);
                        return;
                    }
                    for (int i = balls.Length - 1; i > 1; i++)
                    {
                        finish += (balls[balls.Length - 1] - balls[i]);
                    }
                    finish += balls[balls.Length - 1] - balls[1] - balls[0];
                    Console.WriteLine(finish);
                }
                else
                {
                    int timer = 0;
                    while (balls[balls.Length - 1] % minAmount == 0)
                    {
                        balls[balls.Length - 1]++;
                        timer++;
                    }
                    Console.WriteLine(timer);
                }
            }
            else if (maxAmount > 1)
            {
                int finish = 0;
                for (int i = balls[balls.Length - maxAmount - 1]; i > 1; i--)
                {
                    finish += (balls[balls.Length - maxAmount] - balls[i]);
                }
                finish += (balls[balls.Length - maxAmount] - balls[1] - balls[0]);
                Console.WriteLine(finish);
            }
            else
            {
                int finish = 0;
                for (int i = balls.Length -1 ; i > 1; i--)
                {
                    finish += (balls[balls.Length - 1] - balls[i]);
                }
                finish += balls[balls.Length - 1] - balls[1] - balls[0];
                Console.WriteLine(finish);
            }
        }
        public static int MaxAmount(int [] balls)
        {
            int max = balls.Length - 1;
            int amountMax = 0;
            for (int i = 0; i < balls.Length; i++)
            {
                if (balls[i] == max)
                {
                    amountMax++;
                }
            }
            return amountMax;
        }
        public static int MinAmount(int [] balls)
        {
            int min = balls[0];
            int minAmount = 0;
            for (int i = 0; i < balls.Length; i++)
            {
                if (balls[i] == min)
                {
                    minAmount++;
                }
            }
            return minAmount;
        }
    }
}
