using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Personels.Models
{
    public class Birim
    {
        [Key]
        public int BirimId { get; set; }
        public string BirimAdı { get; set; }

        public List<Personel> Personels { get; set; }
    }
}
