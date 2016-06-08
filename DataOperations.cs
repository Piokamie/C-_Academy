using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Vechicle_Database
{
    static class DataOperations
    {
        public static bool ValidateInput(TextBox Text)
        {
            int w;
            if (!int.TryParse(Text.Text, out w))
            {
                Text.Background = Brushes.Red;
                return false;
            }
            else
            {
                Text.Background = Brushes.White;
                return true;
            }
        }
    }
}
