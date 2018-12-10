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

        bool contextmenu_open = false;
        bool dock_visible = true;
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D1)
            {
                Dock.Visibility = Visibility.Visible;
                if (dock_visible)
                    Homepage.Visibility = Visibility.Visible;
                dock_visible = true;
            }

            if (e.Key == Key.D2)
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

        private void ShowContent(string content)
        {
            Homepage.Visibility = Visibility.Hidden;
            Dock.Visibility = Visibility.Hidden;
            dock_visible = false;

            YouTubeContent.Visibility = Visibility.Hidden;
            SpotifyContent.Visibility = Visibility.Hidden;
            NetflixContent.Visibility = Visibility.Hidden;
            CrunchyrollContent.Visibility = Visibility.Hidden;

            if (content == "YouTube") YouTubeContent.Visibility = Visibility.Visible;
            else if (content == "Spotify") SpotifyContent.Visibility = Visibility.Visible;
            else if (content == "Netflix") NetflixContent.Visibility = Visibility.Visible;
            else if (content == "Crunchyroll") CrunchyrollContent.Visibility = Visibility.Visible;
            else GenericContent.Visibility = Visibility.Visible;
        }

        private void ___Button__YouTube2_Click(object sender, RoutedEventArgs e)
        {
            ShowContent("YouTube");
        }

        private void ___Button__Spotify2_Click(object sender, RoutedEventArgs e)
        {
            ShowContent("Spotify");
        }

        private void ___Button__Netflix1_Click(object sender, RoutedEventArgs e)
        {
            ShowContent("Netflix");
        }

        private void ___Button__CrunchyRoll1_Click(object sender, RoutedEventArgs e)
        {
            ShowContent("Crunchyroll");
        }

        private void ___Button__Twitch1_Click(object sender, RoutedEventArgs e)
        {
            ShowContent("Generic");
        }

        private void ___Button__Google_Play1_Click(object sender, RoutedEventArgs e)
        {
            ShowContent("Generic");
        }

        private void ___Button__Prime_Video1_Click(object sender, RoutedEventArgs e)
        {
            ShowContent("Generic");
        }

        private void ___Button__Local_Videos1_Click(object sender, RoutedEventArgs e)
        {
            ShowContent("Generic");
        }

        private void ___Button__Local_Pictures1_Click(object sender, RoutedEventArgs e)
        {
            ShowContent("Generic");
        }

        private void ___Button__Local_Music1_Click(object sender, RoutedEventArgs e)
        {
            ShowContent("Generic");
        }

        private void ___Button__Local_Games1_Click(object sender, RoutedEventArgs e)
        {
            ShowContent("Generic");
        }

        private void ___Button__Pokemon1_Click(object sender, RoutedEventArgs e)
        {
            ShowContent("Generic");
        }

        private void ___Button__Hulu1_Click(object sender, RoutedEventArgs e)
        {
            ShowContent("Generic");
        }

        private void ___Button__PlayStation1_Click(object sender, RoutedEventArgs e)
        {
            ShowContent("Generic");
        }

        private void ___Button__Cable_TV1_Click(object sender, RoutedEventArgs e)
        {
            ShowContent("Generic");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShowContent("Generic");
        }

        private void ___Button__Netflix1_Copy_Click(object sender, RoutedEventArgs e)
        {
            ShowContent("Generic");
        }

        private void ___Button__CrunchyRoll1_Copy_Click(object sender, RoutedEventArgs e)
        {
            ShowContent("Generic");
        }
    }
}