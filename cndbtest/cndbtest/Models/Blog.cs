using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cndbtest.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateTime { get; set; }
        public List<Post> Posts { get; set; }
    }
}
