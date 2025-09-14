using System;
class Program
{
    static void Main()
    {
        //Задание 1
        //Console.Write("Введите число: ");
        //int number = Convert.ToInt32(Console.ReadLine());
        //
        //if (number % 2 == 0)
        //    Console.WriteLine($"число {number} чётное");
        //else
        //    Console.WriteLine($"число {number} нечётное");
        //Задание 2
        //Console.Write("Введите пароль: ");
        //string password = Console.ReadLine();
        //
        //Console.Write("Подтвердите пароль: ");
        //string confirm = Console.ReadLine();
        //
        //if (password == confirm)
        //    Console.WriteLine("Пароль принят");
        //else
        //    Console.WriteLine("Пароль не принят");
        //Задание 3
        //Console.Write("Введите четырёхзначное число: ");
        //int number = Convert.ToInt32(Console.ReadLine());
        //
        //int dig1 = number / 1000;      
        //int dig2 = (number / 100) % 10;
        //int dig3 = (number / 10) % 10; 
        //int dig4 = number % 10;        
        //
        //if (dig1 + dig4 == dig2 - dig3)
        //    Console.WriteLine("ДА");
        //else
        //    Console.WriteLine("НЕТ");
        //Задание 4
        //Console.Write("Введите ваш возраст: ");
        //int age = Convert.ToInt32(Console.ReadLine());
        //
        //if (age >= 18)
        //    Console.WriteLine("Доступ разрешен");
        //else
        //    Console.WriteLine("Доступ запрещен");
        //Задание 5
        //Console.Write("Введите первое число: ");
        //int a = Convert.ToInt32(Console.ReadLine());
        //
        //Console.Write("Введите второе число: ");
        //int b = Convert.ToInt32(Console.ReadLine());
        //
        //int min = a < b ? a : b;
        //Console.WriteLine($"Наименьшее число: {min}");
        ////Задание 6
        //Console.Write("Введите первое число: ");
        //double a = Convert.ToDouble(Console.ReadLine());
        //
        //Console.Write("Введите второе число: ");
        //double b = Convert.ToDouble(Console.ReadLine());
        //
        //Console.Write("Введите операцию (+, -, *, /): ");
        //string operation = Console.ReadLine();
        //
        //double result = 0;
        //
        //if (operation == "+")
        //    result = a + b;
        //else if (operation == "-")
        //    result = a - b;
        //else if (operation == "*")
        //    result = a * b;
        //else if (operation == "/")
        //    result = b != 0 ? a / b : double.NaN;
        //else
        //    Console.WriteLine("Неизвестная операция");
        //
        //if (operation == "/" && b == 0)
        //    Console.WriteLine("Ошибка: деление на ноль!");
        //else if (operation == "+" || operation == "-" || operation == "*" || (operation == "/" && b != 0))
        //    Console.WriteLine($"{a} {operation} {b} = {result}");
        ////Задание 7
        //Console.Write("Введите номер дня недели (1-7): ");
        //int day = Convert.ToInt32(Console.ReadLine());
        //
        //switch (day)
        //{
        //    case 1:
        //        Console.WriteLine("Понедельник");
        //        break;
        //    case 2:
        //        Console.WriteLine("Вторник");
        //        break;
        //    case 3:
        //        Console.WriteLine("Среда");
        //        break;
        //    case 4:
        //        Console.WriteLine("Четверг");
        //        break;
        //    case 5:
        //        Console.WriteLine("Пятница");
        //        break;
        //    case 6:
        //        Console.WriteLine("Суббота");
        //        break;
        //    case 7:
        //        Console.WriteLine("Воскресенье");
        //        break;
        //    default:
        //        Console.WriteLine("Неверный номер дня");
        //        break;
        //}
        //Задание 8
        //Console.Write("Введите первое число: ");
        //double a = Convert.ToDouble(Console.ReadLine());
        //
        //Console.Write("Введите второе число: ");
        //double b = Convert.ToDouble(Console.ReadLine());
        //
        //Console.Write("Введите операцию (+, -, *, /): ");
        //string operation = Console.ReadLine();
        //
        //double result = 0;
        //
        //switch (operation)
        //{
        //    case "+":
        //        result = a + b;
        //        Console.WriteLine($"{a} + {b} = {result}");
        //        break;
        //    case "-":
        //        result = a - b;
        //        Console.WriteLine($"{a} - {b} = {result}");
        //        break;
        //    case "*":
        //        result = a * b;
        //        Console.WriteLine($"{a} * {b} = {result}");
        //        break;
        //    case "/":
        //        if (b != 0)
        //        {
        //            result = a / b;
        //            Console.WriteLine($"{a} / {b} = {result}");
        //        }
        //        else
        //            Console.WriteLine("Ошибка: деление на ноль!");
        //        break;
        //    default:
        //        Console.WriteLine("Неизвестная операция");
        //        break;
        //}
        //Задание 9
        //Console.WriteLine("Выберите уровень сложности:");
        //Console.WriteLine("1 - Легкий");
        //Console.WriteLine("2 - Средний");
        //Console.WriteLine("3 - Сложный");
        //
        //Console.Write("Ваш выбор: ");
        //int level = Convert.ToInt32(Console.ReadLine());
        //
        //switch (level)
        //{
        //    case 1:
        //        Console.WriteLine("Легкий уровень: Медленные враги, много бонусов");
        //        break;
        //    case 2:
        //        Console.WriteLine("Средний уровень: Стандартная сложность, баланс");
        //        break;
        //    case 3:
        //        Console.WriteLine("Сложный уровень: Быстрые враги, мало ресурсов");
        //        break;
        //    default:
        //        Console.WriteLine("Неверный выбор уровня");
        //        break;
        //}
        //Задание 10
        // Определение пространства имен Program
        //        namespace Program
        //        {
        //    // Объявление внутреннего класса Program
        //    internal class Program
        //    {
        //        // Объявление статической переменной health с начальным значением 100
        //        static int health = 100;
        //        // Объявление главного метода программы - точки входа
        //        static void Main(string[] args)
        //        {
        //            // Вывод текущего здоровья персонажа
        //            Console.WriteLine($"Здоровье персонажа: {health}");
        //            // Вызов метода TakeDamage с параметром 30
        //            TakeDamage(30);
        //        }
        //        // Объявление статического метода TakeDamage, принимающего параметр damage
        //        static void TakeDamage(int damage)
        //        { 
        //            // Уменьшение здоровья на значение damage
        //            health -= damage; 
        //            // Вывод сообщения о полученном уроне
        //            Console.WriteLine($"Персонаж получил {damage} урона. Текущее здоровье: {health}.");
        //        }
        //    }   
        //}
        //Задание 11
        //Console.WriteLine("Выберите класс персонажа:");
        //Console.WriteLine("воин, маг, разбойник, паладин, варвар, охотник, друид, жрец");
        //
        //Console.Write("Ваш выбор: ");
        //string characterClass = Console.ReadLine().ToLower();
        //
        //switch (characterClass)
        //{
        //    case "воин":
        //    case "паладин":
        //    case "варвар":
        //    case "разбойник":
        //        Console.WriteLine("Ближний боец");
        //        break;
        //        
        //    case "маг":
        //    case "охотник":
        //    case "жрец":
        //        Console.WriteLine("Дальнобойщик");
        //        break;
        //        
        //    case "друид":
        //        Console.WriteLine("Универсальный боец (может быть и ближним, и дальним)");
        //        break;
        //        
        //    default:
        //        Console.WriteLine("Неизвестный класс");
        //        break;
        //}
        //Задание 12
        //int sum = 0;
        //
        //Console.Write("Введите первое число: ");
        //int num1 = Convert.ToInt32(Console.ReadLine());
        //if (num1 > 0) sum += num1;
        //
        //Console.Write("Введите второе число: ");
        //int num2 = Convert.ToInt32(Console.ReadLine());
        //if (num2 > 0) sum += num2;
        //
        //Console.Write("Введите третье число: ");
        //int num3 = Convert.ToInt32(Console.ReadLine());
        //if (num3 > 0) sum += num3;
        //
        //Console.WriteLine($"Сумма положительных чисел: {sum}");
        //Задание 13
        //Console.WriteLine("Добро пожаловать в Темный Лабиринт!");
        //Console.WriteLine("Вы стоите перед первой дверью.");
        //Console.WriteLine("Путь А: Войти в комнату с огромным драконом");
        //Console.WriteLine("Путь B: Пойти по темному коридору");
        //
        //Console.Write("Ваш выбор (A/B): ");
        //string choice1 = Console.ReadLine().ToUpper();
        //
        //if (choice1 == "A")
        //{
        //    Console.WriteLine("\nВы входите в комнату с драконом!");
        //    Console.WriteLine("Дракон говорит: \"Кто не дышит, но живет; хоть не нужно — много пьет; и в жизни, и в смерти тело как лед.\"");
        //    
        //    Console.Write("Ваш ответ: ");
        //    string answer = Console.ReadLine().ToLower();
        //    
        //    if (answer == "рыба")
        //    {
        //        Console.WriteLine("\nДракон: \"Правильно! Ты достоин пройти дальше.\"");
        //        Console.WriteLine("Дракон открывает дверь в следующую комнату.");
        //        Console.WriteLine("Поздравляем! Вы прошли лабиринт!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("\nДракон: \"Неправильно! Ты станешь моим обедом!\"");
        //        Console.WriteLine("Игра окончена. Вас съели!");
        //    }
        //}
        //else if (choice1 == "B")
        //{
        //    Console.WriteLine("\nВы идете по темному коридору...");
        //    Console.WriteLine("Перед вами две двери:");
        //    Console.WriteLine("Дверь 1: За ней скрыты сокровища Dungeon Master'а");
        //    Console.WriteLine("Дверь 2: За ней — ловушка с ядовитыми шипами");
        //    
        //    Console.Write("Ваш выбор (1/2): ");
        //    string choice2 = Console.ReadLine();
        //    
        //    if (choice2 == "1")
        //    {
        //        Console.WriteLine("\nВы открываете дверь и видите сияющие сокровища!");
        //        Console.WriteLine("Поздравляем! Вы нашли сокровища Dungeon Master'а!");
        //        Console.WriteLine("Вы победили!");
        //    }
        //    else if (choice2 == "2")
        //    {
        //        Console.WriteLine("\nВы открываете дверь и слышите щелчок...");
        //        Console.WriteLine("Это была ловушка! Ядовитые шипы вылетают из стен.");
        //        Console.WriteLine("Игра окончена. Вы попали в ловушку!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Неверный выбор! Вы заблудились в лабиринте...");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Неверный выбор! Вы остались стоять перед дверью...");
        //}
    }
}