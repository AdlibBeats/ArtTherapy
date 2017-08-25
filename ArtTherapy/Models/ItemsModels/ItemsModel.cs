using System.Collections.ObjectModel;

namespace ArtTherapy.Models.ItemsModels
{
    public class ItemsModel : BaseModel
    {
        public ObservableCollection<CurrentItemModel> Items
        {
            get => _Items;
            set => _Items = GetValue(value, nameof(ItemsModel.Items));
        }
        private ObservableCollection<CurrentItemModel> _Items;
    }
}
