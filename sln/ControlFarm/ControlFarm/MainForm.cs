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
using Provider;
using Agr.Inputs.UI;


namespace ControlFarm
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
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
		TabControl tabcontrol = new TabControl();
		//TabControl tabcontrol = new TabControl();
		TabPage[] tabPage = new TabPage[10];
		
		
		int i = 0;
		
		void FuncionarioToolStripMenuItemClick(object sender, EventArgs e)
			
		{   
			
			if(i<10){
				UCListUpdateProviders uclistupdateprovider = new UCListUpdateProviders();
				tabPage[i] = new TabPage();
				tabPage[i].Text ="Funcionarios (aba:"+(i+1)+")";
				tabPage[i].Controls.Add(uclistupdateprovider);
				tabcontrol.Location = new Point(0,24);
				tabcontrol.Dock = System.Windows.Forms.DockStyle.None;
				tabcontrol.Multiline = true;
				tabcontrol.Name = "tabControlFunc"+i;
				tabcontrol.SelectedIndex = 0;
				tabcontrol.Size = new Size(2000,1024);
				tabcontrol.SizeMode = TabSizeMode.Fixed;
				tabcontrol.TabIndex = 2;
				tabcontrol.Controls.Add(tabPage[i]);
				this.Controls.Add(tabcontrol);
				i++;
			}else{
				MessageBox.Show("Limite de Abas ultrapassado");
			}
			
			
			
			
			
		}
		void SairToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void InsumosToolStripMenuItemClick(object sender, EventArgs e)
		{

			if(i<10){
				UCListUpdateAgrInputs uclistupdateagrinputs = new UCListUpdateAgrInputs();
				
				tabPage[i] = new TabPage();
				tabPage[i].Text ="Insumos (aba:"+(i+1)+")";
				tabPage[i].Controls.Add(uclistupdateagrinputs);
				tabcontrol.Location = new Point(0,24);
				tabcontrol.Dock = System.Windows.Forms.DockStyle.None;
				tabcontrol.Multiline = true;
				tabcontrol.Name = "tabControlFunc"+i;
				tabcontrol.SelectedIndex = 0;
				tabcontrol.Size = new Size(2000,1024);
				tabcontrol.SizeMode = TabSizeMode.Fixed;
				tabcontrol.TabIndex = 2;
				tabcontrol.Controls.Add(tabPage[i]);
				this.Controls.Add(tabcontrol);
				i++;
			}else{
				MessageBox.Show("Limite de Abas ultrapassado");
			}	
			
		}
	}
}
