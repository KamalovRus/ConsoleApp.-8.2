using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Task8_2
{
    public static void Main(string[] args)
    {
        CreateFileWithRandomNumbers("C:/Users/Рустем/source/Для 8.1/С флэшки/Текстовый файл/Фильм/Фотки/1.txt");
        ReadandSumFileWithRandomNumbers("C:/Users/Рустем/source/Для 8.1/С флэшки/Текстовый файл/Фильм/Фотки/1.txt");
    }
    public static void CreateFileWithRandomNumbers(string path)
    {
        Random r = new Random();
        try
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (StreamWriter sw = File.CreateText(path))
            {
                string[] temp = new string[10];
                for (int i = 0; i < 10; i++)
                {
                    temp[i] = r.Next(1, 101).ToString();
                }
                sw.WriteLine(String.Join(" ", temp));
            }

        }
        catch (Exception Ex)
        {
            Console.WriteLine(Ex.ToString());
        }
    }
    public static void ReadandSumFileWithRandomNumbers(string path)
    {
        using (StreamReader sr = File.OpenText(path))
        {
            List<int> list = new List<int>();
            string s = "";
            s = sr.ReadLine();
            Console.WriteLine(s);
            string[] number = s.Split(' ');
            foreach (var item in number)
            {
                list.Add(Convert.ToInt32(item));
            }
            Console.WriteLine(list.Sum());
            Console.ReadKey();

        }
    }
}