
namespace CalculadoraWindowsForms
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
            this.campoNumero01 = new System.Windows.Forms.TextBox();
            this.campoNumero02 = new System.Windows.Forms.TextBox();
            this.btSoma = new System.Windows.Forms.Button();
            this.btSub = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.campoResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // campoNumero01
            // 
            this.campoNumero01.Location = new System.Drawing.Point(64, 75);
            this.campoNumero01.Name = "campoNumero01";
            this.campoNumero01.Size = new System.Drawing.Size(156, 23);
            this.campoNumero01.TabIndex = 0;
            // 
            // campoNumero02
            // 
            this.campoNumero02.Location = new System.Drawing.Point(248, 75);
            this.campoNumero02.Name = "campoNumero02";
            this.campoNumero02.Size = new System.Drawing.Size(176, 23);
            this.campoNumero02.TabIndex = 1;
            // 
            // btSoma
            // 
            this.btSoma.Location = new System.Drawing.Point(64, 120);
            this.btSoma.Name = "btSoma";
            this.btSoma.Size = new System.Drawing.Size(75, 23);
            this.btSoma.TabIndex = 2;
            this.btSoma.Text = "+";
            this.btSoma.UseVisualStyleBackColor = true;
            this.btSoma.Click += new System.EventHandler(this.btSoma_Click);
            // 
            // btSub
            // 
            this.btSub.Location = new System.Drawing.Point(145, 120);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(75, 23);
            this.btSub.TabIndex = 3;
            this.btSub.Text = "-";
            this.btSub.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(248, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(349, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // campoResultado
            // 
            this.campoResultado.Location = new System.Drawing.Point(64, 165);
            this.campoResultado.Name = "campoResultado";
            this.campoResultado.Size = new System.Drawing.Size(360, 23);
            this.campoResultado.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.campoResultado);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btSub);
            this.Controls.Add(this.btSoma);
            this.Controls.Add(this.campoNumero02);
            this.Controls.Add(this.campoNumero01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox campoNumero01;
        private System.Windows.Forms.TextBox campoNumero02;
        private System.Windows.Forms.Button btSoma;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox campoResultado;
    }
}

