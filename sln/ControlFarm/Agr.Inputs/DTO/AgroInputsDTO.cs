/*
 * Criado por SharpDevelop.
 * Usuário: FredePaula
 * Data: 03/06/2018
 * Hora: 22:02
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace Agr.Inputs.DTO
{
	/// <summary>
	/// Description of AgroInputsDTO.
	/// </summary>
	public class AgroInputsDTO
	{
		public AgroInputsDTO()
		{
		}
		private int idAgroInputs;
		private int idCatInputs;
		private int idInput;
		private string name;
		private string unid;
		private DateTime date;
		private float amount;
		private decimal total;
		
		public int IdAgroInputs{
			get {return idAgroInputs;}
			set {idAgroInputs = value;}
		}
		public int IdCatInputs{
			get {return idCatInputs;}
			set {idCatInputs = value;}				
		}		
		public int IdInput{
			get {return idInput;}
			set {idInput = value;}			
		}		
		public string Name{
			get {return name;}
			set {name = value;}			
		}
		public string Unid{
			get {return unid;}
			set {unid = value;}			
		}
		public DateTime Date{
			get {return date;}
			set {date = value;}			
		}
		public float Amount{
			get {return amount;}
			set {amount = value;}			
		}
		public decimal Total{
			get {return total;}
			set {total = value;}			
		}
		
	}
}
