
namespace Petrol_Pump_Management_System.Entities
{
    public class Vendor
    {
        public int VendorId { get; set; }

        public int VendorCode { get; set; }

        public string VendorName { get; set; }

        public string VendorAddress { get; set; }

        public string ContactNumber { get; set; }

        public bool IsActive { get; set; }
    }
}
