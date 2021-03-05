using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMysql.Cache
{
    public static class UserLoginCache
    {
        public static int id { get; set; }
        public static string Nome { get; set; }
        public static string Função { get; set; }

        public static string RE { get; set; }
    }
}
