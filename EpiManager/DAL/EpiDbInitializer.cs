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
            var bodyparts = new List<BodyPart>
            {
                new BodyPart{BodyPartId = 1, BodyPartName = "", BodyPartDescrip = "სახე მთლიანი", ProcedureDurationInMinutes = 10, Gender = "M"},
                new BodyPart{BodyPartId = 2, BodyPartName = "", BodyPartDescrip = "ღაწვები", ProcedureDurationInMinutes = 60, Gender = "M" },
                new BodyPart{BodyPartId = 3, BodyPartName = "", BodyPartDescrip = "ყელი", ProcedureDurationInMinutes = 15, Gender = "M" },
                new BodyPart{BodyPartId = 4, BodyPartName = "", BodyPartDescrip = "კისერი", ProcedureDurationInMinutes = 20, Gender = "M" },
                new BodyPart{BodyPartId = 5, BodyPartName = "", BodyPartDescrip = "შუბლი", ProcedureDurationInMinutes = 5, Gender = "M" },
                new BodyPart{BodyPartId = 6, BodyPartName = "", BodyPartDescrip = "გულმკერდი", ProcedureDurationInMinutes = 20, Gender = "M" },
                new BodyPart{BodyPartId = 7, BodyPartName = "", BodyPartDescrip = "მუცელი", ProcedureDurationInMinutes = 25, Gender = "M" },
                new BodyPart{BodyPartId = 8, BodyPartName = "", BodyPartDescrip = "გულმკერდი და მუცელი ერთად", ProcedureDurationInMinutes = 10, Gender = "M"},
                new BodyPart{BodyPartId = 9, BodyPartName = "", BodyPartDescrip = "მხრები", ProcedureDurationInMinutes = 60, Gender = "M" },
                new BodyPart{BodyPartId = 10, BodyPartName = "", BodyPartDescrip = "წელი", ProcedureDurationInMinutes = 15, Gender = "M" },
                new BodyPart{BodyPartId = 11, BodyPartName = "", BodyPartDescrip = "მთლიანი ზურგი", ProcedureDurationInMinutes = 20, Gender = "M" },
                new BodyPart{BodyPartId = 12, BodyPartName = "", BodyPartDescrip = "ფეხი მთლიანი", ProcedureDurationInMinutes = 5, Gender = "M" },
                new BodyPart{BodyPartId = 13, BodyPartName = "", BodyPartDescrip = "ბარძაყი", ProcedureDurationInMinutes = 20, Gender = "M" },
                new BodyPart{BodyPartId = 14, BodyPartName = "", BodyPartDescrip = "წვივი", ProcedureDurationInMinutes = 25, Gender = "M" },
                new BodyPart{BodyPartId = 15, BodyPartName = "", BodyPartDescrip = "ხელი მთლიანი", ProcedureDurationInMinutes = 60, Gender = "M" },
                new BodyPart{BodyPartId = 16, BodyPartName = "", BodyPartDescrip = "ხელი ნახევარი", ProcedureDurationInMinutes = 15, Gender = "M" },
                new BodyPart{BodyPartId = 17, BodyPartName = "", BodyPartDescrip = "იღლია", ProcedureDurationInMinutes = 20, Gender = "M" },
                new BodyPart{BodyPartId = 18, BodyPartName = "", BodyPartDescrip = "ხელის მტევანი", ProcedureDurationInMinutes = 5, Gender = "M" },

                new BodyPart{BodyPartId = 19, BodyPartName = "", BodyPartDescrip = "ფეხები მთლიანად", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{BodyPartId = 20, BodyPartName = "", BodyPartDescrip = "წვივები", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{BodyPartId = 21, BodyPartName = "", BodyPartDescrip = "ბარძაყები", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{BodyPartId = 22, BodyPartName = "", BodyPartDescrip = "მთლიანი სახე", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{BodyPartId = 23, BodyPartName = "", BodyPartDescrip = "შუბლი", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{BodyPartId = 24, BodyPartName = "", BodyPartDescrip = "ლოყები", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{BodyPartId = 25, BodyPartName = "", BodyPartDescrip = "ტუჩი", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{BodyPartId = 26, BodyPartName = "", BodyPartDescrip = "ბაკები", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{BodyPartId = 27, BodyPartName = "", BodyPartDescrip = "ნიკაპი", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{BodyPartId = 28, BodyPartName = "", BodyPartDescrip = "ყელი", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{BodyPartId = 29, BodyPartName = "", BodyPartDescrip = "კისერი", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{BodyPartId = 30, BodyPartName = "", BodyPartDescrip = "ხელები მთლიანად", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{BodyPartId = 31, BodyPartName = "", BodyPartDescrip = "ხელები  ნახევარი", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{BodyPartId = 32, BodyPartName = "", BodyPartDescrip = "ორივე იღლია", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{BodyPartId = 33, BodyPartName = "", BodyPartDescrip = "გულ-მკერდი", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{BodyPartId = 34, BodyPartName = "", BodyPartDescrip = "მკერდის შუა ზოლი", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{BodyPartId = 35, BodyPartName = "", BodyPartDescrip = "მუცელი", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{BodyPartId = 36, BodyPartName = "", BodyPartDescrip = "მუცლის თეთრი ხაზი", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{BodyPartId = 37, BodyPartName = "", BodyPartDescrip = "წელი", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{BodyPartId = 38, BodyPartName = "", BodyPartDescrip = "ზედაპირული  ბიკინი", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{BodyPartId = 39, BodyPartName = "", BodyPartDescrip = "ღრმა ბიკინი", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{BodyPartId = 40, BodyPartName = "", BodyPartDescrip = "დუნდულები", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{BodyPartId = 41, BodyPartName = "", BodyPartDescrip = "უკანა ზოლი ", ProcedureDurationInMinutes = 20, Gender = "F" }
            };

            bodyparts.ForEach(x => context.BodyParts.Add(x));
            context.SaveChanges();

            var priceHeader = new List<PriceHeader>
            {
                new PriceHeader {PriceName = "Common"},
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
                new Customer {PriceHeaderId = 1, FullName = "Carson Alexander", MobileNumber = "599222201"},
                new Customer {PriceHeaderId = 1, FullName = "Robert Deniro", MobileNumber = "599222202"},
                new Customer {PriceHeaderId = 1, FullName = "Muhammed Alli", MobileNumber = "599222203"},
                new Customer {PriceHeaderId = 1, FullName = "Andres Iniesta", MobileNumber = "599222204"},
                new Customer {PriceHeaderId = 1, FullName = "Arturo Vidal", MobileNumber = "599222205"},
                new Customer {PriceHeaderId = 1, FullName = "Zlatan Ibrahimovic", MobileNumber = "599222206"},
                new Customer {PriceHeaderId = 2, FullName = "Julia Roberts", MobileNumber = "599222207"},
                new Customer {PriceHeaderId = 2, FullName = "Rezo Gabriadze", MobileNumber = "599222208"}
            };

            customers.ForEach(x => context.Customers.Add(x));
            context.SaveChanges();

            var appointments = new List<Appointment>
            {
                new Appointment { CustomerId = 1, Date = DateTime.Today.AddDays(1), Time = new TimeSpan(12, 20, 0) },
                new Appointment { CustomerId = 1, Date = DateTime.Today.AddDays(2), Time = new TimeSpan(13, 40, 0) },
                new Appointment { CustomerId = 2, Date = DateTime.Today.AddDays(20), Time = new TimeSpan(14, 15, 0) },
                new Appointment { CustomerId = 2, Date = DateTime.Today.AddDays(21), Time = new TimeSpan(16, 30, 0) }
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