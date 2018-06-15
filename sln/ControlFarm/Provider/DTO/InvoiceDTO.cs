/*
 * Criado por SharpDevelop.
 * Usuário: FredePaula
 * Data: 27/05/2018
 * Hora: 01:27
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace Provider.DTO
{
	/// <summary>
	/// Description of InvoiceDTO.
	/// </summary>
	
	public class InvoiceDTO
	{
		
		public InvoiceDTO()
		{
		}
		private int idInvoice;
		private int invoice;
		private decimal amount;
		public int IdInvoice{
			get {return idInvoice;}
			set {idInvoice = value;}
		}
		public int Invoice{
			get {return invoice;}
			set {invoice = value;}
		}
		public decimal Amount{
			get {return amount;}
			set {amount = value;}				
		}
		
	}
}
