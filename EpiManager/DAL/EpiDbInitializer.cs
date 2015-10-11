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
            #region Body Parts
            var bodyparts = new List<BodyPart>
            {
                new BodyPart{MigrId = 1, BodyPartId = 1, BodyPartName = "", BodyPartDescrip = "სახე მთლიანი", ProcedureDurationInMinutes = 10, Gender = "M"},
                new BodyPart{MigrId = 2, BodyPartId = 2, BodyPartName = "", BodyPartDescrip = "ღაწვები", ProcedureDurationInMinutes = 60, Gender = "M" },
                new BodyPart{MigrId = 3, BodyPartId = 3, BodyPartName = "", BodyPartDescrip = "ყელი", ProcedureDurationInMinutes = 15, Gender = "M" },
                new BodyPart{MigrId = 4, BodyPartId = 4, BodyPartName = "", BodyPartDescrip = "კისერი", ProcedureDurationInMinutes = 20, Gender = "M" },
                new BodyPart{MigrId = 5, BodyPartId = 5, BodyPartName = "", BodyPartDescrip = "შუბლი", ProcedureDurationInMinutes = 5, Gender = "M" },
                new BodyPart{MigrId = 6, BodyPartId = 6, BodyPartName = "", BodyPartDescrip = "გულმკერდი", ProcedureDurationInMinutes = 20, Gender = "M" },
                new BodyPart{MigrId = 7, BodyPartId = 7, BodyPartName = "", BodyPartDescrip = "მუცელი", ProcedureDurationInMinutes = 25, Gender = "M" },
                new BodyPart{MigrId = 8, BodyPartId = 8, BodyPartName = "", BodyPartDescrip = "გულმკერდი და მუცელი ერთად", ProcedureDurationInMinutes = 10, Gender = "M"},
                new BodyPart{MigrId = 9, BodyPartId = 9, BodyPartName = "", BodyPartDescrip = "მხრები", ProcedureDurationInMinutes = 60, Gender = "M" },
                new BodyPart{MigrId = 10,BodyPartId = 10, BodyPartName = "", BodyPartDescrip = "წელი", ProcedureDurationInMinutes = 15, Gender = "M" },
                new BodyPart{MigrId = 11,BodyPartId = 11, BodyPartName = "", BodyPartDescrip = "მთლიანი ზურგი", ProcedureDurationInMinutes = 20, Gender = "M" },
                new BodyPart{MigrId = 12,BodyPartId = 12, BodyPartName = "", BodyPartDescrip = "ფეხი მთლიანი", ProcedureDurationInMinutes = 5, Gender = "M" },
                new BodyPart{MigrId = 13,BodyPartId = 13, BodyPartName = "", BodyPartDescrip = "ბარძაყი", ProcedureDurationInMinutes = 20, Gender = "M" },
                new BodyPart{MigrId = 14,BodyPartId = 14, BodyPartName = "", BodyPartDescrip = "წვივი", ProcedureDurationInMinutes = 25, Gender = "M" },
                new BodyPart{MigrId = 15,BodyPartId = 15, BodyPartName = "", BodyPartDescrip = "ხელი მთლიანი", ProcedureDurationInMinutes = 60, Gender = "M" },
                new BodyPart{MigrId = 16,BodyPartId = 16, BodyPartName = "", BodyPartDescrip = "ხელი ნახევარი", ProcedureDurationInMinutes = 15, Gender = "M" },
                new BodyPart{MigrId = 17,BodyPartId = 17, BodyPartName = "", BodyPartDescrip = "იღლია", ProcedureDurationInMinutes = 20, Gender = "M" },
                new BodyPart{MigrId = 18,BodyPartId = 18, BodyPartName = "", BodyPartDescrip = "ხელის მტევანი", ProcedureDurationInMinutes = 5, Gender = "M" },

                new BodyPart{MigrId = 19,BodyPartId = 19, BodyPartName = "", BodyPartDescrip = "ფეხები მთლიანად", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{MigrId = 20,BodyPartId = 20, BodyPartName = "", BodyPartDescrip = "წვივები", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{MigrId = 21,BodyPartId = 21, BodyPartName = "", BodyPartDescrip = "ბარძაყები", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{MigrId = 22,BodyPartId = 22, BodyPartName = "", BodyPartDescrip = "მთლიანი სახე", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{MigrId = 23,BodyPartId = 23, BodyPartName = "", BodyPartDescrip = "შუბლი", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{MigrId = 24,BodyPartId = 24, BodyPartName = "", BodyPartDescrip = "ლოყები", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{MigrId = 25,BodyPartId = 25, BodyPartName = "", BodyPartDescrip = "ტუჩი", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{MigrId = 26,BodyPartId = 26, BodyPartName = "", BodyPartDescrip = "ბაკები", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{MigrId = 27,BodyPartId = 27, BodyPartName = "", BodyPartDescrip = "ნიკაპი", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{MigrId = 28,BodyPartId = 28, BodyPartName = "", BodyPartDescrip = "ყელი", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{MigrId = 29,BodyPartId = 29, BodyPartName = "", BodyPartDescrip = "კისერი", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{MigrId = 30,BodyPartId = 30, BodyPartName = "", BodyPartDescrip = "ხელები მთლიანად", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{MigrId = 31,BodyPartId = 31, BodyPartName = "", BodyPartDescrip = "ხელები  ნახევარი", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{MigrId = 32,BodyPartId = 32, BodyPartName = "", BodyPartDescrip = "ორივე იღლია", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{MigrId = 33,BodyPartId = 33, BodyPartName = "", BodyPartDescrip = "გულ-მკერდი", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{MigrId = 34,BodyPartId = 34, BodyPartName = "", BodyPartDescrip = "მკერდის შუა ზოლი", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{MigrId = 35,BodyPartId = 35, BodyPartName = "", BodyPartDescrip = "მუცელი", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{MigrId = 36,BodyPartId = 36, BodyPartName = "", BodyPartDescrip = "მუცლის თეთრი ხაზი", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{MigrId = 37,BodyPartId = 37, BodyPartName = "", BodyPartDescrip = "წელი", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{MigrId = 38,BodyPartId = 38, BodyPartName = "", BodyPartDescrip = "ზედაპირული  ბიკინი", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{MigrId = 39,BodyPartId = 39, BodyPartName = "", BodyPartDescrip = "ღრმა ბიკინი", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{MigrId = 40,BodyPartId = 40, BodyPartName = "", BodyPartDescrip = "დუნდულები", ProcedureDurationInMinutes = 20, Gender = "F" },
                new BodyPart{MigrId = 41,BodyPartId = 41, BodyPartName = "", BodyPartDescrip = "უკანა ზოლი ", ProcedureDurationInMinutes = 20, Gender = "F" }
            }; 
            #endregion

            bodyparts.ForEach(x => context.BodyParts.Add(x));
            context.SaveChanges();
        }
    }
}