using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required] 
        public string FirstName { get; set; }

        [Required] 
        public string LastName { get; set; }

        [Required] 
        public string Address { get; set; }

        [Required]
        [Range(18, 99)]
        public int Age { get; set; }

        public List<Auto> Cars { get; set; }

        private Customer()
        {
            this.Cars = new List<Auto>();   
        }

        public Customer(int id, string fName, string lName, int age_)
        {
            this.Cars = new List<Auto>();
            this.FirstName = fName;
            this.LastName = lName;
            this.Age = age_;
        }
    }
}
