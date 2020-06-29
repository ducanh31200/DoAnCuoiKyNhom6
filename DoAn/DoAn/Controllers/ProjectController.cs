using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagement.Models;
using System.Data.Entity.Migrations;

namespace ProjectManagement.Controllers
{
    public class ProjectController
    {
        
        public static int GetIDProject()
        {
            using (var _context = new QuanLyProjectEntities())
                {
                    var id = (from t in _context.Projects
                              select t.ID).ToList();
                if (id.Count <= 0)
                    return 1;
                else
                    return id.Max() + 1;
                }
        }
        
        public static bool AddProject(Project project)
        {
            using (var _context = new QuanLyProjectEntities())
            {
                _context.Projects.AddOrUpdate(project);
                _context.SaveChanges();
                return true;
            }
        }
        public static List<Project> GetListProject()
        {
            using (var _context = new QuanLyProjectEntities())
            {
                var project = (from u in _context.Projects.AsEnumerable()
                            select u)
                            .Select(x => new Project
                            {
                                ID = x.ID,
                                TenProject = x.TenProject,
                                NgayBatDau = x.NgayBatDau,
                                NgayKetThuc = x.NgayKetThuc,
                                Tasks =x.Tasks

                            }).ToList();
                return project;
            }
        }

        public static Project GetProject(int id)
        {
            using (var _context = new QuanLyProjectEntities())
            {
                var user = (from u in _context.Projects
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

        public static bool DeleteProject(Project project)
        {
            using (var _context = new QuanLyProjectEntities())
            {
                //xoa list 
                var dbpro = (from u in _context.Projects
                              where u.ID == project.ID
                              select u).SingleOrDefault();
                //xoa task
                using (var _context2 = new QuanLyProjectEntities())
                {
                    var dbtask = (from u in _context2.Tasks
                                  where u.IDProject == project.ID
                                  select u).ToList();
                    for(int i=0;i<dbtask.Count;i++)
                        _context2.Tasks.Remove(dbtask[i]);
                    _context2.SaveChanges();
                    //return true;
                }

                _context.Projects.Remove(dbpro);
                _context.SaveChanges();
                return true;
            }
        }


    }
}
