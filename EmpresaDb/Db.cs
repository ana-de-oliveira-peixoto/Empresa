using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Db
{
    //Helper para acesso a dados
    public static class Db
    {
        public static string Conexao
        {
            get
            {
                return "Data Source=ANA;Initial Catalog=EmpresaDb;Integrated Security=True;Pooling=False";

            }
        }

    }
}
