namespace Task_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox_X_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if (char.IsControl(e.KeyChar))
                return;
            if (e.KeyChar.Equals("-") && txtBox.Text.Length == 0)
                return;
            if (e.KeyChar.Equals(".") && !txtBox.Text.Contains("."))
                return;
            if (char.IsDigit(e.KeyChar))
                return;
            if (e.KeyChar != 0)
                return;
            e.Handled = true;
        }

        private void textBox_Z_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if (char.IsControl(e.KeyChar))
                return;
            if (e.KeyChar.Equals("-") && txtBox.Text.Length == 0)
                return;
            if (e.KeyChar.Equals(".") && !txtBox.Text.Contains("."))
                return;
            if (char.IsDigit(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            float x = float.Parse(textBox_X.Text),
                  y = float.Parse(textBox_Y.Text),
                  z = float.Parse(textBox_Z.Text),
                  S_1 = 0,
                  S_2 = 0;

            for (int i = 1; i < x; i++)
            {
                S_1 += i - x*y;
            }

            for (int i = 1; i < y; i++)
            {
                S_2 += i - x * z;
            }

            label_Result.Text = $"= { S_1 / S_2}";
        }
    }
}
