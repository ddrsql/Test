using cndbtest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cndbtest
{
    public class DMBloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //配置DM连接字符串
            optionsBuilder.UseDm("Server=192.168.x.xx;User ID=ddrsql;PWD=qwe123456;PORT=5236;");
        }
    }
}
