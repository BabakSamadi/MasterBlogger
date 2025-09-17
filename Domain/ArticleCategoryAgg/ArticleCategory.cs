using Domain.ArticleAgg;
using Domain.ServicesCheckValidation;

namespace Domain.ArticleCategoryAgg
{
    public class ArticleCategory
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public  bool IsDeleted { get; set; }

        public DateTime CreationDate { get; set; }

        public ICollection<Article> Articles { get;  private set; }

        public ArticleCategory()
        {
            // EF Core برای ساختن موجودیت‌ها از دیتابیس اینو استفاده می‌کنه
        }

        public ArticleCategory(string title, IArticleCategoryValidatorServices validatorServices)
        {
            GuaredAgainstEmptyTitle(title);
            validatorServices.CheckThatThisRecordAlreadyExist(title);
            Title = title;
            IsDeleted = true;
            CreationDate = DateTime.Now;
            Articles = new List<Article>();
        }


        public void GuaredAgainstEmptyTitle(string title )   // validiton Domain pervent Null Name
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentNullException();
        }

        public void Rename(string title)
        {
            GuaredAgainstEmptyTitle(title);
            Title = title;
        }

        public void Remove()
        {
            IsDeleted = false;
        }

        public void Active()
        {
            IsDeleted = true;
        }
    }
}
