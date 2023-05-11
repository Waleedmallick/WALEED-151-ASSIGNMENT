using System.ComponentModel.DataAnnotations;

namespace Resturant_System.Model
{
    public class Customer
    {
        public String Customer_name { get; set; }
        public String Customer_email { get; set;}
        [Key]       
        public String Customer_phone { get; set;}
        public String Customer_address { get; set;}

    }
}
