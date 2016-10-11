using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laborator1.Tema
{
    /// <summary>
    /// Interaction logic for NumericUpDown.xaml
    /// </summary>
    public partial class NumericUpDown : UserControl
    {
        private double m_Minimum;
        private double m_Maximum;
        private double m_Value;
        private double m_Step;
        public double Minimum
        {
            get { return m_Minimum; }
            set { m_Minimum = value; CheckValue(); }

        }
        public double Maximum
        {
            get { return m_Maximum; }
            set { m_Maximum = value; CheckValue(); }

        }
        public double Step
        {
            get { return m_Step; }
            set { m_Step = value; }
        }
        public double Value
        {
            get { return m_Value; }
            set { m_Value = value; CheckValue(); }
        }
        public NumericUpDown()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            m_Value = 0;
            m_Minimum = 0;
            m_Maximum = 100;
            m_Step = 1;
        }
        private void CheckValue()
        {
            if (m_Value < m_Minimum)
                m_Value = m_Minimum;
            else if (m_Value > m_Maximum)
                m_Value = m_Maximum;

            DisplayValue();
        }
        private void DisplayValue()
        {
            ValueTxt.Text = m_Value.ToString();
        }
        private void GoUp()
        {
            Value += Step;
        }
        private void GoDown()
        {
            Value -= Step;
        }

        private void ValueTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Value = double.Parse(ValueTxt.Text);
            }
            
        }

        private void UpBtn_Click(object sender, RoutedEventArgs e)
        {
            GoUp();
        }

        private void DownBtn_Click(object sender, RoutedEventArgs e)
        {
            GoDown();
        }

        private void UserControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                GoUp();
            }
            if (e.Key == Key.Down)
            {
                GoDown();
            }
        }

        private void DownBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            GoDown();
        }

        private void UpBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            GoUp();
        }
    }
}
