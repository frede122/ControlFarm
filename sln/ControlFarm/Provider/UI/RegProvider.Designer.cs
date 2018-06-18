/*
 * Criado por SharpDevelop.
 * Usuário: FredePaula
 * Data: 27/05/2018
 * Hora: 23:27
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Provider.UI
{
	partial class RegProvider
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label labelPhone;
		private System.Windows.Forms.Label labelCity;
		private System.Windows.Forms.Label labelAdress;
		private System.Windows.Forms.TextBox textBoxCity;
		private System.Windows.Forms.TextBox textBoxAdress;
		private System.Windows.Forms.MaskedTextBox textBoxCPFCNPJ;
		private System.Windows.Forms.Label labelcnpj;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Button buttonGravar;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxID;
		private System.Windows.Forms.Label labelID;
		private System.Windows.Forms.Button buttonCancelar;
		private System.Windows.Forms.MaskedTextBox textBoxPhone;
		private System.Windows.Forms.ComboBox comboBoxCNPJ;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegProvider));
			this.labelPhone = new System.Windows.Forms.Label();
			this.labelCity = new System.Windows.Forms.Label();
			this.labelAdress = new System.Windows.Forms.Label();
			this.textBoxCity = new System.Windows.Forms.TextBox();
			this.textBoxAdress = new System.Windows.Forms.TextBox();
			this.labelcnpj = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.buttonGravar = new System.Windows.Forms.Button();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxID = new System.Windows.Forms.TextBox();
			this.labelID = new System.Windows.Forms.Label();
			this.buttonCancelar = new System.Windows.Forms.Button();
			this.textBoxPhone = new System.Windows.Forms.MaskedTextBox();
			this.textBoxCPFCNPJ = new System.Windows.Forms.MaskedTextBox();
			this.comboBoxCNPJ = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// labelPhone
			// 
			this.labelPhone.BackColor = System.Drawing.Color.Transparent;
			this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPhone.Location = new System.Drawing.Point(12, 237);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(77, 23);
			this.labelPhone.TabIndex = 20;
			this.labelPhone.Text = "Telefone";
			// 
			// labelCity
			// 
			this.labelCity.BackColor = System.Drawing.Color.Transparent;
			this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCity.Location = new System.Drawing.Point(12, 194);
			this.labelCity.Name = "labelCity";
			this.labelCity.Size = new System.Drawing.Size(77, 23);
			this.labelCity.TabIndex = 18;
			this.labelCity.Text = "Cidade";
			// 
			// labelAdress
			// 
			this.labelAdress.BackColor = System.Drawing.Color.Transparent;
			this.labelAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAdress.Location = new System.Drawing.Point(12, 157);
			this.labelAdress.Name = "labelAdress";
			this.labelAdress.Size = new System.Drawing.Size(77, 23);
			this.labelAdress.TabIndex = 17;
			this.labelAdress.Text = "Endereço";
			// 
			// textBoxCity
			// 
			this.textBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCity.Location = new System.Drawing.Point(96, 190);
			this.textBoxCity.Name = "textBoxCity";
			this.textBoxCity.Size = new System.Drawing.Size(279, 24);
			this.textBoxCity.TabIndex = 16;
			// 
			// textBoxAdress
			// 
			this.textBoxAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxAdress.Location = new System.Drawing.Point(96, 152);
			this.textBoxAdress.Name = "textBoxAdress";
			this.textBoxAdress.Size = new System.Drawing.Size(279, 24);
			this.textBoxAdress.TabIndex = 15;
			// 
			// labelcnpj
			// 
			this.labelcnpj.BackColor = System.Drawing.Color.Transparent;
			this.labelcnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelcnpj.Location = new System.Drawing.Point(12, 126);
			this.labelcnpj.Name = "labelcnpj";
			this.labelcnpj.Size = new System.Drawing.Size(77, 19);
			this.labelcnpj.TabIndex = 13;
			this.labelcnpj.Text = "CNPJ";
			// 
			// labelName
			// 
			this.labelName.BackColor = System.Drawing.Color.Transparent;
			this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelName.Location = new System.Drawing.Point(12, 52);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(77, 23);
			this.labelName.TabIndex = 12;
			this.labelName.Text = "Nome";
			// 
			// buttonGravar
			// 
			this.buttonGravar.Location = new System.Drawing.Point(45, 293);
			this.buttonGravar.Name = "buttonGravar";
			this.buttonGravar.Size = new System.Drawing.Size(127, 43);
			this.buttonGravar.TabIndex = 21;
			this.buttonGravar.Text = "Gravar";
			this.buttonGravar.UseVisualStyleBackColor = true;
			this.buttonGravar.Click += new System.EventHandler(this.ButtonGravarClick);
			// 
			// textBoxName
			// 
			this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxName.Location = new System.Drawing.Point(96, 46);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(279, 24);
			this.textBoxName.TabIndex = 11;
			// 
			// textBoxID
			// 
			this.textBoxID.Enabled = false;
			this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxID.Location = new System.Drawing.Point(96, 12);
			this.textBoxID.Name = "textBoxID";
			this.textBoxID.Size = new System.Drawing.Size(114, 24);
			this.textBoxID.TabIndex = 22;
			// 
			// labelID
			// 
			this.labelID.BackColor = System.Drawing.Color.Transparent;
			this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelID.Location = new System.Drawing.Point(12, 17);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(77, 23);
			this.labelID.TabIndex = 23;
			this.labelID.Text = "ID";
			// 
			// buttonCancelar
			// 
			this.buttonCancelar.Location = new System.Drawing.Point(232, 293);
			this.buttonCancelar.Name = "buttonCancelar";
			this.buttonCancelar.Size = new System.Drawing.Size(127, 43);
			this.buttonCancelar.TabIndex = 24;
			this.buttonCancelar.Text = "Cancelar";
			this.buttonCancelar.UseVisualStyleBackColor = true;
			this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelarClick);
			// 
			// textBoxPhone
			// 
			this.textBoxPhone.BeepOnError = true;
			this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPhone.Location = new System.Drawing.Point(95, 234);
			this.textBoxPhone.Mask = "(00) 00000-0000";
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(152, 24);
			this.textBoxPhone.TabIndex = 25;
			// 
			// textBoxCPFCNPJ
			// 
			this.textBoxCPFCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCPFCNPJ.Location = new System.Drawing.Point(95, 121);
			this.textBoxCPFCNPJ.Mask = "000,000,000-00";
			this.textBoxCPFCNPJ.Name = "textBoxCPFCNPJ";
			this.textBoxCPFCNPJ.Size = new System.Drawing.Size(280, 24);
			this.textBoxCPFCNPJ.TabIndex = 27;
			this.textBoxCPFCNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCPFCNPJKeyPress);
			// 
			// comboBoxCNPJ
			// 
			this.comboBoxCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxCNPJ.FormattingEnabled = true;
			this.comboBoxCNPJ.Items.AddRange(new object[] {
			"CPF",
			"CNPJ"});
			this.comboBoxCNPJ.Location = new System.Drawing.Point(95, 82);
			this.comboBoxCNPJ.Name = "comboBoxCNPJ";
			this.comboBoxCNPJ.Size = new System.Drawing.Size(121, 26);
			this.comboBoxCNPJ.TabIndex = 28;
			this.comboBoxCNPJ.Text = "CPF";
			this.comboBoxCNPJ.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCNPJTextUpdate);
			// 
			// RegProvider
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(395, 356);
			this.Controls.Add(this.comboBoxCNPJ);
			this.Controls.Add(this.textBoxCPFCNPJ);
			this.Controls.Add(this.textBoxPhone);
			this.Controls.Add(this.buttonCancelar);
			this.Controls.Add(this.labelID);
			this.Controls.Add(this.textBoxID);
			this.Controls.Add(this.labelPhone);
			this.Controls.Add(this.labelCity);
			this.Controls.Add(this.labelAdress);
			this.Controls.Add(this.textBoxCity);
			this.Controls.Add(this.textBoxAdress);
			this.Controls.Add(this.labelcnpj);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.buttonGravar);
			this.Controls.Add(this.textBoxName);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RegProvider";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fornecedor";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
