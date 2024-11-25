namespace Programming_Assessment
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
            menu = new MenuStrip();
            toDoListToolStripMenuItem = new ToolStripMenuItem();
            diaryToolStripMenuItem = new ToolStripMenuItem();
            calendarToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            btn_ToDo = new Button();
            btn_Diary = new Button();
            btnCalendar = new Button();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackColor = Color.FromArgb(123, 211, 137);
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { toDoListToolStripMenuItem, diaryToolStripMenuItem, calendarToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(1246, 28);
            menu.TabIndex = 0;
            menu.Text = "menu";
            // 
            // toDoListToolStripMenuItem
            // 
            toDoListToolStripMenuItem.Name = "toDoListToolStripMenuItem";
            toDoListToolStripMenuItem.Size = new Size(91, 24);
            toDoListToolStripMenuItem.Text = "To-Do List";
            // 
            // diaryToolStripMenuItem
            // 
            diaryToolStripMenuItem.Name = "diaryToolStripMenuItem";
            diaryToolStripMenuItem.Size = new Size(58, 24);
            diaryToolStripMenuItem.Text = "Diary";
            // 
            // calendarToolStripMenuItem
            // 
            calendarToolStripMenuItem.Name = "calendarToolStripMenuItem";
            calendarToolStripMenuItem.Size = new Size(82, 24);
            calendarToolStripMenuItem.Text = "Calendar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ink Free", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 28);
            label1.Name = "label1";
            label1.Size = new Size(1187, 150);
            label1.TabIndex = 1;
            label1.Text = "Welcome to the Program!\r\nPlease choose an option below to get started.\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_ToDo
            // 
            btn_ToDo.BackColor = Color.Transparent;
            btn_ToDo.Location = new Point(26, 245);
            btn_ToDo.Name = "btn_ToDo";
            btn_ToDo.Size = new Size(245, 231);
            btn_ToDo.TabIndex = 2;
            btn_ToDo.Text = "To-Do List";
            btn_ToDo.UseVisualStyleBackColor = false;
            btn_ToDo.Click += btn_ToDo_Click;
            // 
            // btn_Diary
            // 
            btn_Diary.Location = new Point(494, 245);
            btn_Diary.Name = "btn_Diary";
            btn_Diary.Size = new Size(245, 231);
            btn_Diary.TabIndex = 3;
            btn_Diary.Text = "Diary";
            btn_Diary.UseVisualStyleBackColor = true;
            // 
            // btnCalendar
            // 
            btnCalendar.Location = new Point(968, 245);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Size = new Size(245, 231);
            btnCalendar.TabIndex = 4;
            btnCalendar.Text = "Calendar";
            btnCalendar.UseVisualStyleBackColor = true;
            btnCalendar.Click += btnCalendar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1246, 684);
            Controls.Add(btnCalendar);
            Controls.Add(btn_Diary);
            Controls.Add(btn_ToDo);
            Controls.Add(label1);
            Controls.Add(menu);
            MainMenuStrip = menu;
            Name = "Form1";
            Text = "Form1";
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
    }
}
