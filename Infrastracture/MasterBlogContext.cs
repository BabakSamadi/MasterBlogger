using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.ArticleAgg;
using Domain.ArticleCategoryAgg;
using Infrastracture.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Infrastracture
{
    public class MasterBlogContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        public MasterBlogContext(DbContextOptions<MasterBlogContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleMapping());
            modelBuilder.ApplyConfiguration(new ArticleCategoryMapping());
        
            base.OnModelCreating(modelBuilder);
        }
    }
}
