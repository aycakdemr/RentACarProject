using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarImageDto:IDto
    {
        public string ImagePath { get; set; }
        public int CarId { get; set; }
    }
}
