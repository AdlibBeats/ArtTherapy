using ArtTherapy.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace ArtTherapy.Pages.MenuPages
{
    public sealed partial class MenuPage : Page, IPage
    {
        public string Title
        {
            get => _Title;
            set
            {
                _Title = value;
                OnPropertyChanged(nameof(MenuPage.Title));
            }
        }
        private string _Title;

        public NavigateEventTypes NavigateEventType
        {
            get => _NavigateEventType;
            set
            {
                _NavigateEventType = value;
                OnPropertyChanged(nameof(MenuPage.NavigateEventType));
            }
        }
        private NavigateEventTypes _NavigateEventType;

        public event EventHandler<EventArgs> Initialized;

        public MenuPage()
        {
            this.InitializeComponent();
            Title = "Меню";
            NavigateEventType = NavigateEventTypes.ListBoxSelectionChanged;
            DataContext = new MenuViewModel();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainSplitView.IsPaneOpen = !MainSplitView.IsPaneOpen;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoBack)
                MainFrame.GoBack();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //TODO:
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            //TODO:
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        #endregion
    }
}
