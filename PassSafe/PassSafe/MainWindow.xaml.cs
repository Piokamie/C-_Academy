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

namespace PassSafe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Subject> PasswordsList { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            PasswordsList = new ObservableCollection<Subject>();
            Subject lol = new Subject("Piotras", "CHWDP", "wwww.pornhub.com", "JEBAC OLICJE");
            PasswordsList.Add(lol);
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddDialogue.IsOpen = true;
        }
        private void PopupCancelButton_Click(object sender, RoutedEventArgs e)
        {
            AddDialogue.IsOpen = false;
        }

        private void PopupAddButton_Click(object sender, RoutedEventArgs e)
        {
            PasswordsList.Add(new Subject(LoginTextBox.Text, PasswordTextBox.Text, 
                URLTextBox.Text, NotesTextBox.Text));
            LoginTextBox.Clear();
            PasswordTextBox.Clear();
            URLTextBox.Clear();
            NotesTextBox.Clear();
            AddDialogue.IsOpen = false;
        }

        private void EncryptButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Subject item in PasswordsList)
            {
              item.Encrypt();
                ListView1.Items.Refresh();

                
            }
           
        }
    }
}
