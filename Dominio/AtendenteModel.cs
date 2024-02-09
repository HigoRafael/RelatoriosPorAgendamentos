using DataAcces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class AtendenteModel
    {
        AtendenteDAO atendenteDAO = new AtendenteDAO();

        public DataTable CarregaDadosAtendentes()
        {
            DataTable resulta = new DataTable();
            resulta = atendenteDAO.CarregarDadosAtendente();
            return resulta;
        }
    }
}