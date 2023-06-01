namespace CalculatorApp {
    public partial class Form1 : Form {
        CircularButton cb = new CircularButton();
        CircularButton cb1 = new();
        CircularButton cb2 = new();
        CircularButton cb3 = new();
        CircularButton cb4 = new();
        CircularButton cb5 = new();
        CircularButton cb6 = new();
        CircularButton cb7 = new();
        CircularButton cb8 = new();
        CircularButton cb9 = new();
        CircularButton cbdott = new();
        CircularButton cbdivide = new();
        CircularButton cbmultiply = new();
        CircularButton cbminus = new();
        CircularButton cbadd = new();
        CircularButton cbcurrentOperation = new();
        CircularButton cbac = new();
        CircularButton cbequal = new();
        CircularButton cbplusminus = new();
        CircularButton cbpercent = new();
        string firstnum = "", secondnum = "";
        string operation = "";

        private void setButtons() {
            cb.Location = new(20, 480);
            cb.Text = "0";
            cb.MouseClick += numButton;
            cb1.Text = "1";
            cb1.Location = new(20, 400);
            cb1.MouseClick += numButton;
            cb2.Text = "2";
            cb2.Location = new(100, 400);
            cb2.MouseClick += numButton;
            cb3.Text = "3";
            cb3.Location = new(180, 400);
            cb3.MouseClick += numButton;
            cb4.Text = "4";
            cb4.Location = new(20, 320);
            cb4.MouseClick += numButton;
            cb5.Text = "5";
            cb5.Location = new(100, 320);
            cb5.MouseClick += numButton;
            cb6.Text = "6";
            cb6.Location = new(180, 320);
            cb6.MouseClick += numButton;
            cb7.Text = "7";
            cb7.Location = new(20, 240);
            cb7.MouseClick += numButton;
            cb8.Text = "8";
            cb8.Location = new(100, 240);
            cb8.MouseClick += numButton;
            cb9.Text = "9";
            cb9.Location = new(180, 240);
            cb9.MouseClick += numButton;
            cbdott.Text = ",";
            cbdott.Location = new(100, 480);
            cbdott.MouseClick += dottButton_Clicked;
            cbdivide.Text = "÷";
            cbdivide.BackColor = ColorTranslator.FromHtml("#FF9500");
            cbdivide.Location = new(260, 160);
            cbdivide.MouseClick += operationButton_Click;
            cbmultiply.Text = "x";
            cbmultiply.BackColor = ColorTranslator.FromHtml("#FF9500");
            cbmultiply.Location = new(260, 240);
            cbmultiply.MouseClick += operationButton_Click;
            cbminus.Text = "-";
            cbminus.BackColor = ColorTranslator.FromHtml("#FF9500");
            cbminus.Location = new(260, 320);
            cbminus.MouseClick += operationButton_Click;
            cbadd.Text = "+";
            cbadd.BackColor = ColorTranslator.FromHtml("#FF9500");
            cbadd.Location = new(260, 400);
            cbadd.MouseClick += operationButton_Click;
            cbequal.Text = "=";
            cbequal.BackColor = ColorTranslator.FromHtml("#FF9500");
            cbequal.Location = new(260, 480);
            cbequal.MouseClick += equalButton_Click;
            cbac.Text = "AC";
            cbac.ForeColor = Color.Black;
            cbac.BackColor = ColorTranslator.FromHtml("#D4D4D2");
            cbac.Location = new(20, 160);
            cbac.MouseClick += acButton_Click;
            cbplusminus.Text = "+/-";
            cbplusminus.ForeColor = Color.Black;
            cbplusminus.BackColor = ColorTranslator.FromHtml("#D4D4D2");
            cbplusminus.Location = new(100, 160);
            cbplusminus.MouseClick += plusMinus_Clicked;
            cbpercent.Text = "%";
            cbpercent.ForeColor = Color.Black;
            cbpercent.BackColor = ColorTranslator.FromHtml("#D4D4D2");
            cbpercent.Location = new(180, 160);
            cbpercent.MouseClick += percentButton_Clicked;

            Controls.Add(cb);
            Controls.Add(cb1);
            Controls.Add(cb2);
            Controls.Add(cb3);
            Controls.Add(cb4);
            Controls.Add(cb5);
            Controls.Add(cb6);
            Controls.Add(cb7);
            Controls.Add(cb8);
            Controls.Add(cb9);
            Controls.Add(cbdott);
            Controls.Add(cbdivide);
            Controls.Add(cbmultiply);
            Controls.Add(cbminus);
            Controls.Add(cbadd);
            Controls.Add(cbequal);
            Controls.Add(cbac);
            Controls.Add(cbplusminus);
            Controls.Add(cbpercent);
        }

        public Form1() {
            InitializeComponent();
            setButtons();
        }

        private void plusMinus_Clicked(object? sender, MouseEventArgs e) {
            expression.Text = "-" + expression.Text;
        }

        private void percentButton_Clicked(object? sender, MouseEventArgs e) {
            expression.Text = (Convert.ToDouble(expression.Text) / 100.0f).ToString();
        }

        private void dottButton_Clicked(object? sender, MouseEventArgs e) {
            expression.Text = expression.Text + ((CircularButton)sender!).Text;
            cbac.Text = "C";
        }

        private void numButton(object? sender, MouseEventArgs e) {
            if (expression.Text == "0") {
                expression.Text = "";
            } if (operation != "" && firstnum == expression.Text) expression.Text = "";
            expression.Text += ((CircularButton)sender!).Text;
            cbac.Text = "C";
        }

        private void operationButton_Click(object? sender, EventArgs e) {
            cbcurrentOperation.ForeColor = Color.White;
            cbcurrentOperation.BackColor = ColorTranslator.FromHtml("#FF9500");
            cbcurrentOperation = (CircularButton)sender!;
            if (cbcurrentOperation.ForeColor == Color.White) {
                cbcurrentOperation.BackColor = Color.White;
                cbcurrentOperation.ForeColor = ColorTranslator.FromHtml("#FF9500");
                firstnum = expression.Text;
                operation = cbcurrentOperation.Text;
            }
        }

        private void equalButton_Click(object? sender, EventArgs e) {
            try {
                secondnum = expression.Text;
                expression.Text = "";
                dynamic result = 0;
                cbcurrentOperation.ForeColor = Color.White;
                cbcurrentOperation.BackColor = ColorTranslator.FromHtml("#FF9500");
                if (operation == "+") result = Convert.ToDouble(firstnum) + Convert.ToDouble(secondnum);
                else if (operation == "-") result = Convert.ToDouble(firstnum) - Convert.ToDouble(secondnum);
                else if (operation == "x") result = Convert.ToDouble(firstnum) * Convert.ToDouble(secondnum);
                else if (operation == "÷") result = Convert.ToDouble(firstnum) / Convert.ToDouble(secondnum);
                expression.Text = result.ToString();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void acButton_Click(object? sender, MouseEventArgs e) {
            cbac.Text = "AC";
            expression.Text = "0";
            firstnum = "";
            secondnum = "";
            operation = "";
            cbcurrentOperation.ForeColor = Color.White;
            cbcurrentOperation.BackColor = ColorTranslator.FromHtml("#FF9500");
        }
    }
}