using TestTask01.Models;
using TestTask01.Data;
using Microsoft.EntityFrameworkCore;

namespace TestTask01.Servisers
{
    public class PolzovatelServises : IPolzovatelServises
    {
        readonly TestTask01DB db;
        public Polzovatel? Polzovatel { get; set; }
        public List<Polzovatel>? Polzovatels { get; set; }
        public List<OrderControgent> OrderControgents { get; set; }

        public PolzovatelServises(TestTask01DB _db)
        {
            db= _db;
        }
        public async Task GetPolzovatelByEmail(string email)
        {
            Polzovatel = await db.Polzovatels.FirstOrDefaultAsync(x => x.Email == email);
        }

        public async Task PolzovatelEdit(Polzovatel polzovatel)
        {
            if (polzovatel.Id == 0)
            {
                db.Polzovatels.Add(polzovatel);
                await db.SaveChangesAsync();
            }
            else {
                db.Polzovatels.Update(polzovatel);
                await db.SaveChangesAsync();
            }
            
        }

        public async Task GetControgentList(Polzovatel polzovatel)
        {
            OrderControgents = await db.OrderControgents.Where(x => x.PolzovatelId == polzovatel.Id).Include(x=>x.Controgent).ToListAsync();
        }

        public async Task GetPolzovatelList()
        {
            Polzovatels = await db.Polzovatels.ToListAsync();
        }
    }
}
