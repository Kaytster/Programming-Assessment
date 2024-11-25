namespace Programming_Assessment
{
    partial class AddToDo
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
            label1 = new Label();
            txt_Add = new TextBox();
            btn_SubmitTask = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 21);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Add a Task";
            // 
            // txt_Add
            // 
            txt_Add.Location = new Point(67, 44);
            txt_Add.Multiline = true;
            txt_Add.Name = "txt_Add";
            txt_Add.Size = new Size(213, 138);
            txt_Add.TabIndex = 1;
            // 
            // btn_SubmitTask
            // 
            btn_SubmitTask.Location = new Point(122, 206);
            btn_SubmitTask.Name = "btn_SubmitTask";
            btn_SubmitTask.Size = new Size(94, 29);
            btn_SubmitTask.TabIndex = 2;
            btn_SubmitTask.Text = "Submit";
            btn_SubmitTask.UseVisualStyleBackColor = true;
            btn_SubmitTask.Click += btn_SubmitTask_Click_1;
            // 
            // AddToDo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(349, 319);
            Controls.Add(btn_SubmitTask);
            Controls.Add(txt_Add);
            Controls.Add(label1);
            Name = "AddToDo";
            Text = "AddToDo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btn_SubmitTask;
        private TextBox txt_Add;
    }
}