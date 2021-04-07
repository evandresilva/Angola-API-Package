using System;
using System.Collections.Generic;
using System.Text;

namespace Angola_API_Package.Models
{
    public class ProvinceModel
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string Capital { get; set; }
        public int Area { get; set; }
        public int Populacao { get; set; }
        public int Municipios { get; set; }
        public int Comunas { get; set; }
    }
}
