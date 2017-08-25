using System;

namespace ArtTherapy.Models.ItemsModels
{
    public class CurrentItemModel : BaseModel
    {
        public string Icon
        {
            get { return _Icon; }
            set => _Icon = GetValue(value, nameof(Icon));
        }
        string _Icon;

        public string Name
        {
            get { return _Name; }
            set => _Name = GetValue(value, nameof(Name));
        }
        string _Name;

        public string Description
        {
            get { return _Description; }
            set => _Description = GetValue(value, nameof(Description));
        }
        string _Description;

        public Type Type
        {
            get { return _Type; }
            set => _Type = GetValue(value, nameof(Type));
        }
        Type _Type;
    }
}
