using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogservise
    {
        void BlogAdd(Blog blog);
        void BlogDelete(Blog blog);
        void BlogUpdate(Blog blog);
        List<Blog> GetBlogListByWriter();
        Blog GetById(int id);

        List<Blog> GetBlogListWithCategori();

        List<Blog> GetBlogListByWriter(int id);
    }
}
