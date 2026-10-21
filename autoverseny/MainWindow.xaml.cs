using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace autoverseny
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        private Random rnd;
        private double celvonal = 1800;

        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            rnd = new Random();
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Mozog(btn_auto0);
            Mozog(btn_auto1);
            Mozog(btn_auto2);
            Mozog(btn_auto3);
            Mozog(btn_auto4);
            Mozog(btn_auto5);
            Mozog(btn_auto6);
            Mozog(btn_auto7);
            Mozog(btn_auto8);
            Mozog(btn_auto9);
            Mozog(btn_auto10);
            Mozog(btn_auto11);
            Mozog(btn_auto12);
            Mozog(btn_auto13);
            Mozog(btn_auto14);
            Mozog(btn_auto15);
        }

        private void Mozog(Button btn_auto)
        {
            double aktualispozicio = Canvas.GetLeft(btn_auto);
            double sebesseg = rnd.Next(1, 6);
            double ujpozicio = aktualispozicio + sebesseg;
            Canvas.SetLeft(btn_auto, ujpozicio);
            if (ujpozicio >= celvonal)
            {
                //Canvas.SetLeft(btn_auto, 1);

                timer.Stop();
                MessageBox.Show($"Célba ért a(z) {btn_auto.Content}!");
            }


        }

        private void btn_start_Click(object sender, RoutedEventArgs e)
        {

            timer.Start();
        }

        private void btn_reset_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            Canvas.SetLeft(btn_auto0, 1);
            Canvas.SetLeft(btn_auto1, 1);
            Canvas.SetLeft(btn_auto2, 1);
            Canvas.SetLeft(btn_auto3, 1);
            Canvas.SetLeft(btn_auto4, 1);
            Canvas.SetLeft(btn_auto5, 1);
            Canvas.SetLeft(btn_auto6, 1);
            Canvas.SetLeft(btn_auto7, 1);
            Canvas.SetLeft(btn_auto8, 1);
            Canvas.SetLeft(btn_auto9, 1);
            Canvas.SetLeft(btn_auto10, 1);
            Canvas.SetLeft(btn_auto11, 1);
            Canvas.SetLeft(btn_auto12, 1);
            Canvas.SetLeft(btn_auto13, 1);
            Canvas.SetLeft(btn_auto14, 1);
            Canvas.SetLeft(btn_auto15, 1);
        }
    }
}