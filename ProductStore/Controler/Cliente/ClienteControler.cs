using ProductStore.Controler.Endereco;
using ProductStore.DAO.Cliente;
using ProductStore.Entidades.Cliente;
using ProductStore.Entidades.Endereco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStore.Controler.Cliente
{
    public class ClienteControler
    {
        public ClienteControler() { }

        public void AddCliente(ClienteEntidade clienteEntidade)
        {
            ClienteDao clienteDao = new ClienteDao();

            clienteDao.Add(clienteEntidade);

            MessageBox.Show("Cliente Adicionado com sucesso!","Adicionar Cliente", MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        public void AlterarCliente(ClienteEntidade clienteEntidade)
        {
            
                ClienteDao clienteDao = new ClienteDao();

                clienteDao.Update(clienteEntidade);

                MessageBox.Show("Cliente Alterado com sucesso!", "Aterar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        public void RemoverCliente(ClienteEntidade clienteEntidade)
        {
            ClienteDao clienteDao = new ClienteDao();

            if (MessageBox.Show("Deseja Deletar o Cliente : \n"+ clienteEntidade.Id+ " - "+ clienteEntidade.NomeCliente,
                "Remover Cliente",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {

                clienteDao.Delete(clienteEntidade.Id);

                MessageBox.Show("Cliente Adicionado com sucesso!", "Adicionar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public DataTable BuscarTodosCliente()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Nome");
            dataTable.Columns.Add("Sexo");
            dataTable.Columns.Add("Rua");
            dataTable.Columns.Add("Numero");
            dataTable.Columns.Add("Bairro");
            dataTable.Columns.Add("Cidade");
            dataTable.Columns.Add("UF");
            dataTable.Columns.Add("CEP");
            dataTable.Columns.Add("Salario");
            dataTable.Columns.Add("Trabalho");
            dataTable.Columns.Add("Foto");

            ClienteDao clienteDao = new ClienteDao();
            List<ClienteEntidade> listClienteEntidade = clienteDao.BuscarTodosCliente();

            SexoControler sexoControler = new SexoControler();
            RuaControler ruaControler = new RuaControler();
            BairroControler bairroControler = new BairroControler();
            CidadeControler cidadeControler = new CidadeControler();
            CidadeEntidade cidadeEntidade = new CidadeEntidade();
            UfControler ufControler = new UfControler();
            CepControler cepControler = new CepControler();
            TrabalhoControler trabalhoControler = new TrabalhoControler();

            for (int i = 0; i< listClienteEntidade.Count && listClienteEntidade != null; i++)
            {
                cidadeEntidade = cidadeControler.BuscarCidadePorId(listClienteEntidade[i].CodCidade);

                dataTable.Rows.Add(listClienteEntidade[i].Id, 
                  listClienteEntidade[i].NomeCliente, 
                  sexoControler.BuscarSexoPorId(listClienteEntidade[i].CodSexo),
                  ruaControler.BuscarPorId(listClienteEntidade[i].CodRua), 
                  listClienteEntidade[i].NumeroCasa, 
                  bairroControler.BuscarPorId(listClienteEntidade[i].CodBairro),
                  cidadeEntidade.Nomecidade, 
                  ufControler.BuscarUfPorId(cidadeEntidade.Coduf), 
                  cepControler.BuscarCepPorId(listClienteEntidade[i].CodCep),
                  listClienteEntidade[i].Salario, 
                  trabalhoControler.BuscarTrabalhoPorId(listClienteEntidade[i].CodTrabalho), 
                  listClienteEntidade[i].Foto);
            }


            return dataTable;
        }

        public ClienteEntidade BuscarClientePorId(int id)
        {
            ClienteDao clienteDao = new ClienteDao();

            return clienteDao.BuscarClientePorId(id);
        }
    }
    
}
