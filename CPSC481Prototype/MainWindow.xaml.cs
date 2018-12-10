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
            MainGrid.Children[3].Visibility = Visibility.Hidden;
            MainGrid.Children[4].Visibility = Visibility.Hidden;
            MainGrid.Children[5].Visibility = Visibility.Hidden;
        }

        private void HandleMouseWheel(MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
            {
                MainGrid.Children[2].Visibility = Visibility.Visible;
                MainGrid.Children[3].Visibility = Visibility.Hidden;
            }
            else if (e.Delta < 0)
            {
                MainGrid.Children[2].Visibility = Visibility.Hidden;
                MainGrid.Children[3].Visibility = Visibility.Visible;
            }
        }

        private void Homepage_BG_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            HandleMouseWheel(e);
        }

        private void Dock_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            HandleMouseWheel(e);
        }

        private void Homepage_Page1_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            HandleMouseWheel(e);
        }

        private void Homepage_Page2_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            HandleMouseWheel(e);
        }

        bool profile_open = false;
        private void ___Button__Profile2_Click_1(object sender, RoutedEventArgs e)
        {
            if (profile_open)
            {
                MainGrid.Children[4].Visibility = Visibility.Hidden;
                profile_open = false;
            }
            else
            {
                MainGrid.Children[4].Visibility = Visibility.Visible;
                profile_open = true;
            }           
        }
        bool contextmenu_open = false;
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D1)
                if (contextmenu_open)
                {
                    MainGrid.Children[5].Visibility = Visibility.Hidden;
                    contextmenu_open = false;
                }
                else
                {
                    MainGrid.Children[5].Visibility = Visibility.Visible;
                    contextmenu_open = true;
                }
        }
    }
}