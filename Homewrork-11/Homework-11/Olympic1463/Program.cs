using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympic1463
{
    /// <summary>
    /// Изначально делал через массив классов, но работать с ним ещё не умею и возникло очень много трудностей и ошибок
    /// Так же не добавлены проверки, ибо зациклить тут всё через цикл while и try catch будет очень объёмно и на данном этапе особо смысла не имеет
    /// </summary>
    class Program
    {
        const int multiplicityForOne = 7;
        const int multiplicityForTwo = 8;
        const int multiplicity = 9;

        public static int AmountOfEnemy;
        static void Main(string[] args)
        {
            Amount();
            int[] hpEnemies = new int[AmountOfEnemy];


            HpEnemy(hpEnemies);
            
            int allHp = AllHp(hpEnemies);
            int minHp = hpEnemies.Min();
            bool chose = YesOrNo(allHp, minHp);
            Write(chose);
        }
        public static void HpEnemy(int [] enemies)
        {
            
            for (int i = 0; i < enemies.Length; i++)
            {
                Console.WriteLine($"Введите количество жизней для {i+1} врага") ;
                enemies[i] = int.Parse(Console.ReadLine());
            }
        }
        public static int AllHp(int[] enemies)
        {
            int allHp = 0;

            for (int i = 0; i < enemies.Length; i++)
            {
                allHp += enemies[i];
            }
            return allHp;
        }
        public static bool YesOrNo(int allHp, int minHp)
        {
            switch (AmountOfEnemy)
            {
                case 1:
                    if (allHp % multiplicityForOne == 0 )
                    {
                        return true;
                    }
                    return false;
                case 2:
                    if (allHp % multiplicityForTwo == 0)
                    {
                        return true;
                    }
                    return false;
                default:
                    float strike = allHp / multiplicity;
                    if (allHp % multiplicity == 0 && strike <= minHp)
                    {
                        return true;
                    }
                    return false;
            }
        }
        public static void Write(bool choose)
        {
            if (choose)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        public static void Amount()
        {
            Console.WriteLine("Введите количество врагов");
            AmountOfEnemy = int.Parse(Console.ReadLine());
        }
    }
}
