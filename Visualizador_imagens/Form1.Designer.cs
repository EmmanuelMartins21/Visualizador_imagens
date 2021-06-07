
namespace Visualizador_imagens
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
            this.Image_ListBox1 = new System.Windows.Forms.ListBox();
            this.Fvoritos_ListBox1 = new System.Windows.Forms.ListBox();
            this.AdicionarFavoritos_Button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RemoverButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Image_ListBox1
            // 
            this.Image_ListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Image_ListBox1.FormattingEnabled = true;
            this.Image_ListBox1.Location = new System.Drawing.Point(12, 14);
            this.Image_ListBox1.Name = "Image_ListBox1";
            this.Image_ListBox1.Size = new System.Drawing.Size(516, 69);
            this.Image_ListBox1.TabIndex = 0;
            this.Image_ListBox1.SelectedIndexChanged += new System.EventHandler(this.Image_ListBox1_SelectedIndexChanged);
            // 
            // Fvoritos_ListBox1
            // 
            this.Fvoritos_ListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fvoritos_ListBox1.FormattingEnabled = true;
            this.Fvoritos_ListBox1.Location = new System.Drawing.Point(12, 118);
            this.Fvoritos_ListBox1.Name = "Fvoritos_ListBox1";
            this.Fvoritos_ListBox1.Size = new System.Drawing.Size(516, 69);
            this.Fvoritos_ListBox1.TabIndex = 1;
            this.Fvoritos_ListBox1.SelectedIndexChanged += new System.EventHandler(this.Fvoritos_ListBox1_SelectedIndexChanged);
            // 
            // AdicionarFavoritos_Button1
            // 
            this.AdicionarFavoritos_Button1.Location = new System.Drawing.Point(12, 89);
            this.AdicionarFavoritos_Button1.Name = "AdicionarFavoritos_Button1";
            this.AdicionarFavoritos_Button1.Size = new System.Drawing.Size(75, 23);
            this.AdicionarFavoritos_Button1.TabIndex = 2;
            this.AdicionarFavoritos_Button1.Text = "Favoritar";
            this.AdicionarFavoritos_Button1.UseVisualStyleBackColor = true;
            this.AdicionarFavoritos_Button1.Click += new System.EventHandler(this.AdicionarFavoritos_Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 201);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // RemoverButton
            // 
            this.RemoverButton.Location = new System.Drawing.Point(128, 89);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(75, 23);
            this.RemoverButton.TabIndex = 4;
            this.RemoverButton.Text = "Desfavoritar";
            this.RemoverButton.UseVisualStyleBackColor = true;
            this.RemoverButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(531, 418);
            this.Controls.Add(this.RemoverButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AdicionarFavoritos_Button1);
            this.Controls.Add(this.Fvoritos_ListBox1);
            this.Controls.Add(this.Image_ListBox1);
            this.Name = "Form1";
            this.Text = "Visualizador de Imagens";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Image_ListBox1;
        private System.Windows.Forms.ListBox Fvoritos_ListBox1;
        private System.Windows.Forms.Button AdicionarFavoritos_Button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button RemoverButton;
    }
}

