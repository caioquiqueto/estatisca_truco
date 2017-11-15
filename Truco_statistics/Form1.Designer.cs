namespace Truco_statistics
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
            this.btnDo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.lblSuit = new System.Windows.Forms.Label();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(280, 291);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(75, 23);
            this.btnDo.TabIndex = 0;
            this.btnDo.Text = "Deck";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naipe";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(42, 92);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(0, 13);
            this.lblRank.TabIndex = 3;
            // 
            // lblSuit
            // 
            this.lblSuit.AutoSize = true;
            this.lblSuit.Location = new System.Drawing.Point(214, 92);
            this.lblSuit.Name = "lblSuit";
            this.lblSuit.Size = new System.Drawing.Size(0, 13);
            this.lblSuit.TabIndex = 4;
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(45, 294);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(100, 20);
            this.txtIndex.TabIndex = 5;
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(361, 291);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(70, 23);
            this.btnShuffle.TabIndex = 6;
            this.btnShuffle.Text = "Embaralhar";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 409);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.lblSuit);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label lblSuit;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Button btnShuffle;
    }
}

