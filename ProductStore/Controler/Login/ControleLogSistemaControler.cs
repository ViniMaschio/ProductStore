using ProductStore.Controler.Funcionario;
using ProductStore.DAO.Login;
using ProductStore.Entidades.Funcionario;
using ProductStore.Entidades.Login;
using System;
using System.Collections.Generic;
using System.Data;

namespace ProductStore.Controler.Login
{
    public class ControleLogSistemaControler
    {
        public void NovoLogin(int id)
        {
            ControleLogSistemaDAO controleLogSistemaDAO = new ControleLogSistemaDAO();

            controleLogSistemaDAO.Add(id);
        }

        public DataTable BuscarTodosLogPorLogin(int login)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID",typeof(int));
            dataTable.Columns.Add("Funcionario", typeof(string));
            dataTable.Columns.Add("Data",typeof(DateTime));
            dataTable.Columns.Add("Hora", typeof(TimeSpan));

            ControleLogSistemaDAO controleLogSistemaDAO = new ControleLogSistemaDAO();
            List<ControleLogSistemaEntidade> listLogSistemaEntidades = controleLogSistemaDAO.BuscarLogPorLogin(login);

            LoginControler loginControler = new LoginControler();
            LoginEntidade loginEntidade = loginControler.BuscarLoginPorId(login);

            FuncionarioControler funcionarioControler = new FuncionarioControler();
            FuncionarioEntidade funcionarioEntidade = funcionarioControler.BuscarFuncionarioPorId(loginEntidade.Funcionario);

            for (int i = 0; i < listLogSistemaEntidades.Count && listLogSistemaEntidades != null; i++)
            {
                dataTable.Rows.Add(listLogSistemaEntidades[i].Id,
                    funcionarioEntidade.NomeFuncionario,
                    listLogSistemaEntidades[i].DataLog.Date,
                    listLogSistemaEntidades[i].Hora);
            }

            return dataTable;
        }
    }
}
