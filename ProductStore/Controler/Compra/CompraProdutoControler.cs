using ProductStore.Controler.Funcionario;
using ProductStore.DAO.Compra;
using ProductStore.Entidades.Compra;
using ProductStore.Entidades.Funcionario;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProductStore.Controler.Compra
{
    public class CompraProdutoControler
    {
        public CompraProdutoControler() { }

        public void AddCompra(CompraProdutoEntidade compraProduto)
        {
            CompraProdutoDAO compraProdutoDAO = new CompraProdutoDAO();

            int idCompra = compraProdutoDAO.Add(compraProduto);

            MessageBox.Show("Compra Realizada com sucesso!", "Compra Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void AlterarCompra(CompraProdutoEntidade compraProduto)
        {
            CompraProdutoDAO compraProdutoDAO = new CompraProdutoDAO();

            compraProdutoDAO.Alterar(compraProduto);

            MessageBox.Show("Compra Altera com sucesso!", "Alterar Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DeletarCompra(CompraProdutoEntidade compraProduto)
        {
            CompraProdutoDAO compraProdutoDAO = new CompraProdutoDAO();
            if (MessageBox.Show("Deseja Deletar a compra: \n" + compraProduto.Id, "Deletar Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                compraProdutoDAO.Add(compraProduto);
                MessageBox.Show("Compra Realizada com sucesso!", "Compra Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public DataTable BuscarTodasComrpas()
        {
            DataTable dateTable = new DataTable();
            dateTable.Columns.Add("ID");
            dateTable.Columns.Add("Fornecedor");
            dateTable.Columns.Add("Funcionario");
            dateTable.Columns.Add("Data");

            CompraProdutoDAO compraProdutoDAO = new CompraProdutoDAO();
            List<CompraProdutoEntidade> listCompraProdutoEntidade = compraProdutoDAO.BuscarTodasCompras();
            FornecedorControler fornecedorControler = new FornecedorControler();
            FuncionarioControler funcionarioControler = new FuncionarioControler();

            for (int i = 0; i < listCompraProdutoEntidade.Count && listCompraProdutoEntidade != null; i++)
            {
                FornecedorEntidade fornecedorEntidade = fornecedorControler.BuscarFornecedorPorId(listCompraProdutoEntidade[i].CodFornecedor);
                FuncionarioEntidade funcionarioEntidade = funcionarioControler.BuscarFuncionarioPorId(listCompraProdutoEntidade[i].CodFuncionario);

                dateTable.Rows.Add(listCompraProdutoEntidade[i].Id,
                    fornecedorEntidade.NomeFornecedor,
                    funcionarioEntidade.NomeFuncionario,
                    listCompraProdutoEntidade[i].DataCompra
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
