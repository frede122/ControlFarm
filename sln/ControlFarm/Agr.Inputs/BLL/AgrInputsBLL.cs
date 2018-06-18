/*
 * Criado por SharpDevelop.
 * Usuário: FredePaula
 * Data: 03/06/2018
 * Hora: 22:35
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using MySql.Data.MySqlClient;
using System.Data;
using Conect;
using Agr.Inputs.DTO;
using System.Collections.Generic;


namespace Agr.Inputs.BLL
{
	/// <summary>
	/// Description of AgrInputsBLL.
	/// </summary>
	public class AgrInputsBLL
	{
		public AgrInputsBLL()
		{
		}
		
		ConectDAL dal;

		public void Save(AgroInputsDTO dto){
			dal = new ConectDAL();
			dal.Conect();
			dal.ComandSql = string.Format("INSERT INTO `insumos` " +
											"(`idInsumos`, " +
											"`nome`, " +
											"`unid`" +
											"`CatInsumos_idCatInsumos`" +
											") VALUES (" +
											"NULL, " +
											"'{0}', '{1}','{2}');",
											dto.Name,
											dto.Unid,
											dto.IdCatInputs 
								        	);
			dal.Write(dal);
		}
		
		public void UpdateAgrInput(AgroInputsDTO dto){
			dal = new ConectDAL();
			dal.Conect();
			dal.ComandSql = string.Format("UPDATE `insumos` " +
			                              "SET `nome` = '{0}', " +
			                              "`unid` = '{1}', " +
			                              "`CatInsumos_idCatInsumos` = '{2}', " +
			                              "WHERE " +
			                              "`insumos`.`idInsumos` = {5};",
											dto.Name,
											dto.Unid,
											dto.IdCatInputs
								        	);
			dal.Write(dal);
		}
		
		public void Delete(int id){
			dal = new ConectDAL();
			dal.Conect();
			dal.ComandSql = "DELETE FROM `controlfarm`.`fornecedor` WHERE `fornecedor`.`idFornecedor` =  "+id;
			dal.Write(dal);
		}
		
		public DataTable DataGridReturn(AgroInputsDTO dtonv = null){
			ConectDAL dal = new ConectDAL();
			DataTable da = new DataTable();
			if(dtonv == null){
				dal.ComandSql = "SELECT idInsumos, nome, unid, categoria FROM `verinsumos`";				
			}else{
				dal.ComandSql = "SELECT idInsumos, nome, unid, categoria FROM `verinsumos` WHERE `nome` LIKE '%"+dtonv.Name+"%'";
			}
			    da = dal.MySqlDA(dal);
				return da;
		}
		
		
		

	}
	

	
	
}
