using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerShop.Forms.Agenda
{
    internal class Appuntamento
    {
        public int Id { get; set; }
        public string Titolo { get; set; } = "";
        public Color Colore { get; set; } = Color.SteelBlue;
    }
}
