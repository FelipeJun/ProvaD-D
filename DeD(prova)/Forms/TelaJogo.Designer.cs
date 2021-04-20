
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
            this.lbl_vidamonstro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_monstro)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_monstro
            // 
            this.pcb_monstro.Location = new System.Drawing.Point(0, 0);
            this.pcb_monstro.Name = "pcb_monstro";
            this.pcb_monstro.Size = new System.Drawing.Size(397, 265);
            this.pcb_monstro.TabIndex = 0;
            this.pcb_monstro.TabStop = false;
            // 
            // lbl_vidamonstro
            // 
            this.lbl_vidamonstro.AutoSize = true;
            this.lbl_vidamonstro.Location = new System.Drawing.Point(583, 13);
            this.lbl_vidamonstro.Name = "lbl_vidamonstro";
            this.lbl_vidamonstro.Size = new System.Drawing.Size(35, 13);
            this.lbl_vidamonstro.TabIndex = 1;
            this.lbl_vidamonstro.Text = "label1";
            // 
            // TelaJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_vidamonstro);
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
        private System.Windows.Forms.Label lbl_vidamonstro;
    }
}