using BlogProject.DataAccesLayer.Context;
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
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public EfCommentDal(BlogContext context) : base(context)
        {
        }

        List<Comment> ICommentDal.GetCommentListByArticleId(int id)
        {
            var context = new BlogContext();
            var values = context.Comments.Where(x => x.ArticleId == id).Include(y => y.AppUser).Include(z => z.Article).ToList();
            return values;
        }
    }
}
