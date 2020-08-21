using System;

namespace repo.Models
{
    public class Invoice
    {
        public Guid Id{get;set;}

        public DateTime Date{get;set;}

        public decimal NetTotal{get;set;}
    }
}