using static StringMechanics.StringMechanics;

namespace StringMetods
{
    /// <summary>
    /// Практическое задание 5. Методы
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка старта
        /// </summary>
        static void Main()
        {
            #region Задание 1

            Console.WriteLine("Практическое задание 5. Методы");
            Console.WriteLine("Задание 1. Разделение строки на слова");
            Console.WriteLine("Можно воспользоваться преденными примерами для" +
                                " разделения или ввести свою строку");
            Console.WriteLine("Введите цифру выбранного варианта "+
                              "или цифру '3' для своего ввода ");

            string textExample1 = "Извлекает подстроку из данного экземпляра";
            string textExample2 = "Пользователь вводит в консольном приложении длинное предложение";

            Console.WriteLine($"1. {textExample1}");
            Console.WriteLine($"2. {textExample2}");

            int correctInput;

            do
            {
                Console.WriteLine("Введите целое число от 1 до 3: ");
                string userInput = Console.ReadLine().ToString();
                int.TryParse(userInput, out correctInput);

            } while (!(0 < correctInput  && correctInput < 4));

            string[] dividedText;
            string userTextChoice;
            switch (correctInput)
            {
                case 1:
                    userTextChoice = textExample1;
                    dividedText = SplitText(userTextChoice);
                    WriteText(dividedText);
                    break;
                case 2:
                    userTextChoice = textExample2;
                    dividedText = SplitText(userTextChoice);
                    WriteText(dividedText);
                    break;
                default:
                    userTextChoice = Console.ReadLine();
                    
                    if ( !string.IsNullOrEmpty(userTextChoice))
                    {
                        dividedText = SplitText (userTextChoice);
                        WriteText(dividedText);
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели пустую строку, нечего делить");
                    }
                    break;
            }

            Console.ReadKey(true);
            Console.Clear();

            #endregion

            #region Задание 2
            Console.WriteLine("Практическое задание 5. Методы");
            Console.WriteLine("Задание 2. Перестановка слов в предложении");
            Console.WriteLine("Будет использована строка из первого задания");

            Console.WriteLine("\nИзначальная строка:");
            Console.WriteLine(userTextChoice);

            if (!string.IsNullOrEmpty(userTextChoice))
            {
                string reverseText = ReverseWords(userTextChoice);
                Console.WriteLine("\nРазвернутая строка:");
                Console.WriteLine(reverseText);
            }
            else
            {
                Console.WriteLine("Вы ввели пустую строку, нечего делить и разворачивать");
            }

            Console.ReadKey(true);

            #endregion

        }
    }
}