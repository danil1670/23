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

namespace _23
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User person = new User();

        public MainWindow()
        {
            InitializeComponent();

            grCourse.Items.Add("1");
            grCourse.Items.Add("2");
            grCourse.Items.Add("3");
            grCourse.Items.Add("4");
            grCourse.Items.Add("5");

            this.DataContext = person;
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show($"Зарегистрирован: \n{person.FIO}\n{person.Group}\n{person.Age} лет");
        }
    }
}