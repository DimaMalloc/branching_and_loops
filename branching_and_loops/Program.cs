using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branching_and_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1.Приложение по определению чётного или нечётного числа
            //На экране программа с помощью оператора Console.WriteLine предлагает пользователю ввести целое число.
            Console.WriteLine("Введите целое число:");
            //С помощью оператора Console.ReadLine считывается введённое число.
            //С помощью метода int.Parse число преобразуется в целочисленную переменную.
            int number = int.Parse(Console.ReadLine());
            //С помощью оператора деления с остатком определяется, чётное число или нечётное.
            string even = (number % 2 == 0) ? "четное" : "нечетное";
            //В зависимости от предыдущего шага на экран выводится текст, является ли данное число чётным или нет.

            Console.WriteLine($"Число {number} - {even}!");
            Console.ReadKey();


            //Задание 2. Программа подсчёта суммы карт в игре «21»

            //1.Программа приветствует пользователя и спрашивает, сколько у него на руках карт.
            //2.Пользователь вводит целое число.
            //3.Преобразуем это число в счётчик для цикла.
            Console.WriteLine("Здраствуйте! Сколько у вас карт?");
            int cart_count = Convert.ToUInt16(Console.ReadLine());

            //4.С помощью цикла for итеративно просим пользователя ввести номинал каждой карты.Для карт с числовым номиналом он вводит только цифру.

            int sum = 0; //суммы веса карт
            for (; cart_count != 0; --cart_count)
            {
                Console.WriteLine("Введите номеинал карты:");
                string nominal = Console.ReadLine();

             //5.Внутри цикла, используя оператор switch, «вес» каждой карты складываем в общую переменную суммы,
             //которая объявлена до тела основного цикла. Для числовых карт их «вес» равен весу,
             //указанному при вводе пользователем.Для «картинок» «вес» равен 10.
                switch (nominal)
                {
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "10":
                        sum = int.Parse(nominal);
                        break;
                    case "J":
                    case "Q":
                    case "K":
                    case "T":
                    case "j":
                    case "q":
                    case "k":
                    case "t":
                        sum += 10;
                        break;

                }

            }
            //6.По завершении ввода на экране появится значение суммы карт.
            if (sum <= 21)
            {
                Console.WriteLine($"Сумма ваших карт равно = {sum}");
            }
            else
            {
                Console.WriteLine($" {sum} - это перебор ");
            }

            //Задание 3.Проверка простого числа

            Console.WriteLine("Введите число");
            int e_number = Convert.ToInt32(Console.ReadLine());

            int i = e_number - 1;
            bool natural_number = true;

            while (i != 1)
            {
                if (e_number % i == 0)
                {
                    natural_number = false;
                    break;
                }
                i--;
            }

            if (natural_number)
            {
                Console.WriteLine($"{e_number} - простое число!");
            }
            else
            {
                Console.WriteLine($"{e_number} - не простое число, оно делится без остатка на {i}!");
            }

            Console.ReadKey();
        }
    }
}
