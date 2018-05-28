/*
 * Criado por SharpDevelop.
 * Usuário: FredePaula
 * Data: 27/05/2018
 * Hora: 00:55
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace Provider.DTO
{
	/// <summary>
	/// Description of ProviderDTO.
	/// </summary>
	public class ProviderDTO
	{
		public ProviderDTO()
		{
		}
		//Provider
		private int idProvider;
		public int IdProvider {
			get{ return idProvider; }
			set{ idProvider = value; }			
		}
		private string name;
		public string Name {
			get{ return name; }
			set{ name = value; }
		}
		private double cnpj;
		public double Cpnj {
			get{ return cnpj; }
			set{ cnpj = value; }			
		}
		private string adress;
		public string Address {
			get{ return adress; }
			set{ adress = value; }
		}
		private string city;
		public string City {
			get{ return city; }
			set{ city = value; }
		}
		private int phone;
		public int Phone {
			get{ return phone; }
			set{ phone = value; }
		}
		

		
	}
}
