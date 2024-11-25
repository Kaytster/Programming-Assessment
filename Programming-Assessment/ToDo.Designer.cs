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
            label2 = new Label();
            SuspendLayout();
            // 
            // chk_List
            // 
            chk_List.FormattingEnabled = true;
            chk_List.Items.AddRange(new object[] { "hello", "task1" });
            chk_List.Location = new Point(12, 105);
            chk_List.Name = "chk_List";
            chk_List.Size = new Size(330, 576);
            chk_List.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(109, 64);
            label1.Name = "label1";
            label1.Size = new Size(141, 38);
            label1.TabIndex = 1;
            label1.Text = "To-Do List";
            // 
            // btn_AddTask
            // 
            btn_AddTask.Location = new Point(438, 105);
            btn_AddTask.Name = "btn_AddTask";
            btn_AddTask.Size = new Size(227, 111);
            btn_AddTask.TabIndex = 2;
            btn_AddTask.Text = "Add Task";
            btn_AddTask.UseVisualStyleBackColor = true;
            btn_AddTask.Click += btn_AddTask_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(691, 481);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // ToDo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(775, 692);
            Controls.Add(label2);
            Controls.Add(btn_AddTask);
            Controls.Add(label1);
            Controls.Add(chk_List);
            Name = "ToDo";
            Text = "ToDo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox chk_List;
        private Label label1;
        private Button btn_AddTask;
        private Label label2;
    }
}