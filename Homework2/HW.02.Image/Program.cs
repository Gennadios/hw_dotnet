using System;
using System.IO;

namespace HW._02.Image
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Создаем экземпляр класса StreamReader для чтения файла c выполнением поиска меток порядка байтов с начала файла
            // 2. Сохраняем результаты чтения файла в переменной типа string
            // 3. Разбиваем строку из п.2 на основе разделителя ' ', сохраняем подстроки в строчном массиве
            // 4. Выделяем в памяти место под байтовый массив, число элементов которого равно числу элементов строчного массива из п.3
            // 5. Каждый элемент текстового массива из п.3 последовательно интерпретируем в двоичном виде, значения последовательно сохраняем в байтовый массив, созданные в п.4
            // 6. Создаём новый файл в формате .png, в который записываем получившийся байтовый массив
            // 7. Освобождаем ресурсы, удерживаемые объектом StreamReader

            StreamReader textReader = new StreamReader(@"C:\Temp\image.txt", true);

            string textReaderResult = textReader.ReadToEnd();
            string[] arrayOfTextResult = textReaderResult.Split(' ');
            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];

            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;
            }

            File.WriteAllBytes(@"C:\Temp\image.png", imageBytes);
            textReader.Dispose();
        }
    }
}
