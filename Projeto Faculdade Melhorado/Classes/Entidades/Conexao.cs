using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;



namespace Projeto_faculdade_melhorado
{
    public class Conexao
    {
        public string conectaBD()
        {

            return "server=localhost;port=3306;User Id=root;database=makeyourplate;password=admin";

        }
    }  
}

   

