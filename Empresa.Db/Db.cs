using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Db
{
    class Db
    {
        public static string Conexao
        {
            get
            {
                return @"Data Source=ANA;Initial Catalog=EmpresaDb;Integrated Security=True;Pooling=False";

            }
        }

    }
}
