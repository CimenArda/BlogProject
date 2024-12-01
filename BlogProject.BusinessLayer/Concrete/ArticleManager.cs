using SensiveBlogProject.BusinessLayer.Abstract;
using SensiveBlogProject.DataAccessLayer.Abstract;
using SensiveBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveBlogProject.BusinessLayer.Concrete
{
    public class ArticleManager : IArticleService
    {

        private readonly IArticleDal _ArticleDal;

        public ArticleManager(IArticleDal ArticleDal)
        {
            _ArticleDal = ArticleDal;
        }

     

        public void TDelete(int id)
        {
            _ArticleDal.Delete(id);
        }
        
        public List<Article> TGetAll()
        {
            return _ArticleDal.GetAll();
        }

      

        public Article TGetById(int id)
        {
            return _ArticleDal.GetById(id);
        }

      

        public void TInsert(Article entity)
        {
            _ArticleDal.Insert(entity);

        }

        public void TUpdate(Article entity)
        {
            _ArticleDal.Update(entity);
        }
    }
}
