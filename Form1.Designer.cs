namespace Conversor
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxCB1 = new System.Windows.Forms.ComboBox();
            this.comboBoxCB3 = new System.Windows.Forms.ComboBox();
            this.comboBoxCB2 = new System.Windows.Forms.ComboBox();
            this.textBoxCB2 = new System.Windows.Forms.TextBox();
            this.textBoxCB3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxCB1
            // 
            this.comboBoxCB1.FormattingEnabled = true;
            this.comboBoxCB1.Location = new System.Drawing.Point(38, 38);
            this.comboBoxCB1.Name = "comboBoxCB1";
            this.comboBoxCB1.Size = new System.Drawing.Size(308, 21);
            this.comboBoxCB1.TabIndex = 0;
            this.comboBoxCB1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxCB3
            // 
            this.comboBoxCB3.FormattingEnabled = true;
            this.comboBoxCB3.Location = new System.Drawing.Point(221, 117);
            this.comboBoxCB3.Name = "comboBoxCB3";
            this.comboBoxCB3.Size = new System.Drawing.Size(125, 21);
            this.comboBoxCB3.TabIndex = 3;
            // 
            // comboBoxCB2
            // 
            this.comboBoxCB2.FormattingEnabled = true;
            this.comboBoxCB2.Location = new System.Drawing.Point(38, 117);
            this.comboBoxCB2.Name = "comboBoxCB2";
            this.comboBoxCB2.Size = new System.Drawing.Size(125, 21);
            this.comboBoxCB2.TabIndex = 4;
            // 
            // textBoxCB2
            // 
            this.textBoxCB2.Location = new System.Drawing.Point(38, 97);
            this.textBoxCB2.Name = "textBoxCB2";
            this.textBoxCB2.Size = new System.Drawing.Size(125, 20);
            this.textBoxCB2.TabIndex = 5;
            this.textBoxCB2.TextChanged += new System.EventHandler(this.textBoxCB2_TextChanged);
            // 
            // textBoxCB3
            // 
            this.textBoxCB3.Location = new System.Drawing.Point(221, 97);
            this.textBoxCB3.Name = "textBoxCB3";
            this.textBoxCB3.Size = new System.Drawing.Size(125, 20);
            this.textBoxCB3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 184);
            this.Controls.Add(this.textBoxCB3);
            this.Controls.Add(this.textBoxCB2);
            this.Controls.Add(this.comboBoxCB2);
            this.Controls.Add(this.comboBoxCB3);
            this.Controls.Add(this.comboBoxCB1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCB1;
        private System.Windows.Forms.ComboBox comboBoxCB3;
        private System.Windows.Forms.ComboBox comboBoxCB2;
        private System.Windows.Forms.TextBox textBoxCB2;
        private System.Windows.Forms.TextBox textBoxCB3;
    }
}

