namespace Task_2
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
            toolStrip1 = new ToolStrip();
            toolStripButton_LoadFrom = new ToolStripButton();
            toolStripButton_SaveTo = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            textBox_List = new TextBox();
            groupBox = new GroupBox();
            label_Add = new Label();
            textBox_Add = new TextBox();
            button_Add = new Button();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton_LoadFrom, toolStripButton_SaveTo });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_LoadFrom
            // 
            toolStripButton_LoadFrom.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_LoadFrom.Image = Properties.Resources.load;
            toolStripButton_LoadFrom.ImageTransparentColor = Color.Magenta;
            toolStripButton_LoadFrom.Name = "toolStripButton_LoadFrom";
            toolStripButton_LoadFrom.Size = new Size(23, 22);
            toolStripButton_LoadFrom.Text = "toolStripButton1";
            toolStripButton_LoadFrom.ToolTipText = "Завантажити записи";
            toolStripButton_LoadFrom.Click += toolStripButton_LoadFrom_Click;
            // 
            // toolStripButton_SaveTo
            // 
            toolStripButton_SaveTo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_SaveTo.Image = Properties.Resources.save;
            toolStripButton_SaveTo.ImageTransparentColor = Color.Magenta;
            toolStripButton_SaveTo.Name = "toolStripButton_SaveTo";
            toolStripButton_SaveTo.Size = new Size(23, 22);
            toolStripButton_SaveTo.Text = "toolStripButton1";
            toolStripButton_SaveTo.ToolTipText = "Зберегти";
            toolStripButton_SaveTo.Click += toolStripButton_SaveTo_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(39, 17);
            toolStripStatusLabel.Text = "Status";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            // 
            // saveFileDialog
            // 
            saveFileDialog.FileName = "Callers.json";
            saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            // 
            // textBox_List
            // 
            textBox_List.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_List.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_List.Location = new Point(12, 22);
            textBox_List.Multiline = true;
            textBox_List.Name = "textBox_List";
            textBox_List.ReadOnly = true;
            textBox_List.ScrollBars = ScrollBars.Vertical;
            textBox_List.Size = new Size(776, 189);
            textBox_List.TabIndex = 6;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(label_Add);
            groupBox.Controls.Add(textBox_Add);
            groupBox.Controls.Add(textBox_List);
            groupBox.Dock = DockStyle.Fill;
            groupBox.Location = new Point(0, 25);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(800, 403);
            groupBox.TabIndex = 11;
            groupBox.TabStop = false;
            groupBox.Text = "Список абонентів";
            // 
            // label_Add
            // 
            label_Add.AutoSize = true;
            label_Add.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_Add.Location = new Point(12, 214);
            label_Add.Name = "label_Add";
            label_Add.Size = new Size(697, 42);
            label_Add.TabIndex = 8;
            label_Add.Text = "Щоб додати новий запис, введіть дані у полі нижче так: ім'я; прізвище; номер телефону; адреса\r\nДля введення декількох записів розділяйте їх клавішею Enter";
            // 
            // textBox_Add
            // 
            textBox_Add.Location = new Point(12, 257);
            textBox_Add.Multiline = true;
            textBox_Add.Name = "textBox_Add";
            textBox_Add.Size = new Size(776, 117);
            textBox_Add.TabIndex = 7;
            textBox_Add.KeyDown += textBox_Add_KeyDown;
            textBox_Add.KeyUp += textBox_Add_KeyUp;
            // 
            // button_Add
            // 
            button_Add.Dock = DockStyle.Bottom;
            button_Add.Location = new Point(0, 405);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(800, 23);
            button_Add.TabIndex = 10;
            button_Add.Text = "Save new record";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Add);
            Controls.Add(groupBox);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(816, 489);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Довідник";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Add;
        private Label label2;
        private Label label3;
        private ToolStrip toolStrip1;
        private StatusStrip statusStrip1;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private TextBox textBox_List;
        private GroupBox groupBox;
        private Button button_Add;
        private ToolStripButton toolStripButton_LoadFrom;
        private ToolStripButton toolStripButton_SaveTo;
        private GroupBox groupBox2;
        private TextBox textBox_Add;
        private ToolStripStatusLabel toolStripStatusLabel;
    }
}
