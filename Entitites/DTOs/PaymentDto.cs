using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class PaymentDto :IDto
    {
        public int Id { get; set; }
        public int CardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public int SecurityCode { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public string RentDate { get; set; }
        public string ReturnDate { get; set; }

    }
}
