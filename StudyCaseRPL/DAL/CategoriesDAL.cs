using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using StudyCaseRPL.Models;

namespace StudyCaseRPL.DAL
{
    public class CategoriesDAL
    {
        private SampleShopDbEntities db;

        public CategoriesDAL()
        {
            db = new SampleShopDbEntities();
        }

        //menampilkan semua data kategori
        public IQueryable<Category> GetAll()
        {
            var results = from c in db.Categories
                          orderby c.CategoryName ascending
                          select c;

            return results; 
        }

        //menampilkan data kategori berdasarkan id
        public Category GetById(int id)
        {
            var result = (from c in db.Categories
                         where c.CategoryID == id
                         select c).FirstOrDefault();

            if (result != null)
                return result;
            else
                throw new Exception("Data dengan id " + id.ToString() + " tidak ditemukan");
        }

        //menambahkan data Category
        public void Create(Category category)
        {
            try
            {
                db.Categories.Add(category);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }


        public void Update(Category category)
        {
            var result = GetById(category.CategoryID);
            if(result!=null)
            {
                result.CategoryName = category.CategoryName;
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
            {
                throw new Exception("Data tidak ditemukan !");
            }
        }


        public void Delete(Category category)
        {
            var result = GetById(category.CategoryID);
                
            if(result!=null)
            {
                try
                {
                    db.Categories.Remove(result);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

    }
}