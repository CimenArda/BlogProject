﻿using BlogProject.DataAccesLayer.Context;
using Microsoft.EntityFrameworkCore;
using SensiveBlogProject.DataAccessLayer.Abstract;
using SensiveBlogProject.DataAccessLayer.Repositories;
using SensiveBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveBlogProject.DataAccessLayer.EntityFramework
{
    public class EfArticleDal : GenericRepository<Article>, IArticleDal
    {
        public EfArticleDal(BlogContext context) : base(context)
        {
        }

        public List<Article> LastTake5ListArticlesWithCategory()
        {
            using (var context = new BlogContext())
            {
                return context.Articles.Include(x => x.Category).OrderByDescending(x=>x.ArticleId).Take(5).ToList();
            }
        }
    }
}
