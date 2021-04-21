
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
            ((System.ComponentModel.ISupportInitialize)(this.pcb_monstro)).BeginInit();
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
            this.lbl_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_level.Location = new System.Drawing.Point(646, 194);
            this.lbl_level.Name = "lbl_level";
            this.lbl_level.Size = new System.Drawing.Size(49, 24);
            this.lbl_level.TabIndex = 19;
            this.lbl_level.Text = "level";
            // 
            // lbl_jogador
            // 
            this.lbl_jogador.AutoSize = true;
            this.lbl_jogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jogador.Location = new System.Drawing.Point(646, 160);
            this.lbl_jogador.Name = "lbl_jogador";
            this.lbl_jogador.Size = new System.Drawing.Size(74, 24);
            this.lbl_jogador.TabIndex = 18;
            this.lbl_jogador.Text = "jogador";
            // 
            // lbl_classe
            // 
            this.lbl_classe.AutoSize = true;
            this.lbl_classe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_classe.Location = new System.Drawing.Point(646, 226);
            this.lbl_classe.Name = "lbl_classe";
            this.lbl_classe.Size = new System.Drawing.Size(63, 24);
            this.lbl_classe.TabIndex = 17;
            this.lbl_classe.Text = "classe";
            // 
            // btn_ataque1
            // 
            this.btn_ataque1.Location = new System.Drawing.Point(53, 399);
            this.btn_ataque1.Name = "btn_ataque1";
            this.btn_ataque1.Size = new System.Drawing.Size(136, 71);
            this.btn_ataque1.TabIndex = 20;
            this.btn_ataque1.Text = "Ataque 1";
            this.btn_ataque1.UseVisualStyleBackColor = true;
            this.btn_ataque1.Click += new System.EventHandler(this.btn_ataque1_Click);
            // 
            // btn_ataque2
            // 
            this.btn_ataque2.Location = new System.Drawing.Point(584, 399);
            this.btn_ataque2.Name = "btn_ataque2";
            this.btn_ataque2.Size = new System.Drawing.Size(136, 71);
            this.btn_ataque2.TabIndex = 21;
            this.btn_ataque2.Text = "Ataque 2";
            this.btn_ataque2.UseVisualStyleBackColor = true;
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
            this.lbl_vidaheroi.Location = new System.Drawing.Point(303, 420);
            this.lbl_vidaheroi.Name = "lbl_vidaheroi";
            this.lbl_vidaheroi.Size = new System.Drawing.Size(94, 24);
            this.lbl_vidaheroi.TabIndex = 23;
            this.lbl_vidaheroi.Text = "VidaHeroi";
            // 
            // TelaJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.lbl_vidaheroi);
            this.Controls.Add(this.lbl_vidamonstro);
            this.Controls.Add(this.btn_ataque2);
            this.Controls.Add(this.btn_ataque1);
            this.Controls.Add(this.lbl_level);
            this.Controls.Add(this.lbl_jogador);
            this.Controls.Add(this.lbl_classe);
            this.Controls.Add(this.pcb_monstro);
            this.Name = "TelaJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo";
            ((System.ComponentModel.ISupportInitialize)(this.pcb_monstro)).EndInit();
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
    }
}