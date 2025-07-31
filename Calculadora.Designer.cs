namespace calculadora
{
    partial class Calculadora
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
            lblnumero1 = new Label();
            textNumero1 = new TextBox();
            lblNumero2 = new Label();
            textNumero2 = new TextBox();
            btnSomar = new Button();
            btnsubtrair = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            lbl0 = new Label();
            SuspendLayout();
            // 
            // lblnumero1
            // 
            lblnumero1.AutoSize = true;
            lblnumero1.Location = new Point(16, 32);
            lblnumero1.Name = "lblnumero1";
            lblnumero1.Size = new Size(60, 15);
            lblnumero1.TabIndex = 0;
            lblnumero1.Text = "Numero 1";
            lblnumero1.Click += label1_Click;
            // 
            // textNumero1
            // 
            textNumero1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNumero1.Location = new Point(16, 48);
            textNumero1.Name = "textNumero1";
            textNumero1.Size = new Size(100, 29);
            textNumero1.TabIndex = 1;
            // 
            // lblNumero2
            // 
            lblNumero2.AutoSize = true;
            lblNumero2.Location = new Point(136, 32);
            lblNumero2.Name = "lblNumero2";
            lblNumero2.Size = new Size(60, 15);
            lblNumero2.TabIndex = 2;
            lblNumero2.Text = "Numero 2";
            // 
            // textNumero2
            // 
            textNumero2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNumero2.Location = new Point(136, 48);
            textNumero2.Name = "textNumero2";
            textNumero2.Size = new Size(100, 29);
            textNumero2.TabIndex = 3;
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(8, 104);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(75, 23);
            btnSomar.TabIndex = 4;
            btnSomar.Text = "somar";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += button1_Click;
            // 
            // btnsubtrair
            // 
            btnsubtrair.Location = new Point(112, 104);
            btnsubtrair.Name = "btnsubtrair";
            btnsubtrair.Size = new Size(75, 23);
            btnsubtrair.TabIndex = 5;
            btnsubtrair.Text = "subtrair";
            btnsubtrair.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(208, 104);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(75, 23);
            btnMultiplicar.TabIndex = 6;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(304, 104);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(75, 23);
            btnDividir.TabIndex = 7;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            // 
            // lbl0
            // 
            lbl0.AutoSize = true;
            lbl0.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0.Location = new Point(320, 48);
            lbl0.Name = "lbl0";
            lbl0.Size = new Size(28, 32);
            lbl0.TabIndex = 8;
            lbl0.Text = "0";
            lbl0.Click += label1_Click_1;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 157);
            Controls.Add(lbl0);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnsubtrair);
            Controls.Add(btnSomar);
            Controls.Add(textNumero2);
            Controls.Add(lblNumero2);
            Controls.Add(textNumero1);
            Controls.Add(lblnumero1);
            Name = "Calculadora";
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnumero1;
        private TextBox textNumero1;
        private Label lblNumero2;
        private TextBox textNumero2;
        private Button btnSomar;
        private Button btnsubtrair;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Label lbl0;
    }
}
