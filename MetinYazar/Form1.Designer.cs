
namespace MetinYazar
{
    partial class Form1
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
            this.btnMetinSeç = new System.Windows.Forms.Button();
            this.txtDosyaYolu = new System.Windows.Forms.TextBox();
            this.lblDosyaYolu = new System.Windows.Forms.Label();
            this.btnStackOku = new System.Windows.Forms.Button();
            this.txtMetinBilgileri = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMetinSeç
            // 
            this.btnMetinSeç.Location = new System.Drawing.Point(355, 28);
            this.btnMetinSeç.Name = "btnMetinSeç";
            this.btnMetinSeç.Size = new System.Drawing.Size(120, 62);
            this.btnMetinSeç.TabIndex = 1;
            this.btnMetinSeç.Text = "Metin Seç";
            this.btnMetinSeç.UseVisualStyleBackColor = true;
            this.btnMetinSeç.Click += new System.EventHandler(this.btnMetinSeç_Click);
            // 
            // txtDosyaYolu
            // 
            this.txtDosyaYolu.Location = new System.Drawing.Point(340, 117);
            this.txtDosyaYolu.Name = "txtDosyaYolu";
            this.txtDosyaYolu.ReadOnly = true;
            this.txtDosyaYolu.Size = new System.Drawing.Size(201, 22);
            this.txtDosyaYolu.TabIndex = 2;
            // 
            // lblDosyaYolu
            // 
            this.lblDosyaYolu.AutoSize = true;
            this.lblDosyaYolu.Location = new System.Drawing.Point(297, 117);
            this.lblDosyaYolu.Name = "lblDosyaYolu";
            this.lblDosyaYolu.Size = new System.Drawing.Size(37, 17);
            this.lblDosyaYolu.TabIndex = 3;
            this.lblDosyaYolu.Text = "Path";
            // 
            // btnStackOku
            // 
            this.btnStackOku.Location = new System.Drawing.Point(166, 195);
            this.btnStackOku.Name = "btnStackOku";
            this.btnStackOku.Size = new System.Drawing.Size(97, 40);
            this.btnStackOku.TabIndex = 4;
            this.btnStackOku.Text = "Stack\'e Oku";
            this.btnStackOku.UseVisualStyleBackColor = true;
            this.btnStackOku.Click += new System.EventHandler(this.btnStackOku_Click);
            // 
            // txtMetinBilgileri
            // 
            this.txtMetinBilgileri.Location = new System.Drawing.Point(269, 235);
            this.txtMetinBilgileri.Multiline = true;
            this.txtMetinBilgileri.Name = "txtMetinBilgileri";
            this.txtMetinBilgileri.Size = new System.Drawing.Size(419, 178);
            this.txtMetinBilgileri.TabIndex = 5;
            this.txtMetinBilgileri.TextChanged += new System.EventHandler(this.txtMetinBilgileri_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMetinBilgileri);
            this.Controls.Add(this.btnStackOku);
            this.Controls.Add(this.lblDosyaYolu);
            this.Controls.Add(this.txtDosyaYolu);
            this.Controls.Add(this.btnMetinSeç);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMetinSeç;
        private System.Windows.Forms.TextBox txtDosyaYolu;
        private System.Windows.Forms.Label lblDosyaYolu;
        private System.Windows.Forms.Button btnStackOku;
        private System.Windows.Forms.TextBox txtMetinBilgileri;
    }
}