﻿#pragma checksum "C:\Users\Jarrett Yu\source\repos\CS project\CS project\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "20807A525E71C97D4FF60751414BEBB3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CS_project
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 12
                {
                    this.Screen_Login = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // MainPage.xaml line 37
                {
                    this.Screen_Main = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4: // MainPage.xaml line 58
                {
                    this.Subscreen_Home = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 5: // MainPage.xaml line 64
                {
                    this.Subscreen_Item_Info = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 6: // MainPage.xaml line 17
                {
                    this.Title_Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // MainPage.xaml line 19
                {
                    this.Username = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.Username).GotFocus += this.Text_Box_Click_Username;
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.Username).LostFocus += this.Text_Box_Leave_Username;
                }
                break;
            case 8: // MainPage.xaml line 20
                {
                    this.Password = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 9: // MainPage.xaml line 31
                {
                    this.Error_Login = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // MainPage.xaml line 32
                {
                    this.Button_Login = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Button_Login).Click += this.Button_Login_Click;
                }
                break;
            case 11: // MainPage.xaml line 27
                {
                    this.Serverip = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 12: // MainPage.xaml line 28
                {
                    this.Portname = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 13: // MainPage.xaml line 29
                {
                    this.Servername = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

