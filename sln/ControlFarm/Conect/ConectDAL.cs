/*
 * Criado por SharpDevelop.
 * Usuário: FredePaula
 * Data: 27/05/2018
 * Hora: 21:56
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace Conect
{
	/// <summary>
	/// Description of ConectDAL.
	/// </summary>
	public class ConectDAL
	{
		public ConectDAL()
		{
		}
		
		public MySqlConnection conectionMysql{get; set;}
		public MySqlCommand comand;
		public MySqlCommandBuilder cb;
		string stringconection = "server=localhost;database=controlfarm;uid=root;pwd=''";
		
		private string conection;
		private string comandsql;
		public string Conection{
			get{return conection;}
			set{conection = value;}
		}
		public string ComandSql{
			get{return comandsql;}
			set{comandsql = value;}
		}
		
		public void Conect()
		{
			try {
				conectionMysql = new MySqlConnection(stringconection);
				
				
				conectionMysql.Open();					
			} catch (Exception e) {
				throw new Exception("Não foi possivel concluir a solicitação!"+ e);
			}

			
			
		}
		
		public void Write(ConectDAL ConectDAL){
			try {
				//this.Conect(ConectDAL);
				
				comand = new MySqlCommand(ConectDAL.ComandSql);
				comand.Connection = conectionMysql;	
				comand.ExecuteNonQuery();
				conectionMysql.Close();				
			} catch (Exception e) {
				throw new Exception("Não foi possivel concluir a solicitação!"+ e);
			}				
			
		}
		
		public MySqlDataReader Read(ConectDAL dal){
			this.Conect();
			comand = new MySqlCommand(dal.ComandSql);
			MySqlDataReader leitor = comand.ExecuteReader();
			return leitor;
		}
				
		public DataTable MySqlDA(ConectDAL dal){
			this.Conect();
			DataTable dataTableBD = new DataTable();
			MySqlDataAdapter da = new MySqlDataAdapter(dal.ComandSql, conectionMysql);	
			cb = new MySqlCommandBuilder(da);
			da.Fill(dataTableBD);
			return dataTableBD;	
			
		}
	}
}
