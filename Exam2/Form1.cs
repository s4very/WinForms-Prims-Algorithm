using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Exam2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!File.Exists("in.txt"))
            {
                FileStream fs = new FileStream("in.txt", FileMode.Create);
                fs.Close();
            }
        }

        GraphMatrix matrix = new GraphMatrix();
        string result;

        // Метод вызывающий метод чтения из матрицы
        private void DoSomething_Click(object sender, EventArgs e)
        {
            if (sender == WriteToFileButton)
                WriteToFile();
            else
            {
                if (sender == FromFileButton)
                    matrix.FromFile("in.txt");
                if (sender == FromFormButton)
                    matrix.FromForm(Textbox123);
                MatrixLabel.Text = matrix.ToString();
                if (matrix.Count != 0)
                    label3.Text = result = matrix.Primm();
                else
                    MessageBox.Show("Ошибка! Пустая матрица");
            }
        }

        // Запись результата в файл
        private void WriteToFile()
        {
            using (StreamWriter writer = new StreamWriter("out.txt", false))
            {
                if (matrix.Count != 0)
                    writer.Write(result);
                else
                    MessageBox.Show("Ошибка! Пустая матрица");
            }
        }
    }
}