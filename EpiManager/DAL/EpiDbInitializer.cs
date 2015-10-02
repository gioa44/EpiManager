using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EpiManager.Models;

namespace EpiManager.DAL
{

    public class EpiDbInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<EpiContext>
    {
        protected override void Seed(EpiContext context)
        {
            var bodyparts
                = new List<BodyPart>
            {
                new BodyPart{BodyPartId = 1, BodyPartName = "Face"},
                new BodyPart{BodyPartId = 2, BodyPartName = "Leg"},
                new BodyPart{BodyPartId = 3, BodyPartName = "Shin"},
                new BodyPart{BodyPartId = 4, BodyPartName = "Thigh"}
            };

            bodyparts.ForEach(x => context.BodyParts.Add(x));
            context.SaveChanges();

            var priceHeader = new List<PriceHeader>
            {
                new PriceHeader {PriceName = "General"},
                new PriceHeader {PriceName = "Discount"}
            };

            priceHeader.ForEach(x => context.PriceHeaders.Add(x));
            context.SaveChanges();

            var priceLines = new List<PriceLine>
            {
                new PriceLine {PriceHeaderId = 1, BodyPartId = 1, Price = 90},
                new PriceLine {PriceHeaderId = 1, BodyPartId = 2, Price = 150},
                new PriceLine {PriceHeaderId = 1, BodyPartId = 3, Price = 120},
                new PriceLine {PriceHeaderId = 1, BodyPartId = 4, Price = 80},
                                                  
                new PriceLine {PriceHeaderId = 2, BodyPartId = 1, Price = 9},
                new PriceLine {PriceHeaderId = 2, BodyPartId = 2, Price = 15},
                new PriceLine {PriceHeaderId = 2, BodyPartId = 3, Price = 12},
                new PriceLine {PriceHeaderId = 2, BodyPartId = 4, Price = 8}
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

            var targets = new List<AppointmentTarget>
            {
                new AppointmentTarget { AppointmentId = 1, BodyPartId = 1 },
                new AppointmentTarget { AppointmentId = 1, BodyPartId = 2 },

                new AppointmentTarget { AppointmentId = 2, BodyPartId = 3 },
                new AppointmentTarget { AppointmentId = 2, BodyPartId = 4 }
            };

            targets.ForEach(x => context.AppointmentTargets.Add(x));
            context.SaveChanges();
        }
    }
}