using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace AsyncTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void HandleNameButtonClick(object sender, RoutedEventArgs e)
        {
            var id = Thread.CurrentThread.ManagedThreadId;

            if (await SendViaEmail(nameTextBox.Text, "Tokaev@inbox.ru", "город мой Астана"))
            {
                await SendToDatabase(nameTextBox.Text);
                MessageBox.Show("Боже храни королеву!");
                var id2 = Thread.CurrentThread.ManagedThreadId;
            }
        }

        private Task SendToDatabase(string name)
        {
            return Task.Run(() =>
           {
            //STUB
            Thread.Sleep(3000);
           });
            
        }

        private Task<bool> SendViaEmail(string name, string to, string title)
        {
            return Task.Run(() =>
            {
                //STUB
                Thread.Sleep(5000);
                return true;
            });
        }
    }
}
