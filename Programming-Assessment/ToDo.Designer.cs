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
            menuStrip1 = new MenuStrip();
            toDoToolStripMenuItem = new ToolStripMenuItem();
            diaryToolStripMenuItem = new ToolStripMenuItem();
            notesToolStripMenuItem = new ToolStripMenuItem();
            calendarToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // chk_List
            // 
            chk_List.FormattingEnabled = true;
            chk_List.Items.AddRange(new object[] { "hello", "task1" });
            chk_List.Location = new Point(10, 79);
            chk_List.Margin = new Padding(3, 2, 3, 2);
            chk_List.Name = "chk_List";
            chk_List.Size = new Size(289, 418);
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
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toDoToolStripMenuItem, diaryToolStripMenuItem, notesToolStripMenuItem, calendarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(678, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // toDoToolStripMenuItem
            // 
            toDoToolStripMenuItem.Name = "toDoToolStripMenuItem";
            toDoToolStripMenuItem.Size = new Size(51, 20);
            toDoToolStripMenuItem.Text = "To-Do";
            // 
            // diaryToolStripMenuItem
            // 
            diaryToolStripMenuItem.Name = "diaryToolStripMenuItem";
            diaryToolStripMenuItem.Size = new Size(46, 20);
            diaryToolStripMenuItem.Text = "Diary";
            // 
            // notesToolStripMenuItem
            // 
            notesToolStripMenuItem.Name = "notesToolStripMenuItem";
            notesToolStripMenuItem.Size = new Size(50, 20);
            notesToolStripMenuItem.Text = "Notes";
            // 
            // calendarToolStripMenuItem
            // 
            calendarToolStripMenuItem.Name = "calendarToolStripMenuItem";
            calendarToolStripMenuItem.Size = new Size(66, 20);
            calendarToolStripMenuItem.Text = "Calendar";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(43, 20);
            toolStripMenuItem1.Text = "<<<";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // ToDo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(678, 519);
            Controls.Add(btn_AddTask);
            Controls.Add(label1);
            Controls.Add(chk_List);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ToDo";
            Text = "ToDo";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox chk_List;
        private Label label1;
        private Button btn_AddTask;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toDoToolStripMenuItem;
        private ToolStripMenuItem diaryToolStripMenuItem;
        private ToolStripMenuItem notesToolStripMenuItem;
        private ToolStripMenuItem calendarToolStripMenuItem;
    }
}