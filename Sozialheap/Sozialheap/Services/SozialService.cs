using Sozialheap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sozialheap.Services
{
    public class SozialService
    {
        // The database.
        ApplicationDbContext db = new ApplicationDbContext();

        public List<Group> GetAllGroup()
        {
            List<Group> g = new List<Group>();
            return g;
        }

        public List<User> GetAllUsers()
        {
            List<User> u = new List<User>();
            return u;
        }
    }
}