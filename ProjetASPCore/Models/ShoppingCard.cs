using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetASPCore.Models
{

    public class ShoppingCard
    {
        private readonly AppDbContext _appDbContext;

        public string ShoppingCardSessionID { get; set; }
        public ShoppingCard(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static ShoppingCard GetCard(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = service.GetService<AppDbContext>();

            var sessionCard = session.GetString("CardIdSession") ?? Guid.NewGuid().ToString();

        }
    }
}
