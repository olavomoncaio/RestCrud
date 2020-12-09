using AplicacoesDistribuidas.Interfaces;
using AplicacoesDistribuidas.Model;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySqlConnector;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AplicacoesDistribuidas.Repositories
{
    public class CardapioRepository : BaseRepository, ICardapioRepository
    {
        public CardapioRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<IEnumerable<ItemCardapio>> ObterCardapioCompleto()
        {
            string query = @"SELECT  
                                CardapioId,
                                Nome,
                                Valor,
                                Disponivel
                            FROM CARDAPIO";

            using (var con = new MySqlConnection(ObterConexao))
            {
                await con.OpenAsync();
                return await con.QueryAsync<ItemCardapio>(query);
            }
        }

        public async Task Cadastrar(CadastrarItemRequest request)
        {
            string query = @"INSERT INTO CARDAPIO 
                                (Nome, Valor, Disponivel) 
                             VALUES 
                                (@Nome, @Valor, @Disponivel)";

            using (var con = new MySqlConnection(ObterConexao))
            {
                await con.OpenAsync();
                await con.ExecuteAsync(query, new { request.Nome, request.Disponivel, request.Valor } );
            }
        }

        public async Task Atualizar(AtualizarItemRequest request)
        {
            string query = @"UPDATE CARDAPIO 
                             SET
                                Nome = @Nome,
                                Valor = @Valor,
                                Disponivel = @Disponivel
                             WHERE 
                                CardapioId = @Id";

            using (var con = new MySqlConnection(ObterConexao))
            {
                await con.OpenAsync();
                await con.ExecuteAsync(query, new { request.Nome, request.Id, request.Disponivel, request.Valor });
            }
        }

        public async Task Excluir(int id)
        {
            string query = @"DELETE FROM CARDAPIO 
                             WHERE CardapioId = @Id";

            using (var con = new MySqlConnection(ObterConexao))
            {
                await con.OpenAsync();
                await con.ExecuteAsync(query, new { Id = id });
            }
        }
    }
}
