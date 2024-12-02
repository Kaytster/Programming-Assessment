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
            flow_5 = new FlowLayoutPanel();
            flow_4 = new FlowLayoutPanel();
            flow_3 = new FlowLayoutPanel();
            flow_2 = new FlowLayoutPanel();
            flow_1 = new FlowLayoutPanel();
            tab_Feb = new TabPage();
            flow_10 = new FlowLayoutPanel();
            flow_9 = new FlowLayoutPanel();
            flow_8 = new FlowLayoutPanel();
            flow_7 = new FlowLayoutPanel();
            flow_6 = new FlowLayoutPanel();
            tab_Mar = new TabPage();
            flowLayoutPanel6 = new FlowLayoutPanel();
            flowLayoutPanel7 = new FlowLayoutPanel();
            flowLayoutPanel8 = new FlowLayoutPanel();
            flowLayoutPanel9 = new FlowLayoutPanel();
            flowLayoutPanel10 = new FlowLayoutPanel();
            tab_Apr = new TabPage();
            flowLayoutPanel11 = new FlowLayoutPanel();
            flowLayoutPanel12 = new FlowLayoutPanel();
            flowLayoutPanel13 = new FlowLayoutPanel();
            flowLayoutPanel14 = new FlowLayoutPanel();
            flowLayoutPanel15 = new FlowLayoutPanel();
            tab_May = new TabPage();
            flowLayoutPanel16 = new FlowLayoutPanel();
            flowLayoutPanel17 = new FlowLayoutPanel();
            flowLayoutPanel18 = new FlowLayoutPanel();
            flowLayoutPanel19 = new FlowLayoutPanel();
            flowLayoutPanel20 = new FlowLayoutPanel();
            tab_Jun = new TabPage();
            flowLayoutPanel21 = new FlowLayoutPanel();
            flowLayoutPanel22 = new FlowLayoutPanel();
            flowLayoutPanel23 = new FlowLayoutPanel();
            flowLayoutPanel24 = new FlowLayoutPanel();
            flowLayoutPanel25 = new FlowLayoutPanel();
            tab_Jul = new TabPage();
            flowLayoutPanel26 = new FlowLayoutPanel();
            flowLayoutPanel27 = new FlowLayoutPanel();
            flowLayoutPanel28 = new FlowLayoutPanel();
            flowLayoutPanel29 = new FlowLayoutPanel();
            flowLayoutPanel30 = new FlowLayoutPanel();
            tab_Aug = new TabPage();
            tab_Sep = new TabPage();
            tab_Oct = new TabPage();
            tab_Nov = new TabPage();
            tab_Dec = new TabPage();
            menu.SuspendLayout();
            tab_Diary.SuspendLayout();
            tab_Jan.SuspendLayout();
            tab_Feb.SuspendLayout();
            tab_Mar.SuspendLayout();
            tab_Apr.SuspendLayout();
            tab_May.SuspendLayout();
            tab_Jun.SuspendLayout();
            tab_Jul.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackColor = Color.CornflowerBlue;
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { menu_Back, menu_ToDo, menu_Diary, menu_Notes, menu_Calendar });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(6, 3, 0, 3);
            menu.Size = new Size(914, 30);
            menu.TabIndex = 1;
            menu.Text = "menu";
            // 
            // menu_Back
            // 
            menu_Back.Name = "menu_Back";
            menu_Back.Size = new Size(53, 24);
            menu_Back.Text = "<<<";
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
            // 
            // menu_Notes
            // 
            menu_Notes.Name = "menu_Notes";
            menu_Notes.Size = new Size(62, 24);
            menu_Notes.Text = "Notes";
            // 
            // menu_Calendar
            // 
            menu_Calendar.Name = "menu_Calendar";
            menu_Calendar.Size = new Size(82, 24);
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
            tab_Diary.Location = new Point(6, 92);
            tab_Diary.Margin = new Padding(3, 4, 3, 4);
            tab_Diary.Name = "tab_Diary";
            tab_Diary.SelectedIndex = 0;
            tab_Diary.Size = new Size(905, 492);
            tab_Diary.TabIndex = 3;
            // 
            // tab_Jan
            // 
            tab_Jan.Controls.Add(flow_5);
            tab_Jan.Controls.Add(flow_4);
            tab_Jan.Controls.Add(flow_3);
            tab_Jan.Controls.Add(flow_2);
            tab_Jan.Controls.Add(flow_1);
            tab_Jan.Location = new Point(4, 29);
            tab_Jan.Margin = new Padding(3, 4, 3, 4);
            tab_Jan.Name = "tab_Jan";
            tab_Jan.Padding = new Padding(3, 4, 3, 4);
            tab_Jan.Size = new Size(897, 459);
            tab_Jan.TabIndex = 0;
            tab_Jan.Text = "January";
            tab_Jan.UseVisualStyleBackColor = true;
            tab_Jan.Click += tabPage1_Click;
            // 
            // flow_5
            // 
            flow_5.BorderStyle = BorderStyle.FixedSingle;
            flow_5.Location = new Point(7, 383);
            flow_5.Margin = new Padding(3, 4, 3, 4);
            flow_5.Name = "flow_5";
            flow_5.Size = new Size(882, 63);
            flow_5.TabIndex = 4;
            // 
            // flow_4
            // 
            flow_4.BorderStyle = BorderStyle.FixedSingle;
            flow_4.Location = new Point(7, 292);
            flow_4.Margin = new Padding(3, 4, 3, 4);
            flow_4.Name = "flow_4";
            flow_4.Size = new Size(882, 63);
            flow_4.TabIndex = 3;
            // 
            // flow_3
            // 
            flow_3.BorderStyle = BorderStyle.FixedSingle;
            flow_3.Location = new Point(8, 192);
            flow_3.Margin = new Padding(3, 4, 3, 4);
            flow_3.Name = "flow_3";
            flow_3.Size = new Size(882, 63);
            flow_3.TabIndex = 2;
            // 
            // flow_2
            // 
            flow_2.BorderStyle = BorderStyle.FixedSingle;
            flow_2.Location = new Point(8, 96);
            flow_2.Margin = new Padding(3, 4, 3, 4);
            flow_2.Name = "flow_2";
            flow_2.Size = new Size(882, 63);
            flow_2.TabIndex = 1;
            // 
            // flow_1
            // 
            flow_1.BorderStyle = BorderStyle.FixedSingle;
            flow_1.Location = new Point(7, 8);
            flow_1.Margin = new Padding(3, 4, 3, 4);
            flow_1.Name = "flow_1";
            flow_1.Size = new Size(882, 63);
            flow_1.TabIndex = 0;
            // 
            // tab_Feb
            // 
            tab_Feb.Controls.Add(flow_10);
            tab_Feb.Controls.Add(flow_9);
            tab_Feb.Controls.Add(flow_8);
            tab_Feb.Controls.Add(flow_7);
            tab_Feb.Controls.Add(flow_6);
            tab_Feb.Location = new Point(4, 29);
            tab_Feb.Margin = new Padding(3, 4, 3, 4);
            tab_Feb.Name = "tab_Feb";
            tab_Feb.Padding = new Padding(3, 4, 3, 4);
            tab_Feb.Size = new Size(897, 459);
            tab_Feb.TabIndex = 1;
            tab_Feb.Text = "February";
            tab_Feb.UseVisualStyleBackColor = true;
            // 
            // flow_10
            // 
            flow_10.BorderStyle = BorderStyle.FixedSingle;
            flow_10.Location = new Point(7, 383);
            flow_10.Margin = new Padding(3, 4, 3, 4);
            flow_10.Name = "flow_10";
            flow_10.Size = new Size(882, 63);
            flow_10.TabIndex = 9;
            // 
            // flow_9
            // 
            flow_9.BorderStyle = BorderStyle.FixedSingle;
            flow_9.Location = new Point(7, 292);
            flow_9.Margin = new Padding(3, 4, 3, 4);
            flow_9.Name = "flow_9";
            flow_9.Size = new Size(882, 63);
            flow_9.TabIndex = 8;
            // 
            // flow_8
            // 
            flow_8.BorderStyle = BorderStyle.FixedSingle;
            flow_8.Location = new Point(8, 192);
            flow_8.Margin = new Padding(3, 4, 3, 4);
            flow_8.Name = "flow_8";
            flow_8.Size = new Size(882, 63);
            flow_8.TabIndex = 7;
            // 
            // flow_7
            // 
            flow_7.BorderStyle = BorderStyle.FixedSingle;
            flow_7.Location = new Point(8, 96);
            flow_7.Margin = new Padding(3, 4, 3, 4);
            flow_7.Name = "flow_7";
            flow_7.Size = new Size(882, 63);
            flow_7.TabIndex = 6;
            // 
            // flow_6
            // 
            flow_6.BorderStyle = BorderStyle.FixedSingle;
            flow_6.Location = new Point(7, 8);
            flow_6.Margin = new Padding(3, 4, 3, 4);
            flow_6.Name = "flow_6";
            flow_6.Size = new Size(882, 63);
            flow_6.TabIndex = 5;
            // 
            // tab_Mar
            // 
            tab_Mar.Controls.Add(flowLayoutPanel6);
            tab_Mar.Controls.Add(flowLayoutPanel7);
            tab_Mar.Controls.Add(flowLayoutPanel8);
            tab_Mar.Controls.Add(flowLayoutPanel9);
            tab_Mar.Controls.Add(flowLayoutPanel10);
            tab_Mar.Location = new Point(4, 29);
            tab_Mar.Margin = new Padding(3, 4, 3, 4);
            tab_Mar.Name = "tab_Mar";
            tab_Mar.Size = new Size(897, 459);
            tab_Mar.TabIndex = 2;
            tab_Mar.Text = "March";
            tab_Mar.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel6.Location = new Point(7, 383);
            flowLayoutPanel6.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(882, 63);
            flowLayoutPanel6.TabIndex = 9;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel7.Location = new Point(7, 292);
            flowLayoutPanel7.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(882, 63);
            flowLayoutPanel7.TabIndex = 8;
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel8.Location = new Point(8, 192);
            flowLayoutPanel8.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(882, 63);
            flowLayoutPanel8.TabIndex = 7;
            // 
            // flowLayoutPanel9
            // 
            flowLayoutPanel9.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel9.Location = new Point(8, 96);
            flowLayoutPanel9.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Size = new Size(882, 63);
            flowLayoutPanel9.TabIndex = 6;
            // 
            // flowLayoutPanel10
            // 
            flowLayoutPanel10.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel10.Location = new Point(7, 8);
            flowLayoutPanel10.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel10.Name = "flowLayoutPanel10";
            flowLayoutPanel10.Size = new Size(882, 63);
            flowLayoutPanel10.TabIndex = 5;
            // 
            // tab_Apr
            // 
            tab_Apr.Controls.Add(flowLayoutPanel11);
            tab_Apr.Controls.Add(flowLayoutPanel12);
            tab_Apr.Controls.Add(flowLayoutPanel13);
            tab_Apr.Controls.Add(flowLayoutPanel14);
            tab_Apr.Controls.Add(flowLayoutPanel15);
            tab_Apr.Location = new Point(4, 29);
            tab_Apr.Margin = new Padding(3, 4, 3, 4);
            tab_Apr.Name = "tab_Apr";
            tab_Apr.Size = new Size(897, 459);
            tab_Apr.TabIndex = 3;
            tab_Apr.Text = "April";
            tab_Apr.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel11
            // 
            flowLayoutPanel11.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel11.Location = new Point(7, 383);
            flowLayoutPanel11.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel11.Name = "flowLayoutPanel11";
            flowLayoutPanel11.Size = new Size(882, 63);
            flowLayoutPanel11.TabIndex = 9;
            // 
            // flowLayoutPanel12
            // 
            flowLayoutPanel12.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel12.Location = new Point(7, 292);
            flowLayoutPanel12.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel12.Name = "flowLayoutPanel12";
            flowLayoutPanel12.Size = new Size(882, 63);
            flowLayoutPanel12.TabIndex = 8;
            // 
            // flowLayoutPanel13
            // 
            flowLayoutPanel13.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel13.Location = new Point(8, 192);
            flowLayoutPanel13.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel13.Name = "flowLayoutPanel13";
            flowLayoutPanel13.Size = new Size(882, 63);
            flowLayoutPanel13.TabIndex = 7;
            // 
            // flowLayoutPanel14
            // 
            flowLayoutPanel14.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel14.Location = new Point(8, 96);
            flowLayoutPanel14.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel14.Name = "flowLayoutPanel14";
            flowLayoutPanel14.Size = new Size(882, 63);
            flowLayoutPanel14.TabIndex = 6;
            // 
            // flowLayoutPanel15
            // 
            flowLayoutPanel15.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel15.Location = new Point(7, 8);
            flowLayoutPanel15.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel15.Name = "flowLayoutPanel15";
            flowLayoutPanel15.Size = new Size(882, 63);
            flowLayoutPanel15.TabIndex = 5;
            // 
            // tab_May
            // 
            tab_May.Controls.Add(flowLayoutPanel16);
            tab_May.Controls.Add(flowLayoutPanel17);
            tab_May.Controls.Add(flowLayoutPanel18);
            tab_May.Controls.Add(flowLayoutPanel19);
            tab_May.Controls.Add(flowLayoutPanel20);
            tab_May.Location = new Point(4, 29);
            tab_May.Margin = new Padding(3, 4, 3, 4);
            tab_May.Name = "tab_May";
            tab_May.Size = new Size(897, 459);
            tab_May.TabIndex = 4;
            tab_May.Text = "May";
            tab_May.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel16
            // 
            flowLayoutPanel16.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel16.Location = new Point(7, 383);
            flowLayoutPanel16.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel16.Name = "flowLayoutPanel16";
            flowLayoutPanel16.Size = new Size(882, 63);
            flowLayoutPanel16.TabIndex = 9;
            // 
            // flowLayoutPanel17
            // 
            flowLayoutPanel17.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel17.Location = new Point(7, 292);
            flowLayoutPanel17.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel17.Name = "flowLayoutPanel17";
            flowLayoutPanel17.Size = new Size(882, 63);
            flowLayoutPanel17.TabIndex = 8;
            // 
            // flowLayoutPanel18
            // 
            flowLayoutPanel18.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel18.Location = new Point(8, 192);
            flowLayoutPanel18.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel18.Name = "flowLayoutPanel18";
            flowLayoutPanel18.Size = new Size(882, 63);
            flowLayoutPanel18.TabIndex = 7;
            // 
            // flowLayoutPanel19
            // 
            flowLayoutPanel19.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel19.Location = new Point(8, 96);
            flowLayoutPanel19.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel19.Name = "flowLayoutPanel19";
            flowLayoutPanel19.Size = new Size(882, 63);
            flowLayoutPanel19.TabIndex = 6;
            // 
            // flowLayoutPanel20
            // 
            flowLayoutPanel20.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel20.Location = new Point(7, 8);
            flowLayoutPanel20.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel20.Name = "flowLayoutPanel20";
            flowLayoutPanel20.Size = new Size(882, 63);
            flowLayoutPanel20.TabIndex = 5;
            // 
            // tab_Jun
            // 
            tab_Jun.Controls.Add(flowLayoutPanel21);
            tab_Jun.Controls.Add(flowLayoutPanel22);
            tab_Jun.Controls.Add(flowLayoutPanel23);
            tab_Jun.Controls.Add(flowLayoutPanel24);
            tab_Jun.Controls.Add(flowLayoutPanel25);
            tab_Jun.Location = new Point(4, 29);
            tab_Jun.Margin = new Padding(3, 4, 3, 4);
            tab_Jun.Name = "tab_Jun";
            tab_Jun.Size = new Size(897, 459);
            tab_Jun.TabIndex = 5;
            tab_Jun.Text = "June";
            tab_Jun.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel21
            // 
            flowLayoutPanel21.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel21.Location = new Point(7, 383);
            flowLayoutPanel21.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel21.Name = "flowLayoutPanel21";
            flowLayoutPanel21.Size = new Size(882, 63);
            flowLayoutPanel21.TabIndex = 9;
            // 
            // flowLayoutPanel22
            // 
            flowLayoutPanel22.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel22.Location = new Point(7, 292);
            flowLayoutPanel22.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel22.Name = "flowLayoutPanel22";
            flowLayoutPanel22.Size = new Size(882, 63);
            flowLayoutPanel22.TabIndex = 8;
            // 
            // flowLayoutPanel23
            // 
            flowLayoutPanel23.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel23.Location = new Point(8, 192);
            flowLayoutPanel23.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel23.Name = "flowLayoutPanel23";
            flowLayoutPanel23.Size = new Size(882, 63);
            flowLayoutPanel23.TabIndex = 7;
            // 
            // flowLayoutPanel24
            // 
            flowLayoutPanel24.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel24.Location = new Point(8, 96);
            flowLayoutPanel24.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel24.Name = "flowLayoutPanel24";
            flowLayoutPanel24.Size = new Size(882, 63);
            flowLayoutPanel24.TabIndex = 6;
            // 
            // flowLayoutPanel25
            // 
            flowLayoutPanel25.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel25.Location = new Point(7, 8);
            flowLayoutPanel25.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel25.Name = "flowLayoutPanel25";
            flowLayoutPanel25.Size = new Size(882, 63);
            flowLayoutPanel25.TabIndex = 5;
            // 
            // tab_Jul
            // 
            tab_Jul.Controls.Add(flowLayoutPanel26);
            tab_Jul.Controls.Add(flowLayoutPanel27);
            tab_Jul.Controls.Add(flowLayoutPanel28);
            tab_Jul.Controls.Add(flowLayoutPanel29);
            tab_Jul.Controls.Add(flowLayoutPanel30);
            tab_Jul.Location = new Point(4, 29);
            tab_Jul.Margin = new Padding(3, 4, 3, 4);
            tab_Jul.Name = "tab_Jul";
            tab_Jul.Size = new Size(897, 459);
            tab_Jul.TabIndex = 6;
            tab_Jul.Text = "July";
            tab_Jul.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel26
            // 
            flowLayoutPanel26.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel26.Location = new Point(7, 383);
            flowLayoutPanel26.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel26.Name = "flowLayoutPanel26";
            flowLayoutPanel26.Size = new Size(882, 63);
            flowLayoutPanel26.TabIndex = 9;
            // 
            // flowLayoutPanel27
            // 
            flowLayoutPanel27.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel27.Location = new Point(7, 292);
            flowLayoutPanel27.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel27.Name = "flowLayoutPanel27";
            flowLayoutPanel27.Size = new Size(882, 63);
            flowLayoutPanel27.TabIndex = 8;
            // 
            // flowLayoutPanel28
            // 
            flowLayoutPanel28.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel28.Location = new Point(8, 192);
            flowLayoutPanel28.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel28.Name = "flowLayoutPanel28";
            flowLayoutPanel28.Size = new Size(882, 63);
            flowLayoutPanel28.TabIndex = 7;
            // 
            // flowLayoutPanel29
            // 
            flowLayoutPanel29.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel29.Location = new Point(8, 96);
            flowLayoutPanel29.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel29.Name = "flowLayoutPanel29";
            flowLayoutPanel29.Size = new Size(882, 63);
            flowLayoutPanel29.TabIndex = 6;
            // 
            // flowLayoutPanel30
            // 
            flowLayoutPanel30.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel30.Location = new Point(7, 8);
            flowLayoutPanel30.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel30.Name = "flowLayoutPanel30";
            flowLayoutPanel30.Size = new Size(882, 63);
            flowLayoutPanel30.TabIndex = 5;
            // 
            // tab_Aug
            // 
            tab_Aug.Location = new Point(4, 29);
            tab_Aug.Margin = new Padding(3, 4, 3, 4);
            tab_Aug.Name = "tab_Aug";
            tab_Aug.Size = new Size(897, 459);
            tab_Aug.TabIndex = 7;
            tab_Aug.Text = "August";
            tab_Aug.UseVisualStyleBackColor = true;
            // 
            // tab_Sep
            // 
            tab_Sep.Location = new Point(4, 29);
            tab_Sep.Margin = new Padding(3, 4, 3, 4);
            tab_Sep.Name = "tab_Sep";
            tab_Sep.Size = new Size(897, 459);
            tab_Sep.TabIndex = 8;
            tab_Sep.Text = "September";
            tab_Sep.UseVisualStyleBackColor = true;
            // 
            // tab_Oct
            // 
            tab_Oct.Location = new Point(4, 29);
            tab_Oct.Margin = new Padding(3, 4, 3, 4);
            tab_Oct.Name = "tab_Oct";
            tab_Oct.Size = new Size(897, 459);
            tab_Oct.TabIndex = 9;
            tab_Oct.Text = "October";
            tab_Oct.UseVisualStyleBackColor = true;
            // 
            // tab_Nov
            // 
            tab_Nov.Location = new Point(4, 29);
            tab_Nov.Margin = new Padding(3, 4, 3, 4);
            tab_Nov.Name = "tab_Nov";
            tab_Nov.Size = new Size(897, 459);
            tab_Nov.TabIndex = 10;
            tab_Nov.Text = "November";
            tab_Nov.UseVisualStyleBackColor = true;
            // 
            // tab_Dec
            // 
            tab_Dec.Location = new Point(4, 29);
            tab_Dec.Margin = new Padding(3, 4, 3, 4);
            tab_Dec.Name = "tab_Dec";
            tab_Dec.Size = new Size(897, 459);
            tab_Dec.TabIndex = 11;
            tab_Dec.Text = "December";
            tab_Dec.UseVisualStyleBackColor = true;
            // 
            // Diary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(914, 600);
            Controls.Add(tab_Diary);
            Controls.Add(menu);
            Margin = new Padding(3, 4, 3, 4);
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
            tab_Jun.ResumeLayout(false);
            tab_Jul.ResumeLayout(false);
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
        private TabPage tab_Jun;
        private TabPage tab_Jul;
        private TabPage tab_Aug;
        private TabPage tab_Sep;
        private TabPage tab_Oct;
        private TabPage tab_Nov;
        private TabPage tab_Dec;
        private FlowLayoutPanel flow_5;
        private FlowLayoutPanel flow_4;
        private FlowLayoutPanel flow_3;
        private FlowLayoutPanel flow_2;
        private FlowLayoutPanel flow_1;
        private FlowLayoutPanel flow_10;
        private FlowLayoutPanel flow_9;
        private FlowLayoutPanel flow_8;
        private FlowLayoutPanel flow_7;
        private FlowLayoutPanel flow_6;
        private FlowLayoutPanel flowLayoutPanel6;
        private FlowLayoutPanel flowLayoutPanel7;
        private FlowLayoutPanel flowLayoutPanel8;
        private FlowLayoutPanel flowLayoutPanel9;
        private FlowLayoutPanel flowLayoutPanel10;
        private FlowLayoutPanel flowLayoutPanel11;
        private FlowLayoutPanel flowLayoutPanel12;
        private FlowLayoutPanel flowLayoutPanel13;
        private FlowLayoutPanel flowLayoutPanel14;
        private FlowLayoutPanel flowLayoutPanel15;
        private FlowLayoutPanel flowLayoutPanel16;
        private FlowLayoutPanel flowLayoutPanel17;
        private FlowLayoutPanel flowLayoutPanel18;
        private FlowLayoutPanel flowLayoutPanel19;
        private FlowLayoutPanel flowLayoutPanel20;
        private FlowLayoutPanel flowLayoutPanel21;
        private FlowLayoutPanel flowLayoutPanel22;
        private FlowLayoutPanel flowLayoutPanel23;
        private FlowLayoutPanel flowLayoutPanel24;
        private FlowLayoutPanel flowLayoutPanel25;
        private FlowLayoutPanel flowLayoutPanel26;
        private FlowLayoutPanel flowLayoutPanel27;
        private FlowLayoutPanel flowLayoutPanel28;
        private FlowLayoutPanel flowLayoutPanel29;
        private FlowLayoutPanel flowLayoutPanel30;
    }
}