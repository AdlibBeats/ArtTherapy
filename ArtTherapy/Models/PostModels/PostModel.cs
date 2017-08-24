using System;
using System.Collections.ObjectModel;

namespace ArtTherapy.Models.PostModels
{
    public class PostModel : BaseModel
    {
        public ObservableCollection<CurrentPostModel> Items
        {
            get => _Items;
            set
            {
                _Items = value;
                OnPropertyChanged(nameof(PostModel.Items));
            }
        }
        private ObservableCollection<CurrentPostModel> _Items;
    }
}
