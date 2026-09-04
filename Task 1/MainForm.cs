namespace Task_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            label_Result.Text = "";
        }

        private void textBox_X_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if (char.Equals(e.KeyChar, '.') && !txtBox.Text.Contains('.') && txtBox.Text.Length != 0)
                return;
            if (char.IsDigit(e.KeyChar) && txtBox.Text.Length != 0 && char.Equals(e.KeyChar, '0'))
                return;
            if (char.IsDigit(e.KeyChar) && !char.Equals(e.KeyChar, '0'))
                return;
            if (char.IsControl(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void textBox_Z_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if (char.Equals(e.KeyChar, '-') && txtBox.Text.Length == 0)
                return;
            if (char.Equals(e.KeyChar, '.') && !txtBox.Text.Contains('.') && txtBox.Text.Length != 0)
                return;
            if (char.IsDigit(e.KeyChar))
                return;
            if (char.IsControl(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(textBox_X.Text),
                  y = float.Parse(textBox_Y.Text),
                  z = float.Parse(textBox_Z.Text),
                  S_1 = 0,
                  S_2 = 0;

                for (int i = 1; i < x; i++)
                    S_1 += i - x * y;

                for (int i = 1; i < y; i++)
                    S_2 += i - x * z;

                if (float.IsNaN(S_1 / S_2) || float.IsInfinity(S_1 / S_2))
                    throw new Exception();
                label_Result.Text = $"= {S_1 / S_2}";
                label_Result.BackColor = Color.FromArgb(126, 92, 46);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Перевірте параметри, неможливо ділити на нуль", "Помилка!");
            }
            catch(FormatException)
            {
                MessageBox.Show("Перевірте параметри", "Помилка!");
            }
            catch(Exception)
            {
                MessageBox.Show("Щось пішло не так(", "!!!");
            }
        }
    }
}
