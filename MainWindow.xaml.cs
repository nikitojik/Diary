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

namespace Diary
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

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ForwardButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddPageButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void AddNewTextBox()
        {
            TextBox textBox = new TextBox
            {
                Width = 120,
                Height = 18,
                Margin = new Thickness(5)
            };
            HabitsStackPanel.Children.Add(textBox);
        }

        private void AddNewCheckBox()
        {
            CheckBox checkBox = new CheckBox
            {
                Width = 18, Height = 18,
                Margin = new Thickness(5)
            };
            HabitsStackPanel.Children.Add(checkBox);
        }

        private void AddNewHabitButton_Click(object sender, RoutedEventArgs e)
        {
            AddNewTextBox();
            AddNewCheckBox();
        }

        private void AddNewNote()
        {
            Window window = new Window()
            {
                Title = "Diary",
                Width = 1000,
                Height = 600,
            };
            Grid grid = new Grid()
            {

            };
        }
    }
}