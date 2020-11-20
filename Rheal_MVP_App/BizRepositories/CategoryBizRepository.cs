using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Rheal_MVP_App.Models;

namespace Rheal_MVP_App.BizRepositories
{
    public class CategoryBizRepository : IBizRepository<Category, int>
    {
        RHealDbContext ctx;

        public CategoryBizRepository()
        {
            ctx = new RHealDbContext();
        }

        public Category Create(Category entity)
        {
            entity = ctx.Categories.Add(entity);
            ctx.SaveChanges();
            return entity;
        }

        public bool Delete(int id)
        {
            Category cat = ctx.Categories.Find(id);
            if (cat == null) return false;
            ctx.Categories.Remove(cat);
            ctx.SaveChanges();
            return true;
        }

        public List<Category> getData()
        {
            return ctx.Categories.ToList();
        }

        public Category getData(int id)
        {
            Category cat = ctx.Categories.Find(id);
            return cat;
        }

        public Category Update(int id, Category entity)
        {
            Category cat = ctx.Categories.Find(id);
            if (cat != null)
            {
                cat.CategoryId = entity.CategoryId;
                cat.CategoryName = entity.CategoryName;
                cat.CategoryBasePrice = entity.CategoryBasePrice;
                ctx.SaveChanges();
                return cat;
            }
            return entity;
        }
    }
}