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
            label1 = new Label();
            btn_ToDo = new Button();
            btn_Diary = new Button();
            btn_Calendar = new Button();
            btn_Notes = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 53);
            label1.Name = "label1";
            label1.Size = new Size(1246, 144);
            label1.TabIndex = 1;
            label1.Text = "Welcome to the Program!\r\nPlease choose an option below to get started.\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_ToDo
            // 
            btn_ToDo.BackColor = Color.LightSteelBlue;
            btn_ToDo.FlatAppearance.BorderColor = Color.DodgerBlue;
            btn_ToDo.FlatAppearance.BorderSize = 2;
            btn_ToDo.FlatStyle = FlatStyle.Flat;
            btn_ToDo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ToDo.ForeColor = Color.DarkSlateBlue;
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
            btn_Diary.BackColor = Color.LightSteelBlue;
            btn_Diary.FlatAppearance.BorderColor = Color.DodgerBlue;
            btn_Diary.FlatAppearance.BorderSize = 2;
            btn_Diary.FlatStyle = FlatStyle.Flat;
            btn_Diary.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Diary.ForeColor = Color.DarkSlateBlue;
            btn_Diary.Location = new Point(345, 245);
            btn_Diary.Name = "btn_Diary";
            btn_Diary.Size = new Size(245, 231);
            btn_Diary.TabIndex = 3;
            btn_Diary.Text = "Diary";
            btn_Diary.UseVisualStyleBackColor = false;
            btn_Diary.Click += btn_Diary_Click;
            // 
            // btn_Calendar
            // 
            btn_Calendar.BackColor = Color.LightSteelBlue;
            btn_Calendar.FlatAppearance.BorderColor = Color.DodgerBlue;
            btn_Calendar.FlatAppearance.BorderSize = 2;
            btn_Calendar.FlatStyle = FlatStyle.Flat;
            btn_Calendar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Calendar.ForeColor = Color.DarkSlateBlue;
            btn_Calendar.Location = new Point(968, 245);
            btn_Calendar.Name = "btn_Calendar";
            btn_Calendar.Size = new Size(245, 231);
            btn_Calendar.TabIndex = 4;
            btn_Calendar.Text = "Calendar";
            btn_Calendar.UseVisualStyleBackColor = false;
            btn_Calendar.Click += btn_Calendar_Click;
            // 
            // btn_Notes
            // 
            btn_Notes.BackColor = Color.LightSteelBlue;
            btn_Notes.FlatAppearance.BorderColor = Color.DodgerBlue;
            btn_Notes.FlatAppearance.BorderSize = 2;
            btn_Notes.FlatStyle = FlatStyle.Flat;
            btn_Notes.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Notes.ForeColor = Color.DarkSlateBlue;
            btn_Notes.Location = new Point(663, 245);
            btn_Notes.Margin = new Padding(3, 4, 3, 4);
            btn_Notes.Name = "btn_Notes";
            btn_Notes.Size = new Size(245, 231);
            btn_Notes.TabIndex = 5;
            btn_Notes.Text = "Notes";
            btn_Notes.UseVisualStyleBackColor = false;
            btn_Notes.Click += btn_Notes_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 213, 255);
            ClientSize = new Size(1236, 684);
            Controls.Add(btn_Notes);
            Controls.Add(btn_Calendar);
            Controls.Add(btn_Diary);
            Controls.Add(btn_ToDo);
            Controls.Add(label1);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btn_ToDo;
        private Button btn_Diary;
        private Button btn_Calendar;
        private Button btn_Notes;
    }
}
