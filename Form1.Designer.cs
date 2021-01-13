namespace Problema_Roteirizacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelKruskal = new System.Windows.Forms.Panel();
            this.Solve = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelKruskal
            // 
            this.panelKruskal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelKruskal.BackgroundImage")));
            this.panelKruskal.Location = new System.Drawing.Point(21, 37);
            this.panelKruskal.Name = "panelKruskal";
            this.panelKruskal.Size = new System.Drawing.Size(603, 412);
            this.panelKruskal.TabIndex = 0;
            this.panelKruskal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panelKruskal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // Solve
            // 
            this.Solve.Location = new System.Drawing.Point(643, 27);
            this.Solve.Name = "Solve";
            this.Solve.Size = new System.Drawing.Size(75, 23);
            this.Solve.TabIndex = 1;
            this.Solve.Text = "Resolver";
            this.Solve.UseVisualStyleBackColor = true;
            this.Solve.Click += new System.EventHandler(this.Solve_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(643, 56);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "Limpar";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 484);
            this.Controls.Add(this.panelKruskal);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Solve);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelKruskal;
        private System.Windows.Forms.Button Solve;
        private System.Windows.Forms.Button Clear;
    }
}