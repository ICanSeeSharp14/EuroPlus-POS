using System.ComponentModel.DataAnnotations;

namespace Petrol_Pump_Management_System.Entities
{
    public class Position
    {

        [Key]
        public int PositionId { get; set; }
        
        [StringLength(15)]
        public string PositionCode { get; set; }
        
        [StringLength(80)]
        public string PositionName { get; set; }
        public string Description { get; set; }
        
        [Range(0,999999999999999999.99)]
        public decimal Salary { get; set; }



    }
}