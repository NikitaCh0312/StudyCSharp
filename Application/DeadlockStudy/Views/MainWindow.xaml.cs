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
            Task tsk = Function();
            //блокируем UI поток и ждем когда он выполнится
            tsk.Wait();
        }

        private async Task Function()
        {
            //тут выполнение кода возвращается в ButtonClicked в метод .Wait()
            await Task.Factory.StartNew(() =>
            {
                //запускается задача
                Thread.Sleep(2000);
                //задача ожидает пока освободится поток, который ее запустил
                //но поток который ее запустил метод ButtonClicked, ожидает когда эта задача 
                //освободится, получаем deadlock 
            });

        }

    }
}
