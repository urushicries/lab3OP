using System;
using System.Collections.Generic;

namespace lab10
{
    // Класс с простым индексатором
    public class SimpleIndexer
    {
        private int[] numbers = new int[10];

        // Индексатор для доступа к элементам массива
        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < numbers.Length)
                    return numbers[index];
                throw new IndexOutOfRangeException("Invalid index");
            }
            set
            {
                if (index >= 0 && index < numbers.Length)
                    numbers[index] = value;
                else
                    throw new IndexOutOfRangeException("Invalid index");
            }
        }
    }

    // Класс с индексатором для двумерного массива
    public class MultiParamIndexer
    {
        private string[,] matrix = new string[3, 3];

        // Индексатор для доступа к двумерному массиву
        public string this[int row, int col]
        {
            get
            {
                if (row >= 0 && row < 3 && col >= 0 && col < 3)
                    return matrix[row, col];
                throw new IndexOutOfRangeException("Invalid index");
            }
            set
            {
                if (row >= 0 && row < 3 && col >= 0 && col < 3)
                    matrix[row, col] = value;
                else
                    throw new IndexOutOfRangeException("Invalid index");
            }
        }
    }

    // Класс с индексатором для работы с коллекцией List<T>
    public class ListIndexer
    {
        private List<string> items = new List<string>();

        // Индексатор для работы с коллекцией
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < items.Count)
                    return items[index];
                throw new IndexOutOfRangeException("Invalid index");
            }
            set
            {
                if (index >= 0 && index < items.Count)
                    items[index] = value;
                else
                    throw new IndexOutOfRangeException("Invalid index");
            }
        }

        // Метод для добавления элементов в коллекцию
        public void Add(string item)
        {
            items.Add(item);
        }
    }
}
