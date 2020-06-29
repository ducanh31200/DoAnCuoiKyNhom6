using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagement.Models;

namespace ProjectManagement.Controllers
{
    public class AccountController
    {
        public static bool CheckAccount(string tk,string mk)
        {
            using (var _context = new QuanLyProjectEntities())
            {
                var user = (from u in _context.Accounts
                            where u.TenDangNhap == tk && u.MatKhau ==mk
                            select u).ToList();
                if (user.Count == 1)
                {
                        return true;
                }
                   return false;
                
            }
        }
        public static bool AddAccount(Account account)
        {
            using (var _context = new QuanLyProjectEntities())
            {
                _context.Accounts.AddOrUpdate(account);
                _context.SaveChanges();
                return true;
            }
        }
    }
}
