using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DynamicFunctions;

namespace MaSureApox
{
    public partial class FormMain : Form
    {
        private double[] result;
        private double[,] xyTable, matrix;
        //new
        private double[,] xyTableLineral;
        private alglib.spline1dinterpolant c;
        private double[] xDoubles;
        private double[] yDoubles;

        public FormMain()
        {
            InitializeComponent();
        }

        private void TableRemake()
        {
            dataGridTable.RowCount = Convert.ToInt32(numericUpDownCount.Value);
            for (int i = 0; i < dataGridTable.RowCount; i++)
            {
                dataGridTable[0, i].ValueType = System.Type.GetType("System.Double");
                dataGridTable[1, i].ValueType = System.Type.GetType("System.Double");
                if (Convert.ToString(dataGridTable[0, i].Value) == "")
                    dataGridTable[0, i].Value = 0;
                if (Convert.ToString(dataGridTable[1, i].Value) == "")
                    dataGridTable[1, i].Value = 0;
            }
        }

        private void TableRemake1()
        {
            dataGridTable1.RowCount = Convert.ToInt32(nudCount.Value);
            for (int i = 0; i < dataGridTable1.RowCount; i++)
            {
                dataGridTable1[0, i].ValueType = System.Type.GetType("System.Double");
                dataGridTable1[1, i].ValueType = System.Type.GetType("System.Double");
                if (Convert.ToString(dataGridTable1[0, i].Value) == "")
                    dataGridTable1[0, i].Value = 0;
                if (Convert.ToString(dataGridTable1[1, i].Value) == "")
                    dataGridTable1[1, i].Value = 0;
            }
        }

        //решение системы методом Гаусса
        private double[] Gauss(double[,] matrix, int rowCount, int colCount)
        {
            int i;
            int[] mask = new int[colCount - 1];
            for (i = 0; i < colCount - 1; i++) mask[i] = i;
            if (GaussDirectPass(ref matrix, ref mask, colCount, rowCount))
            {
                double[] answer = GaussReversePass(ref matrix, mask, colCount, rowCount);
                return answer;
            }
            else return null;
        }

        //Гаусс
        private bool GaussDirectPass(ref double[,] matrix, ref int[] mask,
            int colCount, int rowCount)
        {
            int i, j, k, maxId, tmpInt;
            double maxVal, tempDouble;
            for (i = 0; i < rowCount; i++)
            {
                maxId = i;
                maxVal = matrix[i, i];
                for (j = i + 1; j < colCount - 1; j++)
                    if (Math.Abs(maxVal) < Math.Abs(matrix[i, j]))
                    {
                        maxVal = matrix[i, j];
                        maxId = j;
                    }
                if (maxVal == 0) return false;
                if (i != maxId)
                {
                    for (j = 0; j < rowCount; j++)
                    {
                        tempDouble = matrix[j, i];
                        matrix[j, i] = matrix[j, maxId];
                        matrix[j, maxId] = tempDouble;
                    }
                    tmpInt = mask[i];
                    mask[i] = mask[maxId];
                    mask[maxId] = tmpInt;
                }
                for (j = 0; j < colCount; j++) matrix[i, j] /= maxVal;
                for (j = i + 1; j < rowCount; j++)
                {
                    double tempMn = matrix[j, i];
                    for (k = 0; k < colCount; k++)
                        matrix[j, k] -= matrix[i, k] * tempMn;
                }
            }
            return true;
        }

        //Гаусс
        private double[] GaussReversePass(ref double[,] matrix, int[] mask,
            int colCount, int rowCount)
        {
            int i, j, k;
            for (i = rowCount - 1; i >= 0; i--)
                for (j = i - 1; j >= 0; j--)
                {
                    double tempMn = matrix[j, i];
                    for (k = 0; k < colCount; k++)
                        matrix[j, k] -= matrix[i, k] * tempMn;
                }
            double[] answer = new double[rowCount];
            for (i = 0; i < rowCount; i++) answer[mask[i]] = matrix[i, colCount - 1];
            return answer;
        }

        //Генерирует СЛАУ
        private double[,] MakeSystem(double[,] xyTable, int basis)
        {
            double[,] matrix = new double[basis, basis + 1];
            for (int i = 0; i < basis; i++)
            {
                for (int j = 0; j < basis; j++)
                {
                    matrix[i, j] = 0;
                }
            }
            for (int i = 0; i < basis; i++)
            {
                for (int j = 0; j < basis; j++)
                {
                    double sumA = 0, sumB = 0;
                    for (int k = 0; k < dataGridTable.RowCount; k++)
                    {
                        sumA += Math.Pow(xyTable[0, k], i) * Math.Pow(xyTable[0, k], j);
                        sumB += xyTable[1, k] * Math.Pow(xyTable[0, k], i);
                    }
                    matrix[i, j] = sumA;
                    matrix[i, basis] = sumB;
                }
            }
            return matrix;
        }

        //Перестройка таблицы
        private void numericUpDownCount_ValueChanged(object sender, EventArgs e)
        {
            TableRemake();
            numericUpDownBasis.Maximum = numericUpDownCount.Value - 1;
        }

        //Загрузка формы
        private void FormMain_Load(object sender, EventArgs e)
        {
            TableRemake();
            TableRemake1();
        }

        //Проверка на ошибки
        private void dataGridTable_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введенное значение не является вещественным числом");
        }

        //Очистка таблицы
        private void buttonClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridTable.RowCount; i++)
            {
                dataGridTable[0, i].Value = 0;
                dataGridTable[1, i].Value = 0;
            }
            matrix = null;
            result = null;
            xyTable = null;
        }

        //Подсчет
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            xyTable = new double[2, dataGridTable.RowCount];
            try
            {
                for (int i = 0; i < dataGridTable.RowCount; i++)
                {
                    xyTable[0, i] = Convert.ToDouble(dataGridTable[0, i].Value);
                    xyTable[1, i] = Convert.ToDouble(dataGridTable[1, i].Value);
                }
            }
            catch
            {
                MessageBox.Show("Одно из введенных в таблицу значений не является" +
                    "вещественным числом");
                richTextBoxResult.Select();
                SendKeys.Send("^{END}");
                return;
            }
            int basis = Convert.ToInt32(numericUpDownBasis.Value) + 1;
            matrix = MakeSystem(xyTable, basis);
            richTextBoxResult.Text += "---\nСоставляем систему уравнений:\n";
            for (int i = 0; i < basis; i++)
            {
                for (int j = 0; j < basis; j++)
                {
                    richTextBoxResult.Text += ((matrix[i, j] > 0) ? "+" : "") +
                        Math.Round(matrix[i, j], 3).ToString() + "*c" + j.ToString() + " ";
                }
                richTextBoxResult.Text += " = " + matrix[i, basis] + "\n";
            }
            result = Gauss(matrix, basis, basis + 1);
            if (result == null)
            {
                richTextBoxResult.Text += "Невозможно найти частное решение составленной системы уравнений\n";
                richTextBoxResult.Select();
                SendKeys.Send("^{END}");
                return;
            }
            richTextBoxResult.Text += "Решение системы уравнений:\n";
            for (int i = 0; i < basis; i++)
            {
                richTextBoxResult.Text += "C" + i.ToString() + " = " + Math.Round(result[i], 3).ToString() + "\n";
            }
            richTextBoxResult.Text += "Таким образом, среднеквадратичное приближение:\ny = ";
            for (int i = 0; i < basis; i++)
            {
                if (Math.Round(result[i], 3) != 0)
                    richTextBoxResult.Text += ((result[i] > 0) ? "+" : "") +
                        Math.Round(result[i], 3).ToString() + ((i > 0) ? "*x^" + i.ToString() : "") + " ";
            }
            richTextBoxResult.Text += "\n";
            richTextBoxResult.Select();
            SendKeys.Send("^{END}");
        }

        //ПОдсчет точного значения
        private void buttonCalcX_Click(object sender, EventArgs e)
        {
            int basis = Convert.ToInt32(numericUpDownBasis.Value) + 1;
            if (result == null)
            {
                richTextBoxResult.Text += "Еще не вычислено среднеквадратичное приближение\n";
                richTextBoxResult.Select();
                SendKeys.Send("^{END}");
                return;
            }
            double x;
            try
            {
                x = Convert.ToDouble(textBoxX.Text);
            }
            catch
            {
                MessageBox.Show("Введенное значение x не является вещественным числом");
                richTextBoxResult.Select();
                SendKeys.Send("^{END}");
                return;
            }
            double y = 0;
            for (int i = 0; i < basis; i++)
            {
                y += result[i] * Math.Pow(x, i);
            }
            richTextBoxResult.Text += "f(" + x.ToString() + ") = " + Math.Round(y, 5).ToString() + " \n";
            richTextBoxResult.Select();
            SendKeys.Send("^{END}");
        }

        //NEW--------------------------------//
        //Calculate lineral spline


        //основная функция
        private void CalcLineralSpline(double[] x, double[] y)
        {
            int n = 0;
            double[,] tbl;
            alglib.spline1dbuildlinear(x,y,out c);
            richTextBoxResult.Text += "---\nПосчитал динейный сплайн\n";
            //alglib.spline1dunpack(c,out n,out tbl);
            //richTextBoxResult.Text += "---\n N= "+n.ToString()+" TABLE :\n";
            //for (int i = 0; i < nudCount.Value-1; i++)
            //{
            //    for (int j = 0; j < 6; j++)
            //    {
            //        richTextBoxResult.Text += "T["+i.ToString()+","+j.ToString()+"]= "+tbl[i,j] + "\n";
            //    }
            //}
            //foreach (double d in tbl)
            //{
            //    richTextBoxResult.Text += "d= " + d.ToString() + " ";
            //}
            //richTextBoxResult.Text += 
        }

        //рассчет
        private void button3_Click(object sender, EventArgs e)
        {
            //xyTableLineral = new double[2,dataGridTable1.RowCount];
            xDoubles = new double[dataGridTable1.RowCount];
            yDoubles = new double[dataGridTable1.RowCount];
            try
            {
                for (int i = 0; i < dataGridTable1.RowCount; i++)
                {
                    xDoubles[i] = Convert.ToDouble(dataGridTable1[0, i].Value);
                    yDoubles[i] = Convert.ToDouble(dataGridTable1[1, i].Value);
                    //xyTableLineral[0, i] = Convert.ToDouble(dataGridTable1[0, i].Value);
                    //xyTableLineral[1, i] = Convert.ToDouble(dataGridTable1[1, i].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            CalcLineralSpline(xDoubles,yDoubles);
        }

        //перестройка таблицы
        private void nudCount_ValueChanged(object sender, EventArgs e)
        {
            TableRemake1();
            nudBasis.Maximum = nudCount.Value - 1;
        }

        //проверка на провильность ввода
        private void dataGridTable1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введенное значение не является вещественным числом");
        }

        //очистка
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridTable1.RowCount; i++)
            {
                dataGridTable1[0, i].Value = 0;
                dataGridTable1[1, i].Value = 0;
            }
        }

        //подсчет конкретного значения
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(tbVal.Text);
                double d = alglib.spline1dcalc(c, x);
                richTextBoxResult.Text += "---\n f(" + x.ToString() + ")=" + d.ToString() + " \n";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Построение графика
        private void button4_Click(object sender, EventArgs e)
        {
            int basis = Convert.ToInt32(numericUpDownBasis.Value) + 1;
            double[] xKvadr = new double[dataGridTable.RowCount];
            double[] yKvadr = new double[dataGridTable.RowCount];
            double[] xLiner = new double[dataGridTable1.RowCount];
            double[] yLiner = new double[dataGridTable1.RowCount];

            try
            {
                double[] x1 = new double[dataGridTable.RowCount];
                double[] y1 = new double[dataGridTable.RowCount];
                try
                {
                    for (int i = 0; i < dataGridTable.RowCount; i++)
                    {
                        x1[i] = Convert.ToDouble(dataGridTable[0, i].Value);
                        y1[i] = Convert.ToDouble(dataGridTable[1, i].Value);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                double step = Calc();
                for (int i = 0; i < dataGridTable.RowCount; i++)
                {
                    double d = Convert.ToDouble(dataGridTable[0, i].Value);
                    double y = 0;
                    for (int j = 0; j < basis; j++)
                    {
                        y += result[j]*Math.Pow(d, j);
                    }
                    xKvadr[i] = d;
                    yKvadr[i] = y;
                }
                for (int i = 0; i < dataGridTable1.RowCount; i++)
                {
                    double d = Convert.ToDouble(dataGridTable[0, i].Value);
                    double y = alglib.spline1dcalc(c, d);
                    xLiner[i] = d;
                    yLiner[i] = y;
                }
                Graphic graphic = new Graphic(x1, y1, xKvadr, yKvadr, xLiner, yLiner); 
                graphic.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private double Calc()
        {
            double step = 0;
            double tmp = Convert.ToDouble(dataGridTable[0, 0].Value);
            double tmp2 = Convert.ToDouble(dataGridTable[0, 1].Value);
            step = Math.Abs(tmp - tmp2);
            return step;
        }

        //Получаем пары X Y для заданного отрезка
        private void bCalc_Click(object sender, EventArgs e)
        {
            if ((nudMax.Value == 0) && (nudMin.Value == 0))
            {
                MessageBox.Show("Укажите точки минимума и максимума");
                return;
            }
            if (Convert.ToDouble(tbStep.Text) == 0)
            {
                MessageBox.Show("Шаг равен 0!!!");
                return;
            }

            int a =(int) nudMin.Value;
            int b = (int) nudMax.Value;
            double step = 0;

            try
            {
                step = Convert.ToDouble(tbStep.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            List<double> myXList = new List<double>();
            List<double> myYList = new List<double>();

            for (double i = a; i <= b; i+=step)
            {
                //myXList.Add(i);
                //double tmp = Math.Cos((Math.PI*i)/6);
                //tmp = Math.Round(tmp, 3); //округление дроби
                //myYList.Add(tmp);
                myXList.Add(i);
                double tmp = AutoFunc(i);
                tmp = Math.Round(tmp,3);
                myYList.Add(tmp);
            }

            //перестройка и автозаполнение таблицы
            dataGridTable.RowCount = myXList.Count;
            dataGridTable1.RowCount = myXList.Count;
            numericUpDownCount.Value = myXList.Count;
            nudCount.Value = myXList.Count;
            for (int i = 0; i < dataGridTable.RowCount; i++)
            {
                dataGridTable[0, i].ValueType = System.Type.GetType("System.Double");
                dataGridTable[1, i].ValueType = System.Type.GetType("System.Double");
                dataGridTable[0, i].Value = myXList.ElementAt(i);
                dataGridTable[1, i].Value = myYList.ElementAt(i);
                dataGridTable1[0, i].ValueType = System.Type.GetType("System.Double");
                dataGridTable1[1, i].ValueType = System.Type.GetType("System.Double");
                dataGridTable1[0, i].Value = myXList.ElementAt(i);
                dataGridTable1[1, i].Value = myYList.ElementAt(i);
            }

            using (StreamWriter sw = new StreamWriter("x_y.txt"))
            {
                sw.WriteLine("X------------Y");
                sw.WriteLine();
                for (int i = 0; i < myXList.Count; i++)
                {
                    sw.WriteLine(myXList.ElementAt(i) + "------------"+myYList.ElementAt(i));
                    sw.WriteLine();
                }
                sw.Close();
            }
            MessageBox.Show("Файл успешно создан - x_y.txt");
        }

        private double AutoFunc(double x)
        {
            DynamicFunctions.DynamicFunctionsClass dfc = new DynamicFunctionsClass();
            string code = dfc.ConvertText2Code(tbFunc.Text);
            return dfc.MakeDynamicFunction(code,x.ToString());
        }

        private void bHelp_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }
    }
}
