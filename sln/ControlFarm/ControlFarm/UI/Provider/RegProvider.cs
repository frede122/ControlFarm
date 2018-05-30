/*
 * Criado por SharpDevelop.
 * Usuário: FredePaula
 * Data: 27/05/2018
 * Hora: 23:27
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Provider.DTO;
using Provider.BLL;

namespace ControlFarm.UI.Provider
{
	/// <summary>
	/// Description of RegProvider.
	/// </summary>
	public partial class RegProvider : Form
	{
		
		public RegProvider(ProviderDTO dtoProvider = null)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			if( dtoProvider != null){
				textBoxAdress.Text = dtoProvider.Address;
				textBoxCity.Text = dtoProvider.City;
				textBoxCNPJ.Text = dtoProvider.Cpnj.ToString();
				textBoxName.Text = dtoProvider.Name;
				textBoxPhone.Text = dtoProvider.Phone.ToString();
				textBoxID.Text = dtoProvider.IdProvider.ToString();				
			}
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		ProviderBLL bll;
		ProviderDTO dto;
		void ButtonGravarClick(object sender, EventArgs e)
		{
			bll = new ProviderBLL();
			dto = new ProviderDTO();
			dto.Address = textBoxAdress.Text;
			dto.City = textBoxCity.Text;
			dto.Cpnj = double.Parse(textBoxCNPJ.Text);
			dto.Name = textBoxName.Text;
			dto.Phone = int.Parse(textBoxPhone.Text);		
			if(textBoxID.Text == ""){
				bll.Save(dto);
			}else{
				dto.IdProvider = int.Parse(textBoxID.Text);
				bll.Update(dto);
			}
			this.Close();
				
		}
		void ButtonCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
