using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagement.Models;


namespace ProjectManagement.Controllers
{
    public class TaskController
    {
        public static int GetIDTask()
        {
            using (var _context = new QuanLyProjectEntities())
            {
                var id = (from t in _context.Tasks
                          select t.ID).ToList();
                if (id.Count <= 0)
                    return 1;
                else
                    return id.Max() + 1;
            }
        }

        public static bool AddTask(Models.Task tasks)
        {
            using (var _context = new QuanLyProjectEntities())
            {
                _context.Tasks.AddOrUpdate(tasks);
                _context.SaveChanges();
                return true;
            }
        }
        public static List<Models.Task> GetListTask(int idPro)
        {
            using (var _context = new QuanLyProjectEntities())
            {
                var task = (from u in _context.Tasks.AsEnumerable()
                            where u.IDProject == idPro
                            select u)
                            .Select(x => new Models.Task
                            
                            {
                                ID = x.ID,
                                IDProject = x.IDProject,
                                IDResource = x.IDResource,
                                TenCongViec = x.TenCongViec,
                                MoTa = x.MoTa,
                                NgayBatDau = x.NgayBatDau,
                                NgayKetThuc = x.NgayKetThuc,
                                
                            }).ToList();
                return task;
            }
        }

        public static Models.Task GetTask(int id)
        {
            using (var _context = new QuanLyProjectEntities())
            {
                var user = (from u in _context.Tasks
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
        /*
        public static int GetIdNTH(string name)
        {
            using (var _context = new QuanLyProjectEntities())
            {
                var user = (from u in _context.Tasks
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
        */
        public static bool DeleteTask(Models.Task task)
        {
            using (var _context = new QuanLyProjectEntities())
            {
                //xoa list 
                var dbtask = (from u in _context.Tasks
                             where u.ID == task.ID
                             select u).SingleOrDefault();
                /*
                foreach (var task in dbuser.TaskWorks)
                {
                    foreach (var u in task.Resources)
                    {
                        if (u.ID == user.ID)
                        {
                            task.Users.Remove(u);
                            break;
                        }
                    }
                }
                */
                _context.Tasks.Remove(dbtask);
                _context.SaveChanges();
                return true;
            }
        }


    }
}
