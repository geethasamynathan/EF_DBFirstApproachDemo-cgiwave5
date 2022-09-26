using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EF_DBFirstApproachDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_DBFirstApproachDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly CgiWave5DBContext context=null;
       public CategoriesController()
        {
            context = new CgiWave5DBContext();
                
        }
        [HttpGet]
        public List<Category> GetCategories()
        {
            return context.Categories.ToList();
        }
        [HttpGet("{id}")]
        public Category GetCategoryById(int id)
        {
            Category category1= context.Categories.FirstOrDefault(c => c.CategoryId == id);

            Category category = context.Categories.Where(c => c.CategoryId == id).FirstOrDefault();
            return category;
        }

       [HttpPost]
       public void AddCategory(Category category)
        {
            context.Categories.Add(category);
             context.SaveChanges();
        }
        [HttpPut]
        public void UpdateCategory(Category category)
        {
           Category category1 = context.Categories.
                FirstOrDefault(c => c.CategoryId==category.CategoryId); 
            category1.CategoryName=category.CategoryName;
            context.Entry(category1).State = EntityState.Modified;
            context.SaveChanges();
        }
        [HttpDelete]
        public void DeleteCategory(int id)
        {
            Category delctegory=context.Categories.FirstOrDefault(c => c.CategoryId==id);
            if(delctegory!=null)
            context.Remove(delctegory);
            context.SaveChanges();
        }


    }
}
