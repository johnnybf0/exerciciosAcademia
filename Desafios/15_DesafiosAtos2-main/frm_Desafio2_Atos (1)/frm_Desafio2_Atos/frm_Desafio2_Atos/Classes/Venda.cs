﻿
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frm_Desafio2_Atos.Classes
{
    internal class Venda
    {
        public int id;
        public int produto_id;
        public int cliente_id;
        public decimal valor;
        public decimal quantidade;

        public bool gravar()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();

            SqlTransaction transacao = cn.BeginTransaction();
            SqlCommand com = new SqlCommand();
            com.Connection = cn;
            com.Transaction = transacao;
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into Venda(produto_id, cliente_id, valor, quantidade) values (@idProduto, @idCliente, @valorProd, @qtd);";
            com.Parameters.Add("@idProduto", SqlDbType.Int);
            com.Parameters.Add("@idCliente", SqlDbType.Int);
            com.Parameters.Add("@valorProd", SqlDbType.Decimal);
            com.Parameters.Add("@qtd", SqlDbType.Decimal);
            com.Parameters[0].Value = produto_id;
            com.Parameters[1].Value = cliente_id;
            com.Parameters[2].Value = valor;
            com.Parameters[3].Value = quantidade;

            try
            {
                com.ExecuteNonQuery();
                transacao.Commit();
                return true;

            }
            catch (Exception ex)
            {
                transacao.Rollback();
                return false;

            }
            finally
            {
                bd.fecharConexao();
            }

        }

        public bool deletar()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();

            SqlTransaction transacao = cn.BeginTransaction();
            SqlCommand com = new SqlCommand();
            com.Connection = cn;
            com.Transaction = transacao;
            com.CommandType = CommandType.Text;
            com.CommandText = "delete from Venda where id = @id";
            com.Parameters.Add("@id", SqlDbType.Int);
            com.Parameters[0].Value = id;

            try
            {
                com.ExecuteNonQuery();
                transacao.Commit();
                return true;

            }
            catch (Exception ex)
            {
                transacao.Rollback();
                return false;

            }
            finally
            {
                bd.fecharConexao();
            }

        }
    }
}
