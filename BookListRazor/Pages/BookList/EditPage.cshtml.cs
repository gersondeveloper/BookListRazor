using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookList
{
    public class EditPage : PageModel
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public Book Book { get; set; }
        
        public EditPage(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task OnGet(int id)
        {
            Book = await _context.Books.FindAsync(id);
        }
    }
}