using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TIdentity.Models;

namespace Vidly.Context
{
    public class VidlyDbContext : IdentityDbContext<ApplicationUser>
    {
        public VidlyDbContext()
            : base("VidlyConnectionString", throwIfV1Schema: false)
        {

        }

        public static VidlyDbContext Create()
        {
            return new VidlyDbContext();
        }

    }
}