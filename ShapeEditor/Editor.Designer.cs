namespace ShapeEditor
{
    partial class Editor
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
            menu = new MenuStrip();
            file = new ToolStripMenuItem();
            save = new ToolStripMenuItem();
            open = new ToolStripMenuItem();
            author = new ToolStripMenuItem();
            content = new Panel();
            picture = new PictureBox();
            panel1 = new Panel();
            shapeBox = new ListBox();
            label1 = new Label();
            add = new Button();
            fileDialog = new OpenFileDialog();
            saveDialog = new SaveFileDialog();
            panel3 = new Panel();
            scale = new NumericUpDown();
            label4 = new Label();
            yCoord = new NumericUpDown();
            xCoord = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            next = new Button();
            clear = new Button();
            remove = new Button();
            info = new TextBox();
            menu.SuspendLayout();
            content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yCoord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xCoord).BeginInit();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { file, author });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(587, 24);
            menu.TabIndex = 2;
            menu.Text = "menuStrip1";
            // 
            // file
            // 
            file.DropDownItems.AddRange(new ToolStripItem[] { save, open });
            file.Name = "file";
            file.Size = new Size(48, 20);
            file.Text = "Файл";
            // 
            // save
            // 
            save.Name = "save";
            save.Size = new Size(124, 22);
            save.Text = "Зберегти";
            save.Click += save_Click;
            // 
            // open
            // 
            open.Name = "open";
            open.Size = new Size(124, 22);
            open.Text = "Відкрити";
            open.Click += open_Click;
            // 
            // author
            // 
            author.Name = "author";
            author.Size = new Size(52, 20);
            author.Text = "Автор";
            author.Click += author_Click;
            // 
            // content
            // 
            content.Controls.Add(picture);
            content.Controls.Add(panel1);
            content.Location = new Point(0, 24);
            content.Name = "content";
            content.Size = new Size(587, 375);
            content.TabIndex = 3;
            // 
            // picture
            // 
            picture.BackColor = SystemColors.ControlLightLight;
            picture.Dock = DockStyle.Fill;
            picture.Location = new Point(185, 0);
            picture.Name = "picture";
            picture.Size = new Size(402, 375);
            picture.TabIndex = 1;
            picture.TabStop = false;
            picture.Paint += picture_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(shapeBox);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 375);
            panel1.TabIndex = 0;
            // 
            // shapeBox
            // 
            shapeBox.BackColor = SystemColors.Control;
            shapeBox.BorderStyle = BorderStyle.None;
            shapeBox.Dock = DockStyle.Fill;
            shapeBox.FormattingEnabled = true;
            shapeBox.ItemHeight = 15;
            shapeBox.Location = new Point(0, 25);
            shapeBox.Name = "shapeBox";
            shapeBox.Size = new Size(185, 350);
            shapeBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 0;
            label1.Text = "Фігури";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // add
            // 
            add.Location = new Point(3, 3);
            add.Name = "add";
            add.Size = new Size(89, 23);
            add.TabIndex = 0;
            add.Text = "Додати";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // fileDialog
            // 
            fileDialog.FileName = "fileDialog";
            fileDialog.Filter = "Editor files (*.edt)|*.edt";
            fileDialog.Title = "Виберіть файл редактору";
            // 
            // saveDialog
            // 
            saveDialog.Filter = "Editor files (*.edt)|*.edt";
            saveDialog.Title = "Збереження файлу редактору";
            // 
            // panel3
            // 
            panel3.Controls.Add(scale);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(yCoord);
            panel3.Controls.Add(xCoord);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(next);
            panel3.Controls.Add(clear);
            panel3.Controls.Add(remove);
            panel3.Controls.Add(info);
            panel3.Controls.Add(add);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 395);
            panel3.Name = "panel3";
            panel3.Size = new Size(587, 55);
            panel3.TabIndex = 4;
            // 
            // scale
            // 
            scale.DecimalPlaces = 1;
            scale.Location = new Point(485, 29);
            scale.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            scale.Name = "scale";
            scale.Size = new Size(99, 23);
            scale.TabIndex = 11;
            scale.Value = new decimal(new int[] { 1, 0, 0, 0 });
            scale.ValueChanged += scale_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(442, 33);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 10;
            label4.Text = "Scale:";
            // 
            // yCoord
            // 
            yCoord.Location = new Point(335, 29);
            yCoord.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            yCoord.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            yCoord.Name = "yCoord";
            yCoord.Size = new Size(99, 23);
            yCoord.TabIndex = 9;
            yCoord.ValueChanged += yCoord_ValueChanged;
            // 
            // xCoord
            // 
            xCoord.Location = new Point(208, 29);
            xCoord.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            xCoord.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            xCoord.Name = "xCoord";
            xCoord.Size = new Size(98, 23);
            xCoord.TabIndex = 8;
            xCoord.ValueChanged += xCoord_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(312, 33);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 7;
            label3.Text = "Y:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 33);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 5;
            label2.Text = "X:";
            // 
            // next
            // 
            next.Location = new Point(98, 29);
            next.Name = "next";
            next.Size = new Size(81, 23);
            next.TabIndex = 4;
            next.Text = "Наступний";
            next.UseVisualStyleBackColor = true;
            next.Click += next_Click;
            // 
            // clear
            // 
            clear.Location = new Point(98, 3);
            clear.Name = "clear";
            clear.Size = new Size(81, 23);
            clear.TabIndex = 3;
            clear.Text = "Очистити";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // remove
            // 
            remove.Location = new Point(3, 29);
            remove.Name = "remove";
            remove.Size = new Size(89, 23);
            remove.TabIndex = 2;
            remove.Text = "Видалити";
            remove.UseVisualStyleBackColor = true;
            remove.Click += remove_Click;
            // 
            // info
            // 
            info.Enabled = false;
            info.Location = new Point(185, 4);
            info.Name = "info";
            info.Size = new Size(399, 23);
            info.TabIndex = 1;
            // 
            // Editor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 450);
            Controls.Add(panel3);
            Controls.Add(content);
            Controls.Add(menu);
            MainMenuStrip = menu;
            Name = "Editor";
            Text = "Редактор фігур";
            Load += Editor_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scale).EndInit();
            ((System.ComponentModel.ISupportInitialize)yCoord).EndInit();
            ((System.ComponentModel.ISupportInitialize)xCoord).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem file;
        private ToolStripMenuItem save;
        private ToolStripMenuItem open;
        private ToolStripMenuItem author;
        private Panel content;
        private PictureBox picture;
        private Panel panel1;
        private ListBox shapeBox;
        private Label label1;
        private Button add;
        private OpenFileDialog fileDialog;
        private SaveFileDialog saveDialog;
        private Panel panel3;
        private Button remove;
        private TextBox info;
        private Button clear;
        private NumericUpDown yCoord;
        private NumericUpDown xCoord;
        private Label label3;
        private Label label2;
        private Button next;
        private NumericUpDown scale;
        private Label label4;
    }
}