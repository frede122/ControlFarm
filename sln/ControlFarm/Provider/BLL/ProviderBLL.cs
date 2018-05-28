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
		public void save(ProviderDTO dto){
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
	}
}
