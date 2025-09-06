using System;
using System.Windows.Forms;

namespace KPOlab1
{
    public partial class Form1 : Form
    {
        private int[] array;
        public Form1()
        {
            InitializeComponent();            
        }     
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            GenerateArray();
            DisplayArray();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            CalculateAverage();
        }
        private void GenerateArray()
        {
            array = new int[15];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 31);
            }
        }
        private void DisplayArray()
        {
            labelArray.Text = "Массив: " + string.Join(", ", array);
        }

        private void CalculateAverage()
        {
            if (array == null)
            {
                MessageBox.Show("Сначала сгенерируйте массив!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int sum = 0;
            int count = 0;
            foreach (int number in array)
            {
                if (number > 0)
                {
                    sum += number;
                    count++;
                }
            }
            if (count > 0)
            {
                double average = (double)sum / count;
                labelResult.Text = $"Среднее арифметическое: {average:F2}";
            }
            else
            {
                labelResult.Text = "Нет положительных элементов";
            }
        }

        private double[] originalArray;
        private double[] resultArray;

        private void buttonInputArray_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxInput.Text))
                {
                    MessageBox.Show("Введите числа прежде чем создавать массив!", "Ошибка");
                    originalArray = null;
                    DisplayArrays();
                    return;
                }
                string[] numberStrings = textBoxInput.Text.Split(new char[] { ' ', ';' },
                                                  StringSplitOptions.RemoveEmptyEntries);
                originalArray = new double[numberStrings.Length];
                for (int i = 0; i < numberStrings.Length; i++)
                {
                    originalArray[i] = double.Parse(numberStrings[i]);
                    if (originalArray[i] <= 0)
                    {
                        MessageBox.Show("Все числа должны быть положительными!", "Ошибка");
                        originalArray = null;
                        return;
                    }
                }
                resultArray = null;
                DisplayArrays();
                MessageBox.Show($"Массив из {numberStrings.Length} чисел успешно введен!", "Успех");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка ввода: {ex.Message}\nИспользуйте запятую как десятичный разделитель", "Ошибка");
            }
        }

        private void buttonCalculate2_Click(object sender, EventArgs e)
        {
            if (originalArray == null || originalArray.Length == 0)
            {
                MessageBox.Show("Сначала введите массив!", "Ошибка");
                return;
            }
            CalculateFunction();
            DisplayArrays();
        }
        private void CalculateFunction()
        {
            resultArray = new double[originalArray.Length];
            for (int i = 0; i < originalArray.Length; i++)
            {
                resultArray[i] = 0.5 * originalArray[i];
            }
        }

        private void DisplayArrays()
        {
            if (originalArray == null)
            {
                labelOriginalArray.Text = "Исходный: -";
                labelResultArray.Text = "Результат: -";
                if (dataGridView2 != null)
                {
                    dataGridView2.Rows.Clear();
                    dataGridView2.Columns.Clear();
                }
                return;
            }
            labelOriginalArray.Text = "Исходный: " + string.Join(", ", originalArray.Select(x => x.ToString("F2")));
            if (resultArray != null)
            {
                labelResultArray.Text = "Результат: " + string.Join(", ", resultArray.Select(x => x.ToString("F2")));
            }
            DisplayInDataGridView();
        }

        private void DisplayInDataGridView()
        {
            if (dataGridView2 == null) return;
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add("Original", "x");
            dataGridView2.Columns.Add("Result", "y = 0.5x");
            for (int i = 0; i < originalArray.Length; i++)
            {
                int rowIndex = dataGridView2.Rows.Add();
                dataGridView2.Rows[rowIndex].Cells["Original"].Value = originalArray[i].ToString("F2");
                if (resultArray != null)
                {
                    dataGridView2.Rows[rowIndex].Cells["Result"].Value = resultArray[i].ToString("F2");
                }
            }
        }

        private int[,] originalArray2D;
        private int[,] convertedArray2D;

        private void buttonGenerate3_Click(object sender, EventArgs e)
        {
            Generate2DArray();
            Display2DArray(originalArray2D, "Исходный массив");
        }
        private void Generate2DArray()
        {
            Random random = new Random();
            int rows = random.Next(2, 11);
            int cols = random.Next(2, 11);
            originalArray2D = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    originalArray2D[i, j] = random.Next(-10, 11);
                }
            }
            convertedArray2D = null;
        }
        private void buttonConvert3_Click(object sender, EventArgs e)
        {
            if (originalArray2D == null)
            {
                MessageBox.Show("Сначала сгенерируйте массив!", "Ошибка");
                return;
            }
            ConvertArray();
            Display2DArray(convertedArray2D, "Преобразованный массив");
        }
        private void ConvertArray()
        {
            int rows = originalArray2D.GetLength(0);
            int cols = originalArray2D.GetLength(1);
            convertedArray2D = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (originalArray2D[i, j] > 0)
                    {
                        convertedArray2D[i, j] = 1;
                    }
                    else
                    {
                        convertedArray2D[i, j] = 0;
                    }
                }
            }
        }
        private void Display2DArray(int[,] array, string title)
        {
            if (dataGridView3 == null) return;
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();
            dataGridView3.AllowUserToAddRows = false;
            int cols = array.GetLength(1);
            for (int j = 0; j < cols; j++)
            {
                dataGridView3.Columns.Add($"col{j}", $"Столбец {j + 1}");
            }
            int rows = array.GetLength(0);
            for (int i = 0; i < rows; i++)
            {
                int rowIndex = dataGridView3.Rows.Add();
                for (int j = 0; j < cols; j++)
                {
                    dataGridView3.Rows[rowIndex].Cells[j].Value = array[i, j];
                    if (array[i, j] == 1)
                    {
                        dataGridView3.Rows[rowIndex].Cells[j].Style.BackColor = Color.LightGreen;
                    }
                    else if (array[i, j] == 0)
                    {
                        dataGridView3.Rows[rowIndex].Cells[j].Style.BackColor = Color.LightCoral;
                    }
                }
            }
            labelInfo3.Text = title;
        }

        private int[,] arrayA;
        private double[] columnAverages;
        private void buttonGenerate4_Click(object sender, EventArgs e)
        {
            GenerateArrayA();
            DisplayArrayA();
        }
        private void buttonCalculate4_Click(object sender, EventArgs e)
        {
            if (arrayA == null)
            {
                MessageBox.Show("Сначала сгенерируйте массив!", "Ошибка");
                return;
            }
            CalculateColumnAverages();
            DisplayAverages();
        }       
        private void GenerateArrayA()
        {
            Random random = new Random();
            int rows = random.Next(1,5); 
            int cols = random.Next(1,7); 
            arrayA = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {                    
                    arrayA[i, j] = random.Next(30, 76);
                }
            }
            columnAverages = null;
        }       
        private void CalculateColumnAverages()
        {
            int rows = arrayA.GetLength(0);
            int cols = arrayA.GetLength(1);
            columnAverages = new double[cols];
            for (int j = 0; j < cols; j++)
            {
                int sum = 0;
                for (int i = 0; i < rows; i++)
                {
                    sum += arrayA[i, j];
                }
                columnAverages[j] = (double)sum / rows;
            }
        }        
        private void DisplayArrayA()
        {
            if (dataGridView4 == null) return;
            dataGridView4.Rows.Clear();
            dataGridView4.Columns.Clear();
            dataGridView4.AllowUserToAddRows = false;
            int rows = arrayA.GetLength(0);
            int cols = arrayA.GetLength(1);            
            for (int j = 0; j < cols; j++)
            {
                dataGridView4.Columns.Add($"col{j}", $"Столбец {j + 1}");
                dataGridView4.Columns[j].Width = 60;
            }
            for (int i = 0; i < rows; i++)
            {
                int rowIndex = dataGridView4.Rows.Add();
                for (int j = 0; j < cols; j++)
                {
                    dataGridView4.Rows[rowIndex].Cells[j].Value = arrayA[i, j];
                    dataGridView4.Rows[rowIndex].Cells[j].Style.BackColor = Color.LightBlue;
                    dataGridView4.Rows[rowIndex].Cells[j].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            labelInfo4.Text = $"Массив A[1..{rows}, 1..{cols}] заполнен числами [30, 75]";
        }      
        private void DisplayAverages()
        {
            if (dataGridViewResults4 == null) return;
            dataGridViewResults4.Rows.Clear();
            dataGridViewResults4.Columns.Clear();
            dataGridViewResults4.AllowUserToAddRows = false;
            int cols = columnAverages.Length;            
            dataGridViewResults4.Columns.Add("Column", "Столбец");
            dataGridViewResults4.Columns.Add("Average", "Среднее арифметическое");
            dataGridViewResults4.Columns[0].Width = 80;
            dataGridViewResults4.Columns[1].Width = 150;
            for (int j = 0; j < cols; j++)
            {
                int rowIndex = dataGridViewResults4.Rows.Add();
                dataGridViewResults4.Rows[rowIndex].Cells["Column"].Value = $"Столбец {j + 1}";
                dataGridViewResults4.Rows[rowIndex].Cells["Average"].Value = columnAverages[j].ToString("F2");
                dataGridViewResults4.Rows[rowIndex].Cells["Average"].Style.BackColor = Color.LightGreen;
                dataGridViewResults4.Rows[rowIndex].Cells["Average"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }             
    }
}