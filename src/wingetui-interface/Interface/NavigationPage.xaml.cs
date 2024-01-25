using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using ModernWindow.Interface.Widgets;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ModernWindow.Interface
{
    public sealed partial class NavigationPage : UserControl
    {
        public SettingsInterface SettingsPage;
        public DiscoverPackagesPage DiscoverPage;
        public Page UpdatesPage = new Page();
        public Page InstalledPage = new Page();
        public Type OldPage;
        public NavigationPage()
        {
            this.InitializeComponent();
            SettingsPage = new SettingsInterface();
            DiscoverPage = new DiscoverPackagesPage();
            DiscoverNavButton.ForceClick();
        }

        private void DiscoverNavButton_Click(object sender, NavButton.NavButtonEventArgs e)
        {
            MainContentPresenter.Navigate(typeof(DiscoverPackagesPage), new DrillInNavigationTransitionInfo());
            //ContentPresenterScrollBar.CornerRadius = new CornerRadius(6, 0, 0, 0);
        }

        private void InstalledNavButton_Click(object sender, NavButton.NavButtonEventArgs e)
        {
            MainContentPresenter.Navigate(typeof(Page), new DrillInNavigationTransitionInfo());
            //ContentPresenterScrollBar.CornerRadius = new CornerRadius(12, 0, 0, 0);
        }

        private void UpdatesNavButton_Click(object sender, NavButton.NavButtonEventArgs e)
        {
            //ContentPresenterScrollBar.CornerRadius = new CornerRadius(12, 0, 0, 0);
            MainContentPresenter.Navigate(typeof(Page), new DrillInNavigationTransitionInfo());
        }

        private void MoreNavButton_Click(object sender, NavButton.NavButtonEventArgs e)
        {
            //ContentPresenterScrollBar.CornerRadius = new CornerRadius(12, 0, 0, 0);
            MainContentPresenter.Navigate(typeof(Page), new DrillInNavigationTransitionInfo());
        }

        private void SettingsNavButton_Click(object sender, NavButton.NavButtonEventArgs e)
        {
            //ContentPresenterScrollBar.CornerRadius = new CornerRadius(12, 0, 0, 0);
            MainContentPresenter.Navigate(typeof(SettingsInterface), new EntranceNavigationTransitionInfo());
        }

        private void AboutNavButton_Click(object sender, NavButton.NavButtonEventArgs e)
        {
            //ContentPresenterScrollBar.CornerRadius = new CornerRadius(12, 0, 0, 0);
            MainContentPresenter.Navigate(typeof(Page), new DrillInNavigationTransitionInfo());
        }
    }
}
