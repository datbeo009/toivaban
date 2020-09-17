using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL
{
    public class UserBll
    {
        WebModel _dbContex = null;
        public UserBll()
        {
            _dbContex = new WebModel();
        }
        public List<Account> Gets()
        {
            return _dbContex.Accounts.ToList();
        }
        public bool CreateOrUpdateUser (Account entity)
        {
            try
            {
                if(entity.AccountID == 0)
                {
                   _dbContex.Accounts.Add(entity);
                }
                else
                {
                    var user = _dbContex.Accounts.Find(entity.AccountID);
                    user.Username = entity.Username;
                    user.Password = entity.Password;
                    user.Phone = entity.Phone;
                    user.Address = entity.Address;
                    user.Role = entity.Role;
                    user.Gender = entity.Gender;
                    user.CreatedDate = entity.CreatedDate;
                    user.LastModifiedDate = entity.LastModifiedDate;
                }
                _dbContex.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        public bool DeleteUser(int id)
        {
            try
            {
                _dbContex.Accounts.Remove(_dbContex.Accounts.Find(id));
                _dbContex.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
            
        }
        public bool CheckExistUserName(string name)
        {
            return _dbContex.Accounts.Any(e => e.Username == name);
        }
            
    }
}
