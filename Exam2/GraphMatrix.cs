using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Exam2
{
    internal class GraphMatrix
    {
        // Матрица смежности графа
        private List<List<int>> matrix;

        // Свойства матрицы
        public int this[int index1, int index2]
        {
            get => matrix[index1][index2];
            set => matrix[index1][index2] = value;
        }
        public int Count { get => matrix.Count; }

        public GraphMatrix() => matrix = new List<List<int>>();

        // Получеие целочисленного массива из строкового
         private int[] StringToInt(string[] str)
         {
             int[] result = new int[str.Length];
             for (int i = 0; i < str.Length; i++)
                 result[i] = Convert.ToInt32(str[i]);
             return result;
         }

        // Чтение матрицы из файла
        public void FromFile(string path)
        {
            matrix.Clear();
            string line;
            using (StreamReader sr = new StreamReader(path))
                while ((line = sr.ReadLine()) != null)
                    matrix.Add(new List<int>(StringToInt(line.Split(' '))));
        }

        // Чтение матрицы из формы
        public void FromForm(RichTextBox Tb)
        {
            string str = Tb.Text;
            matrix.Clear();
            if (str != "")
            {
                string[] text2 = str.Split('\n');
                for (int i = 0; i < text2.Length; i++)
                {
                    str = text2[i];
                    matrix.Add(new List<int>(StringToInt(str.Split(' '))));
                }
            }
            else return;
        }

        // Перевод матрицы в строку для вывода
        override public string ToString()
        {
            string result = "";
            for (int i = 0; i < matrix.Count; ++i)
            {
                for (int j = 0; j < matrix[i].Count; ++j)
                {
                    if (matrix[i][j] >= 0 && matrix[i][j] < 10)
                        result += "  " + matrix[i][j].ToString() + " ";
                    else if (matrix[i][j] > 9)
                        result += matrix[i][j].ToString() + " ";
                }
                result += "\n";
            }
            return result;
        }

        //Алгоритм Прима 
        public string Primm()
        {
            int no_edge = 0;
            int[] selected = new int[matrix.Count];
            selected[0] = 1;
            int x;
            int y;
            string result = "Ребро :  Вес \n";
            while (no_edge < matrix.Count - 1)
            {
                int min = 999999;
                x = 0;
                y = 0;
                for (int i = 0; i < matrix.Count; i++)
                {
                    if (selected[i] != 0)
                    {
                        for (int j = 0; j < matrix.Count; j++)
                        {
                            if (selected[j] == 0 && matrix[i][j] != 0)
                            {
                                if (min > matrix[i][j])
                                {
                                    min = matrix[i][j];
                                    x = i;
                                    y = j;
                                }

                            }
                        }
                    }
                }
                result += " " + x + " - " + y + "    :    " + matrix[x][y] + '\n';
                selected[y] = 1;
                no_edge++;
            }
            return result;
        }
    }
}
