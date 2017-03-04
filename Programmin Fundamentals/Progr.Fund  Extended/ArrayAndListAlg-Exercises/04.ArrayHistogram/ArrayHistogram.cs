using System;
using System.Linq;

public class ArrayHistogram
{
    public static void Main()
    {
        //80/100
        var lineArgs = Console.ReadLine().Split().ToArray();

        var words = new string[lineArgs.Length];
        var wordsCount = new int[lineArgs.Length];
        var count = -1;

        for (int i = 0; i < lineArgs.Length; i++)
        {
            if (!words.Contains(lineArgs[i]))
            {
                count++;
                words[count] = lineArgs[i];
                wordsCount[count]++;
                continue;
            }

            var index = -1;
            for (int j = 0; j < words.Length; j++)
            {
                if (words[j] == lineArgs[i])
                {
                    index = j;
                    break;
                }
            }

            wordsCount[index]++;
        }

        for (int i = 0; i < wordsCount.Length; i++)
        {
            for (int j = 0; j < wordsCount.Length; j++)
            {
                if (wordsCount[i] == 0 || wordsCount[j] == 0)
                {
                    break;
                }

                if (wordsCount[j] < wordsCount[i])
                {
                    var temp = wordsCount[j];
                    wordsCount[j] = wordsCount[i];
                    wordsCount[i] = temp;
                    var tempWord = words[j];
                    words[j] = words[i];
                    words[i] = tempWord;
                }
            }
        }

        for (int i = 0; i < words.Length; i++)
        {
            if (wordsCount[i] == 0)
            {
                return;
            }

            if (i + 1 < words.Length)
            {
                if (wordsCount[i] == wordsCount[i + 1])
                {
                    var indexFirstElement = lineArgs.ToList().IndexOf(words[i]);
                    var indexecondElement = lineArgs.ToList().IndexOf(words[i + 1]);
                    if (indexecondElement < indexFirstElement)
                    {
                        var temp = words[i];
                        words[i] = words[i + 1];
                        words[i + 1] = temp;
                    }
                }
            }



            Console.WriteLine($"{words[i]} -> {wordsCount[i]} times ({wordsCount[i] * 100.0 / lineArgs.Length:f2}%)");
        }
    }
}

