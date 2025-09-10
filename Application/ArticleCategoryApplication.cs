using System.Globalization;
using Application.Contracts;
using Domain.ArticleCategoryAgg;
using Domain.ServicesCheckValidation;
using Infrastracture.Repository;

namespace Application
{
    public class ArticleCategoryApplication : IArticleCategoryApplication
    {
        private readonly IArticleCategoryRepository _ArticleCategoryRepository;
        private readonly IArticleCategoryValidatorServices _ArticleCategoryValidatorServices;

        public ArticleCategoryApplication (IArticleCategoryRepository articleCategoryRepository , IArticleCategoryValidatorServices articleCategoryValidatorServices)
        {
            _ArticleCategoryRepository = articleCategoryRepository;
            _ArticleCategoryValidatorServices = articleCategoryValidatorServices;
        }

        public List<ArticleCategoryViewModel> List()
        {
            var articleCategories = _ArticleCategoryRepository.GetAll();
            var result = new List<ArticleCategoryViewModel>();
            foreach (var ArticleCategory in articleCategories)
            {
                result.Add(new ArticleCategoryViewModel
                {
                   Id = ArticleCategory.Id,
                   Title = ArticleCategory.Title,
                   IsDeleted = ArticleCategory.IsDeleted,
                   CreationDate = ArticleCategory.CreationDate,
                });

            }

            return result;

        }

        public void Create(CreateArticleCategory command)
        {
            var articleCategory = new ArticleCategory(command.Title , _ArticleCategoryValidatorServices );
            _ArticleCategoryRepository.Create(articleCategory);
        }

        public void Rename(RenameArticleCategory command)
        {
           var articlecategory = _ArticleCategoryRepository.Get(command.Id);

           articlecategory.Rename(command.Title);
           _ArticleCategoryRepository.save();
        }

        public RenameArticleCategory Get(long id)
        {
            var articleCategory = _ArticleCategoryRepository.Get(id);
            return new RenameArticleCategory()
            {
                Id = articleCategory.Id,
                Title = articleCategory.Title,
            };
        }

        public void Remove(long id)
        {
            var articlecategory = _ArticleCategoryRepository.Get(id);
            articlecategory.Remove();
            _ArticleCategoryRepository.save();
        }

        public void Activate(long id)
        {
            var articleCategory = _ArticleCategoryRepository.Get(id);
            articleCategory.Active();
            _ArticleCategoryRepository.save();
        }
    }
}
