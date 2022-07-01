using CustomerManagerSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagerSystem.Entities
{
    public class Product : IEntity
    {
        public int ProductNo { get; set; }
        public string Name { get; set; }
    }
}
