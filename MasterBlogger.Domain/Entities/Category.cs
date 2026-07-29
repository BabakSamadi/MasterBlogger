using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterBlogger.Domain.Common;

namespace MasterBlogger.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Title { get; private set; }

        public string ImageUrl { get; private set; }

        public ICollection<Post> Post { get; private set; }


        private Category( )
        {
          Post = new List<Post>();
        }

    public Category(string title, string imageUrl)
        {
            Title = title;
            ImageUrl = imageUrl;
        }

        public void Update(string title, string imageUrl)
        {
            Title = title;
            ImageUrl = imageUrl;
        }
    }
}
