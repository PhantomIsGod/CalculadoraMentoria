namespace CalculadoraMentoria
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
            this.label1 = new System.Windows.Forms.Label();
            this.Numero1 = new System.Windows.Forms.TextBox();
            this.Numero2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Sumar = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora Simple";
            // 
            // Numero1
            // 
            this.Numero1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Numero1.Location = new System.Drawing.Point(12, 49);
            this.Numero1.Name = "Numero1";
            this.Numero1.PlaceholderText = "Primer Digito";
            this.Numero1.Size = new System.Drawing.Size(100, 23);
            this.Numero1.TabIndex = 1;
            this.Numero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Numero1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Numero2
            // 
            this.Numero2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Numero2.Location = new System.Drawing.Point(139, 49);
            this.Numero2.Name = "Numero2";
            this.Numero2.PlaceholderText = "Segundo Digito";
            this.Numero2.Size = new System.Drawing.Size(100, 23);
            this.Numero2.TabIndex = 2;
            this.Numero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Numero2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "+";
            // 
            // Sumar
            // 
            this.Sumar.Location = new System.Drawing.Point(92, 107);
            this.Sumar.Name = "Sumar";
            this.Sumar.Size = new System.Drawing.Size(75, 23);
            this.Sumar.TabIndex = 5;
            this.Sumar.Text = "Sumar";
            this.Sumar.UseVisualStyleBackColor = true;
            this.Sumar.Click += new System.EventHandler(this.Sumar_Click);
            // 
            // Resultado
            // 
            this.Resultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Resultado.Enabled = false;
            this.Resultado.Location = new System.Drawing.Point(80, 78);
            this.Resultado.Name = "Resultado";
            this.Resultado.PlaceholderText = "Resultado";
            this.Resultado.ReadOnly = true;
            this.Resultado.Size = new System.Drawing.Size(100, 23);
            this.Resultado.TabIndex = 4;
            this.Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.ForeColor = System.Drawing.Color.Red;
            this.Error.Location = new System.Drawing.Point(43, 146);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(172, 15);
            this.Error.TabIndex = 6;
            this.Error.Text = "Debes introducir ambos digitos";
            this.Error.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 170);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.Sumar);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Numero2);
            this.Controls.Add(this.Numero1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox Numero1;
        private TextBox Numero2;
        private Label label2;
        private Button Sumar;
        private TextBox Resultado;
        private Label Error;
    }
}