using System;
using Windows.UI.Xaml.Media;

namespace ArtTherapy.Models.PostModels
{
    public class CurrentPostModel : BaseModel
    {
        public string Icon
        {
            get { return _Icon; }
            set
            {
                _Icon = value;
                OnPropertyChanged(nameof(CurrentPostModel.Icon));
            }
        }
        string _Icon;

        public ImageSource Image
        {
            get { return _Image; }
            set
            {
                _Image = value;
                OnPropertyChanged(nameof(CurrentPostModel.Image));
            }
        }
        ImageSource _Image;

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged(nameof(CurrentPostModel.Name));
            }
        }
        string _Name;

        public string Description
        {
            get { return _Description; }
            set
            {
                _Description = value;
                OnPropertyChanged(nameof(CurrentPostModel.Description));
            }
        }
        string _Description;

        public Type Type
        {
            get { return _Type; }
            set
            {
                _Type = value;
                OnPropertyChanged(nameof(CurrentPostModel.Type));
            }
        }
        Type _Type;
    }
}
