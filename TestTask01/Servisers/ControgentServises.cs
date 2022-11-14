using Microsoft.EntityFrameworkCore;
using TestTask01.Data;
using TestTask01.Models;
using System.Net.Http.Json;
using System;

namespace TestTask01.Servisers
{
    public class ControgentServises : IControgentServises
    {
        readonly TestTask01DB db;
        
        public Controgent? Controgent { get; set; }
        public List<Controgent>? Controgents { get; set; }
        public ControgentServises(TestTask01DB _db)
        {
            db = _db;
        }
        public async Task ControgentEdit(Controgent controgent)
        {
            if (controgent.Id != 0)
            {
                db.Controgents.Update(controgent);
            }
            else
            {
                db.Controgents.Add(controgent);
            }
            await db.SaveChangesAsync();
        }
        public async Task ControgentIsBaseByUNP(string UNP)
        {
            Controgent = await db.Controgents.FirstOrDefaultAsync(x => x.UNP == UNP);
        }

        public async Task GetStatusPortalByUNP(string UNP)
        {
            string requestPortal = $"http://www.portal.nalog.gov.by/grp/getData?unp={UNP}&type=json";
            HttpClient httpClient = new HttpClient();
            try
            {
                string portalData = await httpClient.GetStringAsync(requestPortal);
                int index = portalData.IndexOf("VKODS");
                if (index > 0)
                {
                    Controgent = new Controgent();
                    Controgent.Status = portalData.Substring(index + 8, 5);
                }
            }
            catch { }
            /*
             // не десерелизует
            Controgent? portalData = await httpClient.GetFromJsonAsync<Controgent>(requestPortal);            
            if (portalData != null)
            {
                Controgent = new Controgent { Name = portalData.Name, Status = portalData.Status };
            }
            else {
                Controgent = null;
            }
            */
            finally
            {
                httpClient.Dispose();
            }
        }
    }

}
