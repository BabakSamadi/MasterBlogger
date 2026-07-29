using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterBlogger.Domain.Common;
using MasterBlogger.Domain.Enums;

namespace MasterBlogger.Domain.Entities
{
    public class Post : BaseEntity
    {
        public string Title { get; private set; }
        public string Content { get; private set; }
        public string Summery { get; private set; }
        public string ImageUrl { get; private set; }
        public string Slug { get; private set; }
        public int CategoryId { get; private set; }
        public Category Category { get; private set; }
        public PostStatus Status { get; set; }


        private Post()
        {

        }


        public Post(string title, string content, string summery, string imageUrl, string slug, int categoryId, PostStatus status)
        {
            Title = title;
            Content = content;
            Summery = summery;
            ImageUrl = imageUrl;
            Slug = slug;
            CategoryId = categoryId;
            Status = status;
            UpdatedAt = DateTime.Now;
        }

        public void Update(string title, string content, string summery, string imageUrl, string slug, int categoryId)
        {
            Title = title;
            Content = content;
            Summery = summery;
            ImageUrl = imageUrl;
            Slug = slug;
            CategoryId = categoryId;
            
        }

        public void Publish()
        {
            Status = PostStatus.Published;
            UpdatedAt = DateTime.Now;
        }

        public void ChangeStatus(PostStatus newStatus)
        {
            Status = newStatus;
            UpdatedAt = DateTime.Now;

        }

    }

     
}
