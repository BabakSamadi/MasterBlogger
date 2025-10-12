using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Contracts.Article;

namespace Domain.ArticleAgg
{
    public interface IArticleRepository
    {

        List<ArticleViewModel> GetList();

        void CreateAndSave(Article entity);
        Article Get(int id);

        void Save();
    }
}
