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
using System.Windows.Shapes;
using ООО_Ткани.ViewModel;

namespace ООО_Ткани.View
{
    /// <summary>
    /// Логика взаимодействия для PersonWindow.xaml
    /// </summary>
    public partial class PersonWindow : Window
    {
        public PersonWindow()
        {
            InitializeComponent();
            DataContext = new PersonViewModel();
            (DataContext as PersonViewModel).OrderInFabric(cbChoice);
        }


        private void ButtonOrderClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" в разработке");
        }

        private void btClicknLogOut(object sender, RoutedEventArgs e)
        {
            MessageBoxResult check = MessageBox.Show("Вы действительнор хотите выйти?", "Подтверждение выхода", MessageBoxButton.YesNo);
            if (check == MessageBoxResult.Yes)
            {
                Window newWindow = new AuthorizationWindow();
                newWindow.Show();
                Close();
            }
            else if (check == MessageBoxResult.No)
            {
                Show();
            }
        }
    }
}
