using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace ДЗ_07._10._2023
{
    internal class Program
    {
        
        private static int[] GetVowelsAndСonsonantsCount(char[] text)
        {
            const string ENG_VOWELS = "aeiouy";
            int[] vowelsAndСonsonantsCounters = new int[2] { 0, 0 };

            for (int i = 0; i < text.Length; i++)
            {
                if (ENG_VOWELS.Contains(char.ToLower(text[i]).ToString()))
                {
                    vowelsAndСonsonantsCounters[0]++;
                }
                else
                {
                    vowelsAndСonsonantsCounters[1]++;
                }
            }

            return vowelsAndСonsonantsCounters;
        }
        static void ReadMonthAvg(Dictionary<string, double> month_avg)
        {
            foreach (var month in month_avg)
            {
                Console.WriteLine($"В {month.Key} средняя температура была {month.Value:F}");
            }
        }
        static void DoExercise3()
        {
            Console.WriteLine("Упражнение 3 - вычислить среднюю температуру за месяц");

            Random rnd = new Random();
            int[,] temp = new int[12, 30];
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    temp[i, j] = rnd.Next(-50, 50);
                }
            }
            double[] CalculateAverageTemperature(int[,] temp1)
            {
                int sum = 0;
                double[] month_avg1 = new double[12];
                for (int i = 0; i < 12; i++)
                {
                    sum = 0;
                    for (int j = 0; j < 30; j++)
                    {
                        sum += temp[i, j];
                    }
                    month_avg1[i] = sum / 30;
                }
                return month_avg1;
            }
            double[] month_avg = CalculateAverageTemperature(temp);
            Array.Sort(month_avg);
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"Средняя температура в месяце {month_avg[i]}");
            }
            Console.WriteLine("");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Найти количество гласных и согласных букв в файле");
            FileInfo userFile = new FileInfo(args[0]);
            if (userFile.Exists)
            {

                char[] inputFileText = File.ReadAllText(args[0], Encoding.UTF8).ToCharArray();
                int[] inputTextVowelsAndСonsonantsCounters = GetVowelsAndСonsonantsCount(inputFileText);


                Console.WriteLine("Количество гласных букв в тексте: {0}", inputTextVowelsAndСonsonantsCounters[0]);
                Console.WriteLine("Количество согласных букв в тексте: {0}", inputTextVowelsAndСonsonantsCounters[1]);


                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Файл не найден");
            }
            
            Dictionary<string, double> CalculateAverageTemperature(Dictionary<string, int[]> year1)
            {
                Dictionary<string, double> month_avg = new Dictionary<string, double>();

                foreach (var month in year1)
                {
                    int sum = 0;
                    for (int i = 0; i < month.Value.Length; i++)
                    {
                        sum += month.Value[i];
                    }

                    month_avg.Add(month.Key, sum / month.Value.Length);
                }
                return month_avg;
            }
            void ReadMonthAvg(Dictionary<string, double> month_avg)
            {
                foreach (var month in month_avg)
                {
                    Console.WriteLine($"В {month.Key} средняя температура была {month.Value:F}");
                }
            }
            Random rnd = new Random();

            Console.WriteLine("Домашнее задание 3 - считаем среднюю температуру за месяц");

            Dictionary<string, double> month_average = new Dictionary<string, double>();
            Dictionary<string, int[]> year = new Dictionary<string, int[]>();

            for (int i = 0; i < 12; i++)
            {
                int[] month = new int[30];
                for (int j = 0; j < 30; j++)
                {
                    month[j] = rnd.Next(-50, 50);
                }
                switch (i)
                {
                    case 0:
                        year.Add("Январь", month);
                        break;
                    case 1:
                        year.Add("Февраль", month);
                        break;
                    case 2:
                        year.Add("Март", month);
                        break;
                    case 3:
                        year.Add("Апрель", month);
                        break;
                    case 4:
                        year.Add("Май", month);
                        break;
                    case 5:
                        year.Add("Июнь", month);
                        break;
                    case 6:
                        year.Add("Июль", month);
                        break;
                    case 7:
                        year.Add("Август", month);
                        break;
                    case 8:
                        year.Add("Сентябрь", month);
                        break;
                    case 9:
                        year.Add("Октябрь", month);
                        break;
                    case 10:
                        year.Add("Ноябрь", month);
                        break;
                    case 11:
                        year.Add("Декабрь", month);
                        break;
                    }
            }
                month_average = CalculateAverageTemperature(year);
                ReadMonthAvg(month_average);

        }
            

        
    }
}

