namespace Programming_Assessment
{
    partial class Main
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
            toDoListToolStripMenuItem = new ToolStripMenuItem();
            diaryToolStripMenuItem = new ToolStripMenuItem();
            calendarToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            btn_ToDo = new Button();
            btn_Diary = new Button();
            btnCalendar = new Button();
            btnNotes = new Button();
            notesToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackColor = Color.FromArgb(123, 211, 137);
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toDoListToolStripMenuItem, diaryToolStripMenuItem, notesToolStripMenuItem, calendarToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(5, 2, 0, 2);
            menu.Size = new Size(1090, 24);
            menu.TabIndex = 0;
            menu.Text = "menu";
            // 
            // toDoListToolStripMenuItem
            // 
            toDoListToolStripMenuItem.Name = "toDoListToolStripMenuItem";
            toDoListToolStripMenuItem.Size = new Size(72, 20);
            toDoListToolStripMenuItem.Text = "To-Do List";
            // 
            // diaryToolStripMenuItem
            // 
            diaryToolStripMenuItem.Name = "diaryToolStripMenuItem";
            diaryToolStripMenuItem.Size = new Size(46, 20);
            diaryToolStripMenuItem.Text = "Diary";
            // 
            // calendarToolStripMenuItem
            // 
            calendarToolStripMenuItem.Name = "calendarToolStripMenuItem";
            calendarToolStripMenuItem.Size = new Size(66, 20);
            calendarToolStripMenuItem.Text = "Calendar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ink Free", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(947, 120);
            label1.TabIndex = 1;
            label1.Text = "Welcome to the Program!\r\nPlease choose an option below to get started.\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_ToDo
            // 
            btn_ToDo.BackColor = Color.Transparent;
            btn_ToDo.Location = new Point(23, 184);
            btn_ToDo.Margin = new Padding(3, 2, 3, 2);
            btn_ToDo.Name = "btn_ToDo";
            btn_ToDo.Size = new Size(214, 173);
            btn_ToDo.TabIndex = 2;
            btn_ToDo.Text = "To-Do List";
            btn_ToDo.UseVisualStyleBackColor = false;
            btn_ToDo.Click += btn_ToDo_Click;
            // 
            // btn_Diary
            // 
            btn_Diary.Location = new Point(302, 184);
            btn_Diary.Margin = new Padding(3, 2, 3, 2);
            btn_Diary.Name = "btn_Diary";
            btn_Diary.Size = new Size(214, 173);
            btn_Diary.TabIndex = 3;
            btn_Diary.Text = "Diary";
            btn_Diary.UseVisualStyleBackColor = true;
            // 
            // btnCalendar
            // 
            btnCalendar.Location = new Point(847, 184);
            btnCalendar.Margin = new Padding(3, 2, 3, 2);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Size = new Size(214, 173);
            btnCalendar.TabIndex = 4;
            btnCalendar.Text = "Calendar";
            btnCalendar.UseVisualStyleBackColor = true;
            btnCalendar.Click += btnCalendar_Click;
            // 
            // btnNotes
            // 
            btnNotes.Location = new Point(580, 184);
            btnNotes.Name = "btnNotes";
            btnNotes.Size = new Size(214, 173);
            btnNotes.TabIndex = 5;
            btnNotes.Text = "Notes";
            btnNotes.UseVisualStyleBackColor = true;
            // 
            // notesToolStripMenuItem
            // 
            notesToolStripMenuItem.Name = "notesToolStripMenuItem";
            notesToolStripMenuItem.Size = new Size(50, 20);
            notesToolStripMenuItem.Text = "Notes";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(43, 20);
            toolStripMenuItem1.Text = "<<<";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1090, 513);
            Controls.Add(btnNotes);
            Controls.Add(btnCalendar);
            Controls.Add(btn_Diary);
            Controls.Add(btn_ToDo);
            Controls.Add(label1);
            Controls.Add(menu);
            MainMenuStrip = menu;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Main";
            Text = "Main";
            Load += Form1_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem toDoListToolStripMenuItem;
        private ToolStripMenuItem diaryToolStripMenuItem;
        private ToolStripMenuItem calendarToolStripMenuItem;
        private Label label1;
        private Button btn_ToDo;
        private Button btn_Diary;
        private Button btnCalendar;
        private Button btnNotes;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem notesToolStripMenuItem;
    }
}
