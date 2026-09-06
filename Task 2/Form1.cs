using Newtonsoft.Json;

namespace Task_2
{
    public partial class Form1 : Form
    {
        private List<Callers> callers = new();
        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel.Text = "";
        }

        private void toolStripButton_LoadFrom_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using StreamReader sr = new StreamReader(openFileDialog.FileName);
                    using JsonTextReader reader = new(sr);
                    JsonSerializer serializer = new();
                    callers = serializer.Deserialize<List<Callers>>(reader)!;

                    textBox_List.Text = string.Join("\r\n", callers);
                }
                catch (Exception)
                {
                    MessageBox.Show($"Сталася халепа", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> Add = new(textBox_Add.Text.Split("\r\n"));
                foreach (var rec in Add)
                {
                    string[] add = rec.Split(";");
                    callers.Add(new Callers(add[0], add[1], add[2], add[3]));
                }
                toolStripStatusLabel.Text = "New record saved";
                textBox_Add.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show($"Неможливо додати запис", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton_SaveTo_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string json = JsonConvert.SerializeObject(callers, Formatting.Indented);
                    File.WriteAllText(saveFileDialog.FileName, json);
                    toolStripStatusLabel.Text = "File saved";
                }
                catch (Exception)
                {
                    MessageBox.Show($"Сталася халепа", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox_Add_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete) && textBox_Add.Text.Length == 0)
                toolStripStatusLabel.Text = "";
        }

        private void textBox_Add_KeyDown(object sender, KeyEventArgs e)
        {
            toolStripStatusLabel.Text = "Unsaved records";
        }
    }
}
