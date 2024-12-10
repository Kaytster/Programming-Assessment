namespace Programming_Assessment
{
    partial class Diary
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
            menu = new MenuStrip();
            menu_Back = new ToolStripMenuItem();
            menu_ToDo = new ToolStripMenuItem();
            menu_Diary = new ToolStripMenuItem();
            menu_Notes = new ToolStripMenuItem();
            menu_Calendar = new ToolStripMenuItem();
            tab_Diary = new TabControl();
            tab_Jan = new TabPage();
            flow_1 = new FlowLayoutPanel();
            tab_Feb = new TabPage();
            tab_Mar = new TabPage();
            flowLayoutPanel10 = new FlowLayoutPanel();
            tab_Apr = new TabPage();
            flowLayoutPanel15 = new FlowLayoutPanel();
            tab_May = new TabPage();
            flowLayoutPanel20 = new FlowLayoutPanel();
            tab_Jul = new TabPage();
            flowLayoutPanel30 = new FlowLayoutPanel();
            tab_Aug = new TabPage();
            tab_Sep = new TabPage();
            tab_Oct = new TabPage();
            tab_Nov = new TabPage();
            tab_Dec = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel25 = new FlowLayoutPanel();
            tab_Jun = new TabPage();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            flowLayoutPanel6 = new FlowLayoutPanel();
            menu.SuspendLayout();
            tab_Diary.SuspendLayout();
            tab_Jan.SuspendLayout();
            tab_Feb.SuspendLayout();
            tab_Mar.SuspendLayout();
            tab_Apr.SuspendLayout();
            tab_May.SuspendLayout();
            tab_Jul.SuspendLayout();
            tab_Aug.SuspendLayout();
            tab_Sep.SuspendLayout();
            tab_Oct.SuspendLayout();
            tab_Nov.SuspendLayout();
            tab_Dec.SuspendLayout();
            tab_Jun.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackColor = Color.CornflowerBlue;
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { menu_Back, menu_ToDo, menu_Diary, menu_Notes, menu_Calendar });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(5, 2, 0, 2);
            menu.Size = new Size(800, 24);
            menu.TabIndex = 1;
            menu.Text = "menu";
            // 
            // menu_Back
            // 
            menu_Back.Name = "menu_Back";
            menu_Back.Size = new Size(43, 20);
            menu_Back.Text = "<<<";
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
            // tab_Diary
            // 
            tab_Diary.Controls.Add(tab_Jan);
            tab_Diary.Controls.Add(tab_Feb);
            tab_Diary.Controls.Add(tab_Mar);
            tab_Diary.Controls.Add(tab_Apr);
            tab_Diary.Controls.Add(tab_May);
            tab_Diary.Controls.Add(tab_Jun);
            tab_Diary.Controls.Add(tab_Jul);
            tab_Diary.Controls.Add(tab_Aug);
            tab_Diary.Controls.Add(tab_Sep);
            tab_Diary.Controls.Add(tab_Oct);
            tab_Diary.Controls.Add(tab_Nov);
            tab_Diary.Controls.Add(tab_Dec);
            tab_Diary.Location = new Point(5, 69);
            tab_Diary.Name = "tab_Diary";
            tab_Diary.SelectedIndex = 0;
            tab_Diary.Size = new Size(792, 369);
            tab_Diary.TabIndex = 3;
            // 
            // tab_Jan
            // 
            tab_Jan.Controls.Add(flow_1);
            tab_Jan.Location = new Point(4, 24);
            tab_Jan.Name = "tab_Jan";
            tab_Jan.Padding = new Padding(3);
            tab_Jan.Size = new Size(784, 341);
            tab_Jan.TabIndex = 0;
            tab_Jan.Text = "January";
            tab_Jan.UseVisualStyleBackColor = true;
            // 
            // flow_1
            // 
            flow_1.BorderStyle = BorderStyle.FixedSingle;
            flow_1.Dock = DockStyle.Fill;
            flow_1.Location = new Point(3, 3);
            flow_1.Name = "flow_1";
            flow_1.Size = new Size(778, 335);
            flow_1.TabIndex = 0;
            // 
            // tab_Feb
            // 
            tab_Feb.Controls.Add(flowLayoutPanel1);
            tab_Feb.Location = new Point(4, 24);
            tab_Feb.Name = "tab_Feb";
            tab_Feb.Padding = new Padding(3);
            tab_Feb.Size = new Size(784, 341);
            tab_Feb.TabIndex = 1;
            tab_Feb.Text = "February";
            tab_Feb.UseVisualStyleBackColor = true;
            // 
            // tab_Mar
            // 
            tab_Mar.Controls.Add(flowLayoutPanel10);
            tab_Mar.Location = new Point(4, 24);
            tab_Mar.Name = "tab_Mar";
            tab_Mar.Size = new Size(784, 341);
            tab_Mar.TabIndex = 2;
            tab_Mar.Text = "March";
            tab_Mar.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel10
            // 
            flowLayoutPanel10.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel10.Dock = DockStyle.Fill;
            flowLayoutPanel10.Location = new Point(0, 0);
            flowLayoutPanel10.Name = "flowLayoutPanel10";
            flowLayoutPanel10.Size = new Size(784, 341);
            flowLayoutPanel10.TabIndex = 5;
            // 
            // tab_Apr
            // 
            tab_Apr.Controls.Add(flowLayoutPanel15);
            tab_Apr.Location = new Point(4, 24);
            tab_Apr.Name = "tab_Apr";
            tab_Apr.Size = new Size(784, 341);
            tab_Apr.TabIndex = 3;
            tab_Apr.Text = "April";
            tab_Apr.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel15
            // 
            flowLayoutPanel15.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel15.Dock = DockStyle.Fill;
            flowLayoutPanel15.Location = new Point(0, 0);
            flowLayoutPanel15.Name = "flowLayoutPanel15";
            flowLayoutPanel15.Size = new Size(784, 341);
            flowLayoutPanel15.TabIndex = 5;
            // 
            // tab_May
            // 
            tab_May.Controls.Add(flowLayoutPanel20);
            tab_May.Location = new Point(4, 24);
            tab_May.Name = "tab_May";
            tab_May.Size = new Size(784, 341);
            tab_May.TabIndex = 4;
            tab_May.Text = "May";
            tab_May.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel20
            // 
            flowLayoutPanel20.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel20.Dock = DockStyle.Fill;
            flowLayoutPanel20.Location = new Point(0, 0);
            flowLayoutPanel20.Name = "flowLayoutPanel20";
            flowLayoutPanel20.Size = new Size(784, 341);
            flowLayoutPanel20.TabIndex = 5;
            // 
            // tab_Jul
            // 
            tab_Jul.Controls.Add(flowLayoutPanel30);
            tab_Jul.Location = new Point(4, 24);
            tab_Jul.Name = "tab_Jul";
            tab_Jul.Size = new Size(784, 341);
            tab_Jul.TabIndex = 6;
            tab_Jul.Text = "July";
            tab_Jul.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel30
            // 
            flowLayoutPanel30.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel30.Dock = DockStyle.Fill;
            flowLayoutPanel30.Location = new Point(0, 0);
            flowLayoutPanel30.Name = "flowLayoutPanel30";
            flowLayoutPanel30.Size = new Size(784, 341);
            flowLayoutPanel30.TabIndex = 5;
            // 
            // tab_Aug
            // 
            tab_Aug.Controls.Add(flowLayoutPanel2);
            tab_Aug.Location = new Point(4, 24);
            tab_Aug.Name = "tab_Aug";
            tab_Aug.Size = new Size(784, 341);
            tab_Aug.TabIndex = 7;
            tab_Aug.Text = "August";
            tab_Aug.UseVisualStyleBackColor = true;
            // 
            // tab_Sep
            // 
            tab_Sep.Controls.Add(flowLayoutPanel3);
            tab_Sep.Location = new Point(4, 24);
            tab_Sep.Name = "tab_Sep";
            tab_Sep.Size = new Size(784, 341);
            tab_Sep.TabIndex = 8;
            tab_Sep.Text = "September";
            tab_Sep.UseVisualStyleBackColor = true;
            // 
            // tab_Oct
            // 
            tab_Oct.Controls.Add(flowLayoutPanel4);
            tab_Oct.Location = new Point(4, 24);
            tab_Oct.Name = "tab_Oct";
            tab_Oct.Size = new Size(784, 341);
            tab_Oct.TabIndex = 9;
            tab_Oct.Text = "October";
            tab_Oct.UseVisualStyleBackColor = true;
            // 
            // tab_Nov
            // 
            tab_Nov.Controls.Add(flowLayoutPanel5);
            tab_Nov.Location = new Point(4, 24);
            tab_Nov.Name = "tab_Nov";
            tab_Nov.Size = new Size(784, 341);
            tab_Nov.TabIndex = 10;
            tab_Nov.Text = "November";
            tab_Nov.UseVisualStyleBackColor = true;
            // 
            // tab_Dec
            // 
            tab_Dec.Controls.Add(flowLayoutPanel6);
            tab_Dec.Location = new Point(4, 24);
            tab_Dec.Name = "tab_Dec";
            tab_Dec.Size = new Size(784, 341);
            tab_Dec.TabIndex = 11;
            tab_Dec.Text = "December";
            tab_Dec.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(778, 335);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel25
            // 
            flowLayoutPanel25.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel25.Dock = DockStyle.Fill;
            flowLayoutPanel25.Location = new Point(0, 0);
            flowLayoutPanel25.Name = "flowLayoutPanel25";
            flowLayoutPanel25.Size = new Size(784, 341);
            flowLayoutPanel25.TabIndex = 5;
            // 
            // tab_Jun
            // 
            tab_Jun.Controls.Add(flowLayoutPanel25);
            tab_Jun.Location = new Point(4, 24);
            tab_Jun.Name = "tab_Jun";
            tab_Jun.Size = new Size(784, 341);
            tab_Jun.TabIndex = 5;
            tab_Jun.Text = "June";
            tab_Jun.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(784, 341);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(0, 0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(784, 341);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.Location = new Point(0, 0);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(784, 341);
            flowLayoutPanel4.TabIndex = 0;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Dock = DockStyle.Fill;
            flowLayoutPanel5.Location = new Point(0, 0);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(784, 341);
            flowLayoutPanel5.TabIndex = 0;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Dock = DockStyle.Fill;
            flowLayoutPanel6.Location = new Point(0, 0);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(784, 341);
            flowLayoutPanel6.TabIndex = 0;
            // 
            // Diary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 450);
            Controls.Add(tab_Diary);
            Controls.Add(menu);
            Name = "Diary";
            Text = "Diary";
            Load += Diary_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            tab_Diary.ResumeLayout(false);
            tab_Jan.ResumeLayout(false);
            tab_Feb.ResumeLayout(false);
            tab_Mar.ResumeLayout(false);
            tab_Apr.ResumeLayout(false);
            tab_May.ResumeLayout(false);
            tab_Jul.ResumeLayout(false);
            tab_Aug.ResumeLayout(false);
            tab_Sep.ResumeLayout(false);
            tab_Oct.ResumeLayout(false);
            tab_Nov.ResumeLayout(false);
            tab_Dec.ResumeLayout(false);
            tab_Jun.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem menu_Back;
        private ToolStripMenuItem menu_ToDo;
        private ToolStripMenuItem menu_Diary;
        private ToolStripMenuItem menu_Notes;
        private ToolStripMenuItem menu_Calendar;
        private TabControl tab_Diary;
        private TabPage tab_Jan;
        private TabPage tab_Feb;
        private TabPage tab_Mar;
        private TabPage tab_Apr;
        private TabPage tab_May;
        private TabPage tab_Jul;
        private TabPage tab_Aug;
        private TabPage tab_Sep;
        private TabPage tab_Oct;
        private TabPage tab_Nov;
        private TabPage tab_Dec;
        private FlowLayoutPanel flow_1;
        private FlowLayoutPanel flowLayoutPanel10;
        private FlowLayoutPanel flowLayoutPanel15;
        private FlowLayoutPanel flowLayoutPanel20;
        private FlowLayoutPanel flowLayoutPanel30;
        private FlowLayoutPanel flowLayoutPanel1;
        private TabPage tab_Jun;
        private FlowLayoutPanel flowLayoutPanel25;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel6;
    }
}