
namespace ZahlenRaten
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_eingabe = new System.Windows.Forms.Label();
            this.btn_newgame = new System.Windows.Forms.Button();
            this.btn_raten = new System.Windows.Forms.Button();
            this.txt_eingabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_eingabe
            // 
            this.lbl_eingabe.AutoSize = true;
            this.lbl_eingabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eingabe.Location = new System.Drawing.Point(54, 77);
            this.lbl_eingabe.Name = "lbl_eingabe";
            this.lbl_eingabe.Size = new System.Drawing.Size(205, 32);
            this.lbl_eingabe.TabIndex = 0;
            this.lbl_eingabe.Text = "Zahl eingeben:";
            // 
            // btn_newgame
            // 
            this.btn_newgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newgame.Location = new System.Drawing.Point(60, 13);
            this.btn_newgame.Name = "btn_newgame";
            this.btn_newgame.Size = new System.Drawing.Size(385, 49);
            this.btn_newgame.TabIndex = 1;
            this.btn_newgame.Text = "Neues Spiel";
            this.btn_newgame.UseVisualStyleBackColor = true;
            this.btn_newgame.Click += new System.EventHandler(this.btn_newgame_Click);
            // 
            // btn_raten
            // 
            this.btn_raten.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_raten.Location = new System.Drawing.Point(60, 137);
            this.btn_raten.Name = "btn_raten";
            this.btn_raten.Size = new System.Drawing.Size(385, 51);
            this.btn_raten.TabIndex = 2;
            this.btn_raten.Text = "Raten";
            this.btn_raten.UseVisualStyleBackColor = true;
            this.btn_raten.Click += new System.EventHandler(this.btn_raten_Click);
            // 
            // txt_eingabe
            // 
            this.txt_eingabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_eingabe.Location = new System.Drawing.Point(265, 71);
            this.txt_eingabe.Name = "txt_eingabe";
            this.txt_eingabe.Size = new System.Drawing.Size(179, 38);
            this.txt_eingabe.TabIndex = 3;
            this.txt_eingabe.TextChanged += new System.EventHandler(this.txt_eingabe_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 200);
            this.Controls.Add(this.txt_eingabe);
            this.Controls.Add(this.btn_raten);
            this.Controls.Add(this.btn_newgame);
            this.Controls.Add(this.lbl_eingabe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_eingabe;
        private System.Windows.Forms.Button btn_newgame;
        private System.Windows.Forms.Button btn_raten;
        private System.Windows.Forms.TextBox txt_eingabe;
    }
}

