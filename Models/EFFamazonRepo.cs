using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_6_Joisah_Sarles.Models
{
    public class EFFamazonRepo : IFamazonRepo
    {
        private FamazonDbContext _context;

        public EFFamazonRepo(FamazonDbContext context)
        {
            _context = context;
        }

        public IQueryable<Book> books => _context.books;
    }
}
