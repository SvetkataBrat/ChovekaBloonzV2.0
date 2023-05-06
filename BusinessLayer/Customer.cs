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
        [Required]
        public int Id { get; set; }

        [Required] 
        public string FirstName { get; set; }

        [Required] 
        public string LastName { get; set; }

        public List<Auto> cars { get; set; }

        private Customer()
        {
            this.cars = new List<Auto>();   
        }

        public Customer(string fName, string lName)
        {
            this.cars = new List<Auto>();
            this.FirstName = fName;
            this.LastName = lName;
        }
    }
}
