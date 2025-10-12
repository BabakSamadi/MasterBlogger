using Application;
using Application.Contracts.Article;
using Application.Contracts.ArticleCategory;
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

        public RedirectToPageResult OnPostRemove(int id)
        {
            _articleApplication.Remove(id);
            return RedirectToPage("./List");
        }

        public RedirectToPageResult OnPostActivate(int id)
        {
            _articleApplication.Activate(id);
            return RedirectToPage("./List");
        }

    }
}







