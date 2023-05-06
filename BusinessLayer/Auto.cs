using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Auto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Brand { get; set; }

        public int Hp { get; set; }

        public int Price { get; set; }

        [ForeignKey("Salon")]
        public int SalonID { get; set; }

        //public Saloni Salon { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set;}

        //public Customer Customer { get; set; }

        private Auto()
        {
            
        }

        public Auto(int id, string brand, int hp, int price, int salonID, int customerID)
        {
            Id = id;
            Brand = brand;
            Hp = hp;
            Price = price;
            SalonID = salonID;
            CustomerID = customerID;
        }
    }
}
