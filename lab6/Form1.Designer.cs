
namespace lab6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDonne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDonne
            // 
            this.btnDonne.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDonne.Location = new System.Drawing.Point(122, 63);
            this.btnDonne.Name = "btnDonne";
            this.btnDonne.Size = new System.Drawing.Size(538, 330);
            this.btnDonne.TabIndex = 0;
            this.btnDonne.Text = "exercices données en mémoires";
            this.btnDonne.UseVisualStyleBackColor = true;
            this.btnDonne.Click += new System.EventHandler(this.btnDonne_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDonne);
            this.Name = "Form1";
            this.Text = "lab6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDonne;
    }
}

