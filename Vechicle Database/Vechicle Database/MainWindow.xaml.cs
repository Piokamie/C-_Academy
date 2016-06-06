using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Vechicle_Database
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Cars> CarsList;
        public ObservableCollection<Motorcycles> MotorcyclesList;
        public MainWindow()
        {
            InitializeComponent();
            CarsList = new ObservableCollection<Cars>();
            MotorcyclesList = new ObservableCollection<Motorcycles>();
            Main.Content = new CarsPage(CarsList);        
            this.DataContext = this;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            CarsList.Add(new Cars("Chevrolet", "Impala", "Black", 1966, 20000, 5, 5, 40, 7));
            Main.Refresh();
            AddDialogue.IsOpen = true;
            Popup.Content = new Page1();
        }

        private void Motorcycles_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new MotorcyclesPage(MotorcyclesList);
        }

        private void Cars_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new CarsPage(CarsList);
        }

        private void PopupCancelButton_Click(object sender, RoutedEventArgs e)
        {
            AddDialogue.IsOpen = false;
            
        }

        private void PopupAddButton_Click(object sender, RoutedEventArgs e)
        {
            Popup.Content = new Page1();
        }
    }
}
