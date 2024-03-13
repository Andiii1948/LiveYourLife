using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveYourLife.models
{
    public partial class CharactersPhoneContacts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int contactId { get; set; }

        public int phoneNumber { get; set; }
        public string contactName { get; set; }
        public int contactNumber { get; set; }
    }
}