using Dapper.Contrib.Extensions;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Conrete
{
    [Table("MemberMeasurement")]
    public class MemberMeasureMent:IEntity
    {
        [Key]
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int Height  { get; set; }
        public int Weight { get; set; }
        public int Shoulder { get; set; }
        public int Waist { get; set; }
        public int RightLeg { get; set; }
        public int LeftLeg { get; set; }
        public int Chest { get; set; }
        public int RightArm { get; set; }
        public int LeftArm { get; set; }
    }
}
