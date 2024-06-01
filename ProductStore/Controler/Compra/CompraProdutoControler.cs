using ProductStore.Controler.Boletos;
using ProductStore.Controler.Funcionario;
using ProductStore.DAO.Compra;
using ProductStore.Entidades.Boletos;
using ProductStore.Entidades.Compra;
using ProductStore.Entidades.Funcionario;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProductStore.Controler.Compra
{
    public class CompraProdutoControler
    {
        public CompraProdutoControler() { }

        public void AddCompra(CompraProdutoEntidade compraProduto, List<ItensCompraProdutoEntidade> listItensCompraProduto, List<ParcelaCompraEntidade> listparcelacompra)
        {
            CompraProdutoDAO compraProdutoDAO = new CompraProdutoDAO();

            int idCompra = compraProdutoDAO.Add(compraProduto);

            for (int i = 0; i < listItensCompraProduto.Count; i++)
            {
                listItensCompraProduto[i].CodCompra = idCompra;
                
            }
            for (int i = 0; i < listparcelacompra.Count; i++)
            {
                listparcelacompra[i].CodCompra = idCompra;
            }
 
            ItensCompraProdutoControler itensCompraProdutoControler =  new ItensCompraProdutoControler();
            itensCompraProdutoControler.AddProdutos(listItensCompraProduto);

            ParcelaCompraControler parcelaCompraControler = new ParcelaCompraControler();
            parcelaCompraControler.AddParcelas(listparcelacompra);

            MessageBox.Show("Compra Realizada com sucesso!", "Compra Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void AlterarCompra(CompraProdutoEntidade compraProduto)
        {
            CompraProdutoDAO compraProdutoDAO = new CompraProdutoDAO();

            compraProdutoDAO.Alterar(compraProduto);

            MessageBox.Show("Compra Altera com sucesso!", "Alterar Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DeletarCompra(int codCompra)
        {
            CompraProdutoDAO compraProdutoDAO = new CompraProdutoDAO();
            if (MessageBox.Show("Deseja Deletar a compra: \n" + codCompra, "Deletar Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ItensCompraProdutoControler itensCompraProdutoControler = new ItensCompraProdutoControler();
                itensCompraProdutoControler.DeletarProdutos(codCompra);

                compraProdutoDAO.Deletar(codCompra);
                MessageBox.Show("Compra Deletada com sucesso!", "Deeltar Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public DataTable BuscarTodasCompras()
        {
            DataTable dateTable = new DataTable();
            dateTable.Columns.Add("ID",typeof(int));
            dateTable.Columns.Add("Fornecedor",typeof(string));
            dateTable.Columns.Add("Funcionario", typeof(string));
            dateTable.Columns.Add("Data", typeof(DateTime));
            dateTable.Columns.Add("Valor Total", typeof(double));

            CompraProdutoDAO compraProdutoDAO = new CompraProdutoDAO();
            List<CompraProdutoEntidade> listCompraProdutoEntidade = compraProdutoDAO.BuscarTodasCompras();
            FornecedorControler fornecedorControler = new FornecedorControler();
            FuncionarioControler funcionarioControler = new FuncionarioControler();
            ItensCompraProdutoControler itensCompraProdutoControler = new ItensCompraProdutoControler();

            for (int i = 0; i < listCompraProdutoEntidade.Count && listCompraProdutoEntidade != null; i++)
            {
                FornecedorEntidade fornecedorEntidade = fornecedorControler.BuscarFornecedorPorId(listCompraProdutoEntidade[i].CodFornecedor);
                FuncionarioEntidade funcionarioEntidade = funcionarioControler.BuscarFuncionarioPorId(listCompraProdutoEntidade[i].CodFuncionario);
                
                dateTable.Rows.Add(listCompraProdutoEntidade[i].Id,
                    fornecedorEntidade.NomeFornecedor,
                    funcionarioEntidade.NomeFuncionario,
                    listCompraProdutoEntidade[i].DataCompra,
                    itensCompraProdutoControler.BuscarValorTotalPorCompra(listCompraProdutoEntidade[i].Id)
                    );

            }

            return dateTable;
        }

        public CompraProdutoEntidade BuscarCompraPorId(int codCompra)
        {
            CompraProdutoDAO compraProdutoDAO = new CompraProdutoDAO();

            return compraProdutoDAO.BuscarCompraPorId(codCompra);
        }
    }
}
