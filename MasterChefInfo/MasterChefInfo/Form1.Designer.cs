namespace MasterChefInfo
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
            this.MainDrawingArea = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainDrawingArea)).BeginInit();
            this.SuspendLayout();
            // 
            // MainDrawingArea
            // 
            this.MainDrawingArea.BackgroundImage = global::MasterChefInfo.Properties.Resources.Map;
            this.MainDrawingArea.Location = new System.Drawing.Point(0, 0);
            this.MainDrawingArea.Name = "MainDrawingArea";
            this.MainDrawingArea.Size = new System.Drawing.Size(1392, 504);
            this.MainDrawingArea.TabIndex = 0;
            this.MainDrawingArea.TabStop = false;
            this.MainDrawingArea.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 507);
            this.Controls.Add(this.MainDrawingArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainDrawingArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MainDrawingArea;
    }
}

