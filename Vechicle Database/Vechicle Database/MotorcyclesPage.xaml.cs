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
    /// Interaction logic for MotorcyclesPage.xaml
    /// </summary>
    public partial class MotorcyclesPage : Page
    {
        public ObservableCollection<Motorcycles>MotorcyclesList { get; set; }
        public MotorcyclesPage(ObservableCollection<Motorcycles> MotorcyclesList)
        {
            InitializeComponent();            
            this.DataContext = this;
            this.MotorcyclesList = MotorcyclesList;
            Motorcycles bike = new Motorcycles("Harley-Davidson", "Heritage Softail", "Blue", 2002, 20000, 1440, 19, 4, Enums.MotorcycleType.Cruiser );
            MotorcyclesList.Add(bike);
        }
    }
}
