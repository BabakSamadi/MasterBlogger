using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using Application;
using Application.Contracts;
using Domain.ArticleCategoryAgg;
using Domain.ServicesCheckValidation;
using Infrastracture;
using Infrastracture.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace infrastracture_Services.Config
{
    public class Bootstrapper
    {
        public void config(IServiceCollection services, string ConnectionString)
        {

           services.AddTransient<IArticleCategoryApplication, ArticleCategoryApplication>();
           services.AddTransient<IArticleCategoryRepository, ArticleCategoryRepository>();
           services.AddTransient<IArticleCategoryValidatorServices, ArticleCategoryValidatorServices>();
            services.AddDbContext<MasterBlogContext>(options => options.UseSqlServer(ConnectionString));
        }
    }
}
