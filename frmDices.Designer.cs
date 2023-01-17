namespace FIchaOrdemParanormal
{
    partial class frmDices
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
            this.lbManyDices = new System.Windows.Forms.Label();
            this.txtSpeedDices = new System.Windows.Forms.TextBox();
            this.gbDices = new System.Windows.Forms.GroupBox();
            this.lbSpeedMod = new System.Windows.Forms.Label();
            this.rbtnD20 = new System.Windows.Forms.RadioButton();
            this.rbtnD12 = new System.Windows.Forms.RadioButton();
            this.rbtnD10 = new System.Windows.Forms.RadioButton();
            this.rbtnD8 = new System.Windows.Forms.RadioButton();
            this.rbtnD6 = new System.Windows.Forms.RadioButton();
            this.rbtnD4 = new System.Windows.Forms.RadioButton();
            this.rbtnD3 = new System.Windows.Forms.RadioButton();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbDices = new System.Windows.Forms.Label();
            this.txtDices = new System.Windows.Forms.TextBox();
            this.txtSides = new System.Windows.Forms.TextBox();
            this.lbSides = new System.Windows.Forms.Label();
            this.txtMod = new System.Windows.Forms.TextBox();
            this.lbMod = new System.Windows.Forms.Label();
            this.btnThrowDices = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbHigher = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.txtSpeedMod = new System.Windows.Forms.TextBox();
            this.gbDices.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbManyDices
            // 
            this.lbManyDices.AutoSize = true;
            this.lbManyDices.Location = new System.Drawing.Point(206, 13);
            this.lbManyDices.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbManyDices.Name = "lbManyDices";
            this.lbManyDices.Size = new System.Drawing.Size(104, 19);
            this.lbManyDices.TabIndex = 0;
            this.lbManyDices.Text = "Quantos dados:";
            // 
            // txtSpeedDices
            // 
            this.txtSpeedDices.Location = new System.Drawing.Point(317, 10);
            this.txtSpeedDices.Name = "txtSpeedDices";
            this.txtSpeedDices.Size = new System.Drawing.Size(134, 26);
            this.txtSpeedDices.TabIndex = 1;
            this.txtSpeedDices.TextChanged += new System.EventHandler(this.SpeedDices_TextChanged);
            // 
            // gbDices
            // 
            this.gbDices.Controls.Add(this.rbtnD20);
            this.gbDices.Controls.Add(this.rbtnD12);
            this.gbDices.Controls.Add(this.rbtnD10);
            this.gbDices.Controls.Add(this.rbtnD8);
            this.gbDices.Controls.Add(this.rbtnD6);
            this.gbDices.Controls.Add(this.rbtnD4);
            this.gbDices.Controls.Add(this.rbtnD3);
            this.gbDices.Location = new System.Drawing.Point(210, 78);
            this.gbDices.Name = "gbDices";
            this.gbDices.Size = new System.Drawing.Size(245, 81);
            this.gbDices.TabIndex = 2;
            this.gbDices.TabStop = false;
            this.gbDices.Text = "Acesso rápido";
            // 
            // lbSpeedMod
            // 
            this.lbSpeedMod.AutoSize = true;
            this.lbSpeedMod.Location = new System.Drawing.Point(206, 45);
            this.lbSpeedMod.Name = "lbSpeedMod";
            this.lbSpeedMod.Size = new System.Drawing.Size(93, 19);
            this.lbSpeedMod.TabIndex = 14;
            this.lbSpeedMod.Text = "Modificadors:";
            // 
            // rbtnD20
            // 
            this.rbtnD20.AutoSize = true;
            this.rbtnD20.Location = new System.Drawing.Point(139, 53);
            this.rbtnD20.Name = "rbtnD20";
            this.rbtnD20.Size = new System.Drawing.Size(54, 23);
            this.rbtnD20.TabIndex = 6;
            this.rbtnD20.TabStop = true;
            this.rbtnD20.Text = "D20";
            this.rbtnD20.UseVisualStyleBackColor = true;
            this.rbtnD20.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbtnD12
            // 
            this.rbtnD12.AutoSize = true;
            this.rbtnD12.Location = new System.Drawing.Point(79, 53);
            this.rbtnD12.Name = "rbtnD12";
            this.rbtnD12.Size = new System.Drawing.Size(54, 23);
            this.rbtnD12.TabIndex = 5;
            this.rbtnD12.TabStop = true;
            this.rbtnD12.Text = "D12";
            this.rbtnD12.UseVisualStyleBackColor = true;
            this.rbtnD12.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbtnD10
            // 
            this.rbtnD10.AutoSize = true;
            this.rbtnD10.Location = new System.Drawing.Point(19, 53);
            this.rbtnD10.Name = "rbtnD10";
            this.rbtnD10.Size = new System.Drawing.Size(54, 23);
            this.rbtnD10.TabIndex = 4;
            this.rbtnD10.TabStop = true;
            this.rbtnD10.Text = "D10";
            this.rbtnD10.UseVisualStyleBackColor = true;
            this.rbtnD10.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbtnD8
            // 
            this.rbtnD8.AutoSize = true;
            this.rbtnD8.Location = new System.Drawing.Point(195, 25);
            this.rbtnD8.Name = "rbtnD8";
            this.rbtnD8.Size = new System.Drawing.Size(46, 23);
            this.rbtnD8.TabIndex = 3;
            this.rbtnD8.TabStop = true;
            this.rbtnD8.Text = "D8";
            this.rbtnD8.UseVisualStyleBackColor = true;
            this.rbtnD8.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbtnD6
            // 
            this.rbtnD6.AutoSize = true;
            this.rbtnD6.Location = new System.Drawing.Point(143, 25);
            this.rbtnD6.Name = "rbtnD6";
            this.rbtnD6.Size = new System.Drawing.Size(46, 23);
            this.rbtnD6.TabIndex = 2;
            this.rbtnD6.TabStop = true;
            this.rbtnD6.Text = "D6";
            this.rbtnD6.UseVisualStyleBackColor = true;
            this.rbtnD6.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbtnD4
            // 
            this.rbtnD4.AutoSize = true;
            this.rbtnD4.Location = new System.Drawing.Point(80, 25);
            this.rbtnD4.Name = "rbtnD4";
            this.rbtnD4.Size = new System.Drawing.Size(46, 23);
            this.rbtnD4.TabIndex = 1;
            this.rbtnD4.TabStop = true;
            this.rbtnD4.Text = "D4";
            this.rbtnD4.UseVisualStyleBackColor = true;
            this.rbtnD4.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbtnD3
            // 
            this.rbtnD3.AutoSize = true;
            this.rbtnD3.Location = new System.Drawing.Point(19, 25);
            this.rbtnD3.Name = "rbtnD3";
            this.rbtnD3.Size = new System.Drawing.Size(46, 23);
            this.rbtnD3.TabIndex = 0;
            this.rbtnD3.TabStop = true;
            this.rbtnD3.Text = "D3";
            this.rbtnD3.UseVisualStyleBackColor = true;
            this.rbtnD3.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(187, 23);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Dados Customizados";
            // 
            // lbDices
            // 
            this.lbDices.AutoSize = true;
            this.lbDices.Location = new System.Drawing.Point(12, 38);
            this.lbDices.Name = "lbDices";
            this.lbDices.Size = new System.Drawing.Size(104, 19);
            this.lbDices.TabIndex = 4;
            this.lbDices.Text = "Quantos dados:";
            // 
            // txtDices
            // 
            this.txtDices.Location = new System.Drawing.Point(122, 35);
            this.txtDices.Name = "txtDices";
            this.txtDices.Size = new System.Drawing.Size(77, 26);
            this.txtDices.TabIndex = 5;
            this.txtDices.TextChanged += new System.EventHandler(this.Dices_TextChanged);
            // 
            // txtSides
            // 
            this.txtSides.Location = new System.Drawing.Point(122, 67);
            this.txtSides.Name = "txtSides";
            this.txtSides.Size = new System.Drawing.Size(77, 26);
            this.txtSides.TabIndex = 7;
            this.txtSides.TextChanged += new System.EventHandler(this.Dices_TextChanged);
            // 
            // lbSides
            // 
            this.lbSides.AutoSize = true;
            this.lbSides.Location = new System.Drawing.Point(12, 70);
            this.lbSides.Name = "lbSides";
            this.lbSides.Size = new System.Drawing.Size(111, 19);
            this.lbSides.TabIndex = 6;
            this.lbSides.Text = "Lado dos dados:";
            // 
            // txtMod
            // 
            this.txtMod.Location = new System.Drawing.Point(122, 99);
            this.txtMod.Name = "txtMod";
            this.txtMod.Size = new System.Drawing.Size(77, 26);
            this.txtMod.TabIndex = 8;
            this.txtMod.TextChanged += new System.EventHandler(this.Dices_TextChanged);
            // 
            // lbMod
            // 
            this.lbMod.AutoSize = true;
            this.lbMod.Location = new System.Drawing.Point(12, 102);
            this.lbMod.Name = "lbMod";
            this.lbMod.Size = new System.Drawing.Size(93, 19);
            this.lbMod.TabIndex = 9;
            this.lbMod.Text = "Modificadors:";
            // 
            // btnThrowDices
            // 
            this.btnThrowDices.Location = new System.Drawing.Point(16, 131);
            this.btnThrowDices.Name = "btnThrowDices";
            this.btnThrowDices.Size = new System.Drawing.Size(183, 28);
            this.btnThrowDices.TabIndex = 10;
            this.btnThrowDices.Text = "Jogar dados";
            this.btnThrowDices.UseVisualStyleBackColor = true;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(12, 162);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(94, 21);
            this.lbResult.TabIndex = 11;
            this.lbResult.Text = "Resultado: ";
            // 
            // lbHigher
            // 
            this.lbHigher.AutoSize = true;
            this.lbHigher.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHigher.Location = new System.Drawing.Point(12, 183);
            this.lbHigher.Name = "lbHigher";
            this.lbHigher.Size = new System.Drawing.Size(138, 22);
            this.lbHigher.TabIndex = 12;
            this.lbHigher.Text = "Maior número: ";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(12, 205);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(57, 21);
            this.lbTotal.TabIndex = 13;
            this.lbTotal.Text = "Total: ";
            // 
            // txtSpeedMod
            // 
            this.txtSpeedMod.Location = new System.Drawing.Point(317, 42);
            this.txtSpeedMod.Name = "txtSpeedMod";
            this.txtSpeedMod.Size = new System.Drawing.Size(134, 26);
            this.txtSpeedMod.TabIndex = 14;
            this.txtSpeedMod.TextChanged += new System.EventHandler(this.SpeedDices_TextChanged);
            // 
            // frmDices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 241);
            this.Controls.Add(this.lbSpeedMod);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.txtSpeedMod);
            this.Controls.Add(this.lbHigher);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnThrowDices);
            this.Controls.Add(this.lbMod);
            this.Controls.Add(this.txtMod);
            this.Controls.Add(this.txtSides);
            this.Controls.Add(this.lbSides);
            this.Controls.Add(this.txtDices);
            this.Controls.Add(this.lbDices);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.gbDices);
            this.Controls.Add(this.txtSpeedDices);
            this.Controls.Add(this.lbManyDices);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(485, 280);
            this.Name = "frmDices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados";
            this.gbDices.ResumeLayout(false);
            this.gbDices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbManyDices;
        private System.Windows.Forms.TextBox txtSpeedDices;
        private System.Windows.Forms.GroupBox gbDices;
        private System.Windows.Forms.RadioButton rbtnD20;
        private System.Windows.Forms.RadioButton rbtnD12;
        private System.Windows.Forms.RadioButton rbtnD10;
        private System.Windows.Forms.RadioButton rbtnD8;
        private System.Windows.Forms.RadioButton rbtnD6;
        private System.Windows.Forms.RadioButton rbtnD4;
        private System.Windows.Forms.RadioButton rbtnD3;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbDices;
        private System.Windows.Forms.TextBox txtDices;
        private System.Windows.Forms.TextBox txtSides;
        private System.Windows.Forms.Label lbSides;
        private System.Windows.Forms.TextBox txtMod;
        private System.Windows.Forms.Label lbMod;
        private System.Windows.Forms.Button btnThrowDices;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbHigher;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbSpeedMod;
        private System.Windows.Forms.TextBox txtSpeedMod;
    }
}