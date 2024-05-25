﻿using ProductStore.DAO.Login;
using ProductStore.Entidades.Login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Controler.Login
{
    public class AcessoControler
    {
        public AcessoControler() { }

        public DataTable BuscarTodosAcesso()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Acesso");

            AcessoDAO acessoDAO = new AcessoDAO();
            List<AcessoEntidade> listAcessoEntidade = acessoDAO.BuscarTodosAcesso();

            for (int i = 0; i<listAcessoEntidade.Count; i++)
            {
                dataTable.Rows.Add(listAcessoEntidade[i].Id, listAcessoEntidade[i].NomeAcesso);
            }

            return dataTable;
        }

        public string BuscarAcessoPorId(int id)
        {
            AcessoDAO acessoDAO=new AcessoDAO();

            return acessoDAO.BuscarAcessoPorId(id);
        }
    }
}
