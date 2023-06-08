// Вторая программа:
// 1. Считывает путь к файлу из %AppData%/Lesson12Homework.txt
// 2. Открывает указанный файл .csv
// 3. Выводит в консоль список файлов, прочитанный из файла csv, отсортированный по дате изменения
// 4. Удаляет файл %AppData%/Lesson12Homework.txt
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;

namespace ConsoleApp4
{
private static void Main(string[] args)
    {
        try
        {
            //Считывает путь к файлу из %AppData%/Lesson12Homework.txt
            string csvPath = "";
            using (var txtReader = new StreamReader("% AppData %/ Lesson12Homework.txt"))
            {
                csvPath = txtReader.ReadToEnd();
            }

            //Открывает указанный файл .csv
            var csvConfiguration = new CsvConfiguration(CultureInfo.InvariantCulture)
            { Delimiter = "\t", Encoding = Encoding.UTF8 };
            using (var streamReader = new StreamReader(csvPath))
            using (var csvReader = new CsvReader(streamReader, csvConfiguration))
            {
                var fileRecords = csvReader.GetRecords<FileRecord>();
                fileRecords.ToList();

                //Выводит в консоль список файлов, прочитанный из файла csv, отсортированный по дате изменения
                foreach (var item in fileRecords.OrderByDescending(item => item.LastChanges))
                {
                    Console.WriteLine($"{item.Type}, {item.Title}, {item.Path}, {item.LastChanges}");
                }
            }

            //Удаляет файл %AppData%/Lesson12Homework.txt
            Directory.Delete("% AppData %/ Lesson12Homework.txt");
        }
        catch (DirectoryNotFoundException) { Console.WriteLine("Директорий не найден"); }
        catch (FileNotFoundException) { Console.WriteLine("Файл не найден"); }
        catch (InvalidDataException) { Console.WriteLine("Некоректные данные"); }
    }
}

