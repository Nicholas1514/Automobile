﻿namespace Automobile
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.listView1 = new System.Windows.Forms.ListView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.listView2 = new System.Windows.Forms.ListView();
			this.button6 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1445, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// listView1
			// 
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(12, 37);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(776, 289);
			this.listView1.TabIndex = 7;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.List;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 368);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(164, 70);
			this.button1.TabIndex = 8;
			this.button1.Text = "ACCENSIONE";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(216, 368);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(146, 70);
			this.button2.TabIndex = 9;
			this.button2.Text = "ACCELLERA";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(391, 368);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(132, 70);
			this.button3.TabIndex = 10;
			this.button3.Text = "FRENA";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(559, 368);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(97, 70);
			this.button4.TabIndex = 11;
			this.button4.Text = "MARCIA SU";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(693, 368);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(95, 70);
			this.button5.TabIndex = 12;
			this.button5.Text = "MARCIA GIU";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// listView2
			// 
			this.listView2.HideSelection = false;
			this.listView2.Location = new System.Drawing.Point(885, 37);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(548, 289);
			this.listView2.TabIndex = 13;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.View = System.Windows.Forms.View.List;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(885, 368);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(135, 70);
			this.button6.TabIndex = 14;
			this.button6.Text = "ACCENSIONE ";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "AUTOMOBILE CAMBIO MANUALE";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(885, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(195, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "AUTOMOBILE CAMBIO AUTOMATICO";
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(1113, 368);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(112, 70);
			this.button7.TabIndex = 17;
			this.button7.Text = "ACCELLERA";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(1335, 368);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(98, 70);
			this.button8.TabIndex = 18;
			this.button8.Text = "FRENA";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(1445, 557);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.listView2);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
	}
}

