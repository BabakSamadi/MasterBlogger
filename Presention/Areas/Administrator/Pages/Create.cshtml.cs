using Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Presention.Areas.Administrator.Pages
{
    public class CreateModel : PageModel
    {
        private readonly IArticleCategoryApplication _articleCategoryApplication;
        public CreateModel(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
        }
        [BindProperty]
        public CreateArticleCategory Command { get; set; }
        public void OnGet()
        {
           
        }

        public IActionResult OnPost(CreateArticleCategory command)
        {
            try
            {
                _articleCategoryApplication.Create(command);
                return RedirectToPage("Index");
            }
            catch (InvalidOperationException ex)
            {
                // ???? ??? ?? ?? View ????? ???????
                ModelState.AddModelError(string.Empty, ex.Message);
                return Page();
            }
        }
    }
}
