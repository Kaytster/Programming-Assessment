namespace Programming_Assessment
{
    partial class Calendar
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
            monthCalendar = new MonthCalendar();
            menu = new MenuStrip();
            menu_Back = new ToolStripMenuItem();
            menu_ToDo = new ToolStripMenuItem();
            menu_Diary = new ToolStripMenuItem();
            menu_Notes = new ToolStripMenuItem();
            menu_Calendar = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            txt_AddEvent = new TextBox();
            btn_AddEvent = new Button();
            label1 = new Label();
            lsvEvents = new ListView();
            colEventTitle = new ColumnHeader();
            colEventDate = new ColumnHeader();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // monthCalendar
            // 
            monthCalendar.BackColor = Color.CornflowerBlue;
            monthCalendar.Location = new Point(65, 101);
            monthCalendar.MaxSelectionCount = 1;
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 0;
            monthCalendar.TitleBackColor = Color.Thistle;
            monthCalendar.TrailingForeColor = Color.CornflowerBlue;
            // 
            // menu
            // 
            menu.BackColor = Color.CornflowerBlue;
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { menu_Back, menu_ToDo, menu_Diary, menu_Notes, menu_Calendar, settingsToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(6, 3, 0, 3);
            menu.Size = new Size(842, 30);
            menu.TabIndex = 1;
            menu.Text = "menu";
            // 
            // menu_Back
            // 
            menu_Back.Name = "menu_Back";
            menu_Back.Size = new Size(53, 24);
            menu_Back.Text = "<<<";
            menu_Back.Click += menu_Back_Click;
            // 
            // menu_ToDo
            // 
            menu_ToDo.Name = "menu_ToDo";
            menu_ToDo.Size = new Size(91, 24);
            menu_ToDo.Text = "To-Do List";
            menu_ToDo.Click += menu_ToDo_Click;
            // 
            // menu_Diary
            // 
            menu_Diary.Name = "menu_Diary";
            menu_Diary.Size = new Size(58, 24);
            menu_Diary.Text = "Diary";
            menu_Diary.Click += menu_Diary_Click;
            // 
            // menu_Notes
            // 
            menu_Notes.Name = "menu_Notes";
            menu_Notes.Size = new Size(62, 24);
            menu_Notes.Text = "Notes";
            menu_Notes.Click += menu_Notes_Click;
            // 
            // menu_Calendar
            // 
            menu_Calendar.Name = "menu_Calendar";
            menu_Calendar.Size = new Size(82, 24);
            menu_Calendar.Text = "Calendar";
            menu_Calendar.Click += menu_Calendar_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(76, 24);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // txt_AddEvent
            // 
            txt_AddEvent.Location = new Point(65, 349);
            txt_AddEvent.Margin = new Padding(3, 4, 3, 4);
            txt_AddEvent.Name = "txt_AddEvent";
            txt_AddEvent.Size = new Size(259, 27);
            txt_AddEvent.TabIndex = 2;
            // 
            // btn_AddEvent
            // 
            btn_AddEvent.Location = new Point(105, 408);
            btn_AddEvent.Margin = new Padding(3, 4, 3, 4);
            btn_AddEvent.Name = "btn_AddEvent";
            btn_AddEvent.Size = new Size(186, 87);
            btn_AddEvent.TabIndex = 3;
            btn_AddEvent.Text = "Add Event";
            btn_AddEvent.UseVisualStyleBackColor = true;
            btn_AddEvent.Click += btn_AddEvent_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(576, 51);
            label1.Name = "label1";
            label1.Size = new Size(93, 33);
            label1.TabIndex = 5;
            label1.Text = "Events";
            // 
            // lsvEvents
            // 
            lsvEvents.Columns.AddRange(new ColumnHeader[] { colEventTitle, colEventDate });
            lsvEvents.FullRowSelect = true;
            lsvEvents.Location = new Point(433, 101);
            lsvEvents.Margin = new Padding(3, 4, 3, 4);
            lsvEvents.Name = "lsvEvents";
            lsvEvents.Size = new Size(395, 396);
            lsvEvents.TabIndex = 6;
            lsvEvents.UseCompatibleStateImageBehavior = false;
            lsvEvents.View = View.Details;
            // 
            // colEventTitle
            // 
            colEventTitle.Text = "Event name";
            colEventTitle.Width = 173;
            // 
            // colEventDate
            // 
            colEventDate.Text = "Event date";
            colEventDate.Width = 173;
            // 
            // Calendar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 213, 255);
            ClientSize = new Size(842, 579);
            Controls.Add(lsvEvents);
            Controls.Add(label1);
            Controls.Add(btn_AddEvent);
            Controls.Add(txt_AddEvent);
            Controls.Add(menu);
            Controls.Add(monthCalendar);
            Name = "Calendar";
            Text = "Calendar";
            Load += Calendar_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar;
        private MenuStrip menu;
        private ToolStripMenuItem menu_Back;
        private ToolStripMenuItem menu_ToDo;
        private ToolStripMenuItem menu_Diary;
        private ToolStripMenuItem menu_Notes;
        private ToolStripMenuItem menu_Calendar;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private TextBox txt_AddEvent;
        private Button btn_AddEvent;
        private Label label1;
        private ListView lsvEvents;
        private ColumnHeader colEventTitle;
        private ColumnHeader colEventDate;
    }
}