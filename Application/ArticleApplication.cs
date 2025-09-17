﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Contracts.Article;
using Domain.ArticleAgg;

namespace Application
{
    public class ArticleApplication : IArticleApplication
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleApplication(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }
        public List<ArticleViewModel> GetList()
        {
            return _articleRepository.GetList();
        }
    }
}
