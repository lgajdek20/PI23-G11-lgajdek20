namespace Testiranje_za_vj3
{
    partial class frm_unos_izmjena_zahtjeva_CIP
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
            this.txt_br_zahtjeva = new System.Windows.Forms.Label();
            this.txt_podnositelj = new System.Windows.Forms.Label();
            this.txt_vrijeme_kreiranja = new System.Windows.Forms.Label();
            this.txt_opis = new System.Windows.Forms.Label();
            this.txt_komentari = new System.Windows.Forms.Label();
            this.txt_prioritet = new System.Windows.Forms.Label();
            this.txt_preuzeo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_spremi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_br_zahtjeva
            // 
            this.txt_br_zahtjeva.AutoSize = true;
            this.txt_br_zahtjeva.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_br_zahtjeva.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_br_zahtjeva.Location = new System.Drawing.Point(41, 43);
            this.txt_br_zahtjeva.Name = "txt_br_zahtjeva";
            this.txt_br_zahtjeva.Size = new System.Drawing.Size(195, 36);
            this.txt_br_zahtjeva.TabIndex = 0;
            this.txt_br_zahtjeva.Text = "Broj zahtjeva:";
            this.txt_br_zahtjeva.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_podnositelj
            // 
            this.txt_podnositelj.AutoSize = true;
            this.txt_podnositelj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_podnositelj.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_podnositelj.Location = new System.Drawing.Point(41, 107);
            this.txt_podnositelj.Name = "txt_podnositelj";
            this.txt_podnositelj.Size = new System.Drawing.Size(229, 36);
            this.txt_podnositelj.TabIndex = 1;
            this.txt_podnositelj.Text = "Zahtjev podnio: ";
            this.txt_podnositelj.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_vrijeme_kreiranja
            // 
            this.txt_vrijeme_kreiranja.AutoSize = true;
            this.txt_vrijeme_kreiranja.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vrijeme_kreiranja.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_vrijeme_kreiranja.Location = new System.Drawing.Point(40, 173);
            this.txt_vrijeme_kreiranja.Name = "txt_vrijeme_kreiranja";
            this.txt_vrijeme_kreiranja.Size = new System.Drawing.Size(375, 36);
            this.txt_vrijeme_kreiranja.TabIndex = 2;
            this.txt_vrijeme_kreiranja.Text = "Vrijeme kreiranja zahtjeva: ";
            // 
            // txt_opis
            // 
            this.txt_opis.AutoSize = true;
            this.txt_opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_opis.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_opis.Location = new System.Drawing.Point(41, 238);
            this.txt_opis.Name = "txt_opis";
            this.txt_opis.Size = new System.Drawing.Size(211, 36);
            this.txt_opis.TabIndex = 3;
            this.txt_opis.Text = "Opis zahtjeva: ";
            // 
            // txt_komentari
            // 
            this.txt_komentari.AutoSize = true;
            this.txt_komentari.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_komentari.Location = new System.Drawing.Point(40, 414);
            this.txt_komentari.Name = "txt_komentari";
            this.txt_komentari.Size = new System.Drawing.Size(159, 32);
            this.txt_komentari.TabIndex = 4;
            this.txt_komentari.Text = "Komentari: ";
            // 
            // txt_prioritet
            // 
            this.txt_prioritet.AutoSize = true;
            this.txt_prioritet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prioritet.Location = new System.Drawing.Point(40, 563);
            this.txt_prioritet.Name = "txt_prioritet";
            this.txt_prioritet.Size = new System.Drawing.Size(128, 32);
            this.txt_prioritet.TabIndex = 5;
            this.txt_prioritet.Text = "Prioritet: ";
            // 
            // txt_preuzeo
            // 
            this.txt_preuzeo.AutoSize = true;
            this.txt_preuzeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_preuzeo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_preuzeo.Location = new System.Drawing.Point(42, 369);
            this.txt_preuzeo.Name = "txt_preuzeo";
            this.txt_preuzeo.Size = new System.Drawing.Size(196, 29);
            this.txt_preuzeo.TabIndex = 6;
            this.txt_preuzeo.Text = "Zahtjev preuzeo: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 563);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Status: ";
            // 
            // btn_spremi
            // 
            this.btn_spremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_spremi.Location = new System.Drawing.Point(671, 637);
            this.btn_spremi.Name = "btn_spremi";
            this.btn_spremi.Size = new System.Drawing.Size(148, 68);
            this.btn_spremi.TabIndex = 8;
            this.btn_spremi.Text = "Spremi";
            this.btn_spremi.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 449);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(838, 88);
            this.textBox1.TabIndex = 9;
            // 
            // frm_unos_izmjena_zahtjeva_CIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 734);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_spremi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_preuzeo);
            this.Controls.Add(this.txt_prioritet);
            this.Controls.Add(this.txt_komentari);
            this.Controls.Add(this.txt_opis);
            this.Controls.Add(this.txt_vrijeme_kreiranja);
            this.Controls.Add(this.txt_podnositelj);
            this.Controls.Add(this.txt_br_zahtjeva);
            this.Name = "frm_unos_izmjena_zahtjeva_CIP";
            this.Text = "Unesi/izmjeni zahtjev";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_br_zahtjeva;
        private System.Windows.Forms.Label txt_podnositelj;
        private System.Windows.Forms.Label txt_vrijeme_kreiranja;
        private System.Windows.Forms.Label txt_opis;
        private System.Windows.Forms.Label txt_komentari;
        private System.Windows.Forms.Label txt_prioritet;
        private System.Windows.Forms.Label txt_preuzeo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_spremi;
        private System.Windows.Forms.TextBox textBox1;
    }
}