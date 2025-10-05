using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.ArticleCategoryAgg;

namespace Domain.ArticleAgg
{
    public class Article
    {
        public int Id { get; private set; }

        public string Title { get; private set; }

        public string ShortDescription  { get; private set; }

        public string Image { get; private set; }

        public string Content { get; private set; }

        public bool Isdeleted { get; private set; }

        public DateTime CreationDate { get; private set; }

        public int ArticleCategoryId { get; private set; }
        public ArticleCategory articleCategory { get; private set; }



        protected Article()
        {

        }


        public Article(string title, string shortDescription, string image, string content, int articleCategoryId)
        {
            Title = title;
            ShortDescription = shortDescription;
            Image = image;
            Content = content;
            ArticleCategoryId = articleCategoryId;
            Isdeleted =false;
            CreationDate = DateTime.Now;

         }

        public void Edit(string title, string shortDiscription, string image, string content, int articleCategoryId)
        {
            Title = title;
            ShortDescription = shortDiscription;
            Image = image;
            Content = content;
            ArticleCategoryId = articleCategoryId; 
        }
    }
}
