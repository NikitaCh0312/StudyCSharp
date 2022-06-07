using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace DeadlockStudy.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void ButtonClicked(object sender, RoutedEventArgs e)
        {
            //заходим в метод
            var tsk = Function();
            //блокируем UI поток и ждем когда он выполнится
            int result = tsk.Result;
        }

        private async Task<int> Function()
        {
            //тут выполнение кода возвращается в ButtonClicked в метод .Wait()
            //запускается задача
            //задача ожидает пока освободится поток, который ее запустил
            //но поток который ее запустил метод ButtonClicked, ожидает когда эта задача 
            //освободится, получаем deadlock 
            await Task.Delay(TimeSpan.FromSeconds(2)).ConfigureAwait(true);

            return 10;

        }

    }
}
