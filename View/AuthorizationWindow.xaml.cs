﻿using System;
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
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
            DataContext=new AuthorizationViewModel();

        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {            
                (DataContext as AuthorizationViewModel).CheckAuthData(Login, Password);
                Close();
           
        }
    }
}
