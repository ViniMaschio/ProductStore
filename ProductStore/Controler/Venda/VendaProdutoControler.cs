using ProductStore.Controler.Boletos;
using ProductStore.Controler.Cliente;
using ProductStore.Controler.Funcionario;
using ProductStore.DAO.Venda;
using ProductStore.Entidades.Boletos;
using ProductStore.Entidades.Cliente;
using ProductStore.Entidades.Funcionario;
using ProductStore.Entidades.Venda;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProductStore.Controler.Venda
{
    public class VendaProdutoControler
    {
        public VendaProdutoControler() { }

        public void AddVenda(VendaProdutoEntidade vendaProdutoEntidade, List<ItensVendaProdutoEntidade> listItensVendaProdutoEntidade, List<ParcelaVendaEntidade> listParcelaVendaEntidades)
        {
            VendaProdutoDAO vendaProdutoDAO = new VendaProdutoDAO();

            int idVenda = vendaProdutoDAO.Add(vendaProdutoEntidade);

            for(int i = 0; i< listItensVendaProdutoEntidade.Count; i++)
            {
                listItensVendaProdutoEntidade[i].CodVenda = idVenda;
            }

            for (int i = 0; i < listParcelaVendaEntidades.Count; i++)
            {
                listParcelaVendaEntidades[i].CodVenda = idVenda;
            }

            ItensVendaProdutoControler itensVendaProdutoControler = new ItensVendaProdutoControler();
            itensVendaProdutoControler.AddProduto(listItensVendaProdutoEntidade);

            ParcelaVendaControler parcelaVendaControler = new ParcelaVendaControler();
            parcelaVendaControler.AddParcela(listParcelaVendaEntidades);

            MessageBox.Show("Venda Realizada com sucesso!", "Venda Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DeletarVenda(VendaProdutoEntidade vendaProdutoEntidade)
        {
            VendaProdutoDAO vendaProdutoDAO = new VendaProdutoDAO();

            if (MessageBox.Show("Tem certeza que deseja Excluir a venda: \n" + vendaProdutoEntidade.Id, "Deletar Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ItensVendaProdutoControler itensVendaProdutoControler = new ItensVendaProdutoControler();
                itensVendaProdutoControler.DeletarProduto(vendaProdutoEntidade.Id);

                ParcelaVendaControler parcelaVendaControler = new ParcelaVendaControler();
                parcelaVendaControler.RemoverParcela(vendaProdutoEntidade.Id);

                vendaProdutoDAO.Deletar(vendaProdutoEntidade.Id);
                MessageBox.Show("Venda apagada com sucesso!", "Deletar Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public DataTable BuscarTodasVendas()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID",typeof(int));
            dataTable.Columns.Add("Cliente", typeof(string));
            dataTable.Columns.Add("Funcionario", typeof(string));
            dataTable.Columns.Add("Data Venda", typeof(DateTime));
            dataTable.Columns.Add("Valor Total",typeof(double));

            VendaProdutoDAO vendaProdutoDAO = new VendaProdutoDAO();
            List<VendaProdutoEntidade> vendaProdutoEntidades = vendaProdutoDAO.BuscarTodasVendas();

            ClienteControler clienteControler = new ClienteControler();
            FuncionarioControler funcionarioControler = new FuncionarioControler();
            ItensVendaProdutoControler itensVendaProdutoControler = new ItensVendaProdutoControler();

            for (int i = 0; i < vendaProdutoEntidades.Count; i++)
            {
                ClienteEntidade clienteEntidade = clienteControler.BuscarClientePorId(vendaProdutoEntidades[i].CodCliente);
                FuncionarioEntidade funcionarioEntidade = funcionarioControler.BuscarFuncionarioPorId(vendaProdutoEntidades[i].CodFuncionario);

                dataTable.Rows.Add(vendaProdutoEntidades[i].Id,
                    clienteEntidade.NomeCliente,
                    funcionarioEntidade.NomeFuncionario,
                    vendaProdutoEntidades[i].DataVenda,
                    itensVendaProdutoControler.BuscarTotalPorVenda(vendaProdutoEntidades[i].Id)
                    );
            }

            return dataTable;

        }

        public VendaProdutoEntidade BuscarVendaPorId(int CodVenda)
        {
            VendaProdutoDAO vendaProdutoDAO = new VendaProdutoDAO();

            return vendaProdutoDAO.BuscarVendaPorId(CodVenda);
        }
    }
}
