using ArtTherapy.Models;
using ArtTherapy.Models.MenuModel;
using ArtTherapy.Pages.MenuPage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace ArtTherapy.ViewModels
{
    public class MenuViewModel : DependencyObject
    {
        public MenuViewModel()
        {
            MenuModel = new MenuModel()
            {
                MenuItems = new ObservableCollection<ItemModel>()
                {
                    new ItemModel() { Icon = "\xE10F", Name = "Главное меню", Type = typeof(MenuPage) }
                    //new ItemModel() { Icon = "\xE1A5", Name = "Текущая заявка", Type = typeof(CurrentOrderPage) },
                    //new ItemModel() { Icon = "\xE7C3", Name = "История заявок", Type = typeof(OrderHistoryPage) },
                    //new ItemModel() { Icon = "\xE77F", Name = "Подобрать решение", Type = typeof(SelectSolutionPage) },
                    //new ItemModel() { Icon = "\xE7F4", Name = "Каталог оборудования", Type = typeof(EquipmentCatalogPage) },
                    //new ItemModel() { Icon = "\xE81E", Name = "Каталог решений", Type = typeof(SolutionCatalogPage) },
                    //new ItemModel() { Icon = "\xE897", Name = "О приложении", Type = typeof(AboutPage) },
                    //new ItemModel() { Icon = "\xE1E0", Name = "Выход", Type = typeof(INullPage) }
                }
            };
        }

        #region Public Dependency Properties
        public MenuModel MenuModel
        {
            get { return (MenuModel)GetValue(MenuModelProperty); }
            set { SetValue(MenuModelProperty, value); }
        }

        public static readonly DependencyProperty MenuModelProperty =
            DependencyProperty.Register("MenuModel", typeof(MenuModel), typeof(MenuViewModel), new PropertyMetadata(null));

        #endregion
    }
}
