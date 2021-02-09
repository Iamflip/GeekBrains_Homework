using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_4
{
    class Program
    {
        //Код не рабочий, оно неплохо отрисовывает если не попадаетв аут оф рендж, я для себя завтра попробую переделать, но думаю с заданием вывести захардкоженый массив я справился
        static void Main(string[] args)
        {
            int amountFiveShip = 1;
            int amountFourShip = 2;
            int amountThreeShip = 3;
            int amountTwoShip = 4;
            int amountOneShip = 5;
            



            bool[,] map = new bool[10, 10];

            while (amountFiveShip != 0 && amountFourShip != 0 && amountThreeShip != 0 && amountTwoShip != 0 && amountOneShip != 0)
            {
                int size = SizeOfShip(amountFiveShip, amountFourShip, amountThreeShip, amountTwoShip, amountOneShip);
                Console.WriteLine("Напишите координаты постановки корабля, введите кординаты через запятую");
                Console.WriteLine("Первое число это ряд, второе это столбец");
                Console.WriteLine();


                double coordinate = CheckCoordinate();
                int direction = DirectionShip();

                CheckPlaceOfTheMap(coordinate, map, size, direction);
                DeleteShips(ref amountFiveShip, ref amountFourShip, ref amountThreeShip, ref amountTwoShip, ref amountOneShip, size);
            }

            Console.ReadLine();


        }
        static void CreateMap(bool[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == false)
                    {
                        Console.Write("O ");
                    }
                    else
                    {
                        Console.Write("X ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        static double CheckCoordinate()
        {
            double coordinate = 0;
            bool IsOkay = false;
            while (IsOkay == false)
            {
                try
                {
                    coordinate = double.Parse(Console.ReadLine());
                    if (coordinate > 0 && coordinate < 11)
                    {
                        Console.WriteLine("Всё верно");
                        IsOkay = true;
                    }
                    else
                    {
                        Console.WriteLine("Координаты должны распологаться от 1 до 10");
                    }
                }
                catch
                {

                    Console.WriteLine("Введены неверные данные");
                }
            }
            coordinate -= 1.1;
            return coordinate;
        }

        static int DirectionShip()
        {
            bool isOkay = false;
            int direction = 0;
            while (isOkay == false)
            {
                try
                {
                    Console.WriteLine("Выберите в какую сторону будет идти ваш корабль");
                    Console.WriteLine("1. Вверх");
                    Console.WriteLine("2. Вниз");
                    Console.WriteLine("3. Влево");
                    Console.WriteLine("4. Вправо");
                    direction = Convert.ToInt32(Console.ReadLine());
                    if (direction > 0 && direction < 5)
                    {
                        isOkay = true;
                    }
                }
                catch 
                {
                    Console.WriteLine("Введены неверные данные");
                }
            }
            return direction;
        }

        static void CheckPlaceOfTheMap(double firstPosition, bool [,] map, int shipDistance, int direction)
        {
            int rowFirstPosition = (int)firstPosition;
            int columnFirstPosition = ConvertToIntSecondCoordinate(firstPosition);
            double secondPosition = 0;
            bool isOkayShipPlaces = false;
            bool isOkayAbooutShipPlaces = false;

            switch (direction)
            {
                case 1:
                    secondPosition = firstPosition - (shipDistance - 1);
                    isOkayShipPlaces = CheckShipPlases(map, rowFirstPosition, columnFirstPosition, secondPosition, direction, shipDistance);
                    isOkayAbooutShipPlaces = CheckAboutShipPlases(map, firstPosition, secondPosition, direction, shipDistance);
                    if (isOkayShipPlaces && isOkayAbooutShipPlaces)
                    {
                        CreateShips(map, rowFirstPosition, columnFirstPosition, secondPosition, direction, shipDistance);
                        CreateMap(map);
                    }
                    else
                    {
                        Console.WriteLine("Что то пошло не так, попробуйте снова");
                    }
                    break;
                case 2:
                    secondPosition = firstPosition + (shipDistance - 1);
                    isOkayShipPlaces = CheckShipPlases(map, rowFirstPosition, columnFirstPosition, secondPosition, direction, shipDistance);
                    isOkayAbooutShipPlaces = CheckAboutShipPlases(map, firstPosition, secondPosition, direction, shipDistance);
                    if (isOkayShipPlaces && isOkayAbooutShipPlaces)
                    {
                        CreateShips(map, rowFirstPosition, columnFirstPosition, secondPosition, direction, shipDistance);
                        CreateMap(map);
                    }
                    else
                    {
                        Console.WriteLine("Что то пошло не так, попробуйте снова");
                    }
                    break;
                case 3:
                    secondPosition = firstPosition - (shipDistance / 10 - 0.1);
                    isOkayShipPlaces = CheckShipPlases(map, rowFirstPosition, columnFirstPosition, secondPosition, direction, shipDistance);
                    isOkayAbooutShipPlaces = CheckAboutShipPlases(map, firstPosition, secondPosition, direction, shipDistance);
                    if (isOkayShipPlaces && isOkayAbooutShipPlaces)
                    {
                        CreateShips(map, rowFirstPosition, columnFirstPosition, secondPosition, direction, shipDistance);
                        CreateMap(map);
                    }
                    else
                    {
                        Console.WriteLine("Что то пошло не так, попробуйте снова");
                    }
                    break;
                default:
                    secondPosition = firstPosition + (shipDistance / 10 + 0.1);
                    isOkayShipPlaces = CheckShipPlases(map, rowFirstPosition, columnFirstPosition, secondPosition, direction, shipDistance);
                    isOkayAbooutShipPlaces = CheckAboutShipPlases(map, firstPosition, secondPosition, direction, shipDistance);
                    if (isOkayShipPlaces && isOkayAbooutShipPlaces)
                    {
                        CreateShips(map, rowFirstPosition, columnFirstPosition, secondPosition, direction, shipDistance);
                        CreateMap(map);
                    }
                    else
                    {
                        Console.WriteLine("Что то пошло не так, попробуйте снова");
                    }
                    break;
            }
        }
        static bool CheckShipPlases(bool [,] map, int rowFirstPosition, int columnFirstPosition, double secondPosition, int direction, int shipDistance)
        {
            int rowSecondPosition = (int)secondPosition;
            int columnSecondPosition = ConvertToIntSecondCoordinate(secondPosition);

            switch (direction)
            {
                case 1:
                    for (int i = shipDistance; i > 0; i--)
                    {
                        if (map[rowFirstPosition, columnFirstPosition] == false && rowFirstPosition >= 0 && rowFirstPosition - shipDistance >= 0)
                        {
                            rowFirstPosition -= 1;
                        }
                        else
                        {
                            Console.WriteLine("Расположить корабль невозможно");
                            return false;
                        }
                    }
                    return true;
                case 2:
                    for (int i = shipDistance; i > 0; i--)
                    {
                        if (map[rowFirstPosition, columnFirstPosition] == false && rowFirstPosition <= 9 && rowFirstPosition + shipDistance < 10)
                        {
                            rowFirstPosition += 1;
                        }
                        else
                        {
                            Console.WriteLine("Расположить корабль невозможно");
                            return false;
                        }
                    }
                    return true;
                case 3:
                    for (int i = shipDistance; i > 0; i--)
                    {
                        if (map[rowFirstPosition, columnFirstPosition] == false && columnFirstPosition >= 0 && columnFirstPosition - shipDistance >= 0)
                        {
                            columnFirstPosition -= 1;
                        }
                        else
                        {
                            Console.WriteLine("Расположить корабль невозможно");
                            return false;
                        }
                    }
                    return true;
                default:
                    for (int i = shipDistance; i > 0; i--)
                    {
                        if (map[rowFirstPosition, columnFirstPosition] == false && columnFirstPosition <= 9 && columnFirstPosition + shipDistance < 10)
                        {
                            columnFirstPosition += 1;
                        }
                        else
                        {
                            Console.WriteLine("Расположить корабль невозможно");
                            return false;
                        }
                    }
                    return true;
            }

        }
        static bool CheckAboutShipPlases(bool[,] map, double firstPosition, double secondPosition, int direction, int shipDistance)
        {
            double firstCheckPosition;
            int rowFirstCheckPosition;
            int columnFirstCheckPosition;

            double secondCheckPosition;
            int rowSecondCheckPosition;
            int columnSecondCheckPosition;

            double thirdCheckPosition;
            int rowThirdCheckPosition;
            int columnThirdCheckPosition;

            double fourthCheckPosition;
            int rowFourthCehckPosition;
            int columnFourthCheckPosition;

            int firstDistanceAboutPosition;
            int secondDistanceAboutPositions;

            int rowSecondPosition = (int)secondPosition;
            int columnSecondPosition = ConvertToIntSecondCoordinate(secondPosition);

            switch (direction)
            {
                case 1:
                    firstCheckPosition = firstPosition + 0.9;
                    rowFirstCheckPosition = (int)firstCheckPosition;
                    columnFirstCheckPosition = ConvertToIntSecondCoordinate(firstCheckPosition);

                    secondCheckPosition = firstPosition + 1.1;
                    rowSecondCheckPosition = (int)firstCheckPosition;
                    columnSecondCheckPosition = ConvertToIntSecondCoordinate(secondCheckPosition);

                    thirdCheckPosition = secondPosition - 1.1;
                    rowThirdCheckPosition = (int)secondCheckPosition;
                    columnThirdCheckPosition = ConvertToIntSecondCoordinate(thirdCheckPosition);


                    fourthCheckPosition = secondPosition - 0.9;
                    rowFourthCehckPosition = (int)secondCheckPosition;
                    columnFourthCheckPosition = ConvertToIntSecondCoordinate(fourthCheckPosition);

                    firstDistanceAboutPosition = Convert.ToInt32((firstCheckPosition - thirdCheckPosition) * 10);
                    if (firstDistanceAboutPosition < 0)
                    {
                        firstDistanceAboutPosition *= -1;
                    }

                    secondDistanceAboutPositions = Convert.ToInt32(((firstCheckPosition - secondCheckPosition) * 10));
                    if (secondDistanceAboutPositions < 0)
                    {
                        secondDistanceAboutPositions *= -1;
                    }

                    for (int i = rowFirstCheckPosition; firstDistanceAboutPosition > 0; firstDistanceAboutPosition--)
                    {
                        for (int j = columnFirstCheckPosition; secondDistanceAboutPositions > 0; secondDistanceAboutPositions--)
                        {
                            if (map[rowFirstCheckPosition, columnFirstCheckPosition] == true)
                            {
                                Console.WriteLine("Невозможно расположить корабль");
                                return false;
                            }
                        }
                        i++;
                    }
                    return true;
                case 2:
                    firstCheckPosition = firstPosition + 0.9;
                    rowFirstCheckPosition = (int)firstCheckPosition;
                    columnFirstCheckPosition = ConvertToIntSecondCoordinate(firstCheckPosition);

                    secondCheckPosition = firstPosition + 1.1;
                    rowSecondCheckPosition = (int)firstCheckPosition;
                    columnSecondCheckPosition = ConvertToIntSecondCoordinate(secondCheckPosition);

                    thirdCheckPosition = secondPosition - 1.1;
                    rowThirdCheckPosition = (int)secondCheckPosition;
                    columnThirdCheckPosition = ConvertToIntSecondCoordinate(thirdCheckPosition);


                    fourthCheckPosition = secondPosition - 0.9;
                    rowFourthCehckPosition = (int)secondCheckPosition;
                    columnFourthCheckPosition = ConvertToIntSecondCoordinate(fourthCheckPosition);

                    firstDistanceAboutPosition = Convert.ToInt32((firstCheckPosition - thirdCheckPosition) * 10);
                    if (firstDistanceAboutPosition < 0)
                    {
                       firstDistanceAboutPosition *= -1;
                    }

                    secondDistanceAboutPositions = Convert.ToInt32(((firstCheckPosition - secondCheckPosition) * 10));
                    if (secondDistanceAboutPositions < 0)
                    {
                        secondDistanceAboutPositions *= -1;
                    }

                    for (int i = rowThirdCheckPosition; firstDistanceAboutPosition > 0; firstDistanceAboutPosition--)
                    {
                        for (int j = columnThirdCheckPosition; secondDistanceAboutPositions > 0; secondDistanceAboutPositions--)
                        {
                            if (map[rowFirstCheckPosition, columnFirstCheckPosition] == true)
                            {
                                Console.WriteLine("Невозможно расположить корабль");
                                return false;
                            }
                        }
                        i++;
                    }
                    return true;
                case 3:
                    firstCheckPosition = firstPosition - 0.9;
                    rowFirstCheckPosition = (int)firstCheckPosition;
                    columnFirstCheckPosition = ConvertToIntSecondCoordinate(firstCheckPosition);

                    secondCheckPosition = firstPosition + 1.1;
                    rowSecondCheckPosition = (int)firstCheckPosition;
                    columnSecondCheckPosition = ConvertToIntSecondCoordinate(secondCheckPosition);

                    thirdCheckPosition = secondPosition - 1.1;
                    rowThirdCheckPosition = (int)secondCheckPosition;
                    columnThirdCheckPosition = ConvertToIntSecondCoordinate(thirdCheckPosition);


                    fourthCheckPosition = secondPosition + 0.9;
                    rowFourthCehckPosition = (int)secondCheckPosition;
                    columnFourthCheckPosition = ConvertToIntSecondCoordinate(fourthCheckPosition);

                    firstDistanceAboutPosition = Convert.ToInt32((thirdCheckPosition - secondCheckPosition) * 10);
                    if (firstDistanceAboutPosition < 0)
                    {
                        firstDistanceAboutPosition *= -1;
                    }

                    secondDistanceAboutPositions = Convert.ToInt32(((secondCheckPosition - firstCheckPosition) * 10));
                    if (secondDistanceAboutPositions < 0)
                    {
                        secondDistanceAboutPositions *= -1;
                    }

                    for (int i = rowThirdCheckPosition; firstDistanceAboutPosition > 0; firstDistanceAboutPosition--)
                    {
                        for (int j = columnThirdCheckPosition; secondDistanceAboutPositions > 0; secondDistanceAboutPositions--)
                        {
                            if (map[rowFirstCheckPosition, columnFirstCheckPosition] == true)
                            {
                                Console.WriteLine("Невозможно расположить корабль");
                                return false;
                            }
                        }
                    }
                    return true;
                default:
                    firstCheckPosition = firstPosition - 0.9;
                    rowFirstCheckPosition = (int)firstCheckPosition;
                    columnFirstCheckPosition = ConvertToIntSecondCoordinate(firstCheckPosition);

                    secondCheckPosition = firstPosition + 1.1;
                    rowSecondCheckPosition = (int)firstCheckPosition;
                    columnSecondCheckPosition = ConvertToIntSecondCoordinate(secondCheckPosition);

                    thirdCheckPosition = secondPosition - 1.1;
                    rowThirdCheckPosition = (int)secondCheckPosition;
                    columnThirdCheckPosition = ConvertToIntSecondCoordinate(thirdCheckPosition);


                    fourthCheckPosition = secondPosition + 0.9;
                    rowFourthCehckPosition = (int)secondCheckPosition;
                    columnFourthCheckPosition = ConvertToIntSecondCoordinate(fourthCheckPosition);

                    firstDistanceAboutPosition = Convert.ToInt32((thirdCheckPosition - secondCheckPosition) * 10);
                    if (firstDistanceAboutPosition < 0)
                    {
                        firstDistanceAboutPosition *= -1;
                    }

                    secondDistanceAboutPositions = Convert.ToInt32(((secondCheckPosition - firstCheckPosition) * 10));
                    if (secondDistanceAboutPositions < 0)
                    {
                        secondDistanceAboutPositions *= -1;
                    }

                    for (int i = rowThirdCheckPosition; firstDistanceAboutPosition > 0; firstDistanceAboutPosition--)
                    {
                        for (int j = columnThirdCheckPosition; secondDistanceAboutPositions > 0; secondDistanceAboutPositions--)
                        {
                            if (map[rowFirstCheckPosition, columnFirstCheckPosition] == true)
                            {
                                Console.WriteLine("Невозможно расположить корабль");
                                return false;
                            }
                        }
                    }
                    return true; ;
            }
        }

        static void CreateShips(bool[,] map, int rowFirstPosition, int columnFirstPosition, double secondPosition, int direction, int shipDistance)
        {
            int rowSecondPosition = (int)secondPosition;
            int columnSecondPosition = ConvertToIntSecondCoordinate(secondPosition);

            switch (direction)
            {
                case 1:
                    for (int i = shipDistance; i > 0; i--)
                    {
                        map[rowFirstPosition, columnFirstPosition] = true;
                        rowFirstPosition -= 1;
                    }
                    break;
                case 2:
                    for (int i = shipDistance; i > 0; i--)
                    {
                        map[rowFirstPosition, columnFirstPosition] = true;
                        rowFirstPosition += 1;
                    }
                    break;
                case 3:
                    for (int i = shipDistance; i > 0; i--)
                    {
                        map[rowFirstPosition, columnFirstPosition] = true;
                        columnFirstPosition -= 1;
                    }
                    break;
                default:
                    for (int i = shipDistance; i > 0; i--)
                    {
                        map[rowFirstPosition, columnFirstPosition] = true;
                        columnFirstPosition += 1;
                    }
                    break;
            }

        }
        static int ConvertToIntSecondCoordinate(double position)
        {
            int intPosition = Convert.ToInt32((position - (int)position) * 10);
            return intPosition;
        }
        static int SizeOfShip(int ship5, int ship4, int ship3, int ship2, int ship1)
        {
            bool isOkay = false;
            int size = 0;
            while (isOkay == false)
            {
                try
                {
                    Console.WriteLine($"Осталось {ship5} 5-ти палубных кораблей {ship4} 4-ех палубных кораблей {ship3}" +
                    $" 3-ех палубных кораблей {ship2} 2-ух палубных кораблей {ship1} палубных кораблей");
                    Console.WriteLine();
                    Console.WriteLine("Выберите размер корабля от 1 до 5");
                    size = Convert.ToInt32(Console.ReadLine());
                    switch (size)
                    {
                        case 1:
                            if (ship1 != 0)
                            {
                                isOkay = true;
                                size = 1;
                            }
                            else
                            {
                                Console.WriteLine("Таких кораблей не осталось");
                            }
                            break;
                        case 2:
                            if (ship2 != 0)
                            {
                                isOkay = true;
                                size = 2;
                            }
                            else
                            {
                                Console.WriteLine("Таких кораблей не осталось");
                            }
                            break;
                        case 3:
                            if (ship3 != 0)
                            {
                                isOkay = true;
                                size = 3;
                            }
                            else
                            {
                                Console.WriteLine("Таких кораблей не осталось");
                            }
                            break;
                        case 4:
                            if (ship4 != 0)
                            {
                                isOkay = true;
                                size = 4;
                            }
                            else
                            {
                                Console.WriteLine("Таких кораблей не осталось");
                            }
                            break;
                        default:
                            if (ship5 != 0)
                            {
                                isOkay = true;
                                size = 5;
                            }
                            else
                            {
                                Console.WriteLine("Таких кораблей не осталось");
                            }
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Введены неверные данные");
                }
            }
            return size;
        }
        static void DeleteShips(ref int ship5, ref int ship4, ref int ship3, ref int ship2, ref int ship1, int size)
        {
            switch (size)
            {
                case 1:
                    ship1 -= 1;
                    break;
                case 2:
                    ship2 -= 1;
                    break;
                case 3:
                    ship3 -= 1;
                    break;
                case 4:
                    ship4 -= 1;
                    break;
                default:
                    ship5 -= 1;
                    break;
            }
        }
    }
}
