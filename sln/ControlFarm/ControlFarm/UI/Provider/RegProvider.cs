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
		public RegProvider()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		ProviderBLL bll = new ProviderBLL();
		ProviderDTO dto = new ProviderDTO();
		void ButtonGravarClick(object sender, EventArgs e)
		{
			dto.Address = textBoxAdress.Text;
			dto.City = textBoxCity.Text;
			dto.Cpnj = double.Parse(textBoxCNPJ.Text);
			dto.Name = textBoxName.Text;
			dto.Phone = int.Parse(textBoxPhone.Text);
			bll.save(dto);
				
		}
	}
}
