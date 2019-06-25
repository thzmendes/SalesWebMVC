using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Services
{
    public class SellerService
    {
        private readonly SalesWebMVCContext context;

        public SellerService(SalesWebMVCContext context)
        {
            this.context = context;
        }

        public List<Seller> FindAll()
        {
            return context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            context.Add(obj);
            context.SaveChanges();
        }

    }
}