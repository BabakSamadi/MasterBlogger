using System.Security.Cryptography.X509Certificates;
using Application.Contracts.Article;
using Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Presention.Areas.Administrator.Pages.Article
{
    public class EditModel : PageModel
    {

         [BindProperty]public EditArticle Article { get; set; }

         public List<SelectListItem> ArticleCategory { get; set; }
         private readonly IArticleApplication _articleApplication;
         private readonly IArticleCategoryApplication _categoryApplication;

         public EditModel(IArticleApplication articleApplication , IArticleCategoryApplication articleCategoryApplication)
         {
             _articleApplication = articleApplication;
             _categoryApplication = articleCategoryApplication;
         }
        public void OnGet(int id)
        {
            Article = _articleApplication.Get(id);
            ArticleCategory = _categoryApplication.List()
                .Select(x => new SelectListItem(x.Title, x.Id.ToString())).ToList();

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                ArticleCategory = _categoryApplication.List()
                    .Select(x => new SelectListItem(x.Title, x.Id.ToString())).ToList();
                return Page();
            }

            _articleApplication.Edit(Article);
            return RedirectToPage("./List");
        }

    }
}
