using Windows.UI.Xaml.Media;

namespace ArtTherapy.Models.PostModels
{
    public class CurrentPostModel : BaseModel
    {
        public uint Id
        {
            get => _Id;
            set => _Id = GetValue(value, nameof(Id));
        }
        private uint _Id;

        public ImageSource Image
        {
            get => _Image;
            set => _Image = GetValue(value, nameof(Image));
        }
        private ImageSource _Image;

        public string Name
        {
            get => _Name;
            set => _Name = GetValue(value, nameof(Name));
        }
        private string _Name;

        public string Description
        {
            get => _Description;
            set => _Description = GetValue(value, nameof(Description));
        }
        private string _Description;

        public string Type
        {
            get => _Type;
            set => _Type = GetValue(value, nameof(Type));
        }
        private string _Type;
    }
}
