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

namespace CPSC481Prototype
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
            Homepage_Page2.Visibility = Visibility.Hidden;
            ProfileFolder.Visibility = Visibility.Hidden;
            ContextMenu.Visibility = Visibility.Hidden;
        }

        private void Homepage_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
            {
                Homepage_Page1.Visibility = Visibility.Visible;
                Homepage_Page2.Visibility = Visibility.Hidden;
            }
            else if (e.Delta < 0)
            {
                Homepage_Page1.Visibility = Visibility.Hidden;
                Homepage_Page2.Visibility = Visibility.Visible;
            }
        }

        bool profile_open = false;
        private void ___Button__Profile2_Click_1(object sender, RoutedEventArgs e)
        {
            if (profile_open)
            {
                ProfileFolder.Visibility = Visibility.Hidden;
                profile_open = false;
            }
            else
            {
                ProfileFolder.Visibility = Visibility.Visible;
                profile_open = true;
            }           
        }

        bool contextmenu_open = false;
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D1)
                if (contextmenu_open)
                {
                    ContextMenu.Visibility = Visibility.Hidden;
                    contextmenu_open = false;
                }
                else
                {
                    ContextMenu.Visibility = Visibility.Visible;
                    contextmenu_open = true;
                }
        }
    }
}