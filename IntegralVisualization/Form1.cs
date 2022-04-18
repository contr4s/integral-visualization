using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegralVisualization
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();

            ShowFunctionGraphic(GeneratePoints(Function));
            pointSelection.DataSource = Enum.GetValues(typeof(PointSelectionType));
        }

        void ShowFunctionGraphic(IEnumerable<(double, double)> function)
        {
            chart.Series[0].Points.Clear();
            foreach (var point in function)
            {
                chart.Series[0].Points.AddXY(point.Item1, point.Item2);
            }
        }

        IEnumerable<(double, double)> GeneratePoints(Func<double, double> func, double a = 0, double b = 3, double eps = 0.01)
        {
            while (a < b)
            {
                yield return (a, func(a));
                a += eps;
            }
            yield return (b, func(b));
        }

        double Function(double x)
        {
            return Math.Pow(5, x);
        }

        double DerivativeFunction(double x)
        {
            return 5 * Math.Pow(4, x);
        }

        double CalculateInaccuracy(int n, double a = 0, double b = 3)
        {
            return GeneratePoints(DerivativeFunction, eps: 0.00001).Max(x => Math.Abs(x.Item2)) * (b - a) * (b - a) / n;
        }

        IEnumerable<(double, double)> Partitioning(int n = 10, double a = 0, double b = 3)
        {
            double step = (b - a) / n;
            while (a < b)
            {
                yield return (a, a + step < b ? a + step : b);
                a += step;
            }
        }

        double SelectPoint((double, double) range, PointSelectionType selectionType = PointSelectionType.Left)
        {
            var rand = new Random();
            double res = 0;
            switch (selectionType)
            {
                case PointSelectionType.Left:
                    res = range.Item1;
                    break;
                case PointSelectionType.Right:
                    res = range.Item2;
                    break;
                case PointSelectionType.Middle:
                    res = range.Item1 + (range.Item2 - range.Item1) / 2;
                    break;
                case PointSelectionType.Random:
                    res = range.Item1 + rand.NextDouble() * (range.Item2 - range.Item1);
                    break;
                default:
                    break;
            }
            return res;
        }

        private void Compute(object sender, EventArgs e)
        {
            chart.Series[1].Points.Clear();
            double integral = 0;

            var partition = Partitioning();
            if (int.TryParse(partitionRate.Text, out int rate))
                partition = Partitioning(rate);
            if (rate > 5000)
            {
                MessageBox.Show("partition rate is too big, visualizing is disabled to reduce computation time");
            }
            foreach (var range in partition)
            {
                var point = SelectPoint(range, GetSelectionType());
                if (rate <= 5000)
                    Visualize(range, point);
                integral += (range.Item2 - range.Item1) * Function(point);
            }

            integaralText.Text = $"Intergral = {integral:F4}";
            inaccuracyText.Text = $"Inaccuracy = {CalculateInaccuracy(rate)}";
        }

        private void Visualize((double, double) range, double point)
        {
            chart.Series[1].Points.AddXY(range.Item1, Function(point));
            chart.Series[1].Points.AddXY(range.Item2, Function(point));
        }

        PointSelectionType GetSelectionType()
        {
            Enum.TryParse(pointSelection.SelectedValue.ToString(), out PointSelectionType selectedTypeParsing);
            return selectedTypeParsing;
        }

        public enum PointSelectionType
        {
            Left,
            Right,
            Middle,
            Random
        }
    }
}
