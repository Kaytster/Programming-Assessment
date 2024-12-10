namespace Programming_Assessment
{
    partial class ToDo
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
            chk_List = new CheckedListBox();
            label1 = new Label();
            btn_AddTask = new Button();
            menu = new MenuStrip();
            menu_Back = new ToolStripMenuItem();
            menu_ToDo = new ToolStripMenuItem();
            menu_Diary = new ToolStripMenuItem();
            menu_Notes = new ToolStripMenuItem();
            menu_Calendar = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // chk_List
            // 
            chk_List.FormattingEnabled = true;
            chk_List.Items.AddRange(new object[] { "hello", "task1" });
            chk_List.Location = new Point(10, 79);
            chk_List.Margin = new Padding(3, 2, 3, 2);
            chk_List.Name = "chk_List";
            chk_List.Size = new Size(289, 400);
            chk_List.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(95, 48);
            label1.Name = "label1";
            label1.Size = new Size(110, 30);
            label1.TabIndex = 1;
            label1.Text = "To-Do List";
            // 
            // btn_AddTask
            // 
            btn_AddTask.Location = new Point(383, 79);
            btn_AddTask.Margin = new Padding(3, 2, 3, 2);
            btn_AddTask.Name = "btn_AddTask";
            btn_AddTask.Size = new Size(199, 83);
            btn_AddTask.TabIndex = 2;
            btn_AddTask.Text = "Add Task";
            btn_AddTask.UseVisualStyleBackColor = true;
            btn_AddTask.Click += btn_AddTask_Click;
            // 
            // menu
            // 
            menu.BackColor = Color.CornflowerBlue;
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { menu_Back, menu_ToDo, menu_Diary, menu_Notes, menu_Calendar, settingsToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(5, 2, 0, 2);
            menu.Size = new Size(678, 24);
            menu.TabIndex = 3;
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
            // ToDo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 213, 255);
            ClientSize = new Size(678, 519);
            Controls.Add(menu);
            Controls.Add(btn_AddTask);
            Controls.Add(label1);
            Controls.Add(chk_List);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ToDo";
            Text = "ToDo";
            Load += ToDo_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox chk_List;
        private Label label1;
        private Button btn_AddTask;
        private MenuStrip menu;
        private ToolStripMenuItem menu_Back;
        private ToolStripMenuItem menu_ToDo;
        private ToolStripMenuItem menu_Diary;
        private ToolStripMenuItem menu_Notes;
        private ToolStripMenuItem menu_Calendar;
        private ToolStripMenuItem settingsToolStripMenuItem;
    }
}