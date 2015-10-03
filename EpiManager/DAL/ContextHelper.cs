using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EpiManager.Models;

namespace EpiManager.DAL
{
    public static class ContextHelper
    {
        public static List<SelectListItem> CustomersLookup()
        {
            using (var context = new EpiContext())
            {
                return context.Customers.Select(x => new SelectListItem
                {
                    Text = x.FullName,
                    Value = x.CustomerId.ToString()
                }).ToList();
            }
        }

        public static List<SelectListItem> BodyPartsLookup()
        {
            using (var context = new EpiContext())
            {
                return context.BodyParts.Select(x => new SelectListItem
                {
                    Text = x.BodyPartDescrip,
                    Value = x.BodyPartId.ToString()
                }).ToList();
            }
        }

    }
}