using SalesWebMVC.Data;
using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Services
{
    public class SellerService
    {
        private readonly SalesWebMVCContext _conext;

        public SellerService(SalesWebMVCContext context)
        {
            _conext = context;
        }

        public List<Seller> FindAll()
        {
            return _conext.Seller.ToList();
        }


        public void Insert(Seller obj)
        {
            obj.Department = _conext.Department.First();
            _conext.Add(obj);
            _conext.SaveChanges();
        }
    }
}
