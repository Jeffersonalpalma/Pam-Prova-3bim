using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRpgEtec.Models
{
    public class Endereco
    {
        public int Place_Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Lat { get; set; } = string.Empty;
        public string Lon { get; set; } = string.Empty;
        public string Display_Nome { get; set; } = string.Empty;
    }
}
