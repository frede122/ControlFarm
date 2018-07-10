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
using Provider;
using Agr.Inputs.UI;



namespace ControlFarm
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int inc;
		Queue<int> tabcont = new Queue<int>();
		public TabControl tabcontrol = new TabControl();
		public TabPage[] tabPage = new TabPage[10] ;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			for (int i = 0; i < 10; i++) {
				
				tabcont.Enqueue(i);
			}
			panel1.Controls.Add(tabcontrol);
			tabcontrol.Location = new Point(0,0);
			tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
			tabcontrol.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			tabcontrol.Multiline = true; 
			tabcontrol.Name = "tabControlFunc"+inc;
			tabcontrol.SelectedIndex = 0;
			tabcontrol.Size = new Size(2000,1024);
			tabcontrol.SizeMode = TabSizeMode.Fixed;
			tabcontrol.TabIndex = 2;
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
			
		{   
			if(tabcont.Count > 0)
			{
			    inc = tabcont.Dequeue();
			    //MessageBox.Show(inc.ToString());
				UCListUpdateProviders uclistupdateprovider = new UCListUpdateProviders();
				uclistupdateprovider.Name = inc.ToString();
				tabPage[inc] = new TabPage();
				tabPage[inc].Text ="Funcionarios "+inc;
				tabPage[inc].Name = inc.ToString();
				tabPage[inc].Controls.Add(uclistupdateprovider);
				tabcontrol.Controls.Add(tabPage[inc]);
				xToolStripMenuItem.Enabled = true;
				
			}else{

				MessageBox.Show("Limite de Abas ultrapassado");
			}
			
			
			
			
			
		}
		
		public void ExitTab(){
			tabcontrol.Controls.Remove(tabcontrol.SelectedTab);
		}
		
		void SairToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void InsumosToolStripMenuItemClick(object sender, EventArgs e)
		{
			
			if(tabcont.Count > 0){
				inc = tabcont.Dequeue();
				//MessageBox.Show(inc.ToString());
				UCListUpdateAgrInputs uclistupdateagrinputs = new UCListUpdateAgrInputs(inc);
				uclistupdateagrinputs.Name = inc.ToString();
				tabPage[inc] = new TabPage();
				tabPage[inc].Text ="Insumos "+inc;
				tabPage[inc].Name = inc.ToString();
				tabPage[inc].Controls.Add(uclistupdateagrinputs);
				tabcontrol.Controls.Add(tabPage[inc]);
				xToolStripMenuItem.Enabled = true;
			}else{
				MessageBox.Show("Limite de Abas ultrapassado");
			}	
			
		}
		void XToolStripMenuItemClick(object sender, EventArgs e)
		{
			
			DialogResult confirmExit = MessageBox.Show("Fechar?", "Fechar aba: "+ tabcontrol.SelectedTab.Text.ToString()+" ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2);
			if (confirmExit.ToString().ToUpper() == "YES"){
			tabcont.Enqueue(int.Parse(tabcontrol.SelectedTab.Name));
			ExitTab();
			}
			if(tabcont.Count >=10){
					xToolStripMenuItem.Enabled = false;
			}

			
			
		}
	}
}
