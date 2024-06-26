﻿using ProductStore.DAO.Endereco;
using ProductStore.Entidades.Endereco;
using System.Collections.Generic;
using System.Data;

namespace ProductStore.Controler.Endereco
{
    public class CidadeControler
    {
        public CidadeControler() { }

        public DataTable BuscarCidadePorUF(int uf)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Cidade", typeof(string));

            CidadeDao cidadeDao = new CidadeDao();

            List<CidadeEntidade> listCidadeEntidade = cidadeDao.BuscarCidadesPorUf(uf);

            for (int i = 0; i < listCidadeEntidade.Count && listCidadeEntidade != null; i++)
            {
                dataTable.Rows.Add(listCidadeEntidade[i].Id, listCidadeEntidade[i].Nomecidade);
            }

            return dataTable;
        }

        public CidadeEntidade BuscarCidadePorId(int id)
        {
            CidadeDao cidadeDao = new CidadeDao();

            return cidadeDao.BuscarCidadePorID(id);
        }


    }
}
