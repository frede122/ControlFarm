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
		private int idInvoice_idProvider;
		private float amount;
		public int IdInvoice{
			get {return idInvoice;}
			set {idInvoice = value;}
		}
		public int Invoice{
			get {return invoice;}
			set {invoice = value;}
		}
		public int IdInvoice_IdProvider{
			get {return idInvoice_idProvider;}
			set {idInvoice_idProvider = value;}		
		}
		public float Amount{
			get {return amount;}
			set {amount = value;}				
		}
		
	}
}
