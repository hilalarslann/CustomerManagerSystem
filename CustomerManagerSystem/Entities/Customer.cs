using CustomerManagerSystem.Abstract;
using System;

namespace CustomerManagerSystem.Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateYear { get; set; }
        public long NationalityId { get; set; }
        public int StarPoint { get; set; }
    }
}
