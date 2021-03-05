using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMysql.Entidades
{
    public class User
    {
        public int id;
        public string RE;
        public string Nome;
        public string Usuario;
        public string Senha;
        public string Função;
        public string EMAIL;

        public int Id { get => id; set => id = value; }
        public string Nome1 { get => Nome; set => Nome = value; }
        public string Usuario1 { get => Usuario; set => Usuario = value; }
        public string Senha1 { get => Senha; set => Senha = value; }
        public string Função1 { get => Função; set => Função = value; }
        public string RE1 { get => RE; set => RE = value; }
        public string EMAIL1 { get => EMAIL; set => EMAIL = value; }
    }
}
