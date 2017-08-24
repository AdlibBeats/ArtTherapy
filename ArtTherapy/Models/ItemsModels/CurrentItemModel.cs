using System;
using Windows.UI.Xaml.Media;

namespace ArtTherapy.Models.ItemsModels
{
    public class CurrentItemModel : BaseModel
    {
        public string Icon
        {
            get { return _Icon; }
            set
            {
                _Icon = value;
                OnPropertyChanged(nameof(CurrentItemModel.Icon));
            }
        }
        string _Icon;

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged(nameof(CurrentItemModel.Name));
            }
        }
        string _Name;

        public string Description
        {
            get { return _Description; }
            set
            {
                _Description = value;
                OnPropertyChanged(nameof(CurrentItemModel.Description));
            }
        }
        string _Description;

        public Type Type
        {
            get { return _Type; }
            set
            {
                _Type = value;
                OnPropertyChanged(nameof(CurrentItemModel.Type));
            }
        }
        Type _Type;
    }
}
