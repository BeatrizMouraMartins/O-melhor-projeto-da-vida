using _3C1Beatriz.Code.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1Beatriz.Code.DTO
{
    class LoginDTO
    {
        //ctrl +R,E
        private string _email, _senha, _cpf;

        public string Email { get => _email; set => _email = value; }
        public string Senha { get => _senha; set => _senha = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
    }
}
