using System;

namespace ArtTherapy.Models.ItemsModels
{
    public class CurrentItemModel : BaseModel
    {
        public string Icon
        {
            get => _Icon;
            set => _Icon = GetValue(value, nameof(Icon));
        }
        private string _Icon;

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

        public Type Type
        {
            get =>_Type;
            set => _Type = GetValue(value, nameof(Type));
        }
        private Type _Type;
    }
}
