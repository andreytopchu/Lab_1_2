using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Labs
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            findRootsButton.Enabled = false;
        }

        private double Func(double x)
        {
            return Math.Sqrt(Math.Sin(x)) - 0.5;
        }

        private void buildGraphButton_Click(object sender, EventArgs e)
        {
            if (aBoundValue.Text == string.Empty)
            {
                aBoundValue.Text = "-10";
            }

            if (bBoundValue.Text == string.Empty)
            {
                bBoundValue.Text = "10";
            }

            if (epsBoundValue.Text == string.Empty)
            {
                epsBoundValue.Text = "0,1";
            }

            graph.Series[0].Points.Clear();

            double eps ;
            var x = double.NaN;
            var b = double.NaN;
            var y = double.NaN;
            
            if (!double.TryParse(epsBoundValue.Text, out eps) || 
                !double.TryParse(aBoundValue.Text, out x) ||
                !double.TryParse(bBoundValue.Text, out b))
            {
                Error();
            }

            x = Convert.ToDouble(aBoundValue.Text);
            b = Convert.ToDouble(bBoundValue.Text);
            eps = Convert.ToDouble(epsBoundValue.Text);
            
            double y_tmp; //переменная в которую будет сохраняться значение y в прошлой итерации
            var roots = new List<double>();

            while (x <= b)
            {
                y_tmp = y;
                y = Func(x);
                graph.Series[0].Points.AddXY(x, y);

                if (y * y_tmp < 0)
                {
                    if (Math.Abs(y) < Math.Abs(y_tmp))
                    {
                        roots.Add(x);
                    }
                    else
                    {
                        roots.Add(x - eps);
                    }
                }

                x += eps;
            }

            InsertDataIntoDataGrid(0, roots);

            findRootsButton.Enabled = true;
        }

        private void findRootsButton_Click(object sender, EventArgs e)
        {
            var xPoints = new List<double>();

            for (var i = 0; i < this.roots.Rows.Count; i++)
            {
                xPoints.Add(Convert.ToDouble(this.roots[0, i].Value));
            }

            double eps;
            if (!double.TryParse(epsBoundValue.Text, out eps))
            {
                Error();
            }

            eps = Convert.ToDouble(epsBoundValue.Text);

            var roots = new List<double>();
            var absFunc = new List<double>();
            foreach (var x in xPoints)
            {
                var root = PolovinnoeDelenie(x - 0.3, x + 0.3, eps);
                roots.Add(root);
                absFunc.Add(Math.Abs(Func(root)));
            }

            InsertDataIntoDataGrid(1, roots);
            InsertDataIntoDataGrid(2, absFunc);
        }

        private void Error()
        {
            MessageBox.Show("Одно из полей содержит некорректные данные.", "Ошибка ввода", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private double PolovinnoeDelenie(double a, double b, double eps)
        {
            var root = double.MaxValue;

            for (var i = 0; i < 1000; i++)
            {
                var x = (a + b) / 2;

                if (Math.Abs(Func(x)) > eps)
                {
                    if (Func(a) * Func(x) < 0)
                    {
                        b = x;
                    }
                    else
                    {
                        a = x;
                    }
                }
                else
                {
                    root = x;
                    break;
                }
            }

            return root;
        }

        private void InsertDataIntoDataGrid(int columnIndex, List<double> roots)
        {
            if (this.roots.Rows.Count != roots.Count)
            {
                this.roots.Rows.Clear();
                this.roots.Rows.Add(roots.Count - 1);
            }

            for (var i = 0; i < roots.Count; i++)
            {
                this.roots[columnIndex, i].Value = roots[i];
            }
        }

        private void aBoundValue_TextChanged(object sender, EventArgs e)
        {
            findRootsButton.Enabled = false;
            aBoundValue.Text = aBoundValue.Text.Replace('.', ',');
            aBoundValue.SelectionStart = aBoundValue.TextLength;
        }

        private void bBoundValue_TextChanged(object sender, EventArgs e)
        {
            findRootsButton.Enabled = false;
            bBoundValue.Text = bBoundValue.Text.Replace('.', ',');
            bBoundValue.SelectionStart = bBoundValue.TextLength;
        }

        private void epsBoundValue_TextChanged(object sender, EventArgs e)
        {
            findRootsButton.Enabled = false;
            epsBoundValue.Text = epsBoundValue.Text.Replace('.', ',');
            epsBoundValue.SelectionStart = epsBoundValue.TextLength;
        }
    }
}