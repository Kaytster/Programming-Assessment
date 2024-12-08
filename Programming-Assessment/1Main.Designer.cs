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
            menu_Back = new ToolStripMenuItem();
            menu_ToDo = new ToolStripMenuItem();
            menu_Diary = new ToolStripMenuItem();
            menu_Notes = new ToolStripMenuItem();
            menu_Calendar = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            btn_ToDo = new Button();
            btn_Diary = new Button();
            btn_Calendar = new Button();
            btn_Notes = new Button();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackColor = Color.CornflowerBlue;
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { menu_Back, menu_ToDo, menu_Diary, menu_Notes, menu_Calendar, settingsToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(5, 2, 0, 2);
            menu.Size = new Size(1090, 24);
            menu.TabIndex = 0;
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
            // 
            // menu_Diary
            // 
            menu_Diary.Name = "menu_Diary";
            menu_Diary.Size = new Size(46, 20);
            menu_Diary.Text = "Diary";
            // 
            // menu_Notes
            // 
            menu_Notes.Name = "menu_Notes";
            menu_Notes.Size = new Size(50, 20);
            menu_Notes.Text = "Notes";
            // 
            // menu_Calendar
            // 
            menu_Calendar.Name = "menu_Calendar";
            menu_Calendar.Size = new Size(66, 20);
            menu_Calendar.Text = "Calendar";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 40);
            label1.Name = "label1";
            label1.Size = new Size(992, 116);
            label1.TabIndex = 1;
            label1.Text = "Welcome to the Program!\r\nPlease choose an option below to get started.\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_ToDo
            // 
            btn_ToDo.BackColor = Color.BlueViolet;
            btn_ToDo.FlatAppearance.BorderColor = Color.Indigo;
            btn_ToDo.FlatStyle = FlatStyle.Flat;
            btn_ToDo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ToDo.ForeColor = Color.CornflowerBlue;
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
            btn_Diary.BackColor = Color.BlueViolet;
            btn_Diary.FlatAppearance.BorderColor = Color.Indigo;
            btn_Diary.FlatStyle = FlatStyle.Flat;
            btn_Diary.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Diary.ForeColor = Color.CornflowerBlue;
            btn_Diary.Location = new Point(302, 184);
            btn_Diary.Margin = new Padding(3, 2, 3, 2);
            btn_Diary.Name = "btn_Diary";
            btn_Diary.Size = new Size(214, 173);
            btn_Diary.TabIndex = 3;
            btn_Diary.Text = "Diary";
            btn_Diary.UseVisualStyleBackColor = false;
            btn_Diary.Click += btn_Diary_Click;
            // 
            // btn_Calendar
            // 
            btn_Calendar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Calendar.Location = new Point(847, 184);
            btn_Calendar.Margin = new Padding(3, 2, 3, 2);
            btn_Calendar.Name = "btn_Calendar";
            btn_Calendar.Size = new Size(214, 173);
            btn_Calendar.TabIndex = 4;
            btn_Calendar.Text = "Calendar";
            btn_Calendar.UseVisualStyleBackColor = true;
            btn_Calendar.Click += btn_Calendar_Click;
            // 
            // btn_Notes
            // 
            btn_Notes.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Notes.Location = new Point(580, 184);
            btn_Notes.Name = "btn_Notes";
            btn_Notes.Size = new Size(214, 173);
            btn_Notes.TabIndex = 5;
            btn_Notes.Text = "Notes";
            btn_Notes.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1090, 513);
            Controls.Add(btn_Notes);
            Controls.Add(btn_Calendar);
            Controls.Add(btn_Diary);
            Controls.Add(btn_ToDo);
            Controls.Add(label1);
            Controls.Add(menu);
            MainMenuStrip = menu;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Main";
            Text = "Main";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem menu_ToDo;
        private ToolStripMenuItem menu_Diary;
        private ToolStripMenuItem menu_Calendar;
        private Label label1;
        private Button btn_ToDo;
        private Button btn_Diary;
        private Button btn_Calendar;
        private Button btn_Notes;
        private ToolStripMenuItem menu_Back;
        private ToolStripMenuItem menu_Notes;
        private ToolStripMenuItem settingsToolStripMenuItem;
    }
}
