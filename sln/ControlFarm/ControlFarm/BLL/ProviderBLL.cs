/*
 * Criado por SharpDevelop.
 * Usuário: FredePaula
 * Data: 27/05/2018
 * Hora: 21:42
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using Provider.DTO;
using Conect;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Provider.BLL
{
	/// <summary>
	/// Description of ProviderBLL.
	/// </summary>
	public class ProviderBLL
	{
		ConectDAL dal;
		public ProviderBLL()
		{
			
		}
		public void Save(ProviderDTO dto){
			dal = new ConectDAL();
			dal.Conect();
			dal.ComandSql = string.Format("INSERT INTO `fornecedor` " +
											"(`idFornecedor`, " +
											"`nome`, " +
											"`cnpj`, " +
											"`endereco`, " +
											"`cidade`, " +
											"`telefone`" +
											") VALUES (" +
											"NULL, " +
											"'{0}', '{1}', '{2}', '{3}', '{4}');",
											dto.Name,
											dto.Cpnj, 
											dto.Address, 
											dto.City, 
											dto.Phone
								        	);
			dal.Write(dal);
		}
		
		public void Update(ProviderDTO dto){
			dal = new ConectDAL();
			dal.Conect();
			dal.ComandSql = string.Format("UPDATE `fornecedor` " +
			                              "SET `nome` = '{0}', " +
			                              "`cnpj` = '{1}', " +
			                              "`endereco` = '{2}', " +
			                              "`cidade` = '{3}', " +
			                              "`telefone` = '{4}' " +
			                              "WHERE " +
			                              "`fornecedor`.`idFornecedor` = {5};",
											dto.Name,
											dto.Cpnj, 
											dto.Address, 
											dto.City, 
											dto.Phone,
											dto.IdProvider
								        	);
			dal.Write(dal);
		}
		
		public void Delete(int id){
			dal = new ConectDAL();
			dal.Conect();
			dal.ComandSql = "DELETE FROM `controlfarm`.`fornecedor` WHERE `fornecedor`.`idFornecedor` =  "+id;
			dal.Write(dal);
		}
		
		public DataTable DataGridReturn(ProviderDTO dtonv = null){
			ConectDAL dal = new ConectDAL();
			DataTable da = new DataTable();
			if(dtonv == null){
				dal.ComandSql = "SELECT `idFornecedor`,`nome`,`cnpj`,`endereco`,`cidade`,`telefone` FROM `fornecedor` ORDER BY idFornecedor DESC LIMIT 50";				
			}else{
				dal.ComandSql = "SELECT `idFornecedor`,`nome`,`cnpj`,`endereco`,`cidade`,`telefone` FROM `fornecedor` WHERE `nome` LIKE '%"+dtonv.Name+"%' ORDER BY idFornecedor DESC LIMIT 20 ";
			}
			    da = dal.MySqlDA(dal);
				return da;
		}
		
		
		
	}
}
