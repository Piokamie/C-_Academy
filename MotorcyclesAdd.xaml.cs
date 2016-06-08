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
    /// Interaction logic for MotorcyclesAdd.xaml
    /// </summary>
    public partial class MotorcyclesAdd : Page
    {
        public MotorcyclesAdd()
        {
            InitializeComponent();
            MotorcycleType.ItemsSource = Enum.GetValues(typeof (Enums.MotorcycleType));
            MotorcycleType.SelectedIndex = 0;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (DataOperations.ValidateInput(YearTextBox) && DataOperations.ValidateInput(KilometerageTextBox)
               && DataOperations.ValidateInput(Engine) && DataOperations.ValidateInput(FuelTextBox)
               && DataOperations.ValidateInput(BurnRateTextBox))
            {
                Enums.MotorcycleType Type = (Enums.MotorcycleType)Enum.Parse(typeof(Enums.MotorcycleType), this.MotorcycleType.Text);
                MainWindow.MotorcyclesList.Add(new Motorcycles(ManufacturerTextBox.Text, ModelTextBox.Text, ColorTextBox.Text,
                       int.Parse(YearTextBox.Text), int.Parse(KilometerageTextBox.Text), int.Parse(Engine.Text),
                       int.Parse(FuelTextBox.Text), int.Parse(BurnRateTextBox.Text),Type));
                NavigationService.GoBack();
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
