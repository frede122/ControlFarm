﻿/*
 * Criado por SharpDevelop.
 * Usuário: FredePaula
 * Data: 17/06/2018
 * Hora: 13:06
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Provider.BLL;
using Provider.DTO;
using Provider.UI;
using System.Windows.Forms.Design;


namespace Provider
{
	/// <summary>
	/// Description of UCListUpdateProviders.
	/// </summary>
	public partial class UCListUpdateProviders : UserControl
	{
		//ProviderBLL bllProv = new ProviderBLL();
		ProviderBLL bllProv = new ProviderBLL();
		ProviderDTO dtoProv = new ProviderDTO();
		public void LoadTable(){
			dataGridViewProvider.DataSource = bllProv.DataGridReturn();
		}
		public UCListUpdateProviders()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			LoadTable();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
				void DataGridViewProviderCellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			
			DialogResult confirmSave = MessageBox.Show("Deseja salvar a alteração feita?", "Salvar Fornecedor", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2);
			if (confirmSave.ToString().ToUpper() == "YES"){
					if(dataGridViewProvider.Rows[e.RowIndex].Cells[0].Value.ToString() != ""){
					dtoProv.IdProvider = int.Parse(dataGridViewProvider.Rows[e.RowIndex].Cells[0].Value.ToString());
					dtoProv.Name = dataGridViewProvider.Rows[e.RowIndex].Cells[1].Value.ToString();
					dtoProv.Cpnj = dataGridViewProvider.Rows[e.RowIndex].Cells[2].Value.ToString();
					dtoProv.Address = dataGridViewProvider.Rows[e.RowIndex].Cells[3].Value.ToString();
					dtoProv.City = dataGridViewProvider.Rows[e.RowIndex].Cells[4].Value.ToString();
					dtoProv.Phone = dataGridViewProvider.Rows[e.RowIndex].Cells[5].Value.ToString();
					bllProv.Update(dtoProv);					
				}
				LoadTable();				
			}else{
				LoadTable();
			}
		}
		void ButtonEditTableClick(object sender, EventArgs e)
		{
			RegProvider regProvider = new RegProvider(dtoProv);
			regProvider.Show();
			
		}
		void DeleteRow(){
			
			DialogResult confirmDelete = MessageBox.Show("Deseja Excluir permanentemente o cadastro do fornecedor: "+dtoProv.Name+"?", "Deletar Fornecedor", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2);
			if (confirmDelete.ToString().ToUpper() == "YES"){
				if(dtoProv.IdProvider > 0){
					bllProv.Delete(dtoProv.IdProvider);
					MessageBox.Show("Linha de id = "+dtoProv.IdProvider+" excluida");
					dataGridViewProvider.DataSource = bllProv.DataGridReturn();
					
				}else{
					MessageBox.Show("Linha da tabela não pode ser excluida, tente novamente!");
				}
			}
			LoadTable();
			
		}
		void ButtonDeleteClick(object sender, EventArgs e)
		{
			//this.Close();
		}
		void DataGridViewProviderCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex >=0 ){
				if(dataGridViewProvider.Rows[e.RowIndex].Cells[0].Value.ToString() != ""){
					dtoProv.IdProvider = int.Parse(dataGridViewProvider.Rows[e.RowIndex].Cells[0].Value.ToString());
					dtoProv.Name = dataGridViewProvider.Rows[e.RowIndex].Cells[1].Value.ToString();
					dtoProv.Cpnj = dataGridViewProvider.Rows[e.RowIndex].Cells[2].Value.ToString();
					dtoProv.Address = dataGridViewProvider.Rows[e.RowIndex].Cells[3].Value.ToString();
					dtoProv.City = dataGridViewProvider.Rows[e.RowIndex].Cells[4].Value.ToString();
					dtoProv.Phone = dataGridViewProvider.Rows[e.RowIndex].Cells[5].Value.ToString();
				}
				else{
					dtoProv.IdProvider = -1;
				}
			}
				
		}
		void DataGridViewProviderRowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			DeleteRow();
		}
		void NovoToolStripButtonClick(object sender, EventArgs e)
		{	
			
			RegProvider regProvider = new RegProvider();
			regProvider.Show();
		}
		void DeleteStripButtonClick(object sender, EventArgs e)
		{
			DeleteRow();	
		}
		void Panel1Paint(object sender, PaintEventArgs e)
		{
	
		}
		void ToolStripTextBox1Enter(object sender, EventArgs e)
		{
			dtoProv.Name = searchStripTextBox.Text;
			dataGridViewProvider.DataSource = bllProv.DataGridReturn(dtoProv);
		}
		void ImprimirToolStripButtonClick(object sender, EventArgs e)
		{
			//printPreviewDialog1.Document = printDocument1;
			
			//printPreviewDialog1.Show();
			printDocument1.Print();
			
		}
		void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
		
			Bitmap bm = new Bitmap(this.dataGridViewProvider.Width, this.dataGridViewProvider.Height);
			
			this.dataGridViewProvider.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridViewProvider.Width, this.dataGridViewProvider.Height));
			
			e.Graphics.DrawImage(bm, 0, 0);
		}
		/*void Im(object sender, EventArgs e)
		{
	
		}*/

		void ReloadStripButtonClick(object sender, EventArgs e)
		{
			LoadTable();
		}
		void DataGridViewProviderUserDeletedRow(object sender, DataGridViewRowEventArgs e)
		{
			DeleteRow();
		}
		void EditStripButtonClick(object sender, EventArgs e)
		{
	
		}
		
		
		
		
	}
}
