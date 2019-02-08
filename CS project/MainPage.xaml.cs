using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CS_project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Screen_Login.Visibility = Visibility.Visible;
            Screen_Main.Visibility = Visibility.Collapsed;
            Subscreen_Home.Visibility = Visibility.Visible;
            Subscreen_Item_Info.Visibility = Visibility.Collapsed;
        }

        private void Text_Box_Click_Username(object sender, RoutedEventArgs e)
        {
            if (Username.Text.Equals("Type your username here"))
            {
                Username.Text = "";
            }
        }

        private void Text_Box_Leave_Username(object sender, RoutedEventArgs e)
        {
            if (Username.Text.Equals(""))
            {
                Username.Text = "Type your username here";
            }
        }

        private void Button_Login_Click(object sender, RoutedEventArgs e)
        {
            // send login data, if successful unhide main menu
            if (SQL_Instructions.SQL_Connect(Serverip.Text, Username.Text, Servername.Text, Portname.Text, Password.Password) != null)
            {
                Screen_Login.Visibility = Visibility.Collapsed;
                Screen_Main.Visibility = Visibility.Visible;
            }
            else // else present error msg
            {
                Error_Login.Visibility = Visibility.Visible;
            }


        }
    }
}
