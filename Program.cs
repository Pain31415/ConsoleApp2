using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5 };

            ArrayAnalyzer analyzer = new ArrayAnalyzer(array);
            analyzer.AnalyzeArray();

            Console.WriteLine("Number of even elements: " + analyzer.EvenCount);
            Console.WriteLine("Number of odd elements: " + analyzer.OddCount);
            Console.WriteLine("Number of unique elements: " + analyzer.UniqueCount);

            Console.WriteLine("Enter the threshold value:");
            int threshold = Convert.ToInt32(Console.ReadLine());

            ArrayAnalyzer analyzer2 = new ArrayAnalyzer(array);
            int count = analyzer2.CountValuesBelowThreshold(threshold);

            Console.WriteLine($"Number of values below {threshold}: {count}");
        }
    }

    public class ArrayAnalyzer
    {
        public static int GetUniqueCount(int[] array)
        {
            return array.Distinct().Count();
        }
        public static int GetEvenCount(int[] array)
        {
            return array.Count(x => x % 2 == 0);
        }
        public static int GetOddCount(int[] array)
        {
            return array.Count(x => x % 2 != 0);
        }

        public static int CountValuesBelowThreshold(int[] array, int threshold)
        {
            return array.Count(x => x < threshold);
        }
    }
        public static int CountSequenceOccurrences(int[] array, int[] sequence)
    {
        int count = 0;
        for (int i = 0; i <= array.Length - sequence.Length; i++)
        {
            bool isMatch = true;
            for (int j = 0; j < sequence.Length; j++)
            {
                if (array[i + j] != sequence[j])
                {
                    isMatch = false;
                    break;
                }
            }
            if (isMatch)
            {
                count++;
            }
        }
        return count;
    }
    static void Tasks4 (string[] args)
    {
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = { 3, 4, 5, 6, 7 };
        int[] resultArray = CommonElements(array1, array2);
        Console.WriteLine("Результат:");
        foreach (var element in resultArray)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static int[] GetCommonElements(int[] array1, int[] array2)
    {
        var commonElements = array1.Intersect(array2).Distinct().ToArray();
        return commonElements;
    }
    static void Task5(string[] args)
    {
        int[,] array2D = {
            { 5, 12, 7 },
            { 9, 3, 15 },
            { 6, 2, 10 }
        };

        int min = FindMinValue(array2D);
        int max = FindMaxValue(array2D);

        // Виведення результатів
        Console.WriteLine($"Мінімальне значення: {min}");
        Console.WriteLine($"Максимальне значення: {max}");
    }

    static int FindMinValue(int[,] array)
    {
        int min = array[0, 0];
        foreach (int value in array)
        {
            if (value < min)
            {
                min = value;
            }
        }
        return min;
    }

    static int FindMaxValue(int[,] array)
    {
        int max = array[0, 0];
        foreach (int value in array)
        {
            if (value > max)
            {
                max = value;
            }
        }
        return max;
    }
    static void Task6(string[] args)
    {
        Console.WriteLine("Введіть речення:");
        string sentence = Console.ReadLine();

        int wordCount = CountWords(sentence);
        Console.WriteLine($"Кількість слів у реченні: {wordCount}");
    }

    static int CountWords(string sentence)
    {
        string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
    static void Task7(string[] args)
    {
        Console.WriteLine("Введіть речення:");
        string sentence = Console.ReadLine();

        string reversedSentence = ReverseWords(sentence);
        Console.WriteLine($"Після перевороту: {reversedSentence}");
    }

    static string ReverseWords(string sentence)
    {
        // Розділяємо речення на слова
        string[] words = sentence.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            words[i] = ReverseString(words[i]);
        }

        string reversedSentence = string.Join(" ", words);
        return reversedSentence;
    }

    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    static void Task8(string[] args)
    {
        Console.WriteLine("Введіть речення:");
        string sentence = Console.ReadLine();

        int vowelCount = CountVowels(sentence);
        Console.WriteLine($"Кількість голосних літер у реченні: {vowelCount}");
    }

    static int CountVowels(string sentence)
    {
        string vowels = "aeiouAEIOU";

        int count = 0;

        foreach (char c in sentence)
        {
            if (vowels.Contains(c))
            {
                count++;
            }
        }

        return count;
    }
    static void HM1(string[] args)
    {
        double[] A = new double[5];
        Console.WriteLine("Введіть 5 чисел для масиву A:");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"Елемент {i + 1}: ");
            A[i] = double.Parse(Console.ReadLine());
        }

        double[,] B = new double[3, 4];
        Random random = new Random();
        Console.WriteLine("Масив B:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                B[i, j] = random.NextDouble() * 100;
                Console.Write(B[i, j] + "\t");
            }
            Console.WriteLine();
        }

        double maxA = A[0];
        double maxB = B[0, 0];
        foreach (double item in A)
        {
            if (item > maxA)
                maxA = item;
        }
        foreach (double item in B)
        {
            if (item > maxB)
                maxB = item;
        }
        double max = Math.Max(maxA, maxB);

        double minA = A[0];
        double minB = B[0, 0];
        foreach (double item in A)
        {
            if (item < minA)
                minA = item;
        }
        foreach (double item in B)
        {
            if (item < minB)
                minB = item;
        }
        double min = Math.Min(minA, minB);

        double sumA = 0;
        double sumB = 0;
        foreach (double item in A)
        {
            sumA += item;
        }
        foreach (double item in B)
        {
            sumB += item;
        }
        double sum = sumA + sumB;

        double productA = 1;
        double productB = 1;
        foreach (double item in A)
        {
            productA *= item;
        }
        foreach (double item in B)
        {
            productB *= item;
        }
        double product = productA * productB;

        double evenSumA = 0;
        foreach (double item in A)
        {
            if (item % 2 == 0)
                evenSumA += item;
        }

        double oddColumnSumB = 0;
        for (int j = 0; j < 4; j++)
        {
            if (j % 2 != 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    oddColumnSumB += B[i, j];
                }
            }
        }

        Console.WriteLine($"Максимальний елемент: {max}");
        Console.WriteLine($"Мінімальний елемент: {min}");
        Console.WriteLine($"Загальна сума елементів: {sum}");
        Console.WriteLine($"Загальний добуток елементів: {product}");
        Console.WriteLine($"Сума парних елементів масиву A: {evenSumA}");
        Console.WriteLine($"Сума непарних стовпців масиву B: {oddColumnSumB}");
    }
    static void Main(string[] args)
    {
        int[,] array = new int[5, 5];
        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                array[i, j] = random.Next(-100, 101);
            }
        }

        Console.WriteLine("Двовимірний масив:");
        PrintArray(array);

        int min = array[0, 0];
        int max = array[0, 0];
        int minRow = 0, minCol = 0, maxRow = 0, maxCol = 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (array[i, j] < min)
                {
                    min = array[i, j];
                    minRow = i;
                    minCol = j;
                }

                if (array[i, j] > max)
                {
                    max = array[i, j];
                    maxRow = i;
                    maxCol = j;
                }
            }
        }

        Console.WriteLine($"Мінімальний елемент: {min} (рядок {minRow + 1}, стовпець {minCol + 1})");
        Console.WriteLine($"Максимальний елемент: {max} (рядок {maxRow + 1}, стовпець {maxCol + 1})");

        int sum = 0;
        int startRow = Math.Min(minRow, maxRow) + 1;
        int endRow = Math.Max(minRow, maxRow);
        int startCol = Math.Min(minCol, maxCol) + 1;
        int endCol = Math.Max(minCol, maxCol);

        for (int i = startRow; i < endRow; i++)
        {
            for (int j = startCol; j < endCol; j++)
            {
                sum += array[i, j];
            }
        }

        Console.WriteLine($"Сума елементів між мінімальним і максимальним: {sum}");
    }
    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}