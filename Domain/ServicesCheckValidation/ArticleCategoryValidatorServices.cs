using Domain.ArticleCategoryAgg;

namespace Domain.ServicesCheckValidation;

public class ArticleCategoryValidatorServices : IArticleCategoryValidatorServices
{
    private readonly IArticleCategoryRepository _articleCategoryRepository;
    public ArticleCategoryValidatorServices(IArticleCategoryRepository articleCategoryRepository)
    {
        _articleCategoryRepository = articleCategoryRepository;
    }

    public void CheckThatThisRecordAlreadyExist(string title)
    {
        if (_articleCategoryRepository.Exist(title))
           throw new  InvalidOperationException("این عنوان قبلاً ثبت شده است.");
    }
}