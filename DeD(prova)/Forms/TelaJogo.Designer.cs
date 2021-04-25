
namespace DeD_prova_.Forms
{
    partial class TelaJogo
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
            this.pcb_monstro = new System.Windows.Forms.PictureBox();
            this.lbl_level = new System.Windows.Forms.Label();
            this.lbl_jogador = new System.Windows.Forms.Label();
            this.lbl_classe = new System.Windows.Forms.Label();
            this.btn_ataque1 = new System.Windows.Forms.Button();
            this.btn_ataque2 = new System.Windows.Forms.Button();
            this.lbl_vidamonstro = new System.Windows.Forms.Label();
            this.lbl_vidaheroi = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_dinheiro = new System.Windows.Forms.Label();
            this.lbl_mana = new System.Windows.Forms.Label();
            this.lbl_vida = new System.Windows.Forms.Label();
            this.lbl_sorte = new System.Windows.Forms.Label();
            this.lbl_agilidade = new System.Windows.Forms.Label();
            this.lbl_defesa = new System.Windows.Forms.Label();
            this.lbl_forca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_monstro)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcb_monstro
            // 
            this.pcb_monstro.Location = new System.Drawing.Point(0, 0);
            this.pcb_monstro.Name = "pcb_monstro";
            this.pcb_monstro.Size = new System.Drawing.Size(397, 310);
            this.pcb_monstro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_monstro.TabIndex = 0;
            this.pcb_monstro.TabStop = false;
            // 
            // lbl_level
            // 
            this.lbl_level.AutoSize = true;
            this.lbl_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_level.Location = new System.Drawing.Point(252, 63);
            this.lbl_level.Name = "lbl_level";
            this.lbl_level.Size = new System.Drawing.Size(40, 20);
            this.lbl_level.TabIndex = 19;
            this.lbl_level.Text = "level";
            // 
            // lbl_jogador
            // 
            this.lbl_jogador.AutoSize = true;
            this.lbl_jogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jogador.Location = new System.Drawing.Point(252, 29);
            this.lbl_jogador.Name = "lbl_jogador";
            this.lbl_jogador.Size = new System.Drawing.Size(62, 20);
            this.lbl_jogador.TabIndex = 18;
            this.lbl_jogador.Text = "jogador";
            // 
            // lbl_classe
            // 
            this.lbl_classe.AutoSize = true;
            this.lbl_classe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_classe.Location = new System.Drawing.Point(252, 95);
            this.lbl_classe.Name = "lbl_classe";
            this.lbl_classe.Size = new System.Drawing.Size(54, 20);
            this.lbl_classe.TabIndex = 17;
            this.lbl_classe.Text = "classe";
            // 
            // btn_ataque1
            // 
            this.btn_ataque1.Location = new System.Drawing.Point(12, 387);
            this.btn_ataque1.Name = "btn_ataque1";
            this.btn_ataque1.Size = new System.Drawing.Size(136, 71);
            this.btn_ataque1.TabIndex = 20;
            this.btn_ataque1.Text = "Socar";
            this.btn_ataque1.UseVisualStyleBackColor = true;
            this.btn_ataque1.Click += new System.EventHandler(this.btn_ataque1_Click);
            // 
            // btn_ataque2
            // 
            this.btn_ataque2.Location = new System.Drawing.Point(256, 387);
            this.btn_ataque2.Name = "btn_ataque2";
            this.btn_ataque2.Size = new System.Drawing.Size(136, 71);
            this.btn_ataque2.TabIndex = 21;
            this.btn_ataque2.Text = "Ataque 2";
            this.btn_ataque2.UseVisualStyleBackColor = true;
            this.btn_ataque2.Click += new System.EventHandler(this.btn_ataque2_Click);
            // 
            // lbl_vidamonstro
            // 
            this.lbl_vidamonstro.AutoSize = true;
            this.lbl_vidamonstro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vidamonstro.Location = new System.Drawing.Point(557, 28);
            this.lbl_vidamonstro.Name = "lbl_vidamonstro";
            this.lbl_vidamonstro.Size = new System.Drawing.Size(116, 24);
            this.lbl_vidamonstro.TabIndex = 22;
            this.lbl_vidamonstro.Text = "VidaMonstro";
            // 
            // lbl_vidaheroi
            // 
            this.lbl_vidaheroi.AutoSize = true;
            this.lbl_vidaheroi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vidaheroi.Location = new System.Drawing.Point(156, 341);
            this.lbl_vidaheroi.Name = "lbl_vidaheroi";
            this.lbl_vidaheroi.Size = new System.Drawing.Size(94, 24);
            this.lbl_vidaheroi.TabIndex = 23;
            this.lbl_vidaheroi.Text = "VidaHeroi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_dinheiro);
            this.groupBox1.Controls.Add(this.lbl_mana);
            this.groupBox1.Controls.Add(this.lbl_vida);
            this.groupBox1.Controls.Add(this.lbl_sorte);
            this.groupBox1.Controls.Add(this.lbl_agilidade);
            this.groupBox1.Controls.Add(this.lbl_defesa);
            this.groupBox1.Controls.Add(this.lbl_level);
            this.groupBox1.Controls.Add(this.lbl_forca);
            this.groupBox1.Controls.Add(this.lbl_jogador);
            this.groupBox1.Controls.Add(this.lbl_classe);
            this.groupBox1.Location = new System.Drawing.Point(398, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 154);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // lbl_dinheiro
            // 
            this.lbl_dinheiro.AutoSize = true;
            this.lbl_dinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dinheiro.Location = new System.Drawing.Point(173, 112);
            this.lbl_dinheiro.Name = "lbl_dinheiro";
            this.lbl_dinheiro.Size = new System.Drawing.Size(49, 20);
            this.lbl_dinheiro.TabIndex = 20;
            this.lbl_dinheiro.Text = "Mana";
            // 
            // lbl_mana
            // 
            this.lbl_mana.AutoSize = true;
            this.lbl_mana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mana.Location = new System.Drawing.Point(173, 58);
            this.lbl_mana.Name = "lbl_mana";
            this.lbl_mana.Size = new System.Drawing.Size(49, 20);
            this.lbl_mana.TabIndex = 5;
            this.lbl_mana.Text = "Mana";
            // 
            // lbl_vida
            // 
            this.lbl_vida.AutoSize = true;
            this.lbl_vida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vida.Location = new System.Drawing.Point(173, 29);
            this.lbl_vida.Name = "lbl_vida";
            this.lbl_vida.Size = new System.Drawing.Size(41, 20);
            this.lbl_vida.TabIndex = 4;
            this.lbl_vida.Text = "Vida";
            // 
            // lbl_sorte
            // 
            this.lbl_sorte.AutoSize = true;
            this.lbl_sorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sorte.Location = new System.Drawing.Point(40, 112);
            this.lbl_sorte.Name = "lbl_sorte";
            this.lbl_sorte.Size = new System.Drawing.Size(48, 20);
            this.lbl_sorte.TabIndex = 3;
            this.lbl_sorte.Text = "Sorte";
            // 
            // lbl_agilidade
            // 
            this.lbl_agilidade.AutoSize = true;
            this.lbl_agilidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_agilidade.Location = new System.Drawing.Point(40, 83);
            this.lbl_agilidade.Name = "lbl_agilidade";
            this.lbl_agilidade.Size = new System.Drawing.Size(74, 20);
            this.lbl_agilidade.TabIndex = 2;
            this.lbl_agilidade.Text = "Agilidade";
            // 
            // lbl_defesa
            // 
            this.lbl_defesa.AutoSize = true;
            this.lbl_defesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_defesa.Location = new System.Drawing.Point(40, 58);
            this.lbl_defesa.Name = "lbl_defesa";
            this.lbl_defesa.Size = new System.Drawing.Size(61, 20);
            this.lbl_defesa.TabIndex = 1;
            this.lbl_defesa.Text = "Defesa";
            // 
            // lbl_forca
            // 
            this.lbl_forca.AutoSize = true;
            this.lbl_forca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_forca.Location = new System.Drawing.Point(40, 29);
            this.lbl_forca.Name = "lbl_forca";
            this.lbl_forca.Size = new System.Drawing.Size(50, 20);
            this.lbl_forca.TabIndex = 0;
            this.lbl_forca.Text = "Força";
            // 
            // TelaJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_vidaheroi);
            this.Controls.Add(this.lbl_vidamonstro);
            this.Controls.Add(this.btn_ataque2);
            this.Controls.Add(this.btn_ataque1);
            this.Controls.Add(this.pcb_monstro);
            this.Name = "TelaJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo";
            this.Load += new System.EventHandler(this.TelaJogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_monstro)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_monstro;
        private System.Windows.Forms.Label lbl_level;
        private System.Windows.Forms.Label lbl_jogador;
        private System.Windows.Forms.Label lbl_classe;
        private System.Windows.Forms.Button btn_ataque1;
        private System.Windows.Forms.Button btn_ataque2;
        private System.Windows.Forms.Label lbl_vidamonstro;
        private System.Windows.Forms.Label lbl_vidaheroi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_mana;
        private System.Windows.Forms.Label lbl_vida;
        private System.Windows.Forms.Label lbl_sorte;
        private System.Windows.Forms.Label lbl_agilidade;
        private System.Windows.Forms.Label lbl_defesa;
        private System.Windows.Forms.Label lbl_forca;
        private System.Windows.Forms.Label lbl_dinheiro;
    }
}