/*
 * Criado por SharpDevelop.
 * Usuário: FredePaula
 * Data: 03/06/2018
 * Hora: 22:20
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace ControlFarm.UI.Agr.Inputs
{
	partial class ListUpdateAgrInputs
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripTextBox searchStripTextBox;
		private System.Windows.Forms.ToolStripButton imprimirToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.ToolStripButton reloadStripButton;
		private System.Windows.Forms.ToolStripButton deleteStripButton;
		private System.Windows.Forms.ToolStripButton editStripButton;
		private System.Windows.Forms.ToolStripButton novoToolStripButton;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.DataGridView dataGridViewProvider;
		private System.Windows.Forms.SplitContainer splitContainer1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListUpdateAgrInputs));
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.label1 = new System.Windows.Forms.Label();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.searchStripTextBox = new System.Windows.Forms.ToolStripTextBox();
			this.imprimirToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.reloadStripButton = new System.Windows.Forms.ToolStripButton();
			this.deleteStripButton = new System.Windows.Forms.ToolStripButton();
			this.editStripButton = new System.Windows.Forms.ToolStripButton();
			this.novoToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.dataGridViewProvider = new System.Windows.Forms.DataGridView();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProvider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// printDialog1
			// 
			this.printDialog1.Document = this.printDocument1;
			this.printDialog1.PrintToFile = true;
			this.printDialog1.UseEXDialog = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(463, 27);
			this.label1.TabIndex = 3;
			this.label1.Text = "*  Duplo click para edição, ENTER para alterar e salvar\r\n** Deletar linha da tabe" +
	"la em edição resultara na exclusão permanente das informações";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(57, 36);
			this.toolStripLabel1.Text = "Pesquisar";
			// 
			// searchStripTextBox
			// 
			this.searchStripTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
			this.searchStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.searchStripTextBox.Name = "searchStripTextBox";
			this.searchStripTextBox.Size = new System.Drawing.Size(200, 39);
			this.searchStripTextBox.Tag = "";
			// 
			// imprimirToolStripButton
			// 
			this.imprimirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripButton.Image")));
			this.imprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.imprimirToolStripButton.Name = "imprimirToolStripButton";
			this.imprimirToolStripButton.Size = new System.Drawing.Size(89, 36);
			this.imprimirToolStripButton.Text = "&Imprimir";
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(6, 39);
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Document = this.printDocument1;
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Visible = false;
			// 
			// reloadStripButton
			// 
			this.reloadStripButton.Image = ((System.Drawing.Image)(resources.GetObject("reloadStripButton.Image")));
			this.reloadStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.reloadStripButton.Name = "reloadStripButton";
			this.reloadStripButton.Size = new System.Drawing.Size(99, 36);
			this.reloadStripButton.Text = "Recarregar";
			// 
			// deleteStripButton
			// 
			this.deleteStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteStripButton.Image")));
			this.deleteStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.deleteStripButton.Name = "deleteStripButton";
			this.deleteStripButton.Size = new System.Drawing.Size(77, 36);
			this.deleteStripButton.Text = "Excluir";
			// 
			// editStripButton
			// 
			this.editStripButton.Image = ((System.Drawing.Image)(resources.GetObject("editStripButton.Image")));
			this.editStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.editStripButton.Name = "editStripButton";
			this.editStripButton.Size = new System.Drawing.Size(111, 36);
			this.editStripButton.Tag = "";
			this.editStripButton.Text = "Editar Tabela";
			// 
			// novoToolStripButton
			// 
			this.novoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripButton.Image")));
			this.novoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.novoToolStripButton.Name = "novoToolStripButton";
			this.novoToolStripButton.Size = new System.Drawing.Size(72, 36);
			this.novoToolStripButton.Text = "&Novo";
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.novoToolStripButton,
			this.editStripButton,
			this.deleteStripButton,
			this.toolStripSeparator1,
			this.reloadStripButton,
			this.toolStripSeparator,
			this.imprimirToolStripButton,
			this.searchStripTextBox,
			this.toolStripLabel1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(834, 39);
			this.toolStrip1.TabIndex = 6;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.toolStrip1);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.dataGridViewProvider);
			this.splitContainer2.Size = new System.Drawing.Size(834, 442);
			this.splitContainer2.SplitterDistance = 43;
			this.splitContainer2.TabIndex = 0;
			// 
			// dataGridViewProvider
			// 
			this.dataGridViewProvider.AllowUserToOrderColumns = true;
			this.dataGridViewProvider.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridViewProvider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridViewProvider.ColumnHeadersHeight = 40;
			this.dataGridViewProvider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridViewProvider.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewProvider.EnableHeadersVisualStyles = false;
			this.dataGridViewProvider.GridColor = System.Drawing.SystemColors.Control;
			this.dataGridViewProvider.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewProvider.Name = "dataGridViewProvider";
			this.dataGridViewProvider.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dataGridViewProvider.Size = new System.Drawing.Size(834, 395);
			this.dataGridViewProvider.TabIndex = 3;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
			this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.splitContainer1.Size = new System.Drawing.Size(834, 512);
			this.splitContainer1.SplitterDistance = 442;
			this.splitContainer1.TabIndex = 5;
			// 
			// ListUpdateAgrInputs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(834, 512);
			this.Controls.Add(this.splitContainer1);
			this.Name = "ListUpdateAgrInputs";
			this.Text = "ListUpdateAgrInputs";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProvider)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
