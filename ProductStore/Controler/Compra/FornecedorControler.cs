using ProductStore.Controler.Endereco;
using ProductStore.DAO.Compra;
using ProductStore.Entidades.Compra;
using ProductStore.Entidades.Endereco;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProductStore.Controler.Compra
{
    public class FornecedorControler
    {
        public FornecedorControler() { }

        public void AddFornecedor(FornecedorEntidade fornecedorEntidade)
        {
            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            fornecedorDAO.Add(fornecedorEntidade);
            MessageBox.Show("Fornecedor adicionado com sucesso!", "Adicionar Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void AlterarFornecedor(FornecedorEntidade fornecedorEntidade)
        {
            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            fornecedorDAO.Alterar(fornecedorEntidade);
            MessageBox.Show("Fornecedor alterado com sucesso!", "Alterar Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void RemoverFornecedor(FornecedorEntidade fornecedorEntidade)
        {
            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            if (MessageBox.Show("Tem certeza que deseja remover o fornecedor: \n" + fornecedorEntidade.Id + " - " + fornecedorEntidade.NomeFornecedor, "Reniver Fornecedor",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                fornecedorDAO.Deletar(fornecedorEntidade.Id);
                MessageBox.Show("Fornecedor Removido com sucesso!", "Reniver Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public DataTable BuscarTodosFornecedor()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID",typeof(int));
            dataTable.Columns.Add("Nome Fornecedor",typeof(string));
            dataTable.Columns.Add("Numero", typeof(string));
            dataTable.Columns.Add("Rua", typeof(string));
            dataTable.Columns.Add("Bairro", typeof(string));
            dataTable.Columns.Add("Cidade", typeof(string));
            dataTable.Columns.Add("CEP", typeof(string));

            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            RuaControler ruaControler = new RuaControler();
            BairroControler bairroControler = new BairroControler();
            CidadeControler cidadeControler = new CidadeControler();
            CepControler cepControler = new CepControler();
            List<FornecedorEntidade> listFornecedorEntidade = fornecedorDAO.BuscarTodosFornecedor();

            for (int i = 0; i < listFornecedorEntidade.Count && listFornecedorEntidade != null; i++)
            {
                CidadeEntidade cidadeEntidade = cidadeControler.BuscarCidadePorId(listFornecedorEntidade[i].CodCidade);

                dataTable.Rows.Add(listFornecedorEntidade[i].Id,
                    listFornecedorEntidade[i].NomeFornecedor,
                    listFornecedorEntidade[i].NumeroCasa,
                    ruaControler.BuscarPorId(listFornecedorEntidade[i].CodRua),
                    bairroControler.BuscarPorId(listFornecedorEntidade[i].CodBairro),
                    cidadeEntidade.Nomecidade,
                    cepControler.BuscarCepPorId(listFornecedorEntidade[i].CodCep)
                 );
            }

            return dataTable;
        }

        public FornecedorEntidade BuscarFornecedorPorId(int codFornecedor)
        {
            FornecedorDAO fornecedorDAO = new FornecedorDAO();

            return fornecedorDAO.BuscarFornecedorPorID(codFornecedor);
        }
    }
}
