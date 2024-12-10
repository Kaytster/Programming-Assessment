namespace Programming_Assessment
{
    partial class Notes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rtb_Notes = new RichTextBox();
            menu = new MenuStrip();
            menu_Back = new ToolStripMenuItem();
            menu_ToDo = new ToolStripMenuItem();
            menu_Diary = new ToolStripMenuItem();
            menu_Notes = new ToolStripMenuItem();
            menu_Calendar = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            btn_Save = new Button();
            btn_Colour = new Button();
            btn_Font = new Button();
            btn_Highlight = new Button();
            saveFileDialog1 = new SaveFileDialog();
            lbl_Char = new Label();
            lbl_Word = new Label();
            lbl_CharCount = new Label();
            lbl_WordCount = new Label();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // rtb_Notes
            // 
            rtb_Notes.Location = new Point(10, 89);
            rtb_Notes.Margin = new Padding(3, 2, 3, 2);
            rtb_Notes.Name = "rtb_Notes";
            rtb_Notes.Size = new Size(720, 380);
            rtb_Notes.TabIndex = 0;
            rtb_Notes.Text = "";
            rtb_Notes.TextChanged += rtb_Notes_TextChanged;
            // 
            // menu
            // 
            menu.BackColor = Color.CornflowerBlue;
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { menu_Back, menu_ToDo, menu_Diary, menu_Notes, menu_Calendar, settingsToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(5, 2, 0, 2);
            menu.Size = new Size(741, 24);
            menu.TabIndex = 1;
            menu.Text = "menu";
            // 
            // menu_Back
            // 
            menu_Back.Name = "menu_Back";
            menu_Back.Size = new Size(43, 20);
            menu_Back.Text = "<<<";
            menu_Back.Click += menu_Back_Click;
            // 
            // menu_ToDo
            // 
            menu_ToDo.Name = "menu_ToDo";
            menu_ToDo.Size = new Size(72, 20);
            menu_ToDo.Text = "To-Do List";
            menu_ToDo.Click += menu_ToDo_Click;
            // 
            // menu_Diary
            // 
            menu_Diary.Name = "menu_Diary";
            menu_Diary.Size = new Size(46, 20);
            menu_Diary.Text = "Diary";
            menu_Diary.Click += menu_Diary_Click;
            // 
            // menu_Notes
            // 
            menu_Notes.Name = "menu_Notes";
            menu_Notes.Size = new Size(50, 20);
            menu_Notes.Text = "Notes";
            menu_Notes.Click += menu_Notes_Click;
            // 
            // menu_Calendar
            // 
            menu_Calendar.Name = "menu_Calendar";
            menu_Calendar.Size = new Size(66, 20);
            menu_Calendar.Text = "Calendar";
            menu_Calendar.Click += menu_Calendar_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // btn_Save
            // 
            btn_Save.Font = new Font("Segoe UI", 10.8F);
            btn_Save.Location = new Point(10, 33);
            btn_Save.Margin = new Padding(3, 2, 3, 2);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(82, 45);
            btn_Save.TabIndex = 2;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Colour
            // 
            btn_Colour.Font = new Font("Segoe UI", 10.8F);
            btn_Colour.Location = new Point(144, 33);
            btn_Colour.Margin = new Padding(3, 2, 3, 2);
            btn_Colour.Name = "btn_Colour";
            btn_Colour.Size = new Size(82, 45);
            btn_Colour.TabIndex = 3;
            btn_Colour.Text = "Colour";
            btn_Colour.UseVisualStyleBackColor = true;
            btn_Colour.Click += btn_Colour_Click;
            // 
            // btn_Font
            // 
            btn_Font.Font = new Font("Segoe UI", 10.8F);
            btn_Font.Location = new Point(276, 33);
            btn_Font.Margin = new Padding(3, 2, 3, 2);
            btn_Font.Name = "btn_Font";
            btn_Font.Size = new Size(82, 45);
            btn_Font.TabIndex = 4;
            btn_Font.Text = "Font";
            btn_Font.UseVisualStyleBackColor = true;
            btn_Font.Click += btn_Font_Click;
            // 
            // btn_Highlight
            // 
            btn_Highlight.Font = new Font("Segoe UI", 10.8F);
            btn_Highlight.Location = new Point(408, 33);
            btn_Highlight.Margin = new Padding(3, 2, 3, 2);
            btn_Highlight.Name = "btn_Highlight";
            btn_Highlight.Size = new Size(82, 45);
            btn_Highlight.TabIndex = 5;
            btn_Highlight.Text = "Highlight";
            btn_Highlight.UseVisualStyleBackColor = true;
            btn_Highlight.Click += btn_Highlight_Click;
            // 
            // lbl_Char
            // 
            lbl_Char.AutoSize = true;
            lbl_Char.Font = new Font("Segoe UI", 10.8F);
            lbl_Char.Location = new Point(538, 33);
            lbl_Char.Name = "lbl_Char";
            lbl_Char.Size = new Size(81, 20);
            lbl_Char.TabIndex = 6;
            lbl_Char.Text = "Characters:";
            // 
            // lbl_Word
            // 
            lbl_Word.AutoSize = true;
            lbl_Word.Font = new Font("Segoe UI", 10.8F);
            lbl_Word.Location = new Point(538, 63);
            lbl_Word.Name = "lbl_Word";
            lbl_Word.Size = new Size(54, 20);
            lbl_Word.TabIndex = 7;
            lbl_Word.Text = "Words:";
            // 
            // lbl_CharCount
            // 
            lbl_CharCount.AutoSize = true;
            lbl_CharCount.Font = new Font("Segoe UI", 10.8F);
            lbl_CharCount.Location = new Point(641, 33);
            lbl_CharCount.Name = "lbl_CharCount";
            lbl_CharCount.Size = new Size(27, 20);
            lbl_CharCount.TabIndex = 8;
            lbl_CharCount.Text = "---";
            // 
            // lbl_WordCount
            // 
            lbl_WordCount.AutoSize = true;
            lbl_WordCount.Font = new Font("Segoe UI", 10.8F);
            lbl_WordCount.Location = new Point(641, 63);
            lbl_WordCount.Name = "lbl_WordCount";
            lbl_WordCount.Size = new Size(27, 20);
            lbl_WordCount.TabIndex = 9;
            lbl_WordCount.Text = "---";
            // 
            // Notes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 213, 255);
            ClientSize = new Size(741, 478);
            Controls.Add(lbl_WordCount);
            Controls.Add(lbl_CharCount);
            Controls.Add(lbl_Word);
            Controls.Add(lbl_Char);
            Controls.Add(btn_Highlight);
            Controls.Add(btn_Font);
            Controls.Add(btn_Colour);
            Controls.Add(btn_Save);
            Controls.Add(menu);
            Controls.Add(rtb_Notes);
            Name = "Notes";
            Text = "Notes";
            Load += Notes_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtb_Notes;
        private MenuStrip menu;
        private ToolStripMenuItem menu_Back;
        private ToolStripMenuItem menu_ToDo;
        private ToolStripMenuItem menu_Diary;
        private ToolStripMenuItem menu_Notes;
        private ToolStripMenuItem menu_Calendar;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private Button btn_Save;
        private Button btn_Colour;
        private Button btn_Font;
        private Button btn_Highlight;
        private SaveFileDialog saveFileDialog1;
        private Label lbl_Char;
        private Label lbl_Word;
        private Label lbl_CharCount;
        private Label lbl_WordCount;
    }
}