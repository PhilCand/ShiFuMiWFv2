namespace ShiFuMiWF
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPierre = new System.Windows.Forms.Button();
            this.btnFeuille = new System.Windows.Forms.Button();
            this.btnCiseaux = new System.Windows.Forms.Button();
            this.labelIA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelScoreJoueur = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelVicDef = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelScoreIA = new System.Windows.Forms.Label();
            this.labelJoueur = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPierre
            // 
            this.btnPierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPierre.Image = global::ShiFuMiWF.Properties.Resources.pierre;
            this.btnPierre.Location = new System.Drawing.Point(47, 364);
            this.btnPierre.Name = "btnPierre";
            this.btnPierre.Size = new System.Drawing.Size(200, 200);
            this.btnPierre.TabIndex = 0;
            this.btnPierre.UseVisualStyleBackColor = true;
            this.btnPierre.Click += new System.EventHandler(this.btnPierre_Click);
            // 
            // btnFeuille
            // 
            this.btnFeuille.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeuille.Image = global::ShiFuMiWF.Properties.Resources.feuille;
            this.btnFeuille.Location = new System.Drawing.Point(316, 364);
            this.btnFeuille.Name = "btnFeuille";
            this.btnFeuille.Size = new System.Drawing.Size(200, 200);
            this.btnFeuille.TabIndex = 0;
            this.btnFeuille.UseVisualStyleBackColor = true;
            this.btnFeuille.Click += new System.EventHandler(this.btnFeuille_Click);
            // 
            // btnCiseaux
            // 
            this.btnCiseaux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCiseaux.Image = global::ShiFuMiWF.Properties.Resources.ciseaux;
            this.btnCiseaux.Location = new System.Drawing.Point(585, 364);
            this.btnCiseaux.Name = "btnCiseaux";
            this.btnCiseaux.Size = new System.Drawing.Size(200, 200);
            this.btnCiseaux.TabIndex = 0;
            this.btnCiseaux.UseVisualStyleBackColor = true;
            this.btnCiseaux.Click += new System.EventHandler(this.btnCiseaux_Click);
            // 
            // labelIA
            // 
            this.labelIA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelIA.Location = new System.Drawing.Point(481, 63);
            this.labelIA.Name = "labelIA";
            this.labelIA.Size = new System.Drawing.Size(200, 200);
            this.labelIA.TabIndex = 2;
            this.labelIA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Joueur";
            // 
            // labelScoreJoueur
            // 
            this.labelScoreJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreJoueur.Location = new System.Drawing.Point(12, 145);
            this.labelScoreJoueur.Name = "labelScoreJoueur";
            this.labelScoreJoueur.Size = new System.Drawing.Size(118, 97);
            this.labelScoreJoueur.TabIndex = 4;
            this.labelScoreJoueur.Text = "0";
            this.labelScoreJoueur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            // 
            // labelVicDef
            // 
            this.labelVicDef.Font = new System.Drawing.Font("OCR A Extended", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVicDef.Location = new System.Drawing.Point(268, 281);
            this.labelVicDef.Name = "labelVicDef";
            this.labelVicDef.Size = new System.Drawing.Size(298, 54);
            this.labelVicDef.TabIndex = 5;
            this.labelVicDef.Text = "Gagné";
            this.labelVicDef.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(506, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ordinateur";
            // 
            // labelScoreIA
            // 
            this.labelScoreIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreIA.Location = new System.Drawing.Point(698, 145);
            this.labelScoreIA.Name = "labelScoreIA";
            this.labelScoreIA.Size = new System.Drawing.Size(120, 97);
            this.labelScoreIA.TabIndex = 4;
            this.labelScoreIA.Text = "0";
            this.labelScoreIA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelJoueur
            // 
            this.labelJoueur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJoueur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelJoueur.Location = new System.Drawing.Point(147, 63);
            this.labelJoueur.Name = "labelJoueur";
            this.labelJoueur.Size = new System.Drawing.Size(200, 200);
            this.labelJoueur.TabIndex = 2;
            this.labelJoueur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(714, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 576);
            this.Controls.Add(this.labelVicDef);
            this.Controls.Add(this.labelScoreIA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelScoreJoueur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelJoueur);
            this.Controls.Add(this.labelIA);
            this.Controls.Add(this.btnCiseaux);
            this.Controls.Add(this.btnFeuille);
            this.Controls.Add(this.btnPierre);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShiFuMi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPierre;
        private System.Windows.Forms.Button btnFeuille;
        private System.Windows.Forms.Button btnCiseaux;
        private System.Windows.Forms.Label labelIA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelScoreJoueur;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelVicDef;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelScoreIA;
        private System.Windows.Forms.Label labelJoueur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

