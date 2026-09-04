namespace Task_1
{
    partial class MainForm
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
            button_calculate = new Button();
            pictureBox1 = new PictureBox();
            label_X = new Label();
            label_Y = new Label();
            label_Z = new Label();
            textBox_Z = new TextBox();
            textBox_X = new TextBox();
            textBox_Y = new TextBox();
            label_Result = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_calculate
            // 
            button_calculate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_calculate.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button_calculate.Location = new Point(12, 210);
            button_calculate.Name = "button_calculate";
            button_calculate.Size = new Size(193, 39);
            button_calculate.TabIndex = 0;
            button_calculate.Text = "Обчислити";
            button_calculate.UseVisualStyleBackColor = true;
            button_calculate.Click += button_calculate_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.Снимок_экрана_2026_09_04_121656;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(206, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(485, 143);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label_X
            // 
            label_X.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label_X.AutoSize = true;
            label_X.Font = new Font("Yu Gothic UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_X.ForeColor = Color.FromArgb(217, 236, 242);
            label_X.Location = new Point(12, 43);
            label_X.Name = "label_X";
            label_X.Size = new Size(18, 20);
            label_X.TabIndex = 2;
            label_X.Text = "X";
            // 
            // label_Y
            // 
            label_Y.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label_Y.AutoSize = true;
            label_Y.Font = new Font("Yu Gothic UI Semibold", 11.25F, FontStyle.Bold);
            label_Y.ForeColor = Color.FromArgb(217, 236, 242);
            label_Y.Location = new Point(12, 103);
            label_Y.Name = "label_Y";
            label_Y.Size = new Size(18, 20);
            label_Y.TabIndex = 3;
            label_Y.Text = "Y";
            // 
            // label_Z
            // 
            label_Z.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label_Z.AutoSize = true;
            label_Z.Font = new Font("Yu Gothic UI Semibold", 11.25F, FontStyle.Bold);
            label_Z.ForeColor = Color.FromArgb(217, 236, 242);
            label_Z.Location = new Point(12, 163);
            label_Z.Name = "label_Z";
            label_Z.Size = new Size(18, 20);
            label_Z.TabIndex = 4;
            label_Z.Text = "Z";
            // 
            // textBox_Z
            // 
            textBox_Z.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_Z.Location = new Point(60, 160);
            textBox_Z.Name = "textBox_Z";
            textBox_Z.Size = new Size(100, 23);
            textBox_Z.TabIndex = 5;
            textBox_Z.KeyPress += textBox_Z_KeyPress;
            // 
            // textBox_X
            // 
            textBox_X.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_X.Location = new Point(60, 40);
            textBox_X.Name = "textBox_X";
            textBox_X.Size = new Size(100, 23);
            textBox_X.TabIndex = 6;
            textBox_X.KeyPress += textBox_X_KeyPress;
            // 
            // textBox_Y
            // 
            textBox_Y.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_Y.Location = new Point(60, 100);
            textBox_Y.Name = "textBox_Y";
            textBox_Y.Size = new Size(100, 23);
            textBox_Y.TabIndex = 7;
            textBox_Y.KeyPress += textBox_X_KeyPress;
            // 
            // label_Result
            // 
            label_Result.AutoSize = true;
            label_Result.Location = new Point(518, 234);
            label_Result.Name = "label_Result";
            label_Result.Size = new Size(38, 15);
            label_Result.TabIndex = 8;
            label_Result.Text = "label4";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 68, 69);
            ClientSize = new Size(772, 261);
            Controls.Add(label_Result);
            Controls.Add(textBox_Y);
            Controls.Add(textBox_X);
            Controls.Add(textBox_Z);
            Controls.Add(label_Z);
            Controls.Add(label_Y);
            Controls.Add(label_X);
            Controls.Add(pictureBox1);
            Controls.Add(button_calculate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(600, 300);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Калькулятор";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_calculate;
        private PictureBox pictureBox1;
        private Label label_X;
        private Label label_Y;
        private Label label_Z;
        private TextBox textBox_Z;
        private TextBox textBox_X;
        private TextBox textBox_Y;
        private Label label_Result;
    }
}
