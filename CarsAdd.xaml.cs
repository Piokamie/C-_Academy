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

namespace Vechicle_Database
{
    /// <summary>
    /// Interaction logic for CarsAdd.xaml
    /// </summary>
    public partial class CarsAdd : Page
    {
        public CarsAdd()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

            if (DataOperations.ValidateInput(YearTextBox)&& DataOperations.ValidateInput(KilometerageTextBox)
                && DataOperations.ValidateInput(Passengers)&& DataOperations.ValidateInput(FuelTextBox) 
                && DataOperations.ValidateInput(BurnRateTextBox) && DataOperations.ValidateInput(DoorsTextBox))
            {
                MainWindow.CarsList.Add(new Cars(ManufacturerTextBox.Text, ModelTextBox.Text, ColorTextBox.Text,
                       int.Parse(YearTextBox.Text), int.Parse(KilometerageTextBox.Text), int.Parse(Passengers.Text),
                       int.Parse(DoorsTextBox.Text), int.Parse(FuelTextBox.Text), int.Parse(BurnRateTextBox.Text)));
                NavigationService.GoBack();
            }

        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

       
    }
}
