using System;
using System.Collections.Generic;
using System.IO;

namespace DataLibrary
{
    public class DataManager
    {
        private readonly string filePath;

        public DataManager(string filePath)
        {
            this.filePath = filePath;
        }

        // Сохранение данных в файл
        public void SaveData(List<string> data)
        {
            File.WriteAllLines(filePath, data);
        }

        // Загрузка данных из файла
        public List<string> LoadData()
        {
            if (!File.Exists(filePath))
                return new List<string>();

            return new List<string>(File.ReadAllLines(filePath));
        }

        // Обработка параметров через ref
        public void ModifyData(ref string input)
        {
            input = input.ToUpper(); 
        }
    }
}
