using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using ООО_Ткани.Model;
using ООО_Ткани.View;

namespace ООО_Ткани.ViewModel
{
    internal class AuthorizationViewModel
    {
        public void CheckAuthData(TextBox tbLogin, TextBox tbPassword)
        {
            AdminWindow admin = new AdminWindow();
            PersonWindow user = new PersonWindow();

            StreamReader st = new StreamReader("C://Users/white/Desktop/ООО Ткани/Source/Authorization.txt");
            string[] words;

            while (!st.EndOfStream)
            {
                string line = st.ReadLine();
                words = line.Split(',');

                if (tbLogin.Text == words[0] && tbPassword.Text == words[1])
                {
                    if (words[2] == "Admin")
                    {
                        admin.Show();
                        return;

                    }
                    if (words[2] == "User")
                    {
                        user.Show();
                        return;

                    }
                    else
                        MessageBox.Show("Нет такого пользователя");

                }



            }

        }
    }
}
