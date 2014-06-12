using NorthwindSystem.DataAccessLayer;
using NorthwindSystem.Entities;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindSystem.BusinessLogicLayer
{
    //This is the primary public access into the NorthwindSystem data
    public partial class NorthwindManager
    {
        #region Shippers

        public Shipper GetShipper(int shipperId)
        {
            using (var context = new NWContext())
            {
                return context.Shippers.Find(shipperId);
            }
        }

        public IList<Shipper> ListShippers()
        {
            using (var context = new NWContext())
            {
                return context.Shippers.ToList();
                
                //var result = context.Regions.Include(item => item.Territories).OrderBy(item => item.RegionDescription);
                //return result.ToList();
            }
        }

        public void UpdateShipper(Shipper info)
        {
            //NOTE: See question and commentary on
            //  http://stackoverflow.com/questions/15336248/entity-framework-5-updating-a-record
            using (var context = new NWContext())
            {
                context.Shippers.Attach(info);
                context.Entry(info).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public int AddShipper(Shipper info)
        {
            using (var context = new NWContext())
            {
                context.Shippers.Add(info);
                context.SaveChanges();
                return info.ShipperID;
            }
        }

        public void DeleteShipper(Shipper info)
        {
            using (var context = new NWContext())
            {
                var found = context.Shippers.Find(info.ShipperID);
                if (found != null)
                {
                    context.Shippers.Remove(found);
                    context.SaveChanges();
                }
            }
        }

        #endregion

        #region Products

        public Product GetProduct(int productId)
        {
            using (var context = new NWContext())
            {
                return context.Products.Find(productId);
            }
        }

        public IList<Product> ListProducts()
        {
            using (var context = new NWContext())
            {
                return context.Products.ToList();
            }
        }

        public void UpdateProduct(Product info)
        {
            //NOTE: See question and commentary on
            //  http://stackoverflow.com/questions/15336248/entity-framework-5-updating-a-record
            using (var context = new NWContext())
            {
                context.Products.Attach(info);
                context.Entry(info).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public int AddProduct(Product info)
        {
            using (var context = new NWContext())
            {
                context.Products.Add(info);
                context.SaveChanges();
                return info.ProductID;
            }
        }

        public void DeleteProduct(Product info)
        {
            using (var context = new NWContext())
            {
                var found = context.Products.Find(info.ProductID);
                if (found != null)
                {
                    context.Products.Remove(found);
                    context.SaveChanges();
                }
            }
        }

        #endregion

        #region Legacy Code - GetEmployees, GetOrders, GetRegions
        public List<Employee> GetEmployees()
        {
            using (var context = new NWContext())
            {
                var result = context.Employees;
                return result.ToList();
            }
        }

        //TODO: Create a method called GetOrders() that will return a list of Order objets from teh database.
        public List<Order> GetOrders()
        {
            using (var context = new NWContext())
            {
                var result = context.Orders;
                return result.ToList();
            }
        }

        public List<Region> GetRegions()
        {
            using (var context = new NWContext())
            {
                var result = context.Regions.Include(item => item.Territories).OrderBy(item => item.RegionDescription);
                return result.ToList();
            }

        }
        #endregion



    }
}
