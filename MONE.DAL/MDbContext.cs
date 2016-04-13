using MONE.Models;
using System.Data.Entity;

namespace MONE.DAL
{
    /// <summary>
    /// 数据上下文
    /// <remarks>创建：2014.02.03</remarks>
    /// </summary>
    public class MDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Roles> UserGroups { get; set; }
        public DbSet<UserRoleRelation> UserRoleRelations { get; set; }
        public DbSet<UserConfig> UserConfig { get; set; }
        public MDbContext()
            : base("DefaultConnection")
        {
        }
    }
}

