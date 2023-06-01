namespace CalculatorApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            expression = new RichTextBox();
            SuspendLayout();
            // 
            // expression
            // 
            expression.BackColor = SystemColors.MenuText;
            expression.BorderStyle = BorderStyle.None;
            expression.Font = new Font("Microsoft Sans Serif", 45F, FontStyle.Regular, GraphicsUnit.Point);
            expression.ForeColor = SystemColors.Window;
            expression.Location = new Point(24, 49);
            expression.Multiline = false;
            expression.Name = "expression";
            expression.ReadOnly = true;
            expression.RightToLeft = RightToLeft.No;
            expression.Size = new Size(302, 69);
            expression.TabIndex = 0;
            expression.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(354, 597);
            Controls.Add(expression);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox expression;
    }
}