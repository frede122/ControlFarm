/*
 * Criado por SharpDevelop.
 * Usuário: FredePaula
 * Data: 26/05/2018
 * Hora: 00:40
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Provider.DTO;
using Provider.BLL;
using ControlFarm.UI.Provider;
using ControlFarm.UI.Agr.Inputs;


namespace ControlFarm
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		ListUpdateProvider provider;
		ListUpdateAgrInputs agroInput;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ButtonTesteClick(object sender, EventArgs e)
		{
			
		}
		void ArquivoToolStripMenuItemClick(object sender, EventArgs e)
		{
	
		}
		void FuncionarioToolStripMenuItemClick(object sender, EventArgs e)
		{   MainForm mf = new MainForm();
			provider = new ListUpdateProvider();
			provider.MdiParent = this;
			provider.Show();
			provider = null;
		}
		void SairToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void InsumosToolStripMenuItemClick(object sender, EventArgs e)
		{
			agroInput = new ListUpdateAgrInputs();
			agroInput.MdiParent = this;
			agroInput.Show();
			agroInput = null;
	
		}
	}
}
