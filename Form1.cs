namespace CalculadoraMentoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Sumar_Click(object sender, EventArgs e)
        {
            if(Numero1.Text != "" && Numero2.Text != "")
            {
                Error.Visible = false;
                double num1 = double.Parse(Numero1.Text);
                double num2 = double.Parse(Numero2.Text);
                var Result = num1 + num2;
                Resultado.Text = Result.ToString();
            }
            else
            {
                Error.Visible = true;
            }
        }

    }
}