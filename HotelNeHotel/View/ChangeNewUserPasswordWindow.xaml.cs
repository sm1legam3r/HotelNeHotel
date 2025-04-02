using HotelNeHotel.Model;
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

namespace HotelNeHotel.View
{
    /// <summary>
    /// Логика взаимодействия для ChangeNewUserPasswordWindow.xaml
    /// </summary>
    public partial class ChangeNewUserPasswordWindow : Window
    {
        private User user;
        public ChangeNewUserPasswordWindow(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void ChangePassword_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
