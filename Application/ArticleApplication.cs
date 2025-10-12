using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Contracts.Article;
using Domain.ArticleAgg;

namespace Application
{
    public class ArticleApplication : IArticleApplication
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleApplication(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

       

        public void Create(CreateArticle command)
        {
            var article = new Article(command.Title, command.ShortDescription, command.Image, command.content,
                command.ArticleCategoryId);

            _articleRepository.CreateAndSave(article);
        }

        public void Edit(EditArticle command)
        {
           var article =  _articleRepository.Get(command.Id);
           article.Edit(command.Title, command.ShortDescription, command.Image ,command.content , command.ArticleCategoryId);
           _articleRepository.Save();
        }

        public EditArticle Get(int id)
        {
            var article = _articleRepository.Get(id);

            return new EditArticle()
            {
                Id = article.Id,
                Title = article.Title,
                Image = article.Image,
                ShortDescription = article.ShortDescription,
                content = article.Content,
                ArticleCategoryId = article.ArticleCategoryId
            };
        }




        public List<ArticleViewModel> GetList()
        {
            return _articleRepository.GetList();
        }

        public void Activate(int id)
        {
            var article = _articleRepository.Get(id);
            if (article != null)
            {
                article.Activate(); // ✅ فعال کردن
                _articleRepository.Save();
            }
        }
        
        public void Remove(int id)
        {
            var article = _articleRepository.Get(id);
            if (article != null)
            {
                article.Deactivate(); // ✅ غیرفعال کردن
                _articleRepository.Save();
            }
        }
    }
}
