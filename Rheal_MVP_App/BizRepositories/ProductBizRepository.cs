using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Rheal_MVP_App.Models;

namespace Rheal_MVP_App.BizRepositories
{
    public class ProductBizRepository : IBizRepository<Product, int>
    {
        RHealDbContext ctx;

        public ProductBizRepository()
        {
            ctx = new RHealDbContext();
        }
        public Product Create(Product entity)
        {
            entity = ctx.Products.Add(entity);
            ctx.SaveChanges();
            return entity;
        }

        public bool Delete(int id)
        {
            Product pd = ctx.Products.Find(id);
            if (pd == null) return false;
            ctx.Products.Remove(pd);
            ctx.SaveChanges();
            return true;
        }

        public List<Product> getData()
        {
            return ctx.Products.ToList();
        }

        public Product getData(int id)
        {
            Product pd = ctx.Products.Find(id);
            return pd;
        }

        public Product Update(int id, Product entity)
        {
            Product pd = ctx.Products.Find(id);
            if(pd !=null)
            {
                pd.ProductId = entity.ProductId;
                pd.ProductName = entity.ProductName;
                pd.ProductManufacturer = entity.ProductManufacturer;
                pd.ProductDescription = entity.ProductDescription;
                ctx.SaveChanges();
                return pd;
            }
            return entity;
        }
    }
}