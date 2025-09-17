using Application.Contracts.Article;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Presention.Areas.Administrator.Pages.Article
{
    public class ListModel : PageModel
    {

        public List<ArticleViewModel> Articles { get; set; }

        private readonly IArticleApplication _articleApplication;
        public ListModel(IArticleApplication articleApplication)
        {
            _articleApplication = articleApplication;
        }

        public void OnGet()
        {
            Articles = _articleApplication.GetList();
        }
    }
}
