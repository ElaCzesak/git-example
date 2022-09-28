namespace Counter_Button
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
            this.anzahl = new System.Windows.Forms.TextBox();
            this.buttonZaehler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // anzahl
            // 
            this.anzahl.Location = new System.Drawing.Point(170, 31);
            this.anzahl.Name = "anzahl";
            this.anzahl.Size = new System.Drawing.Size(156, 23);
            this.anzahl.TabIndex = 0;
            this.anzahl.Text = "0";
            this.anzahl.TextChanged += new System.EventHandler(this.anzahl_TextChanged);
            // 
            // buttonZaehler
            // 
            this.buttonZaehler.Location = new System.Drawing.Point(12, 23);
            this.buttonZaehler.Name = "buttonZaehler";
            this.buttonZaehler.Size = new System.Drawing.Size(152, 36);
            this.buttonZaehler.TabIndex = 1;
            this.buttonZaehler.Text = "Counter";
            this.buttonZaehler.UseVisualStyleBackColor = true;
            this.buttonZaehler.Click += new System.EventHandler(this.buttonZaehler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonZaehler);
            this.Controls.Add(this.anzahl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox anzahl;
        private Button buttonZaehler;
    }
}