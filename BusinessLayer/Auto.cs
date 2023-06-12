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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Brand { get; set; }

        public int Hp { get; set; }

        public double Price { get; set; }

        [ForeignKey("Salon")]
        public int SalonID { get; set; }

        public Saloni Salon { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set;}

        public Customer Customer { get; set; }

        private Auto()
        {
            
        }

        public Auto(string brand, int hp, double price, int salonID)
        {
            Brand = brand;
            Hp = hp;
            Price = price;
            SalonID = salonID;
        }
    }
}
