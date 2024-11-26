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
            flow_J5 = new FlowLayoutPanel();
            button29 = new Button();
            button30 = new Button();
            button31 = new Button();
            flow_J4 = new FlowLayoutPanel();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            button25 = new Button();
            button26 = new Button();
            button27 = new Button();
            button28 = new Button();
            flow_J3 = new FlowLayoutPanel();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            flow_J2 = new FlowLayoutPanel();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            flow_J1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            tab_Feb = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
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
            flow_J5.SuspendLayout();
            flow_J4.SuspendLayout();
            flow_J3.SuspendLayout();
            flow_J2.SuspendLayout();
            flow_J1.SuspendLayout();
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
            tab_Jan.Controls.Add(flow_J5);
            tab_Jan.Controls.Add(flow_J4);
            tab_Jan.Controls.Add(flow_J3);
            tab_Jan.Controls.Add(flow_J2);
            tab_Jan.Controls.Add(flow_J1);
            tab_Jan.Location = new Point(4, 24);
            tab_Jan.Name = "tab_Jan";
            tab_Jan.Padding = new Padding(3);
            tab_Jan.Size = new Size(784, 341);
            tab_Jan.TabIndex = 0;
            tab_Jan.Text = "January";
            tab_Jan.UseVisualStyleBackColor = true;
            tab_Jan.Click += tabPage1_Click;
            // 
            // flow_J5
            // 
            flow_J5.BorderStyle = BorderStyle.FixedSingle;
            flow_J5.Controls.Add(button29);
            flow_J5.Controls.Add(button30);
            flow_J5.Controls.Add(button31);
            flow_J5.Location = new Point(6, 287);
            flow_J5.Name = "flow_J5";
            flow_J5.Size = new Size(772, 48);
            flow_J5.TabIndex = 4;
            // 
            // button29
            // 
            button29.Location = new Point(3, 3);
            button29.Name = "button29";
            button29.Size = new Size(104, 44);
            button29.TabIndex = 7;
            button29.Text = "button29";
            button29.UseVisualStyleBackColor = true;
            // 
            // button30
            // 
            button30.Location = new Point(113, 3);
            button30.Name = "button30";
            button30.Size = new Size(104, 44);
            button30.TabIndex = 8;
            button30.Text = "button30";
            button30.UseVisualStyleBackColor = true;
            // 
            // button31
            // 
            button31.Location = new Point(223, 3);
            button31.Name = "button31";
            button31.Size = new Size(104, 44);
            button31.TabIndex = 9;
            button31.Text = "button31";
            button31.UseVisualStyleBackColor = true;
            // 
            // flow_J4
            // 
            flow_J4.BorderStyle = BorderStyle.FixedSingle;
            flow_J4.Controls.Add(button22);
            flow_J4.Controls.Add(button23);
            flow_J4.Controls.Add(button24);
            flow_J4.Controls.Add(button25);
            flow_J4.Controls.Add(button26);
            flow_J4.Controls.Add(button27);
            flow_J4.Controls.Add(button28);
            flow_J4.Location = new Point(6, 219);
            flow_J4.Name = "flow_J4";
            flow_J4.Size = new Size(772, 48);
            flow_J4.TabIndex = 3;
            // 
            // button22
            // 
            button22.Location = new Point(3, 3);
            button22.Name = "button22";
            button22.Size = new Size(104, 44);
            button22.TabIndex = 7;
            button22.Text = "button22";
            button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            button23.Location = new Point(113, 3);
            button23.Name = "button23";
            button23.Size = new Size(104, 44);
            button23.TabIndex = 8;
            button23.Text = "button23";
            button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            button24.Location = new Point(223, 3);
            button24.Name = "button24";
            button24.Size = new Size(104, 44);
            button24.TabIndex = 9;
            button24.Text = "button24";
            button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            button25.Location = new Point(333, 3);
            button25.Name = "button25";
            button25.Size = new Size(104, 44);
            button25.TabIndex = 10;
            button25.Text = "button25";
            button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            button26.Location = new Point(443, 3);
            button26.Name = "button26";
            button26.Size = new Size(104, 44);
            button26.TabIndex = 11;
            button26.Text = "button26";
            button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            button27.Location = new Point(553, 3);
            button27.Name = "button27";
            button27.Size = new Size(104, 44);
            button27.TabIndex = 12;
            button27.Text = "button27";
            button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            button28.Location = new Point(663, 3);
            button28.Name = "button28";
            button28.Size = new Size(104, 44);
            button28.TabIndex = 13;
            button28.Text = "button28";
            button28.UseVisualStyleBackColor = true;
            // 
            // flow_J3
            // 
            flow_J3.BorderStyle = BorderStyle.FixedSingle;
            flow_J3.Controls.Add(button15);
            flow_J3.Controls.Add(button16);
            flow_J3.Controls.Add(button17);
            flow_J3.Controls.Add(button18);
            flow_J3.Controls.Add(button19);
            flow_J3.Controls.Add(button20);
            flow_J3.Controls.Add(button21);
            flow_J3.Location = new Point(7, 144);
            flow_J3.Name = "flow_J3";
            flow_J3.Size = new Size(772, 48);
            flow_J3.TabIndex = 2;
            // 
            // button15
            // 
            button15.Location = new Point(3, 3);
            button15.Name = "button15";
            button15.Size = new Size(104, 44);
            button15.TabIndex = 7;
            button15.Text = "button15";
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.Location = new Point(113, 3);
            button16.Name = "button16";
            button16.Size = new Size(104, 44);
            button16.TabIndex = 8;
            button16.Text = "button16";
            button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Location = new Point(223, 3);
            button17.Name = "button17";
            button17.Size = new Size(104, 44);
            button17.TabIndex = 9;
            button17.Text = "button17";
            button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Location = new Point(333, 3);
            button18.Name = "button18";
            button18.Size = new Size(104, 44);
            button18.TabIndex = 10;
            button18.Text = "button18";
            button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            button19.Location = new Point(443, 3);
            button19.Name = "button19";
            button19.Size = new Size(104, 44);
            button19.TabIndex = 11;
            button19.Text = "button19";
            button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            button20.Location = new Point(553, 3);
            button20.Name = "button20";
            button20.Size = new Size(104, 44);
            button20.TabIndex = 12;
            button20.Text = "button20";
            button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            button21.Location = new Point(663, 3);
            button21.Name = "button21";
            button21.Size = new Size(104, 44);
            button21.TabIndex = 13;
            button21.Text = "button21";
            button21.UseVisualStyleBackColor = true;
            // 
            // flow_J2
            // 
            flow_J2.BorderStyle = BorderStyle.FixedSingle;
            flow_J2.Controls.Add(button8);
            flow_J2.Controls.Add(button9);
            flow_J2.Controls.Add(button10);
            flow_J2.Controls.Add(button11);
            flow_J2.Controls.Add(button12);
            flow_J2.Controls.Add(button13);
            flow_J2.Controls.Add(button14);
            flow_J2.Location = new Point(7, 72);
            flow_J2.Name = "flow_J2";
            flow_J2.Size = new Size(772, 48);
            flow_J2.TabIndex = 1;
            // 
            // button8
            // 
            button8.Location = new Point(3, 3);
            button8.Name = "button8";
            button8.Size = new Size(104, 44);
            button8.TabIndex = 7;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(113, 3);
            button9.Name = "button9";
            button9.Size = new Size(104, 44);
            button9.TabIndex = 8;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(223, 3);
            button10.Name = "button10";
            button10.Size = new Size(104, 44);
            button10.TabIndex = 9;
            button10.Text = "button10";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(333, 3);
            button11.Name = "button11";
            button11.Size = new Size(104, 44);
            button11.TabIndex = 10;
            button11.Text = "button11";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(443, 3);
            button12.Name = "button12";
            button12.Size = new Size(104, 44);
            button12.TabIndex = 11;
            button12.Text = "button12";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(553, 3);
            button13.Name = "button13";
            button13.Size = new Size(104, 44);
            button13.TabIndex = 12;
            button13.Text = "button13";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(663, 3);
            button14.Name = "button14";
            button14.Size = new Size(104, 44);
            button14.TabIndex = 13;
            button14.Text = "button14";
            button14.UseVisualStyleBackColor = true;
            // 
            // flow_J1
            // 
            flow_J1.BorderStyle = BorderStyle.FixedSingle;
            flow_J1.Controls.Add(button1);
            flow_J1.Controls.Add(button2);
            flow_J1.Controls.Add(button3);
            flow_J1.Controls.Add(button4);
            flow_J1.Controls.Add(button5);
            flow_J1.Controls.Add(button6);
            flow_J1.Controls.Add(button7);
            flow_J1.Location = new Point(6, 6);
            flow_J1.Name = "flow_J1";
            flow_J1.Size = new Size(772, 48);
            flow_J1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(104, 44);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(113, 3);
            button2.Name = "button2";
            button2.Size = new Size(104, 44);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(223, 3);
            button3.Name = "button3";
            button3.Size = new Size(104, 44);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(333, 3);
            button4.Name = "button4";
            button4.Size = new Size(104, 44);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(443, 3);
            button5.Name = "button5";
            button5.Size = new Size(104, 44);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(553, 3);
            button6.Name = "button6";
            button6.Size = new Size(104, 44);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(663, 3);
            button7.Name = "button7";
            button7.Size = new Size(104, 44);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            // 
            // tab_Feb
            // 
            tab_Feb.Controls.Add(flowLayoutPanel1);
            tab_Feb.Controls.Add(flowLayoutPanel2);
            tab_Feb.Controls.Add(flowLayoutPanel3);
            tab_Feb.Controls.Add(flowLayoutPanel4);
            tab_Feb.Controls.Add(flowLayoutPanel5);
            tab_Feb.Location = new Point(4, 24);
            tab_Feb.Name = "tab_Feb";
            tab_Feb.Padding = new Padding(3);
            tab_Feb.Size = new Size(784, 341);
            tab_Feb.TabIndex = 1;
            tab_Feb.Text = "February";
            tab_Feb.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Location = new Point(6, 287);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(772, 48);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel2.Location = new Point(6, 219);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(772, 48);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel3.Location = new Point(7, 144);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(772, 48);
            flowLayoutPanel3.TabIndex = 7;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel4.Location = new Point(7, 72);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(772, 48);
            flowLayoutPanel4.TabIndex = 6;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel5.Location = new Point(6, 6);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(772, 48);
            flowLayoutPanel5.TabIndex = 5;
            // 
            // tab_Mar
            // 
            tab_Mar.Controls.Add(flowLayoutPanel6);
            tab_Mar.Controls.Add(flowLayoutPanel7);
            tab_Mar.Controls.Add(flowLayoutPanel8);
            tab_Mar.Controls.Add(flowLayoutPanel9);
            tab_Mar.Controls.Add(flowLayoutPanel10);
            tab_Mar.Location = new Point(4, 24);
            tab_Mar.Name = "tab_Mar";
            tab_Mar.Size = new Size(784, 341);
            tab_Mar.TabIndex = 2;
            tab_Mar.Text = "March";
            tab_Mar.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel6.Location = new Point(6, 287);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(772, 48);
            flowLayoutPanel6.TabIndex = 9;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel7.Location = new Point(6, 219);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(772, 48);
            flowLayoutPanel7.TabIndex = 8;
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel8.Location = new Point(7, 144);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(772, 48);
            flowLayoutPanel8.TabIndex = 7;
            // 
            // flowLayoutPanel9
            // 
            flowLayoutPanel9.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel9.Location = new Point(7, 72);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Size = new Size(772, 48);
            flowLayoutPanel9.TabIndex = 6;
            // 
            // flowLayoutPanel10
            // 
            flowLayoutPanel10.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel10.Location = new Point(6, 6);
            flowLayoutPanel10.Name = "flowLayoutPanel10";
            flowLayoutPanel10.Size = new Size(772, 48);
            flowLayoutPanel10.TabIndex = 5;
            // 
            // tab_Apr
            // 
            tab_Apr.Controls.Add(flowLayoutPanel11);
            tab_Apr.Controls.Add(flowLayoutPanel12);
            tab_Apr.Controls.Add(flowLayoutPanel13);
            tab_Apr.Controls.Add(flowLayoutPanel14);
            tab_Apr.Controls.Add(flowLayoutPanel15);
            tab_Apr.Location = new Point(4, 24);
            tab_Apr.Name = "tab_Apr";
            tab_Apr.Size = new Size(784, 341);
            tab_Apr.TabIndex = 3;
            tab_Apr.Text = "April";
            tab_Apr.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel11
            // 
            flowLayoutPanel11.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel11.Location = new Point(6, 287);
            flowLayoutPanel11.Name = "flowLayoutPanel11";
            flowLayoutPanel11.Size = new Size(772, 48);
            flowLayoutPanel11.TabIndex = 9;
            // 
            // flowLayoutPanel12
            // 
            flowLayoutPanel12.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel12.Location = new Point(6, 219);
            flowLayoutPanel12.Name = "flowLayoutPanel12";
            flowLayoutPanel12.Size = new Size(772, 48);
            flowLayoutPanel12.TabIndex = 8;
            // 
            // flowLayoutPanel13
            // 
            flowLayoutPanel13.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel13.Location = new Point(7, 144);
            flowLayoutPanel13.Name = "flowLayoutPanel13";
            flowLayoutPanel13.Size = new Size(772, 48);
            flowLayoutPanel13.TabIndex = 7;
            // 
            // flowLayoutPanel14
            // 
            flowLayoutPanel14.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel14.Location = new Point(7, 72);
            flowLayoutPanel14.Name = "flowLayoutPanel14";
            flowLayoutPanel14.Size = new Size(772, 48);
            flowLayoutPanel14.TabIndex = 6;
            // 
            // flowLayoutPanel15
            // 
            flowLayoutPanel15.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel15.Location = new Point(6, 6);
            flowLayoutPanel15.Name = "flowLayoutPanel15";
            flowLayoutPanel15.Size = new Size(772, 48);
            flowLayoutPanel15.TabIndex = 5;
            // 
            // tab_May
            // 
            tab_May.Controls.Add(flowLayoutPanel16);
            tab_May.Controls.Add(flowLayoutPanel17);
            tab_May.Controls.Add(flowLayoutPanel18);
            tab_May.Controls.Add(flowLayoutPanel19);
            tab_May.Controls.Add(flowLayoutPanel20);
            tab_May.Location = new Point(4, 24);
            tab_May.Name = "tab_May";
            tab_May.Size = new Size(784, 341);
            tab_May.TabIndex = 4;
            tab_May.Text = "May";
            tab_May.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel16
            // 
            flowLayoutPanel16.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel16.Location = new Point(6, 287);
            flowLayoutPanel16.Name = "flowLayoutPanel16";
            flowLayoutPanel16.Size = new Size(772, 48);
            flowLayoutPanel16.TabIndex = 9;
            // 
            // flowLayoutPanel17
            // 
            flowLayoutPanel17.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel17.Location = new Point(6, 219);
            flowLayoutPanel17.Name = "flowLayoutPanel17";
            flowLayoutPanel17.Size = new Size(772, 48);
            flowLayoutPanel17.TabIndex = 8;
            // 
            // flowLayoutPanel18
            // 
            flowLayoutPanel18.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel18.Location = new Point(7, 144);
            flowLayoutPanel18.Name = "flowLayoutPanel18";
            flowLayoutPanel18.Size = new Size(772, 48);
            flowLayoutPanel18.TabIndex = 7;
            // 
            // flowLayoutPanel19
            // 
            flowLayoutPanel19.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel19.Location = new Point(7, 72);
            flowLayoutPanel19.Name = "flowLayoutPanel19";
            flowLayoutPanel19.Size = new Size(772, 48);
            flowLayoutPanel19.TabIndex = 6;
            // 
            // flowLayoutPanel20
            // 
            flowLayoutPanel20.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel20.Location = new Point(6, 6);
            flowLayoutPanel20.Name = "flowLayoutPanel20";
            flowLayoutPanel20.Size = new Size(772, 48);
            flowLayoutPanel20.TabIndex = 5;
            // 
            // tab_Jun
            // 
            tab_Jun.Controls.Add(flowLayoutPanel21);
            tab_Jun.Controls.Add(flowLayoutPanel22);
            tab_Jun.Controls.Add(flowLayoutPanel23);
            tab_Jun.Controls.Add(flowLayoutPanel24);
            tab_Jun.Controls.Add(flowLayoutPanel25);
            tab_Jun.Location = new Point(4, 24);
            tab_Jun.Name = "tab_Jun";
            tab_Jun.Size = new Size(784, 341);
            tab_Jun.TabIndex = 5;
            tab_Jun.Text = "June";
            tab_Jun.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel21
            // 
            flowLayoutPanel21.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel21.Location = new Point(6, 287);
            flowLayoutPanel21.Name = "flowLayoutPanel21";
            flowLayoutPanel21.Size = new Size(772, 48);
            flowLayoutPanel21.TabIndex = 9;
            // 
            // flowLayoutPanel22
            // 
            flowLayoutPanel22.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel22.Location = new Point(6, 219);
            flowLayoutPanel22.Name = "flowLayoutPanel22";
            flowLayoutPanel22.Size = new Size(772, 48);
            flowLayoutPanel22.TabIndex = 8;
            // 
            // flowLayoutPanel23
            // 
            flowLayoutPanel23.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel23.Location = new Point(7, 144);
            flowLayoutPanel23.Name = "flowLayoutPanel23";
            flowLayoutPanel23.Size = new Size(772, 48);
            flowLayoutPanel23.TabIndex = 7;
            // 
            // flowLayoutPanel24
            // 
            flowLayoutPanel24.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel24.Location = new Point(7, 72);
            flowLayoutPanel24.Name = "flowLayoutPanel24";
            flowLayoutPanel24.Size = new Size(772, 48);
            flowLayoutPanel24.TabIndex = 6;
            // 
            // flowLayoutPanel25
            // 
            flowLayoutPanel25.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel25.Location = new Point(6, 6);
            flowLayoutPanel25.Name = "flowLayoutPanel25";
            flowLayoutPanel25.Size = new Size(772, 48);
            flowLayoutPanel25.TabIndex = 5;
            // 
            // tab_Jul
            // 
            tab_Jul.Controls.Add(flowLayoutPanel26);
            tab_Jul.Controls.Add(flowLayoutPanel27);
            tab_Jul.Controls.Add(flowLayoutPanel28);
            tab_Jul.Controls.Add(flowLayoutPanel29);
            tab_Jul.Controls.Add(flowLayoutPanel30);
            tab_Jul.Location = new Point(4, 24);
            tab_Jul.Name = "tab_Jul";
            tab_Jul.Size = new Size(784, 341);
            tab_Jul.TabIndex = 6;
            tab_Jul.Text = "July";
            tab_Jul.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel26
            // 
            flowLayoutPanel26.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel26.Location = new Point(6, 287);
            flowLayoutPanel26.Name = "flowLayoutPanel26";
            flowLayoutPanel26.Size = new Size(772, 48);
            flowLayoutPanel26.TabIndex = 9;
            // 
            // flowLayoutPanel27
            // 
            flowLayoutPanel27.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel27.Location = new Point(6, 219);
            flowLayoutPanel27.Name = "flowLayoutPanel27";
            flowLayoutPanel27.Size = new Size(772, 48);
            flowLayoutPanel27.TabIndex = 8;
            // 
            // flowLayoutPanel28
            // 
            flowLayoutPanel28.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel28.Location = new Point(7, 144);
            flowLayoutPanel28.Name = "flowLayoutPanel28";
            flowLayoutPanel28.Size = new Size(772, 48);
            flowLayoutPanel28.TabIndex = 7;
            // 
            // flowLayoutPanel29
            // 
            flowLayoutPanel29.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel29.Location = new Point(7, 72);
            flowLayoutPanel29.Name = "flowLayoutPanel29";
            flowLayoutPanel29.Size = new Size(772, 48);
            flowLayoutPanel29.TabIndex = 6;
            // 
            // flowLayoutPanel30
            // 
            flowLayoutPanel30.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel30.Location = new Point(6, 6);
            flowLayoutPanel30.Name = "flowLayoutPanel30";
            flowLayoutPanel30.Size = new Size(772, 48);
            flowLayoutPanel30.TabIndex = 5;
            // 
            // tab_Aug
            // 
            tab_Aug.Location = new Point(4, 24);
            tab_Aug.Name = "tab_Aug";
            tab_Aug.Size = new Size(784, 341);
            tab_Aug.TabIndex = 7;
            tab_Aug.Text = "August";
            tab_Aug.UseVisualStyleBackColor = true;
            // 
            // tab_Sep
            // 
            tab_Sep.Location = new Point(4, 24);
            tab_Sep.Name = "tab_Sep";
            tab_Sep.Size = new Size(784, 341);
            tab_Sep.TabIndex = 8;
            tab_Sep.Text = "September";
            tab_Sep.UseVisualStyleBackColor = true;
            // 
            // tab_Oct
            // 
            tab_Oct.Location = new Point(4, 24);
            tab_Oct.Name = "tab_Oct";
            tab_Oct.Size = new Size(784, 341);
            tab_Oct.TabIndex = 9;
            tab_Oct.Text = "October";
            tab_Oct.UseVisualStyleBackColor = true;
            // 
            // tab_Nov
            // 
            tab_Nov.Location = new Point(4, 24);
            tab_Nov.Name = "tab_Nov";
            tab_Nov.Size = new Size(784, 341);
            tab_Nov.TabIndex = 10;
            tab_Nov.Text = "November";
            tab_Nov.UseVisualStyleBackColor = true;
            // 
            // tab_Dec
            // 
            tab_Dec.Location = new Point(4, 24);
            tab_Dec.Name = "tab_Dec";
            tab_Dec.Size = new Size(784, 341);
            tab_Dec.TabIndex = 11;
            tab_Dec.Text = "December";
            tab_Dec.UseVisualStyleBackColor = true;
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
            menu.ResumeLayout(false);
            menu.PerformLayout();
            tab_Diary.ResumeLayout(false);
            tab_Jan.ResumeLayout(false);
            flow_J5.ResumeLayout(false);
            flow_J4.ResumeLayout(false);
            flow_J3.ResumeLayout(false);
            flow_J2.ResumeLayout(false);
            flow_J1.ResumeLayout(false);
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
        private FlowLayoutPanel flow_J5;
        private FlowLayoutPanel flow_J4;
        private FlowLayoutPanel flow_J3;
        private FlowLayoutPanel flow_J2;
        private FlowLayoutPanel flow_J1;
        private Button button29;
        private Button button30;
        private Button button31;
        private Button button22;
        private Button button23;
        private Button button24;
        private Button button25;
        private Button button26;
        private Button button27;
        private Button button28;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
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