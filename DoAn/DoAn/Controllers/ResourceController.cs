using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagement.Models;


namespace ProjectManagement.Controllers
{
    public class ResourceController
    {
        public static bool AddResource(Resource re)
        {
            try
            {
                using(var context = new QuanLyProjectEntities())
                {
                    context.Resources.Add(re);
                    context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static int GetIDResource()
        {
            using (var _context = new QuanLyProjectEntities())
            {
                var id = (from t in _context.Resources
                          select t.ID).ToList();
                if (id.Count <= 0)
                    return 1;
                else
                    return id.Max() + 1;
            }
        }

        public static Resource GetResource(int id)
        {
            using (var _context = new QuanLyProjectEntities())
            {
                var user = (from u in _context.Resources
                            where u.ID == id
                            select u).ToList();
                if (user.Count == 1)
                {
                    return user[0];
                }
                else
                {
                    return null;
                }
            }
        }

        public static List<Resource> getListResource()
        {
            using (var _context = new QuanLyProjectEntities())
            {
                var user = (from u in _context.Resources.AsEnumerable()
                            select u)
                            .Select(x => new Resource
                            {
                                ID = x.ID,
                                Ten = x.Ten,
                                NgaySinh = x.NgaySinh,
                                VaiTro = x.VaiTro,
                                SoDienThoai = x.SoDienThoai,
                                Mail = x.Mail,
                               
                            }).ToList();
                return user;
            }
        }

        public static bool DeleteResource(Resource user)
        {
            using (var _context = new QuanLyProjectEntities())
            {
                //xoa list 
                var dbuser = (from u in _context.Resources
                              where u.ID == user.ID
                              select u).SingleOrDefault();
                /*
                    foreach (var u in _context.Tasks)
                    {
                        if (u.IDResource == user.ID)
                        {
                        u.IDResource = null;
                            break;
                        }
                    }
                */
                _context.Resources.Remove(dbuser);
                _context.SaveChanges();
                return true;
            }
        }

        /*
        public static bool UpdateResource(Resource user)
        {
            try
            {
                using (var _context = new QuanLyProjectEntities())
                {
                    _context.Resources.AddOrUpdate(user);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        */
    }
}
