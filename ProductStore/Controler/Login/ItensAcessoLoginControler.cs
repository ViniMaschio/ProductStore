using ProductStore.DAO.Login;
using ProductStore.Entidades.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Controler.Login
{
    public class ItensAcessoLoginControler
    {
        public ItensAcessoLoginControler() { }

        public void AddAcesso(ItensAcessoLoginEntidade itensAcessoLoginEntidade)
        {
            ItensAcessoLoginDAO itensAcessoLoginDAO = new ItensAcessoLoginDAO();
            
            itensAcessoLoginDAO.Add(itensAcessoLoginEntidade);
        }

        public void DeletarAcesso(ItensAcessoLoginEntidade itensAcessoLoginEntidade)
        {
            ItensAcessoLoginDAO itensAcessoLoginDAO = new ItensAcessoLoginDAO();

            itensAcessoLoginDAO.Delete(itensAcessoLoginEntidade);
        }
        public int BuscarAcessoPorLogin(int idLogin)
        {
            ItensAcessoLoginDAO itensAcessoLoginDAO = new ItensAcessoLoginDAO();

            ItensAcessoLoginEntidade itensAcessoLoginEntidade = itensAcessoLoginDAO.BuscarAcessoPorLogin(idLogin);

            return itensAcessoLoginEntidade.CodAcesso;
        }
    }
}
