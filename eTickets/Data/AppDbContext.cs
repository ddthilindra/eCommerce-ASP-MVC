using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDbContext:DbContext
    {
        //ctor + TAB2 default constructor
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
    }
}
