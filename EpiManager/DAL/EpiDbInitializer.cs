using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EpiManager.Models;

namespace EpiManager.DAL
{

    public class EpiDbInitializer : System.Data.Entity.DropCreateDatabaseAlways<EpiContext>
    {
        protected override void Seed(EpiContext context)
        {
            var epikinds = new List<EpiKind>
            {
                new EpiKind{EpiKindId = 1, EpiKindName = "Face"},
                new EpiKind{EpiKindId = 2, EpiKindName = "Leg"},
                new EpiKind{EpiKindId = 3, EpiKindName = "Shin"},
                new EpiKind{EpiKindId = 4, EpiKindName = "Thigh"}
            };

            epikinds.ForEach(x => context.EpiKind.Add(x));
            context.SaveChanges();

            var priceHeader = new List<PriceHeader>
            {
                new PriceHeader {PriceName = "General"},
                new PriceHeader {PriceName = "Discount"}
            };

            priceHeader.ForEach(x => context.PriceHeader.Add(x));
            context.SaveChanges();

            var priceLines = new List<PriceLine>
            {
                new PriceLine {PriceHeaderId = 1, EpiKindId = 1, Price = 90},
                new PriceLine {PriceHeaderId = 1, EpiKindId = 2, Price = 150},
                new PriceLine {PriceHeaderId = 1, EpiKindId = 3, Price = 120},
                new PriceLine {PriceHeaderId = 1, EpiKindId = 4, Price = 80},

                new PriceLine {PriceHeaderId = 2, EpiKindId = 1, Price = 9},
                new PriceLine {PriceHeaderId = 2, EpiKindId = 2, Price = 15},
                new PriceLine {PriceHeaderId = 2, EpiKindId = 3, Price = 12},
                new PriceLine {PriceHeaderId = 2, EpiKindId = 4, Price = 8}
            };

            priceLines.ForEach(x => context.PriceLines.Add(x));
            context.SaveChanges();

            var customers = new List<Customer>
            {
                new Customer {PriceHeaderId = 1, FirstName = "Carson", LastName = "Alexander", MobileNumber = "599222201"},
                new Customer {PriceHeaderId = 1, FirstName = "Meredith", LastName = "Alonso", MobileNumber = "599222202"},
                new Customer {PriceHeaderId = 1, FirstName = "Arturo", LastName = "Anand", MobileNumber = "599222203"},
                new Customer {PriceHeaderId = 1, FirstName = "Gytis", LastName = "Barzdukas", MobileNumber = "599222204"},
                new Customer {PriceHeaderId = 1, FirstName = "Yan", LastName = "Li", MobileNumber = "599222205"},
                new Customer {PriceHeaderId = 1, FirstName = "Peggy", LastName = "Justice", MobileNumber = "599222206"},
                new Customer {PriceHeaderId = 2, FirstName = "Laura", LastName = "Norman", MobileNumber = "599222207"},
                new Customer {PriceHeaderId = 2, FirstName = "Nino", LastName = "Olivetto", MobileNumber = "599222208"}
            };

            customers.ForEach(x => context.Customers.Add(x));
            context.SaveChanges();

            var appointments = new List<Appointment>
            {
                new Appointment { CustomerId = 1, Date = DateTime.Today.AddDays(1), PriceHeaderId = 2 },
                new Appointment { CustomerId = 1, Date = DateTime.Today.AddDays(2), PriceHeaderId = 2  },
                new Appointment { CustomerId = 2, Date = DateTime.Today.AddDays(20), PriceHeaderId = 2  },
                new Appointment { CustomerId = 2, Date = DateTime.Today.AddDays(21), PriceHeaderId = 2  }
            };

            appointments.ForEach(x => context.Appointments.Add(x));
            context.SaveChanges();
        }
    }
}