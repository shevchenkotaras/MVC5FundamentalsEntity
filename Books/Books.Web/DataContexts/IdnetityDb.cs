using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Books.Web.Models;

namespace Books.Web.DataContexts
{
    public class IdntityDb : IdentityDbContext<ApplicationUser>
    {
        public IdntityDb()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static IdntityDb Create()
        {
            return new IdntityDb();
        }
    }
}