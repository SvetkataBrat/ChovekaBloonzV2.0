using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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

        public Customer(string fName, string lName, int age_)
        {
            this.Cars = new List<Auto>();
            this.FirstName = fName;
            this.LastName = lName;
            this.Age = age_;
        }
    }
}
