using System.Collections.Concurrent;

namespace ConsoleApp9
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("1 задание");
            Console.WriteLine("{0:f1}", Math.E); //1 задание.Выводим на экран число e(основание натурального логарифма)

            Console.WriteLine("2 задание");
            Console.WriteLine(50 + "\n" + 10); //2 задание.Выводим на экран числа 50 и 10 одно под другим

            Console.WriteLine("3 задание");//3 задание. Выводим на экран «столбиком» четыре любые числа.
            Random rnd = new Random();
            int y = rnd.Next();
            int z = rnd.Next();
            int s = rnd.Next();
            int x = rnd.Next();
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(s);

            Console.WriteLine("4 задание");//4 задание. Выводим на экран число, которое больше введенного на 10.
            Console.Write("Введите число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Число большее введенного на 10:{a + 10}");

            Console.WriteLine("5 задание");//5 задание. Находим периметр квадрата
            Console.Write("Введите сторону квадрата:");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = n * 4;
            Console.WriteLine("Периметр квадрата= " + m);

            Console.WriteLine("6 задание");//6 задание. Находим длину окружности и площадь круга.
            Console.Write("Введите радиус окружности:");
            double rad = Convert.ToDouble(Console.ReadLine());
            double length = 2 * Math.PI * rad;
            double square = Math.PI * rad * rad;
            Console.WriteLine("Длина окружности: " + length);
            Console.WriteLine("Площадь круга: " + square);

            Console.WriteLine("7 задание");//7 задание. Находим значение y=cos(x).
            Console.Write("Введите аргумент:");
            double arg = Convert.ToDouble(Console.ReadLine());
            double res = Math.Cos(arg);
            Console.WriteLine("Значение cos(" + arg + ") равно " + res);

            Console.WriteLine("8 задание"); //Находим периметр равнобедренной трапеции.
            Console.Write("Введите длину первого основания:");
            double osn1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину второго основания:");
            double osn2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту трапеции:");
            double h = Convert.ToDouble(Console.ReadLine());
            double side = Math.Sqrt(h * h + Math.Pow((osn2 - osn1) / 2, 2));
            double P = osn1 + osn2 + side * 2;
            Console.WriteLine("Периметр трапеции равен " + P);

            Console.WriteLine("9 задание");//Находим стоимость всей покупки,если купили x кг конфет, у кг печенья и z кг яблок.
            Console.Write("Введите стоимость 1 кг конфет:");
            double candy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите стоимость 1 кг печенья:");
            double cookie = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите стоимость 1 кг яблок:");
            double apples = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество кг конфет:");
            double candy_x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество кг печенья:");
            double cookie_y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество кг яблок:");
            double apples_z = Convert.ToDouble(Console.ReadLine());
            double summa = (candy * candy_x) + (cookie * cookie_y) + (apples * apples_z);
            Console.WriteLine("Сумма покупки равна " + summa);

            Console.WriteLine("10 задание");//Выводим на экран три строки "Мир", "Труд" и "Май".
            string sl1 = "Мир";
            string sl2 = "Труд";
            string sl3 = "Май";

            Console.WriteLine(sl1 + " " + sl2 + " " + sl3);
            Console.WriteLine($"{sl1}");
            Console.WriteLine($"{sl2,10}");
            Console.WriteLine($"{sl3,15}");

            Console.WriteLine("11 задание");//Выводятся на экран два числа, если это числа, то они меняются местами
            Console.WriteLine("Введите два числа:");
            Console.Write("a=");
            string sa = Console.ReadLine();
            if (sa.Contains("."))
                sa = sa.Replace('.', ',');
            Console.Write("b=");
            string sb = Console.ReadLine();
            if (sb.Contains("."))
                sb = sb.Replace('.', ',');
            if (double.TryParse(sa, out double a11) && double.TryParse(sb, out double b11))
            {
                a11 = Convert.ToDouble(sa);
                b11 = Convert.ToDouble(sb);
                double t;
                t = a11;
                a11 = b11;
                b11 = t;
                Console.WriteLine("Результат:");
                Console.WriteLine("a=" + a11);
                Console.WriteLine("b=" + b11);
            }
            else Console.WriteLine("неверный формат");


            Console.WriteLine("12 задание"); //Пользователь выбирает фигуру и указывает, что программа будет считать
            //периметр или площадь. Задаются значения, и на их основе подсчитываются периметры и площади
            Console.WriteLine("Выберите фигуру:");
            Console.WriteLine("1. Треугольник");
            Console.WriteLine("2. Четырехугольник");
            Console.WriteLine("3. Круг");
            int figure = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Что хотите вычислить? (1 - Площадь, 2 - Периметр)");
            int deistv = Convert.ToInt32(Console.ReadLine());

            if (figure == 1) // Треугольник
            {
                if (deistv == 1) // Площадь
                {
                    Console.Write("Введите основание: ");
                    double osn = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите высоту: ");
                    double h1 = Convert.ToDouble(Console.ReadLine());
                    double area = 0.5 * osn * h1;
                    Console.WriteLine("Площадь треугольника равна " + area);
                }
                else // Периметр
                {
                    Console.Write("Введите длины сторон: ");
                    double a12_1 = Convert.ToDouble(Console.ReadLine());
                    double b12_1 = Convert.ToDouble(Console.ReadLine());
                    double c12_1 = Convert.ToDouble(Console.ReadLine());
                    double perimeter1 = a12_1 + b12_1 + c12_1;
                    Console.WriteLine("Периметр треугольника: " + perimeter1);
                }
            }
            else if (figure == 2) // Четырехугольник
            {
                if (deistv == 1) // Площадь
                {
                    Console.Write("Введите длину: ");
                    double dlina = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите ширину: ");
                    double shirina = Convert.ToDouble(Console.ReadLine());
                    double area1 = dlina * shirina;
                    Console.WriteLine("Площадь четырехугольника: " + area1);
                }
                else // Периметр
                {
                    Console.Write("Введите длины сторон: ");
                    double a12_2 = Convert.ToDouble(Console.ReadLine());
                    double b12_2 = Convert.ToDouble(Console.ReadLine());
                    double c12_2 = Convert.ToDouble(Console.ReadLine());
                    double d12_2 = Convert.ToDouble(Console.ReadLine());
                    double perimeter2 = a12_2 + b12_2 + c12_2 + d12_2;
                    Console.WriteLine("Периметр четырехугольника: " + perimeter2);
                }
            }
            else if (figure == 3) // Круг
            {
                Console.Write("Введите радиус: ");
                double r1 = Convert.ToDouble(Console.ReadLine());
                if (deistv == 1) // Площадь
                {
                    double area2 = Math.PI * r1 * r1;
                    Console.WriteLine("Площадь круга: " + area2);
                }
                else // Периметр
                {
                    double per = 2 * Math.PI * r1;
                    Console.WriteLine("Периметр круга: " + per);
                }
            }
            else
            {
                Console.WriteLine("Неверный выбор фигуры.");
            }

            Console.WriteLine("13 задание");//Составить программу вывода на экран числа, вводимого с клавиатуры.
            Console.WriteLine("Введите число:");
            double num13 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Вы ввели число: " + num13);

            Console.WriteLine("14 задание");//Составить программу вывода на экран следующей информации: 2 кг, 13 17
            Console.WriteLine("2 кг");
            Console.WriteLine("13 17");

            Console.WriteLine("15 задание");//Составить программу вывода на экран «столбиком» четырех случайных чисел.
            Random rnd15 = new Random();
            int x15 = rnd15.Next();
            int y15 = rnd15.Next();
            int z15 = rnd15.Next();
            int s15 = rnd15.Next();
            Console.WriteLine(x15);
            Console.WriteLine(y15);
            Console.WriteLine(z15);
            Console.WriteLine(s15);

            Console.WriteLine("16 задание");//Найти корни квадратного уравнения(коэффициента задаются пользователем с клавиатуры)
            double a16 = Convert.ToDouble(Console.ReadLine());
            double b16 = Convert.ToDouble(Console.ReadLine());
            double c16 = Convert.ToDouble(Console.ReadLine());
            double D = b16 * b16 - 4 * a16 * c16;
            if (D < 0)
            {
                Console.WriteLine("Дискриминант меньше нуля, корней нет");
            }
            else
            {
                if (D == 0)
                {
                    double res16_1 = -b16 / (2 * a16);
                    Console.WriteLine("Дискриминант равен нулю, один корень: " + res16_1);
                }
                else
                {
                    double res16_2 = (-b16 - Math.Pow(D, 0.5)) / (2 * a16);
                    double res16_3 = (-b16 + Math.Pow(D, 0.5)) / (2 * a16);
                    Console.WriteLine("Первый корень равен " + res16_2 + "Второй корень равен" + res16_3);
                }
            }

            Console.WriteLine("17 задание");//Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее геометрическое
            int a17 = Convert.ToInt32(Console.ReadLine());
            int b17 = Convert.ToInt32(Console.ReadLine());
            if ((a17 < 0) | (b17 < 0))
            {
                Console.WriteLine("Числа должны быть больше нуля");
            }
            else
            {
                Console.WriteLine($"Среднее арифметическое равно {(double)(a17 + b17) / 2}");
                Console.WriteLine($"Среднее геометрическое равно {Math.Sqrt(a17 * b17)}");
            }

            Console.WriteLine("18 задание");//Известны координаты на плоскости двух точек. Составить программу вычисления расстояния между ними.
            Console.WriteLine("Введите координату Х первой точки:");
            double x18_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Y первой точки:");
            double y18_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Х второй точки:");
            double x18_2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Y второй точки:");
            double y18_2 = Convert.ToDouble(Console.ReadLine());
            double dist = Math.Sqrt(Math.Pow(x18_2 - x18_1, 2) + Math.Pow(y18_2 - y18_1, 2));
            Console.WriteLine("Расстояние между точками= " + dist);

            Console.WriteLine("19 задание");//Составить программу обмена значениями трех переменных величин а, b, c по следующим двум схемам
            //а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
            //б) b присвоить значение а, с присвоить значение b, а присвоить значение с.
            int a19 = Convert.ToInt32(Console.ReadLine());
            int b19 = Convert.ToInt32(Console.ReadLine());
            int c19 = Convert.ToInt32(Console.ReadLine());

            int f19 = a19;
            a19 = b19;
            b19 = c19;
            c19 = f19;
            Console.WriteLine($"Пункт а: {a19} {b19} {c19}");

            a19 = Convert.ToInt32(Console.ReadLine());
            b19 = Convert.ToInt32(Console.ReadLine());
            c19 = Convert.ToInt32(Console.ReadLine());

            int t19 = a19;
            a19 = c19;
            c19 = b19;
            b19 = t19;
            Console.WriteLine($"Пункт б: {a19} {b19} {c19}");

            Console.WriteLine("20 задание");//С начала суток прошло n секунд. Определить:
            //а) сколько полных часов прошло с начала суток;
            //б) сколько полных минут прошло с начала очередного часа;
            //в) сколько полных секунд прошло с начала очередной минуты.
            int n20 = Convert.ToInt32(Console.ReadLine());
            int hour = n20 / 3600;
            int minute = (n20 % 3600) / 60;
            int second = n20 % 60;
            Console.WriteLine("Полных часов прошло " + hour + "полных минут прошло " + minute + "полных секунд прошло " + second);

            Console.WriteLine("21 задание");//Дан прямоугольник с размерами 543 х 130 мм. Определить сколько квадратов со стороной 130 мм можно отрезать от него
            int width = 543;
            int height = 130;
            int side21 = 130;
            int width2 = width / side21;
            int height2 = height / side21;
            int squares = width2 * height2;
            Console.WriteLine("Количество квадратов равно " + squares);

            Console.WriteLine("22 задание");//Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали
                                            //ее в начале.Найти полученное число.
            Console.WriteLine("Введите трехзначное число");
            int num01 = Convert.ToInt32(Console.ReadLine());

            int last = num01 % 10;
            int middle = num01 / 10;
            int num02 = last + 100 + middle;
            Console.WriteLine("Полученное число = " + num02);

            Console.WriteLine("23 задание");//Дано натуральное число n (n > 999). Найти:
            //а) число сотен в нем;
            //б) число тысяч в нем.
            Console.WriteLine("Введите натуральное число (n > 999):");
            int n23 = Convert.ToInt32(Console.ReadLine());
            int hundreds = (n / 100);
            int thousands = (n / 1000);
            Console.WriteLine("Число сотен = " + hundreds);
            Console.WriteLine("Число тысяч = " + thousands);

            Console.WriteLine("24 задание");//Дано четырехзначное число. Найти:
            //а) число, полученное при прочтении его цифр справа налево;
            //б) число, образуемое при перестановке первой и второй, третьей и четвертой цифр заданного числа.
            //в) число, образуемое при перестановке второй и третьей цифр заданного числа.
            //г) число, образуемое при перестановке двух первых и двух последних цифр
            Console.Write("Введите четырехзначное число: ");
            int a24 = Convert.ToInt32(Console.ReadLine());
            int c24_1 = a24 / 1000;
            Console.WriteLine("первая цифра:" + c24_1);
            int c24_2 = a24 / 100 % 10;
            Console.WriteLine("вторая цифра:" + c24_2);
            int c24_3 = a24 / 10 % 10;
            Console.WriteLine("третья цифра:" + c24_3);
            int c24_4 = a % 10;
            Console.WriteLine("четвертая цифра:" + c24_4);
            Console.WriteLine($"а) Перевернутное число {c24_4 * 1000 + c24_3 * 100 + c24_2 * 10 + c24_1}");
            Console.WriteLine($"б) Число, образуемое при перестановке первой и второй, третьей и четвертой цифр заданного числа {c24_2 * 1000 + c24_1 * 100 + c24_4 * 10 + c24_3}");
            Console.WriteLine($"в) Число, образуемое при перестановке второй и третьей цифр заданного числа {c24_1 * 1000 + c24_3 * 100 + c24_2 * 10 + c24_4}");
            Console.WriteLine($"г) Число, образуемое при перестановке двух первых и двух последних цифр {c24_3 * 1000 + c24_4 * 100 + c24_1 * 10 + c24_2}");

            Console.WriteLine("25 задание");//// Из трехзначного числа x вычли его последнюю цифру.
            // Pезультат разделили на 10, и слева приписали ту цифру числа x.
            // Получилось число n. Найти число x.
            int n25 = Convert.ToInt32(Console.ReadLine());
            for (int x25 = 100; x25 <= 999; x25++)
            {
                int last25 = x25 % 10;
                int result25 = (x25 - last25) / 10;

                if (result25 == n25 / 10 && last25 == n25 % 10)
                {
                    Console.WriteLine($"Найдено число x: {x25}");
                    return;
                }
            }
            Console.WriteLine("Число x не найдено.");

            Console.WriteLine("26 задание");// Даны целые числа h, m, s (0 ≤ h ≤ 23, 0 ≤ m ≤ 59, 0 ≤ s ≤ 59),
            // указывающие момент времени: «h часов, m минут, s секунд».
            // Определить угол(в градусах) между
            // положением часовой стрелки в начале суток и в указанный момент времени.
            Console.Write("Введите часы: ");
            int h26 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите минуты: ");
            int m26 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите секунды: ");
            int s26 = Convert.ToInt32(Console.ReadLine());
            double angle = (h26 % 12) * 30 + (m26 / 60) * 30 + (s26 / 3600) * 30;
            Console.WriteLine("Угол между положением часовой стрелки в начале суток и в указанный момент времени = " + angle);

            Console.WriteLine("27 задание");//Дан угол часовой стрелки, вывести время и угол минутной
            Console.WriteLine("Введите угол часовой стрелки (в радианах)");
            double y27 = double.Parse(Console.ReadLine());

            double hours = Math.Floor(6 * y27);
            double minut = (180 * y27 - 30 * hours) * 2;
            double minutes = minut / 30;

            Console.WriteLine($"Угол минутной стрелки равен {minutes:F1} радиан; время - {hours:F0}:{minut:F0}");

            Console.WriteLine("28 задание");//Вывести наименьшее по модулю из 3 введенных
            Console.WriteLine("Введите три вещественных числа: ");
            double num28_1 = Convert.ToDouble(Console.ReadLine());
            double num28_2 = Convert.ToDouble(Console.ReadLine());
            double num28_3 = Convert.ToDouble(Console.ReadLine());
            double minAbs = Math.Min(Math.Abs(num28_1), Math.Min(Math.Abs(num28_2), Math.Abs(num28_3)));
            Console.WriteLine("Меньшее по модулю число = " + minAbs);

            Console.WriteLine("29 задание");//Найти сумму наибольшего и наименьшего из 3 введенных чисел
            double a29 = Convert.ToDouble(Console.ReadLine());
            double b29 = Convert.ToDouble(Console.ReadLine());
            double c29 = Convert.ToDouble(Console.ReadLine());
            double max = Math.Max(Math.Max(a29, b29), c29);
            double min = Math.Min(Math.Min(a29, b29), c29);
            double sum29 = max + min;
            Console.WriteLine("Сумма наибольшего числа и наименьшего равна " + sum29);

            Console.WriteLine("30 задание");//Подсчитать количество делителей вводимого числа
            Console.WriteLine("Введите натуральное число: ");
            int n30 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Делители числа {n}:");

            for (int d30 = 1; d30 <= n30; d30++)

                if (n30 % d30 == 0)
                {
                    Console.Write(d30 + " ");
                }


            Console.WriteLine("31 задание");//Вводятся коэффициенты кубического уравнения, выводятся корни уравнения, если они есть
            double a31 = Convert.ToDouble(Console.ReadLine());
            double b31 = Convert.ToDouble(Console.ReadLine());
            double c31 = Convert.ToDouble(Console.ReadLine());
            double d31 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Найденные целые корни:");

            for (int x31 = -100; x31 <= 100; x31++)
                if (a31 * x31 * x31 * x31 + b31 * x31 * x31 + c31 * x31 + d31 == 0)
                    Console.WriteLine(x);

            Console.WriteLine("32 задание");// Даны 1 и 2 элементы арифм. прогрессии, найти и вывести n-ный
            Console.WriteLine("Введите 1 элемент");
            double a32_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 2 элемент");
            double a32_2 = Convert.ToDouble(Console.ReadLine());

            double delta = a32_2 - a32_1;

            Console.WriteLine("Введите число n");
            int n32 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{a32_1 + delta * (n32 - 1)}");

            Console.WriteLine("33 задание");//Ввод профессии, пенсионер или нет, трудоустроен ли
            // Если (пенсионер или студент) и не трудоустроен, то получаю кредит
            // И пенсионер, и студент - нет
            // В неоговоренных случаях в кредите отказать
            Console.WriteLine("Кто вы? Студент или нет?");
            string status1 = Console.ReadLine().ToLower();
            Console.WriteLine("Вы пенсионер? да/нет");
            string status2 = Console.ReadLine().ToLower();
            Console.WriteLine("Вы трудоустроены? да/нет");
            string joy = Console.ReadLine().ToLower();

            if (status1 == "студент")
            {
                if (status2 == "да")
                {
                    Console.WriteLine("В кредите отказано");
                }

                else
                {
                    if (joy == "нет")
                    {
                        Console.WriteLine("Кредит одобрен");
                    }
                    else
                    {
                        Console.WriteLine("В кредите отказано");
                    }
                }
            }
            else if (status2 == "да")
            {
                if (joy == "нет")
                {
                    Console.WriteLine("Кредит одобрен");
                }
                else
                {
                    Console.WriteLine("В кредите отказано");
                }
            }
            else
            {
                Console.WriteLine("В кредите отказано");
            }

            Console.WriteLine("34 задание");// 1) Спросить имя и вывести его 
            // 2) Спросить имя и вывести его с приветствием
            Console.WriteLine("Как тебя зовут?");
            string name = Console.ReadLine();

            Console.WriteLine($"{name}");

            Console.WriteLine("Какое твое имя?");
            string name34 = Console.ReadLine();
            Console.WriteLine($"Привет, {name34}!");

            Console.WriteLine("35 задание");//Воспроизвести разговор Гарри и дневника Тома Реддла.
            // Пользователь здоровается с консолью.
            // Консоль спрашивает, как зовут пользователя.
            // Пользователь называет имя.
            // Консоль пишет: привет, < имя пользователя >.
            // После этого пользователь спрашивает, знает ли консоль что-то о тайной комнате.
            // Консоль отвечает «Да».
            // После этого пользователь спрашивает, может ли рассказать.
            // Консоль отвечает «Нет».
            // Спустя 5 секунд консоль дополняет «но могу показать».
            // Консоль меняет
            // цвет на любой случайный цвет.
            Console.WriteLine("Здравствуйте!");
            Console.Write("Как вас зовут? ");
            string name36 = Console.ReadLine();
            Console.WriteLine($"Привет, {name36}!");
            if (Console.ReadLine().ToLower() == "Ты знаешь что-то о тайной комнате?")
            {
                Console.WriteLine("Да");

                if (Console.ReadLine().ToLower() == "А можешь рассказать?")
                {
                    Console.WriteLine("Нет");
                    Thread.Sleep(5000);
                    Console.WriteLine("но могу показать");
                    Random random = new Random();
                    ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
                    Console.ForegroundColor = colors[random.Next(colors.Length)];
                }
            }

            Console.WriteLine("36 задание");//Вычислить контрольную цифру штрихкода (EAN13).
            // 1) 12 цифр определяются случайным образом. 
            // 2) 12 цифр вводит пользователя














        }
    }
}

