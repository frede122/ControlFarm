/*
 * Criado por SharpDevelop.
 * Usuário: FredePaula
 * Data: 17/06/2018
 * Hora: 19:20
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Agr.Inputs.BLL;
using Agr.Inputs.DTO;

namespace Agr.Inputs.UI
{
	/// <summary>
	/// Description of UCListUpdateAgrInputs.
	/// </summary>
	public partial class UCListUpdateAgrInputs : UserControl
	{   
		int row = 0;
		AgrInputsBLL bllAgr = new AgrInputsBLL();
		AgroInputsDTO dtoAgr = new AgroInputsDTO();
		public void LoadTable(){
			dataGridViewAgrInputs.DataSource = bllAgr.DataGridReturn();
		}
		void DeleteRow(){
			
			DialogResult confirmDelete = MessageBox.Show("Deseja Excluir permanentemente o cadastro do fornecedor: "+dtoAgr.Name+"?", "Deletar Fornecedor", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2);
			if (confirmDelete.ToString().ToUpper() == "YES"){
				if(dtoAgr.IdAgroInputs > 0){
					bllAgr.Delete(dtoAgr.IdAgroInputs);
					MessageBox.Show("Linha de id = "+dtoAgr.IdAgroInputs+" excluida");
					dataGridViewAgrInputs.DataSource = bllAgr.DataGridReturn();
					
				}else{
					MessageBox.Show("Linha da tabela não pode ser excluida, tente novamente!");
				}
			}
			LoadTable();
			
		}
		public UCListUpdateAgrInputs()
		{
			
			
			InitializeComponent();
			LoadTable();
			
		}
		void ToolStrip1ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
	
		}
		void Panel2Paint(object sender, PaintEventArgs e)
		{
	
		}
		void SairToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		void EditStripButtonClick(object sender, EventArgs e)
		{
			
			textBoxId.Text = dataGridViewAgrInputs.Rows[row].Cells[0].Value.ToString();
			textBoxName.Text = dataGridViewAgrInputs.Rows[row].Cells[1].Value.ToString();
			textBoxU.Text = dataGridViewAgrInputs.Rows[row].Cells[2].Value.ToString();
			comboBoxCat.Text = dataGridViewAgrInputs.Rows[row].Cells[3].Value.ToString();
		}
		void DataGridViewAgrInputsCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			row = e.RowIndex;
		}
		void NovoToolStripButtonClick(object sender, EventArgs e)
		{
			textBoxU.Text = null;
			textBoxName.Text = null;
			textBoxId.Text = null;
			comboBoxCat.Text = null;
			comboBoxCat.Items.Add("");
			
		}
		void ButtonClearClick(object sender, EventArgs e)
		{
			textBoxU.Text = null;
			textBoxName.Text = null;
			comboBoxCat.Text = null;
		}
	}
}
