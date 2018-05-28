/*
 * Criado por SharpDevelop.
 * Usuário: FredePaula
 * Data: 27/05/2018
 * Hora: 23:27
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace ControlFarm.UI.Provider
{
	partial class RegProvider
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label labelPhone;
		private System.Windows.Forms.TextBox textBoxPhone;
		private System.Windows.Forms.Label labelCity;
		private System.Windows.Forms.Label labelAdress;
		private System.Windows.Forms.TextBox textBoxCity;
		private System.Windows.Forms.TextBox textBoxAdress;
		private System.Windows.Forms.TextBox textBoxCNPJ;
		private System.Windows.Forms.Label labelcnpj;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Button buttonGravar;
		private System.Windows.Forms.TextBox textBoxName;
		
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
			this.labelPhone = new System.Windows.Forms.Label();
			this.textBoxPhone = new System.Windows.Forms.TextBox();
			this.labelCity = new System.Windows.Forms.Label();
			this.labelAdress = new System.Windows.Forms.Label();
			this.textBoxCity = new System.Windows.Forms.TextBox();
			this.textBoxAdress = new System.Windows.Forms.TextBox();
			this.textBoxCNPJ = new System.Windows.Forms.TextBox();
			this.labelcnpj = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.buttonGravar = new System.Windows.Forms.Button();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// labelPhone
			// 
			this.labelPhone.Location = new System.Drawing.Point(14, 175);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(41, 23);
			this.labelPhone.TabIndex = 20;
			this.labelPhone.Text = "Telefone";
			// 
			// textBoxPhone
			// 
			this.textBoxPhone.Location = new System.Drawing.Point(74, 172);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(198, 20);
			this.textBoxPhone.TabIndex = 19;
			// 
			// labelCity
			// 
			this.labelCity.Location = new System.Drawing.Point(12, 129);
			this.labelCity.Name = "labelCity";
			this.labelCity.Size = new System.Drawing.Size(43, 23);
			this.labelCity.TabIndex = 18;
			this.labelCity.Text = "Cidade";
			// 
			// labelAdress
			// 
			this.labelAdress.Location = new System.Drawing.Point(12, 91);
			this.labelAdress.Name = "labelAdress";
			this.labelAdress.Size = new System.Drawing.Size(56, 23);
			this.labelAdress.TabIndex = 17;
			this.labelAdress.Text = "Endereço";
			// 
			// textBoxCity
			// 
			this.textBoxCity.Location = new System.Drawing.Point(74, 129);
			this.textBoxCity.Name = "textBoxCity";
			this.textBoxCity.Size = new System.Drawing.Size(198, 20);
			this.textBoxCity.TabIndex = 16;
			// 
			// textBoxAdress
			// 
			this.textBoxAdress.Location = new System.Drawing.Point(74, 91);
			this.textBoxAdress.Name = "textBoxAdress";
			this.textBoxAdress.Size = new System.Drawing.Size(198, 20);
			this.textBoxAdress.TabIndex = 15;
			// 
			// textBoxCNPJ
			// 
			this.textBoxCNPJ.Location = new System.Drawing.Point(74, 55);
			this.textBoxCNPJ.Name = "textBoxCNPJ";
			this.textBoxCNPJ.Size = new System.Drawing.Size(198, 20);
			this.textBoxCNPJ.TabIndex = 14;
			// 
			// labelcnpj
			// 
			this.labelcnpj.Location = new System.Drawing.Point(12, 58);
			this.labelcnpj.Name = "labelcnpj";
			this.labelcnpj.Size = new System.Drawing.Size(43, 23);
			this.labelcnpj.TabIndex = 13;
			this.labelcnpj.Text = "cnpj";
			// 
			// labelName
			// 
			this.labelName.Location = new System.Drawing.Point(12, 18);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(43, 23);
			this.labelName.TabIndex = 12;
			this.labelName.Text = "Nome";
			// 
			// buttonGravar
			// 
			this.buttonGravar.Location = new System.Drawing.Point(103, 208);
			this.buttonGravar.Name = "buttonGravar";
			this.buttonGravar.Size = new System.Drawing.Size(86, 36);
			this.buttonGravar.TabIndex = 21;
			this.buttonGravar.Text = "Gravar";
			this.buttonGravar.UseVisualStyleBackColor = true;
			this.buttonGravar.Click += new System.EventHandler(this.ButtonGravarClick);
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(74, 18);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(198, 20);
			this.textBoxName.TabIndex = 11;
			// 
			// RegProvider
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.labelPhone);
			this.Controls.Add(this.textBoxPhone);
			this.Controls.Add(this.labelCity);
			this.Controls.Add(this.labelAdress);
			this.Controls.Add(this.textBoxCity);
			this.Controls.Add(this.textBoxAdress);
			this.Controls.Add(this.textBoxCNPJ);
			this.Controls.Add(this.labelcnpj);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.buttonGravar);
			this.Controls.Add(this.textBoxName);
			this.Name = "RegProvider";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastrar Fornecedor";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
