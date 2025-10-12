using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Contracts.Article;
using Domain.ArticleAgg;
using Microsoft.EntityFrameworkCore;

namespace Infrastracture.Repository
{
    public class ArticleRepository :IArticleRepository  
    {
        private readonly MasterBlogContext _context;

        public ArticleRepository(MasterBlogContext context)
        {
            _context = context;
        }

        public void CreateAndSave(Article entity)
        {
            _context.Articles.Add(entity);
            Save();
        }

       

        public List<ArticleViewModel> GetList()
        {
            return _context.Articles.Include(x => x.articleCategory).Select(x => new ArticleViewModel()
            {
              Id = x.Id,
              Title = x.Title,
              ArticleCategory = x.articleCategory.Title,
              IsActive = x.IsActive ,
              CreationDate = x.CreationDate.ToString( CultureInfo.InvariantCulture)
            }).ToList();
        }
        public Article Get(int id)
        {
            return _context.Articles.FirstOrDefault(x => x.Id == id);
           
        }


        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
