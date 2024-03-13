using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveYourLife.models
{
    public partial class CharactersOwnedClothes
    {
        public partial class CharactersPhoneChatMessages
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int id { get; set; }

            public int chatId { get; set; }
            public int fromNumber { get; set; }
            public int toNumber { get; set; }
            public int unix { get; set; }
            public string message { get; set; }
        }
    }
}
