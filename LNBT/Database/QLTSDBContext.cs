using LNBT.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNBT.Database
{
    public class QLTSDBContext : DbContext
    {
        public QLTSDBContext() : base("QLTSDBContext")
        {
        }

        public DbSet<TKNhanVien> TKNhanViens { get; set; }
    }
}
