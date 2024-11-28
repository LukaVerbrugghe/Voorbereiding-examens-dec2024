namespace prjHerhalingZO
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
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.btnZO = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtBreedtew = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.Location = new System.Drawing.Point(13, 13);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(704, 425);
            this.pnlCanvas.TabIndex = 0;
            // 
            // btnZO
            // 
            this.btnZO.BackColor = System.Drawing.Color.Lime;
            this.btnZO.Location = new System.Drawing.Point(724, 13);
            this.btnZO.Name = "btnZO";
            this.btnZO.Size = new System.Drawing.Size(64, 54);
            this.btnZO.TabIndex = 1;
            this.btnZO.Text = "ZO";
            this.btnZO.UseVisualStyleBackColor = false;
            this.btnZO.Click += new System.EventHandler(this.btnZO_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(724, 73);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 34);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtBreedtew
            // 
            this.txtBreedtew.Location = new System.Drawing.Point(724, 114);
            this.txtBreedtew.Name = "txtBreedtew";
            this.txtBreedtew.Size = new System.Drawing.Size(64, 20);
            this.txtBreedtew.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBreedtew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnZO);
            this.Controls.Add(this.pnlCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.Button btnZO;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtBreedtew;
    }
}

