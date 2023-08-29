namespace aula4vetores
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.listBoxValor1 = new System.Windows.Forms.ListBox();
            this.listBoxValor2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Resultado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.Location = new System.Drawing.Point(71, 126);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(120, 95);
            this.listBoxItems.TabIndex = 1;
            // 
            // listBoxValor1
            // 
            this.listBoxValor1.FormattingEnabled = true;
            this.listBoxValor1.Location = new System.Drawing.Point(71, 241);
            this.listBoxValor1.Name = "listBoxValor1";
            this.listBoxValor1.Size = new System.Drawing.Size(120, 95);
            this.listBoxValor1.TabIndex = 2;
            // 
            // listBoxValor2
            // 
            this.listBoxValor2.FormattingEnabled = true;
            this.listBoxValor2.Location = new System.Drawing.Point(216, 241);
            this.listBoxValor2.Name = "listBoxValor2";
            this.listBoxValor2.Size = new System.Drawing.Size(120, 95);
            this.listBoxValor2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxValor2);
            this.Controls.Add(this.listBoxValor1);
            this.Controls.Add(this.listBoxItems);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.ListBox listBoxValor1;
        private System.Windows.Forms.ListBox listBoxValor2;
    }
}

