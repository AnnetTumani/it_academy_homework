using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            var input = Console.ReadLine();
            var words = input.Split(' ');

            Console.WriteLine("Строка с удаленным из него самым длинным словом: " + Environment.NewLine + DeleteMaxLenghtWord(words));
            
            Console.WriteLine("Строка с измененными местами самого длинного и самого короткого слова: " + Environment.NewLine + SwapMaxAndMinWords(words));
            
            var lettersAndPunctuationMarks = FindLettersAndPunctuationMarks(input);
            Console.WriteLine("Количество букв в строке: " + lettersAndPunctuationMarks.Item1 + "." + Environment.NewLine 
                            + "Количество знаков препинания: " + lettersAndPunctuationMarks.Item2 + ".");
            
            Console.WriteLine("Отсортированный по убыванию длины слова массив, полученный из строки: ");            
            foreach (var word in DescendingSortedWords(words))
            {
                Console.WriteLine(word);
            }

            Console.ReadKey();



            string DeleteMaxLenghtWord(string[] array)
            {
                var arrayCopy = (string[])array.Clone();
                var maxLenghtWord = FindMaxLenghtWord(arrayCopy);
                arrayCopy[maxLenghtWord.Item2] = string.Empty;
                var result = string.Join(" ", arrayCopy);

                return result;
            }
            string SwapMaxAndMinWords(string[] array)
            {
                var maxLenghtWord = FindMaxLenghtWord(array);
                var minLenghtWord = FindMinLenghtWord(array);
                array[maxLenghtWord.Item2] = minLenghtWord.Item1;
                array[minLenghtWord.Item2] = maxLenghtWord.Item1;
                var result = string.Join(" ", array);

                return result;
            }
            (int, int) FindLettersAndPunctuationMarks(string inputString)
            {
                var lettersCount = inputString.Count(char.IsLetter);
                var punctuationMarksCount = inputString.Count(char.IsPunctuation);
                return (lettersCount, punctuationMarksCount);
            }
            string[] DescendingSortedWords(string[] array)
            {
                string[] outputArray = new string[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    var maxTemp = FindMaxLenghtWord(array);
                    outputArray[i] = maxTemp.Item1;
                    array[maxTemp.Item2] = string.Empty;
                }
                return outputArray;
            }

            (string, int) FindMaxLenghtWord(string[] array)
            {
                int maxLenght = 0, index = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (maxLenght <= array[i].Length)
                    {
                        maxLenght = array[i].Length;
                        index = i;
                    }
                }
                return (array[index], index);
            }
            (string, int) FindMinLenghtWord(string[] array)
            {
                int minLenght = int.MaxValue, index = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (minLenght >= array[i].Length)
                    {
                        minLenght = array[i].Length;
                        index = i;
                    }
                }
                return (array[index], index);
            }       
        }
    }
}
