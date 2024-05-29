using ProductStore.Controler.Cliente;
using ProductStore.Controler.Funcionario;
using ProductStore.DAO.Venda;
using ProductStore.Entidades.Cliente;
using ProductStore.Entidades.Funcionario;
using ProductStore.Entidades.Venda;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProductStore.Controler.Venda
{
    public class VendaProdutoControler
    {
        public VendaProdutoControler() { }

        public void AddVenda(VendaProdutoEntidade vendaProdutoEntidade)
        {
            VendaProdutoDAO vendaProdutoDAO = new VendaProdutoDAO();

            int idVenda = vendaProdutoDAO.Add(vendaProdutoEntidade);

            MessageBox.Show("Venda Realizada com sucesso!", "Venda Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DeletarVenda(VendaProdutoEntidade vendaProdutoEntidade)
        {
            VendaProdutoDAO vendaProdutoDAO = new VendaProdutoDAO();

            if (MessageBox.Show("Tem certeza que deseja Excluir a venda: \n" + vendaProdutoEntidade.Id, "Deletar Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                vendaProdutoDAO.Deletar(vendaProdutoEntidade.Id);
                MessageBox.Show("Venda apagada com sucesso!", "Deletar Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public DataTable BuscarTodasVendas()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Cod");
            dataTable.Columns.Add("Data Venda");
            dataTable.Columns.Add("Cliente");
            dataTable.Columns.Add("Funcionario");

            VendaProdutoDAO vendaProdutoDAO = new VendaProdutoDAO();

            List<VendaProdutoEntidade> vendaProdutoEntidades = vendaProdutoDAO.BuscarTodasVendas();
            ClienteControler clienteControler = new ClienteControler();
            FuncionarioControler funcionarioControler = new FuncionarioControler();

            for (int i = 0; i < vendaProdutoEntidades.Count; i++)
            {
                ClienteEntidade clienteEntidade = clienteControler.BuscarClientePorId(vendaProdutoEntidades[i].Id);
                FuncionarioEntidade funcionarioEntidade = funcionarioControler.BuscarFuncionarioPorId(vendaProdutoEntidades[i].Id);

                dataTable.Rows.Add(vendaProdutoEntidades[i].Id,
                    vendaProdutoEntidades[i].DataVenda.ToString("dd:MM:yyyy"),
                    clienteEntidade.NomeCliente,
                    funcionarioEntidade.NomeFuncionario
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
