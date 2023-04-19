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

namespace ExsamPM04
{
    
    public partial class MainWindow : Window
    {
        public static string asd;
        public MainWindow()
        {
            InitializeComponent();
            asd = HospitTextBox.Text;
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            if (HospitTextBox.Text.Length > 40)
            {
                MessageBox.Show("Превышено максимальное количество символов\n Максимально 40 символов");
            }
            if (HospitTextBox.Text.Length < 10)
            {
                MessageBox.Show("Введено недостаточно символов \n Минимально 10 символов");
            }
            if (VrachTextBox.Text.Length < 10)
            {
                MessageBox.Show("Введено недостаточно символов \n Минимально 10 символов");
            }
            if (VrachTextBox.Text.Length > 60)
            {
                MessageBox.Show("Превышено максимальное количество символов\n Максимально 60 символов");
            }
            if (PocTextBox.Text.Length < 10)
            {
                MessageBox.Show("Введено недостаточно символов \n Минимально 10 символов");
            }
            if (PocTextBox.Text.Length > 60)
            {
                MessageBox.Show("Превышено максимальное количество символов\n Максимально 60 символов");
            }

            int num = Convert.ToInt32(NumberTextBox.Text);
            if (num < 0)
            {
                MessageBox.Show("Введено отрицательное число");
            }


        }
    }
}
