using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Article
{
    public class ArticleViewModel
    { 
        public int Id { get; set; }
        public String Title { get; set; }

        public string ArticleCategory { get; set; }
        public bool IsActive { get; set; }

        public string CreationDate { get; set; }
     }
}
