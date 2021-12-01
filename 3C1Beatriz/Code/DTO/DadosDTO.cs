using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1Beatriz.Code.DTO
{
    class DadosDTO
    {
        private int _id;
        private string _bmm, _b08, _m11;

        public int Id { get => _id; set => _id = value; }
        public string Bmm { get => _bmm; set => _bmm = value; }
        public string B08 { get => _b08; set => _b08 = value; }
        public string M11 { get => _m11; set => _m11 = value; }
    }
}
