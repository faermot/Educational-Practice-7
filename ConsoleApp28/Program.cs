using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Выберите задание (1-15): ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Задание №1");

                        Console.WriteLine("Решено в примере");

                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Задание №2");
                        Task2();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Задание №3");
                        Task3();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Задание №4");
                        Task4();
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Задание №5");
                        Task5();
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Задание №6");
                        Task6();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.Clear();
                        Console.WriteLine("Задание №7");
                        Task7();
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.Clear();
                        Console.WriteLine("Задание №8");
                        Task8();
                        Console.ReadKey();
                        break;
                    case "9":
                        Console.Clear();
                        Console.WriteLine("Задание №9");
                        Task9();
                        Console.ReadKey();
                        break;
                    case "10":
                        Console.Clear();
                        Console.WriteLine("Задание №10");
                        Task10();
                        Console.ReadKey();
                        break;
                    case "11":
                        Console.Clear();
                        Console.WriteLine("Задание №11");
                        Task11();
                        Console.ReadKey();
                        break;
                    case "12":
                        Console.Clear();
                        Console.WriteLine("Задание №12");
                        Task12();
                        Console.ReadKey();
                        break;
                    case "13":
                        Console.Clear();
                        Console.WriteLine("Задание №13");
                        Task13();
                        Console.ReadKey();
                        break;
                    case "14":
                        Console.Clear();
                        Console.WriteLine("Задание №14");
                        Task14();
                        Console.ReadKey();
                        break;
                    case "15":
                        Console.Clear();
                        Console.WriteLine("Задание №15");
                        Task15();
                        Console.ReadKey();
                        break;
                    case "16":
                        Console.Clear();
                        Console.WriteLine("Задание №16");
                        Task16();
                        Console.ReadKey();
                        break;
                    case "17":
                        Console.Clear();
                        Console.WriteLine("Задание №17");
                        Task17();
                        Console.ReadKey();
                        break;
                    case "18":
                        Console.Clear();
                        Console.WriteLine("Задание №18");
                        Task18();
                        Console.ReadKey();
                        break;
                    case "19":
                        Console.Clear();
                        Console.WriteLine("Задание №19");
                        Task19();
                        Console.ReadKey();
                        break;
                    case "20":
                        Console.Clear();
                        Console.WriteLine("Задание №20");
                        Task20();
                        Console.ReadKey();
                        break;
                    case "21":
                        Console.Clear();
                        Console.WriteLine("Задание №21");
                        Task21();
                        Console.ReadKey();
                        break;
                    case "22":
                        Console.Clear();
                        Console.WriteLine("Задание №22");
                        Task22();
                        Console.ReadKey();
                        break;
                    case "23":
                        Console.Clear();
                        Console.WriteLine("Задание №23");
                        Task23();
                        Console.ReadKey();
                        break;
                    case "24":
                        Console.Clear();
                        Console.WriteLine("Задание №24");
                        Task24();
                        Console.ReadKey();
                        break;
                    case "25":
                        Console.Clear();
                        Console.WriteLine("Задание №25");
                        Task25();
                        Console.ReadKey();
                        break;
                    case "26":
                        Console.Clear();
                        Console.WriteLine("Задание №26");
                        Task26();
                        Console.ReadKey();
                        break;
                    case "27":
                        Console.Clear();
                        Console.WriteLine("Задание №27");
                        Task27();
                        Console.ReadKey();
                        break;
                    case "28":
                        Console.Clear();
                        Console.WriteLine("Задание №28");
                        Task28();
                        Console.ReadKey();
                        break;
                    case "29":
                        Console.Clear();
                        Console.WriteLine("Задание №29");
                        Task29();
                        Console.ReadKey();
                        break;
                    case "30":
                        Console.Clear();
                        Console.WriteLine("Задание №30");
                        Task30();
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Выберите корректное задание!");
                        Thread.Sleep(3000);
                        break;
                }
            }
        }

        static void Task2()
        {
            int workExperience;
            double currentSalary, newSalary = 0, increment = 0;
            Console.Write("Введите текущую з/п: ");

            while (!double.TryParse(Console.ReadLine(), out currentSalary))
            {
                Console.WriteLine("Введите корректную з/п!");
                Thread.Sleep(1000);
                Console.Write("Введите текущую з/п: ");
            }


            Console.Write("Введите трудовой стаж (в годах): ");
            while (!int.TryParse(Console.ReadLine(), out workExperience))
            {
                Console.WriteLine("Введите корректный трудовой стаж!");
                Thread.Sleep(1000);
                Console.Write("Введите трудовой стаж (в годах): ");
            }

            if (workExperience > 2 & workExperience < 5)
            {
                increment = currentSalary * 0.02;
                newSalary = currentSalary + increment;
            }
            else if (workExperience > 5)
            {
                increment = currentSalary * 0.05;
                newSalary = currentSalary + increment;
            }

            Console.WriteLine("-------------");
            Console.WriteLine($"Надбавка составляет: {increment}");
            Console.WriteLine($"Итоговая з/п: {newSalary}");
        }

        static void Task3()
        {
            Console.Write("Введите координаты точки A (x0, y0): ");
            string[] aCoords = Console.ReadLine().Split(); // мне за эту разработку такую премию дадут...
            int x0 = int.Parse(aCoords[0]);
            int y0 = int.Parse(aCoords[1]);

            Console.Write("Введите координаты точки B (x1, y1): ");
            string[] bCoords = Console.ReadLine().Split();
            int x1 = int.Parse(bCoords[0]);
            int y1 = int.Parse(bCoords[1]);

            double distanceA = Math.Sqrt(x0 * x0 + y0 * y0);
            double distanceB = Math.Sqrt(x1 * x1 + y1 * y1);

            if (distanceA > distanceB)
                Console.WriteLine("Точка A дальше от начала координат.");
            else if (distanceA < distanceB)
                Console.WriteLine("Точка B дальше от начала координат.");
            else
                Console.WriteLine("Обе точки находятся на одинаковом расстоянии от начала координат.");
        }

        static void Task4()
        {
            Console.Write("Введите стороны треугольника a, b, c: ");
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                Console.WriteLine("Треугольник является прямоугольным.");
            else
                Console.WriteLine("Треугольник не является прямоугольным.");
        }

        static void Task5()
        {
            Console.Write("Введите три числа: ");
            string[] numbers = Console.ReadLine().Split();
            int[] array = new int[3];

            for (int i = 0; i < 3; i++)
            {
                array[i] = int.Parse(numbers[i]);
                if (array[i] > 0)
                    array[i] *= array[i];
            }

            Console.WriteLine($"Результат: {string.Join(" ", array)}");
        }

        static void Task6()
        {
            Console.Write("Введите координаты точки A (x, y): ");
            string[] coords = Console.ReadLine().Split();
            int x = int.Parse(coords[0]);
            int y = int.Parse(coords[1]);

            if (x > 0 && y > 0) Console.WriteLine("Точка находится в первой четверти.");
            else if (x < 0 && y > 0) Console.WriteLine("Точка находится во второй четверти.");
            else if (x < 0 && y < 0) Console.WriteLine("Точка находится в третьей четверти.");
            else if (x > 0 && y < 0) Console.WriteLine("Точка находится в четвертой четверти.");
            else Console.WriteLine("Точка лежит на одной из осей или в начале координат.");
        }


        static void Task7()
        {
            Console.Write("Введите координаты точки A (x, y): ");
            string[] coords = Console.ReadLine().Split();
            int x = int.Parse(coords[0]);
            int y = int.Parse(coords[1]);

            Console.Write("Введите радиус окружности R: ");
            int R = int.Parse(Console.ReadLine());

            double distance = Math.Sqrt(x * x + y * y);

            if (distance < R)
                Console.WriteLine("Точка лежит внутри окружности.");
            else if (distance == R)
                Console.WriteLine("Точка лежит на окружности.");
            else
                Console.WriteLine("Точка лежит вне окружности.");
        }

        static void Task8()
        {
            Console.Write("Введите стороны первого треугольника a1, b1, c1: ");
            string[] triangle1 = Console.ReadLine().Split();
            int a1 = int.Parse(triangle1[0]);
            int b1 = int.Parse(triangle1[1]);
            int c1 = int.Parse(triangle1[2]);

            Console.Write("Введите стороны второго треугольника a2, b2, c2: ");
            string[] triangle2 = Console.ReadLine().Split();
            int a2 = int.Parse(triangle2[0]);
            int b2 = int.Parse(triangle2[1]);
            int c2 = int.Parse(triangle2[2]);

            double p1 = (a1 + b1 + c1) / 2.0;
            double area1 = Math.Sqrt(p1 * (p1 - a1) * (p1 - b1) * (p1 - c1));

            double p2 = (a2 + b2 + c2) / 2.0;
            double area2 = Math.Sqrt(p2 * (p2 - a2) * (p2 - b2) * (p2 - c2));

            if (area1 > area2)
                Console.WriteLine("Площадь первого треугольника больше.");
            else if (area1 < area2)
                Console.WriteLine("Площадь второго треугольника больше.");
            else
                Console.WriteLine("Площади треугольников равны.");
        }

        static void Task9()
        {
            Console.Write("Введите сторону квадрата a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите радиус окружности R: ");
            int R = int.Parse(Console.ReadLine());

            double squareArea = a * a;
            double circleArea = Math.PI * R * R;

            if (squareArea > circleArea)
                Console.WriteLine("Площадь квадрата больше.");
            else if (squareArea < circleArea)
                Console.WriteLine("Площадь окружности больше.");
            else
                Console.WriteLine("Площади равны.");
        }

        static void Task10()
        {
            Console.Write("Введите три числа: ");
            string[] numbers = Console.ReadLine().Split();
            int[] array = new int[3];

            for (int i = 0; i < 3; i++)
            {
                array[i] = int.Parse(numbers[i]);
                if (array[i] > 0)
                    array[i] = array[i] * array[i] * array[i];
                else
                    array[i] = 0;
            }

            Console.WriteLine($"Результат: {string.Join(" ", array)}");
        }

        static void Task11()
        {
            Console.Write("Введите натуральное число: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0 || number % 10 == 3)
                Console.WriteLine("Число является четным или оканчивается на 3.");
            else
                Console.WriteLine("Число не является четным и не оканчивается на 3.");
        }

        static void Task12()
        {
            Console.Write("Введите координаты точки A (x, y): ");
            string[] coords = Console.ReadLine().Split();
            int x = int.Parse(coords[0]);
            int y = int.Parse(coords[1]);

            if (x > 0 && y > 0)
                Console.WriteLine("Точка лежит в первой четверти.");
            else
                Console.WriteLine("Точка не лежит в первой четверти.");
        }

        static void Task13()
        {
            Console.Write("Введите сумму вклада: ");
            double deposit = double.Parse(Console.ReadLine());

            Console.Write("Введите срок договора (6 или 12 месяцев): ");
            int term = int.Parse(Console.ReadLine());

            double rate = term == 6 ? 0.06 : 0.08;
            double monthlyInterest = deposit * rate / 12;

            Console.WriteLine($"Сумма ежемесячных выплат процентов: {monthlyInterest}");
        }

        static void Task14()
        {
            Console.Write("Введите два числа: ");
            string[] numbers = Console.ReadLine().Split();
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);

            double diffSquares = a * a - b * b;
            double squareDiff = Math.Pow(a - b, 2);

            if (diffSquares > squareDiff)
                Console.WriteLine("Разность квадратов больше.");
            else if (diffSquares < squareDiff)
                Console.WriteLine("Модуль квадрата разности больше.");
            else
                Console.WriteLine("Значения равны.");
        }

        static void Task15()
        {
            Console.Write("Введите координаты точки A (x0, y0): ");
            string[] aCoords = Console.ReadLine().Split();
            int x0 = int.Parse(aCoords[0]);
            int y0 = int.Parse(aCoords[1]);

            Console.Write("Введите координаты точки B (x1, y1): ");
            string[] bCoords = Console.ReadLine().Split();
            int x1 = int.Parse(bCoords[0]);
            int y1 = int.Parse(bCoords[1]);

            double distanceA = Math.Sqrt(x0 * x0 + y0 * y0);
            double distanceB = Math.Sqrt(x1 * x1 + y1 * y1);

            if (distanceA < distanceB)
                Console.WriteLine("Точка A ближе к началу координат.");
            else if (distanceA > distanceB)
                Console.WriteLine("Точка B ближе к началу координат.");
            else
                Console.WriteLine("Обе точки находятся на одинаковом расстоянии от начала координат.");
        }

        static void Task16()
        {
            Console.Write("Введите координаты точки A (x, y): ");
            string[] coords = Console.ReadLine().Split();
            double x = double.Parse(coords[0]);
            double y = double.Parse(coords[1]);

            Console.Write("Введите радиусы окружностей r и R (r < R): ");
            string[] radii = Console.ReadLine().Split();
            double r = double.Parse(radii[0]);
            double R = double.Parse(radii[1]);

            double distance = Math.Sqrt(x * x + y * y);

            if (distance > r && distance < R)
                Console.WriteLine("Точка лежит внутри тора.");
            else
                Console.WriteLine("Точка не лежит внутри тора.");
        }

        static void Task17()
        {
            Console.Write("Введите координаты точки A (x, y): ");
            string[] coords = Console.ReadLine().Split();
            int x = int.Parse(coords[0]);
            int y = int.Parse(coords[1]);

            if (x > 0 && y < 0)
                Console.WriteLine("Точка лежит в четвертой четверти.");
            else
                Console.WriteLine("Точка не лежит в четвертой четверти.");
        }

        static void Task18()
        {
            Console.Write("Введите стороны треугольника a, b, c: ");
            string[] sides = Console.ReadLine().Split();
            int a = int.Parse(sides[0]);
            int b = int.Parse(sides[1]);
            int c = int.Parse(sides[2]);

            if (a == b || b == c || a == c)
                Console.WriteLine("Треугольник является равнобедренным.");
            else
                Console.WriteLine("Треугольник не является равнобедренным.");
        }

        static void Task19()
        {
            Console.Write("Введите три целых числа a, b, c: ");
            string[] numbers = Console.ReadLine().Split();
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);
            int c = int.Parse(numbers[2]);

            if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                Console.WriteLine("Числа являются тройкой Пифагора.");
            else
                Console.WriteLine("Числа не являются тройкой Пифагора.");
        }

        static void Task20()
        {
            Console.Write("Введите объемную скорость 1 (л/с): ");
            double speed1 = double.Parse(Console.ReadLine());

            Console.Write("Введите объемную скорость 2 (м^3/мин): ");
            double speed2 = double.Parse(Console.ReadLine());

            speed2 *= 1000 / 60;

            if (speed1 > speed2)
                Console.WriteLine("Первая скорость больше.");
            else if (speed1 < speed2)
                Console.WriteLine("Вторая скорость больше.");
            else
                Console.WriteLine("Скорости равны.");
        }

        static void Task21()
        {
            Console.Write("Введите площадь круга: ");
            double circleArea = double.Parse(Console.ReadLine());

            Console.Write("Введите площадь квадрата: ");
            double squareArea = double.Parse(Console.ReadLine());

            double circleRadius = Math.Sqrt(circleArea / Math.PI);
            double squareSide = Math.Sqrt(squareArea);

            if (circleRadius * 2 <= squareSide)
                Console.WriteLine("Круг уместится в квадрате.");
            else
                Console.WriteLine("Круг не уместится в квадрате.");

            if (squareSide * Math.Sqrt(2) <= circleRadius * 2)
                Console.WriteLine("Квадрат уместится в круге.");
            else
                Console.WriteLine("Квадрат не уместится в круге.");
        }

        static void Task22()
        {
            Console.Write("Введите массу и объем первого тела: ");
            string[] body1 = Console.ReadLine().Split();
            double mass1 = double.Parse(body1[0]);
            double volume1 = double.Parse(body1[1]);

            Console.Write("Введите массу и объем второго тела: ");
            string[] body2 = Console.ReadLine().Split();
            double mass2 = double.Parse(body2[0]);
            double volume2 = double.Parse(body2[1]);

            double density1 = mass1 / volume1;
            double density2 = mass2 / volume2;

            if (density1 > density2)
                Console.WriteLine("Плотность первого тела больше.");
            else if (density1 < density2)
                Console.WriteLine("Плотность второго тела больше.");
            else
                Console.WriteLine("Плотности тел равны.");
        }

        static void Task23()
        {
            Console.Write("Введите скорость в км/ч: ");
            double speedKmh = double.Parse(Console.ReadLine());

            Console.Write("Введите скорость в м/с: ");
            double speedMs = double.Parse(Console.ReadLine());

            speedKmh /= 3.6;

            if (speedKmh > speedMs)
                Console.WriteLine("Первая скорость больше.");
            else if (speedKmh < speedMs)
                Console.WriteLine("Вторая скорость больше.");
            else
                Console.WriteLine("Скорости равны.");
        }

        static void Task24()
        {
            Console.Write("Введите сторону равностороннего треугольника: ");
            double a = double.Parse(Console.ReadLine());

            double triangleArea = a * a * Math.Sqrt(3) / 4;
            double circleRadius1 = a * Math.Sqrt(3) / 6;
            double circleRadius2 = a * Math.Sqrt(3) / 3;

            double circleArea1 = Math.PI * circleRadius1 * circleRadius1;
            double circleArea2 = Math.PI * circleRadius2 * circleRadius2;

            if (circleArea1 <= triangleArea)
                Console.WriteLine("Круг уместится в треугольнике.");
            else
                Console.WriteLine("Круг не уместится в треугольнике.");

            if (triangleArea <= circleArea2)
                Console.WriteLine("Треугольник уместится в круге.");
            else
                Console.WriteLine("Треугольник не уместится в круге.");
        }

        static void Task25()
        {
            Console.Write("Введите сопротивление и напряжение для первого участка: ");
            string[] circuit1 = Console.ReadLine().Split();
            double resistance1 = double.Parse(circuit1[0]);
            double voltage1 = double.Parse(circuit1[1]);

            Console.Write("Введите сопротивление и напряжение для второго участка: ");
            string[] circuit2 = Console.ReadLine().Split();
            double resistance2 = double.Parse(circuit2[0]);
            double voltage2 = double.Parse(circuit2[1]);

            double current1 = voltage1 / resistance1;
            double current2 = voltage2 / resistance2;

            if (current1 < current2)
                Console.WriteLine("Ток на первом участке меньше.");
            else if (current1 > current2)
                Console.WriteLine("Ток на втором участке меньше.");
            else
                Console.WriteLine("Токи на участках равны.");
        }

        static void Task26()
        {
            // здесь я задумался, а может все таки стоило на повара идти? 
            double G = 6.7e-8;
            double mv = 4.86e27;
            double rv = 6175e5;
            double ms = 5.68e29;
            double rs = 57750e5;

            double gv = G * mv / (rv * rv);
            double gs = G * ms / (rs * rs);

            if (gv > gs)
                Console.WriteLine("Ускорение силы тяжести на Венере больше.");
            else if (gv < gs)
                Console.WriteLine("Ускорение силы тяжести на Сатурне больше.");
            else
                Console.WriteLine("Ускорения силы тяжести равны.");
        }

        static void Task27()
        {
            Console.Write("Введите текущее время (0-24): ");
            int time = int.Parse(Console.ReadLine());

            if (time >= 0 && time < 12)
                Console.WriteLine("Время суток: am.");
            else if (time >= 12 && time <= 24)
                Console.WriteLine("Время суток: pm.");
            else
                Console.WriteLine("Некорректное время.");
        }

        static void Task28()
        {
            Console.Write("Введите географическую долготу: ");
            double longitude = double.Parse(Console.ReadLine());

            if (longitude >= 0)
                Console.WriteLine("Место находится в восточном полушарии.");
            else
                Console.WriteLine("Место находится в западном полушарии.");
        }

        static void Task29()
        {
            double siriusDistance = 8.14e12;
            double arcturusDistance = 103 * 3.259 * 9.461e12;

            if (siriusDistance > arcturusDistance)
                Console.WriteLine("Сириус находится дальше.");
            else if (siriusDistance < arcturusDistance)
                Console.WriteLine("Арктур находится дальше.");
            else
                Console.WriteLine("Расстояния равны.");
        }

        static void Task30()
        {
            Console.Write("Введите натуральное число: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0 || number % 10 == 7)
                Console.WriteLine("Число является четным или оканчивается на 7.");
            else
                Console.WriteLine("Число не является четным и не оканчивается на 7.");
        }
    }
}