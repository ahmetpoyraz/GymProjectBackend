using Dapper.Contrib.Extensions;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Conrete
{
    [Table("Member")]
    public class Member : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string? IdentificationNumber { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? TelNumber { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
