/*
 * Criado por SharpDevelop.
 * Usuário: FredePaula
 * Data: 20/05/2018
 * Hora: 22:21
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace ControlFarm
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem insumosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem conteúdoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem índiceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
		public System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
		
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.insumosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.conteúdoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.índiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.cadastroToolStripMenuItem,
			this.ajudaToolStripMenuItem,
			this.xToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(934, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// cadastroToolStripMenuItem
			// 
			this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.funcionarioToolStripMenuItem,
			this.insumosToolStripMenuItem,
			this.sairToolStripMenuItem});
			this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
			this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.cadastroToolStripMenuItem.Text = "&Cadastro";
			// 
			// funcionarioToolStripMenuItem
			// 
			this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
			this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.funcionarioToolStripMenuItem.Text = "Funcionario";
			this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.FuncionarioToolStripMenuItemClick);
			// 
			// insumosToolStripMenuItem
			// 
			this.insumosToolStripMenuItem.Name = "insumosToolStripMenuItem";
			this.insumosToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.insumosToolStripMenuItem.Text = "Insumos";
			this.insumosToolStripMenuItem.Click += new System.EventHandler(this.InsumosToolStripMenuItemClick);
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.sairToolStripMenuItem.Text = "Sair";
			this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItemClick);
			// 
			// ajudaToolStripMenuItem
			// 
			this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.conteúdoToolStripMenuItem,
			this.índiceToolStripMenuItem,
			this.pesquisarToolStripMenuItem,
			this.toolStripSeparator5,
			this.sobreToolStripMenuItem});
			this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
			this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.ajudaToolStripMenuItem.Text = "Aj&uda";
			// 
			// conteúdoToolStripMenuItem
			// 
			this.conteúdoToolStripMenuItem.Name = "conteúdoToolStripMenuItem";
			this.conteúdoToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.conteúdoToolStripMenuItem.Text = "&Conteúdo";
			// 
			// índiceToolStripMenuItem
			// 
			this.índiceToolStripMenuItem.Name = "índiceToolStripMenuItem";
			this.índiceToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.índiceToolStripMenuItem.Text = "Í&ndice";
			// 
			// pesquisarToolStripMenuItem
			// 
			this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
			this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.pesquisarToolStripMenuItem.Text = "&Pesquisar";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(124, 6);
			// 
			// sobreToolStripMenuItem
			// 
			this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
			this.sobreToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.sobreToolStripMenuItem.Text = "&Sobre...";
			// 
			// xToolStripMenuItem
			// 
			this.xToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.xToolStripMenuItem.Enabled = false;
			this.xToolStripMenuItem.Name = "xToolStripMenuItem";
			this.xToolStripMenuItem.Size = new System.Drawing.Size(26, 20);
			this.xToolStripMenuItem.Text = "X";
			this.xToolStripMenuItem.Click += new System.EventHandler(this.XToolStripMenuItemClick);
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(934, 488);
			this.panel1.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(934, 512);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ControlFarm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
