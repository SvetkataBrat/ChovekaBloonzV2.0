using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Saloni
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Adress { get; set; }

        public List<Auto> Cars { get; set; }

        private Saloni()
        {
            Cars = new List<Auto>();
        }

        public Saloni(int id, string name, string adress)
        {
            Name = name;
            Adress = adress;
        }
    }
}
