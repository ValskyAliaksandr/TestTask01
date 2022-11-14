using TestTask01.Data;
namespace TestTask01.Servisers
{
    public class MailinglistTaskServises
    {
        Timer timer;
        readonly TestTask01DB db;
        public MailinglistTaskServises(TestTask01DB _db)
        {
            db = _db;            
        }
        public async Task SendEmail()
        { 
        }
        public async Task UpdateStatusContagent()
        {
        }
    }
}
