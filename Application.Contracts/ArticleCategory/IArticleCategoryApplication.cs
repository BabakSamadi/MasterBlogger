using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.ArticleCategory
{
    public interface IArticleCategoryApplication
    {
        List<ArticleCategoryViewModel> List();
        void Create(CreateArticleCategory command);
        void Rename(RenameArticleCategory command);

        RenameArticleCategory Get(int id);

        void Remove(int id);

        void Activate(int id);
    }
}
