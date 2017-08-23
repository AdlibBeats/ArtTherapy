using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ArtTherapy.Models.MenuModel
{
    public class MenuModel : BaseModel
    {
        public ObservableCollection<ItemModel> MenuItems
        {
            get => _MenuItems;
            set
            {
                _MenuItems = value;
                OnPropertyChanged(nameof(MenuModel));
            }
        }
        private ObservableCollection<ItemModel> _MenuItems;
    }
}
