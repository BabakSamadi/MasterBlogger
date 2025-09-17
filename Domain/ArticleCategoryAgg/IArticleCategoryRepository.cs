using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ArticleCategoryAgg
{
    public interface IArticleCategoryRepository
    {
        List<ArticleCategory> GetAll();

        ArticleCategory Get(int id);
        void Create(ArticleCategory entity);

        void save();

        bool Exist(string title);
    }
}
