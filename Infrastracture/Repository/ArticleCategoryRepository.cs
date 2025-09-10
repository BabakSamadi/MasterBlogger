using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.ArticleCategoryAgg;

namespace Infrastracture.Repository
{
    public class ArticleCategoryRepository : IArticleCategoryRepository
    {
        private readonly MasterBlogContext _masterBlogContext;

        public ArticleCategoryRepository(MasterBlogContext masterBlogContext)
        {
            _masterBlogContext = masterBlogContext;
        }

        public void Create(ArticleCategory entity)
        {
            _masterBlogContext.ArticleCategories.Add(entity);
           save();
        }

      

        public ArticleCategory Get(long id)
        {
            return _masterBlogContext.ArticleCategories.FirstOrDefault(x => x.Id == id);
        }

        public List<ArticleCategory> GetAll()
        {
            return _masterBlogContext.ArticleCategories.ToList();
        }

        public bool Exist(string title)
        {
            return _masterBlogContext.ArticleCategories.Any(x => x.Title == title);
        }

        public void save()
        {
            _masterBlogContext.SaveChanges();
        }
    }
}
