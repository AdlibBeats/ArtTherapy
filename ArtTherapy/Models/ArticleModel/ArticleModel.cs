using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtTherapy.Models.Article
{
    public class ArticleModel : BaseModel
    {
        //author, title,

        public string Title
        {
            get => _Title;
            set
            {
                _Title = value;
                OnPropertyChanged(nameof(ArticleModel.Title));
            }
        }
        private string _Title;

        public string Text
        {
            get => _Text;
            set
            {
                _Text = value;
                OnPropertyChanged(nameof(ArticleModel.Text));
            }
        }
        private string _Text;

        public string Author
        {
            get => _Author;
            set
            {
                _Author = value;
                OnPropertyChanged(nameof(ArticleModel.Author));
            }
        }
        private string _Author;
    }
}
