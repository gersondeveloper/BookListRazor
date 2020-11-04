using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookListRazor.Pages.BookList
{
    public class Index  : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IEnumerable<Book> Books { get; set; }
        
        public Index(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task OnGet()
        {
            Books = await _context.Books.ToListAsync();
        }
    }
}