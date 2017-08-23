using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtTherapy.Models
{
    public class ItemModel : BaseModel
    {
        public string Icon
        {
            get { return _Icon; }
            set
            {
                _Icon = value;
                OnPropertyChanged(nameof(ItemModel.Icon));
            }
        }
        string _Icon;

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged(nameof(ItemModel.Name));
            }
        }
        string _Name;

        public string Description
        {
            get { return _Description; }
            set
            {
                _Description = value;
                OnPropertyChanged(nameof(ItemModel.Description));
            }
        }
        string _Description;

        public Type Type
        {
            get { return _Type; }
            set
            {
                _Type = value;
                OnPropertyChanged(nameof(ItemModel.Type));
            }
        }
        Type _Type;
    }
}
