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
            add = new Button();
            shapeBox = new ListBox();
            label1 = new Label();
            fileDialog = new OpenFileDialog();
            saveDialog = new SaveFileDialog();
            panel3 = new Panel();
            textBox1 = new TextBox();
            button1 = new Button();
            menu.SuspendLayout();
            content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
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
            panel3.Controls.Add(button1);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(add);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 421);
            panel3.Name = "panel3";
            panel3.Size = new Size(587, 29);
            panel3.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(185, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(399, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(98, 3);
            button1.Name = "button1";
            button1.Size = new Size(81, 23);
            button1.TabIndex = 2;
            button1.Text = "Видалити";
            button1.UseVisualStyleBackColor = true;
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
        private Button button1;
        private TextBox textBox1;
    }
}