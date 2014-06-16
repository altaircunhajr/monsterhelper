using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MonsterHelper.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MonsterHelper.App_Start
{
    public class DbInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {

            var diasDaSemana = new List<DiaDaSemana> 
            {
                new DiaDaSemana { Nome = "Domingo" },
                new DiaDaSemana { Nome = "Segunda" },
                new DiaDaSemana { Nome = "Terça" },
                new DiaDaSemana { Nome = "Quarta" },
                new DiaDaSemana { Nome = "Quinta" },
                new DiaDaSemana { Nome = "Sexta" },
                new DiaDaSemana { Nome = "Sábado" }
            };

            diasDaSemana.ForEach( item => context.DiasDaSemana.Add(item) );
            context.SaveChanges();

            //var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            //var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            //string name = "admin";
            //string password = "123456";

            //var roleresult = RoleManager.Create(new IdentityRole(name));

            //var user = new ApplicationUser();
            //user.UserName = name;

            //var adminResult = UserManager.Create(user, password);

            //var result = UserManager.AddToRole(user.Id, name);

            base.Seed(context);
        }
    }
}