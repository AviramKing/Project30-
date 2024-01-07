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

namespace Project30_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            nameTxt.GotFocus += NameTextBox_GotFocus;
        }

        private void NameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (nameTxt.Text == "Name")
            {
                nameTxt.Text = "";
            }
        }
       private void Continue_Click(object sender, RoutedEventArgs e)
        {
            GamePage gamePage = new GamePage(nameTxt.Text);
            this.Close();
            gamePage.Show();
        }
    }
}
