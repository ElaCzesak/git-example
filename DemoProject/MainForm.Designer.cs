
namespace DemoProject
{
    partial class MainForm
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
            this.btnClickThis = new System.Windows.Forms.Button();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.buttonZaehler = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.anzahl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClickThis
            // 
            this.btnClickThis.BackColor = System.Drawing.Color.Chartreuse;
            this.btnClickThis.Location = new System.Drawing.Point(12, 60);
            this.btnClickThis.Name = "btnClickThis";
            this.btnClickThis.Size = new System.Drawing.Size(81, 25);
            this.btnClickThis.TabIndex = 0;
            this.btnClickThis.Text = "Click this";
            this.btnClickThis.UseVisualStyleBackColor = false;
            this.btnClickThis.Click += new System.EventHandler(this.btnClickThis_Click);
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Location = new System.Drawing.Point(109, 66);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(0, 13);
            this.lblHelloWorld.TabIndex = 1;
            // 
            // buttonZaehler
            // 
            this.buttonZaehler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonZaehler.Location = new System.Drawing.Point(12, 134);
            this.buttonZaehler.Name = "buttonZaehler";
            this.buttonZaehler.Size = new System.Drawing.Size(110, 34);
            this.buttonZaehler.TabIndex = 2;
            this.buttonZaehler.Text = "counter";
            this.buttonZaehler.UseVisualStyleBackColor = false;
            this.buttonZaehler.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "colour";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(334, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "end";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // anzahl
            // 
            this.anzahl.Location = new System.Drawing.Point(134, 139);
            this.anzahl.Name = "anzahl";
            this.anzahl.Size = new System.Drawing.Size(121, 20);
            this.anzahl.TabIndex = 5;
            this.anzahl.Text = "0";
            this.anzahl.TextChanged += new System.EventHandler(this.anzahl_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 218);
            this.Controls.Add(this.anzahl);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonZaehler);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.btnClickThis);
            this.Name = "MainForm";
            this.Text = "Demo Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickThis;
        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.Button buttonZaehler;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox anzahl;
    }
}

