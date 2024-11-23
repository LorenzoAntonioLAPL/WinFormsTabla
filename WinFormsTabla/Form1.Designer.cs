namespace WinFormsTabla
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
            panelprincipal = new Panel();
            label2 = new Label();
            richTextBoxresultados = new RichTextBox();
            buttonVer = new Button();
            textBoxnum = new TextBox();
            label = new Label();
            label1 = new Label();
            panelprincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelprincipal
            // 
            panelprincipal.BackColor = Color.FromArgb(255, 255, 128);
            panelprincipal.Controls.Add(label2);
            panelprincipal.Controls.Add(richTextBoxresultados);
            panelprincipal.Controls.Add(buttonVer);
            panelprincipal.Controls.Add(textBoxnum);
            panelprincipal.Controls.Add(label);
            panelprincipal.Controls.Add(label1);
            panelprincipal.Location = new Point(12, 4);
            panelprincipal.Name = "panelprincipal";
            panelprincipal.Size = new Size(776, 434);
            panelprincipal.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 377);
            label2.Name = "label2";
            label2.Size = new Size(244, 19);
            label2.TabIndex = 5;
            label2.Text = "Lorenzo Antonio Pacheco Leyva";
            label2.Click += label2_Click;
            // 
            // richTextBoxresultados
            // 
            richTextBoxresultados.BackColor = Color.White;
            richTextBoxresultados.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxresultados.Location = new Point(501, 80);
            richTextBoxresultados.Name = "richTextBoxresultados";
            richTextBoxresultados.Size = new Size(201, 316);
            richTextBoxresultados.TabIndex = 4;
            richTextBoxresultados.Text = "";
            // 
            // buttonVer
            // 
            buttonVer.BackColor = Color.Yellow;
            buttonVer.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVer.Location = new Point(155, 250);
            buttonVer.Name = "buttonVer";
            buttonVer.Size = new Size(131, 31);
            buttonVer.TabIndex = 3;
            buttonVer.Text = "Ver Tabla";
            buttonVer.UseVisualStyleBackColor = false;
            buttonVer.Click += buttonVer_Click;
            // 
            // textBoxnum
            // 
            textBoxnum.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxnum.Location = new Point(168, 137);
            textBoxnum.Name = "textBoxnum";
            textBoxnum.Size = new Size(100, 26);
            textBoxnum.TabIndex = 2;
            textBoxnum.TextAlign = HorizontalAlignment.Center;
            textBoxnum.TextChanged += textBoxnum_TextChanged;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(96, 99);
            label.Name = "label";
            label.Size = new Size(189, 24);
            label.TabIndex = 1;
            label.Text = "Cual tabla quieres?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Terminator Two", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 21);
            label1.Name = "label1";
            label1.Size = new Size(332, 24);
            label1.TabIndex = 0;
            label1.Text = "TABLA DE MULTIPLICAR";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelprincipal);
            Name = "Form1";
            Text = "Form1";
            panelprincipal.ResumeLayout(false);
            panelprincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelprincipal;
        private Label label1;
        private TextBox textBoxnum;
        private Label label;
        private Button buttonVer;
        private RichTextBox richTextBoxresultados;
        private Label label2;
    }
}
