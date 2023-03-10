namespace FIchaOrdemParanormal
{
    partial class frmPlayers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayers));
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tabPericias = new System.Windows.Forms.TabPage();
            this.btnRandomDices = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.tabInventario = new System.Windows.Forms.TabPage();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbVida = new System.Windows.Forms.Label();
            this.lbPE = new System.Windows.Forms.Label();
            this.lbSanidade = new System.Windows.Forms.Label();
            this.lbNEX = new System.Windows.Forms.Label();
            this.lbDeslocamento = new System.Windows.Forms.Label();
            this.lbDefesa = new System.Windows.Forms.Label();
            this.lbAgilidade = new System.Windows.Forms.Label();
            this.lbOrigem = new System.Windows.Forms.Label();
            this.lbClasse = new System.Windows.Forms.Label();
            this.lbForca = new System.Windows.Forms.Label();
            this.lbIntelecto = new System.Windows.Forms.Label();
            this.lbPresenca = new System.Windows.Forms.Label();
            this.lbVigor = new System.Windows.Forms.Label();
            this.tbcPrincipal.SuspendLayout();
            this.tabPericias.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcPrincipal.Controls.Add(this.tabPericias);
            this.tbcPrincipal.Controls.Add(this.tabInfo);
            this.tbcPrincipal.Controls.Add(this.tabInventario);
            this.tbcPrincipal.Location = new System.Drawing.Point(17, 119);
            this.tbcPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(781, 374);
            this.tbcPrincipal.TabIndex = 0;
            // 
            // tabPericias
            // 
            this.tabPericias.Controls.Add(this.btnRandomDices);
            this.tabPericias.Controls.Add(this.txtFiltro);
            this.tabPericias.Controls.Add(this.lbFiltro);
            this.tabPericias.Location = new System.Drawing.Point(4, 28);
            this.tabPericias.Name = "tabPericias";
            this.tabPericias.Size = new System.Drawing.Size(773, 342);
            this.tabPericias.TabIndex = 2;
            this.tabPericias.Text = "Pericias";
            this.tabPericias.UseVisualStyleBackColor = true;
            // 
            // btnRandomDices
            // 
            this.btnRandomDices.Location = new System.Drawing.Point(266, 16);
            this.btnRandomDices.Name = "btnRandomDices";
            this.btnRandomDices.Size = new System.Drawing.Size(75, 23);
            this.btnRandomDices.TabIndex = 2;
            this.btnRandomDices.Text = "Dados";
            this.btnRandomDices.UseVisualStyleBackColor = true;
            this.btnRandomDices.Click += new System.EventHandler(this.btnRandomDices_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(60, 13);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(200, 26);
            this.txtFiltro.TabIndex = 1;
            // 
            // lbFiltro
            // 
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Location = new System.Drawing.Point(10, 16);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(44, 19);
            this.lbFiltro.TabIndex = 0;
            this.lbFiltro.Text = "Filtro:";
            // 
            // tabInfo
            // 
            this.tabInfo.Location = new System.Drawing.Point(4, 28);
            this.tabInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(4);
            this.tabInfo.Size = new System.Drawing.Size(773, 342);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.Text = "Informações";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // tabInventario
            // 
            this.tabInventario.Location = new System.Drawing.Point(4, 28);
            this.tabInventario.Margin = new System.Windows.Forms.Padding(4);
            this.tabInventario.Name = "tabInventario";
            this.tabInventario.Padding = new System.Windows.Forms.Padding(4);
            this.tabInventario.Size = new System.Drawing.Size(773, 342);
            this.tabInventario.TabIndex = 1;
            this.tabInventario.Text = "Inventario";
            this.tabInventario.UseVisualStyleBackColor = true;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(13, 9);
            this.lbNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(73, 19);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome: { }";
            // 
            // lbVida
            // 
            this.lbVida.AutoSize = true;
            this.lbVida.ForeColor = System.Drawing.Color.Black;
            this.lbVida.Location = new System.Drawing.Point(13, 42);
            this.lbVida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbVida.Name = "lbVida";
            this.lbVida.Size = new System.Drawing.Size(63, 19);
            this.lbVida.TabIndex = 3;
            this.lbVida.Text = "Vida: { }";
            this.lbVida.Click += new System.EventHandler(this.lbVida_Click);
            // 
            // lbPE
            // 
            this.lbPE.AutoSize = true;
            this.lbPE.Location = new System.Drawing.Point(199, 42);
            this.lbPE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPE.Name = "lbPE";
            this.lbPE.Size = new System.Drawing.Size(53, 19);
            this.lbPE.TabIndex = 4;
            this.lbPE.Text = "PE: { }";
            this.lbPE.Click += new System.EventHandler(this.lbPE_Click);
            // 
            // lbSanidade
            // 
            this.lbSanidade.AutoSize = true;
            this.lbSanidade.Location = new System.Drawing.Point(13, 75);
            this.lbSanidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSanidade.Name = "lbSanidade";
            this.lbSanidade.Size = new System.Drawing.Size(91, 19);
            this.lbSanidade.TabIndex = 5;
            this.lbSanidade.Text = "Sanidade: { }";
            this.lbSanidade.Click += new System.EventHandler(this.lbSanidade_Click);
            // 
            // lbNEX
            // 
            this.lbNEX.AutoSize = true;
            this.lbNEX.Location = new System.Drawing.Point(199, 9);
            this.lbNEX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNEX.Name = "lbNEX";
            this.lbNEX.Size = new System.Drawing.Size(67, 19);
            this.lbNEX.TabIndex = 6;
            this.lbNEX.Text = "NEX: { }";
            this.lbNEX.Click += new System.EventHandler(this.lbNEX_Click);
            // 
            // lbDeslocamento
            // 
            this.lbDeslocamento.AutoSize = true;
            this.lbDeslocamento.Location = new System.Drawing.Point(318, 75);
            this.lbDeslocamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDeslocamento.Name = "lbDeslocamento";
            this.lbDeslocamento.Size = new System.Drawing.Size(121, 19);
            this.lbDeslocamento.TabIndex = 7;
            this.lbDeslocamento.Text = "Deslocamento: { }";
            this.lbDeslocamento.Click += new System.EventHandler(this.lbDeslocamento_Click);
            // 
            // lbDefesa
            // 
            this.lbDefesa.AutoSize = true;
            this.lbDefesa.Location = new System.Drawing.Point(199, 75);
            this.lbDefesa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDefesa.Name = "lbDefesa";
            this.lbDefesa.Size = new System.Drawing.Size(77, 19);
            this.lbDefesa.TabIndex = 8;
            this.lbDefesa.Text = "Defesa: { }";
            this.lbDefesa.Click += new System.EventHandler(this.lbDefesa_Click);
            // 
            // lbAgilidade
            // 
            this.lbAgilidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAgilidade.AutoSize = true;
            this.lbAgilidade.Location = new System.Drawing.Point(621, 9);
            this.lbAgilidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAgilidade.Name = "lbAgilidade";
            this.lbAgilidade.Size = new System.Drawing.Size(92, 19);
            this.lbAgilidade.TabIndex = 9;
            this.lbAgilidade.Text = "Agilidade: { }";
            this.lbAgilidade.Click += new System.EventHandler(this.lbAgilidade_Click);
            // 
            // lbOrigem
            // 
            this.lbOrigem.AutoSize = true;
            this.lbOrigem.Location = new System.Drawing.Point(318, 9);
            this.lbOrigem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOrigem.Name = "lbOrigem";
            this.lbOrigem.Size = new System.Drawing.Size(80, 19);
            this.lbOrigem.TabIndex = 10;
            this.lbOrigem.Text = "Origem: { }";
            this.lbOrigem.Click += new System.EventHandler(this.lbOrigem_Click);
            // 
            // lbClasse
            // 
            this.lbClasse.AutoSize = true;
            this.lbClasse.Location = new System.Drawing.Point(318, 42);
            this.lbClasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClasse.Name = "lbClasse";
            this.lbClasse.Size = new System.Drawing.Size(75, 19);
            this.lbClasse.TabIndex = 11;
            this.lbClasse.Text = "Classe: { }";
            this.lbClasse.Click += new System.EventHandler(this.lbClasse_Click);
            // 
            // lbForca
            // 
            this.lbForca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbForca.AutoSize = true;
            this.lbForca.Location = new System.Drawing.Point(560, 42);
            this.lbForca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbForca.Name = "lbForca";
            this.lbForca.Size = new System.Drawing.Size(71, 19);
            this.lbForca.TabIndex = 12;
            this.lbForca.Text = "Força: { }";
            this.lbForca.Click += new System.EventHandler(this.lbForca_Click);
            // 
            // lbIntelecto
            // 
            this.lbIntelecto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIntelecto.AutoSize = true;
            this.lbIntelecto.Location = new System.Drawing.Point(672, 42);
            this.lbIntelecto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIntelecto.Name = "lbIntelecto";
            this.lbIntelecto.Size = new System.Drawing.Size(87, 19);
            this.lbIntelecto.TabIndex = 13;
            this.lbIntelecto.Text = "Intelecto: { }";
            this.lbIntelecto.Click += new System.EventHandler(this.lbIntelecto_Click);
            // 
            // lbPresenca
            // 
            this.lbPresenca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPresenca.AutoSize = true;
            this.lbPresenca.Location = new System.Drawing.Point(560, 75);
            this.lbPresenca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPresenca.Name = "lbPresenca";
            this.lbPresenca.Size = new System.Drawing.Size(94, 19);
            this.lbPresenca.TabIndex = 14;
            this.lbPresenca.Text = " Presença: { }";
            this.lbPresenca.Click += new System.EventHandler(this.lbPresenca_Click);
            // 
            // lbVigor
            // 
            this.lbVigor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVigor.AutoSize = true;
            this.lbVigor.BackColor = System.Drawing.Color.Transparent;
            this.lbVigor.ForeColor = System.Drawing.Color.Black;
            this.lbVigor.Location = new System.Drawing.Point(672, 75);
            this.lbVigor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbVigor.Name = "lbVigor";
            this.lbVigor.Size = new System.Drawing.Size(68, 19);
            this.lbVigor.TabIndex = 15;
            this.lbVigor.Text = "Vigor: { }";
            this.lbVigor.Click += new System.EventHandler(this.lbVigor_Click);
            // 
            // frmPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 511);
            this.Controls.Add(this.lbVigor);
            this.Controls.Add(this.lbPresenca);
            this.Controls.Add(this.lbIntelecto);
            this.Controls.Add(this.lbForca);
            this.Controls.Add(this.lbClasse);
            this.Controls.Add(this.lbOrigem);
            this.Controls.Add(this.lbAgilidade);
            this.Controls.Add(this.lbDefesa);
            this.Controls.Add(this.lbDeslocamento);
            this.Controls.Add(this.lbNEX);
            this.Controls.Add(this.lbSanidade);
            this.Controls.Add(this.lbPE);
            this.Controls.Add(this.lbVida);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.tbcPrincipal);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(750, 250);
            this.Name = "frmPlayers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player { }";
            this.tbcPrincipal.ResumeLayout(false);
            this.tabPericias.ResumeLayout(false);
            this.tabPericias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcPrincipal;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.TabPage tabPericias;
        private System.Windows.Forms.TabPage tabInventario;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbVida;
        private System.Windows.Forms.Label lbPE;
        private System.Windows.Forms.Label lbSanidade;
        private System.Windows.Forms.Label lbNEX;
        private System.Windows.Forms.Label lbDeslocamento;
        private System.Windows.Forms.Label lbDefesa;
        private System.Windows.Forms.Label lbAgilidade;
        private System.Windows.Forms.Label lbOrigem;
        private System.Windows.Forms.Label lbClasse;
        private System.Windows.Forms.Label lbForca;
        private System.Windows.Forms.Label lbIntelecto;
        private System.Windows.Forms.Label lbPresenca;
        private System.Windows.Forms.Label lbVigor;
        private System.Windows.Forms.Button btnRandomDices;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lbFiltro;
    }
}