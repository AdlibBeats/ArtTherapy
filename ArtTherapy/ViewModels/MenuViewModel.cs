using System;

using ArtTherapy.Models.ItemsModels;
using ArtTherapy.Pages.PostPages;
using ArtTherapy.Pages.SettingsPages;
using ArtTherapy.Pages.AboutAppPages;

using System.Collections.ObjectModel;
using Windows.UI.Xaml;

namespace ArtTherapy.ViewModels
{
    public class MenuViewModel : DependencyObject
    {
        public MenuViewModel()
        {
            MenuModel = new ItemsModel()
            {
                Items = new ObservableCollection<CurrentItemModel>()
                {
                    new CurrentItemModel() { Icon = "\xE10F", Name = "Стихи", Type = typeof(PostPage) },
                    new CurrentItemModel() { Icon = "\xE1A5", Name = "Сказки", Type = typeof(PostPage) },
                    new CurrentItemModel() { Icon = "\xE7C3", Name = "Статьи", Type = typeof(PostPage) },
                    new CurrentItemModel() { Icon = "\xE77F", Name = "О приложении", Type = typeof(AboutAppPage) },
                    new CurrentItemModel() { Icon = "\xE7F4", Name = "Настройки", Type = typeof(SettingsPage) }
                }
            };
        }

        #region Public Dependency Properties

        public ItemsModel MenuModel
        {
            get { return (ItemsModel)GetValue(MenuModelProperty); }
            set { SetValue(MenuModelProperty, value); }
        }

        public static readonly DependencyProperty MenuModelProperty =
            DependencyProperty.Register("MenuModel", typeof(ItemsModel), typeof(MenuViewModel), new PropertyMetadata(null));

        #endregion
    }
}
