using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.ArticleAgg;

namespace Infrastracture.Repository
{
    public class ArticleRepository :IArticleRepository  
    {
        private readonly MasterBlogContext _context;

        public ArticleRepository(MasterBlogContext context)
        {
            _context = context;
        }
    }
}
