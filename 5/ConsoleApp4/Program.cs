// Первая из программ совершает следующие действия:
// 1. Распаковывает архив в папку рядом с запускаемым файлом программы
// 2. Считывает названия файлов и папок из указанной папки
// 3. Записывает информацию о содержимом папки (тип (файл/папка), название, дата
// изменения) в текстовый файл в формате .csv (разделитель – \t (знак табуляции) )
// 4. Удаляет папку с распакованным архивом
// 5. Сохраняет путь к файлу csv в файле %AppData%/Lesson12Homework.txt

namespace ConsoleApp4;
static void Main(string[] args)
{
    try
    {
        //Распаковывает архив в папку рядом с запускаемым файлом программы
        string zipPath = @"D\";
        string extractPath = @"D\";
        ZipFile.ExtractToDirectory(zipPath, extractPath);

        //Считывает названия файлов и папок из указанной папки
        var directory = new DirectoryInfo(extractPath);
        var files = directory.GetFiles();

        //Записывает информацию о содержимом папки в текстовый файл в формате .csv
        var csvRecord = files.Select(u => new
        {
            Title = u.Name,
            Type = u.Extension.TrimStart('.'),
            Path = u.FullName,
            LastChanges = u.LastWriteTime
        });
        var csvConfiguration = new CsvConfiguration(CultureInfo.InvariantCulture)
        { Delimiter = "\t", Encoding = Encoding.UTF8 };
        using (var streamWriter = new StreamWriter(Path.Combine(extractPath, "fileRedord.csv")))
        using (var csvWriter = new CsvWriter(streamWriter, csvConfiguration))
        {
            csvWriter.WriteRecords(csvRecord);
        }

        //Удаляет папку с распакованным архивом
        Directory.Delete(extractPath);

        //Сохраняет путь к файлу csv в файле %AppData%/Lesson12Homework.txt
        using (StreamWriter txtWriter = new StreamWriter("%AppData%/Lesson12Homework.txt", false))
        {
            txtWriter.WriteLine(Path.Combine(extractPath, "fileRecord.csv"));
        }
    }
    catch (DirectoryNotFoundException) { Console.WriteLine("Директорий не найден"); }
    catch (FileNotFoundException) { Console.WriteLine("Файл не найден"); }
    catch (InvalidDataException) { Console.WriteLine("Некоректные данные"); }

}