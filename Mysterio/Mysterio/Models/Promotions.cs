using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mysterio.Models
{
    public class Promotions
    {
        // criar o construtor
        public Promotions()
        {
            EventList = new HashSet<PromocoesEventos>();
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string Image { get; set; }

        public virtual ICollection<PromocoesEventos> EventList { get; set; }
    }
}