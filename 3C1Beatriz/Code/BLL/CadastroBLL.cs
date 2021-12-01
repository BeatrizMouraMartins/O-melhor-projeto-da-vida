using _3C1Beatriz.Code.DAL;
using _3C1Beatriz.Code.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1Beatriz.Code.BLL
{
    class CadastroBLL
    {
        //Objeto para acesso ao banco de dados
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_usuario";


        //O método de inserir recebe os dados via DTO 
        //e envia para o banco de dados através da classe AcessoBancoDados
        public void RealizarCadastro(CadastroDTO medDto)
        {
            //Antes de criar o comando aqui, teste no PhpMyAdmin ou Worckbench
            string inserir = $"insert into {tabela} values(null,'{medDto.Nome}','{medDto.Tell}','{medDto.Rua}','{medDto.Numero}','{medDto.Bairro}','{medDto.Cidade}','{medDto.Estado}'," +
                $"'{medDto.Pais}','{medDto.Cpf}','{medDto.Rg}','{medDto.Datanas}','{medDto.País}','{medDto.Email}','{medDto.Senha}');";
            conexao.ExecutarComando(inserir);
           
        }

        public void Editar(CadastroDTO medDto)
        {
            string editar = $"update {tabela} set nome = '{medDto.Nome}', telefone = '{medDto.Tell}',rua ='{medDto.Rua}', numero = '{medDto.Numero}', bairro ='{medDto.Bairro}', cidade = '{medDto.Cidade}', estado = '{medDto.Estado}', pais = '{medDto.Pais}', cpf = '{medDto.Cpf}', rg = '{medDto.Rg}', datanascimento = '{medDto.Datanas}', país = '{medDto.País}', email = '{medDto.Email}', senha = '{medDto.Senha}'  where id = '{medDto.Id}';";
            conexao.ExecutarComando(editar);
        }
        public void Excluir(CadastroDTO medDto)
        {
            string excluir = $"delete from {tabela} where id = '{medDto.Id}';";
            conexao.ExecutarComando(excluir);
        }
        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }
    }
}
