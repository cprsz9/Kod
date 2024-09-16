using System;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonDod = new System.Windows.Forms.Button();
            this.buttonOde = new System.Windows.Forms.Button();
            this.buttonMno = new System.Windows.Forms.Button();
            this.buttonDzi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDod
            // 
            this.buttonDod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDod.Location = new System.Drawing.Point(277, 253);
            this.buttonDod.Name = "buttonDod";
            this.buttonDod.Size = new System.Drawing.Size(50, 50);
            this.buttonDod.TabIndex = 0;
            this.buttonDod.Text = "+";
            this.buttonDod.UseVisualStyleBackColor = true;
            this.buttonDod.Click += new System.EventHandler(this.buttonDod_Click);
            // 
            // buttonOde
            // 
            this.buttonOde.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOde.Location = new System.Drawing.Point(333, 253);
            this.buttonOde.Name = "buttonOde";
            this.buttonOde.Size = new System.Drawing.Size(50, 50);
            this.buttonOde.TabIndex = 1;
            this.buttonOde.Text = "-";
            this.buttonOde.UseVisualStyleBackColor = true;
            this.buttonOde.Click += new System.EventHandler(this.buttonOde_Click);
            // 
            // buttonMno
            // 
            this.buttonMno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMno.Location = new System.Drawing.Point(389, 253);
            this.buttonMno.Name = "buttonMno";
            this.buttonMno.Size = new System.Drawing.Size(50, 50);
            this.buttonMno.TabIndex = 2;
            this.buttonMno.Text = "*";
            this.buttonMno.UseVisualStyleBackColor = true;
            this.buttonMno.Click += new System.EventHandler(this.buttonMno_Click);
            // 
            // buttonDzi
            // 
            this.buttonDzi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDzi.Location = new System.Drawing.Point(445, 253);
            this.buttonDzi.Name = "buttonDzi";
            this.buttonDzi.Size = new System.Drawing.Size(50, 50);
            this.buttonDzi.TabIndex = 3;
            this.buttonDzi.Text = "/";
            this.buttonDzi.UseVisualStyleBackColor = true;
            this.buttonDzi.Click += new System.EventHandler(this.buttonDzi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(386, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 4;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(467, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(589, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(650, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 8;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonMno);
            this.Controls.Add(this.buttonDod);
            this.Controls.Add(this.buttonDzi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOde);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Button buttonDod;
        private System.Windows.Forms.Button buttonOde;
        private System.Windows.Forms.Button buttonMno;
        private System.Windows.Forms.Button buttonDzi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

