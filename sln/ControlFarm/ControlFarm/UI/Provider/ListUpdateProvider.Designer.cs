/*
 * Criado por SharpDevelop.
 * Usuário: Arizona
 * Data: 28/05/2018
 * Hora: 16:55
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace ControlFarm.UI.Provider
{
	partial class ListUpdateProvider
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridViewProvider;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton novoToolStripButton;
		private System.Windows.Forms.ToolStripButton imprimirToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripButton deleteStripButton;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.ToolStripButton editStripButton;
		private System.Windows.Forms.ToolStripTextBox searchStripTextBox;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton reloadStripButton;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListUpdateProvider));
			this.dataGridViewProvider = new System.Windows.Forms.DataGridView();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.novoToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.editStripButton = new System.Windows.Forms.ToolStripButton();
			this.deleteStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.reloadStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.imprimirToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.searchStripTextBox = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProvider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
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
			this.dataGridViewProvider.Size = new System.Drawing.Size(864, 379);
			this.dataGridViewProvider.TabIndex = 3;
			this.dataGridViewProvider.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewProviderCellClick);
			this.dataGridViewProvider.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewProviderCellValueChanged);
			this.dataGridViewProvider.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.DataGridViewProviderUserDeletedRow);
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
			this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1Paint);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.splitContainer1.Size = new System.Drawing.Size(864, 492);
			this.splitContainer1.SplitterDistance = 425;
			this.splitContainer1.TabIndex = 4;
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
			this.splitContainer2.Size = new System.Drawing.Size(864, 425);
			this.splitContainer2.SplitterDistance = 42;
			this.splitContainer2.TabIndex = 0;
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
			this.toolStrip1.Size = new System.Drawing.Size(864, 39);
			this.toolStrip1.TabIndex = 6;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// novoToolStripButton
			// 
			this.novoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripButton.Image")));
			this.novoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.novoToolStripButton.Name = "novoToolStripButton";
			this.novoToolStripButton.Size = new System.Drawing.Size(72, 36);
			this.novoToolStripButton.Text = "&Novo";
			this.novoToolStripButton.Click += new System.EventHandler(this.NovoToolStripButtonClick);
			// 
			// editStripButton
			// 
			this.editStripButton.Image = ((System.Drawing.Image)(resources.GetObject("editStripButton.Image")));
			this.editStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.editStripButton.Name = "editStripButton";
			this.editStripButton.Size = new System.Drawing.Size(111, 36);
			this.editStripButton.Tag = "";
			this.editStripButton.Text = "Editar Tabela";
			this.editStripButton.Click += new System.EventHandler(this.ButtonEditTableClick);
			// 
			// deleteStripButton
			// 
			this.deleteStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteStripButton.Image")));
			this.deleteStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.deleteStripButton.Name = "deleteStripButton";
			this.deleteStripButton.Size = new System.Drawing.Size(77, 36);
			this.deleteStripButton.Text = "Excluir";
			this.deleteStripButton.Click += new System.EventHandler(this.DeleteStripButtonClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
			// 
			// reloadStripButton
			// 
			this.reloadStripButton.Image = ((System.Drawing.Image)(resources.GetObject("reloadStripButton.Image")));
			this.reloadStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.reloadStripButton.Name = "reloadStripButton";
			this.reloadStripButton.Size = new System.Drawing.Size(99, 36);
			this.reloadStripButton.Text = "Recarregar";
			this.reloadStripButton.Click += new System.EventHandler(this.ReloadStripButtonClick);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(6, 39);
			// 
			// imprimirToolStripButton
			// 
			this.imprimirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripButton.Image")));
			this.imprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.imprimirToolStripButton.Name = "imprimirToolStripButton";
			this.imprimirToolStripButton.Size = new System.Drawing.Size(89, 36);
			this.imprimirToolStripButton.Text = "&Imprimir";
			this.imprimirToolStripButton.Click += new System.EventHandler(this.ImprimirToolStripButtonClick);
			// 
			// searchStripTextBox
			// 
			this.searchStripTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
			this.searchStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.searchStripTextBox.Name = "searchStripTextBox";
			this.searchStripTextBox.Size = new System.Drawing.Size(200, 39);
			this.searchStripTextBox.Tag = "";
			this.searchStripTextBox.TextChanged += new System.EventHandler(this.ToolStripTextBox1Enter);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(57, 36);
			this.toolStripLabel1.Text = "Pesquisar";
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
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
			// printDialog1
			// 
			this.printDialog1.Document = this.printDocument1;
			this.printDialog1.PrintToFile = true;
			this.printDialog1.UseEXDialog = true;
			// 
			// ListUpdateProvider
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(864, 492);
			this.Controls.Add(this.splitContainer1);
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "ListUpdateProvider";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fornecedores";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProvider)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
