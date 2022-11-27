using System.Linq.Expressions;

namespace StringMechanics
{
    public class StringMechanics
    {
        /// <summary>
        /// Разделяет строку на слова, разделителем считается символ пробела
        /// </summary>
        /// <param name="text">Строка которую необходимо разделить</param>
        /// <returns>Массив слов разделенной строки</returns>
        public static string[] SplitText(string text)
        {
            int countWords = 1;
            char[] arrayOfLetters = new char[text.Length];
            int charIndex = 0;
            foreach (var letter in text)
            {
                arrayOfLetters[charIndex] = letter;
                charIndex++;
                if (letter == ' ')
                {
                    countWords++;
                }
            }

            string[] dividedText = new string[countWords];

            int wordNumberIndex = 0;   
            for (charIndex = 0; charIndex < arrayOfLetters.Length; charIndex++)
            {
                if (arrayOfLetters[charIndex] != ' ')
                {
                    dividedText[wordNumberIndex] += arrayOfLetters[charIndex];
                }
                else
                {
                    wordNumberIndex++;
                }
            }
           

            return dividedText;
        }

        /// <summary>
        /// Вывод в консоль массива строк каждый элемент на новой строке
        /// </summary>
        /// <param name="arrayToWrite">Массив для вывода в консоль</param>
        public static void WriteText(string[] arrayToWrite)
        {
            for (int wordsIndex = 0; wordsIndex < arrayToWrite.Length; wordsIndex++)
            {
                Console.WriteLine(arrayToWrite[wordsIndex]);
            }
        }

        /// <summary>
        /// Возвращает строку с обратной последовательностью слов
        /// </summary>
        /// <param name="text">Текст для разворота слов</param>
        /// <returns>Результат смены последовательности слов, при неуданом преобразовании
        /// возращается изначальная строка</returns>
        public static string ReverseWords(string text)
        {
            string? result = null;
            string[] initialText = SplitText(text);

            for (int wordIndex = initialText.Length-1; wordIndex>=0; wordIndex--)
            {
                result += initialText[wordIndex] + ' ';
            }


            if (result != null)
            {
                return result;
            }
            else
            {
                return text;
            }
        }
    }
}