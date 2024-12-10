namespace Programming_Assessment
{
    partial class AddEntry
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
            rtb_DiaryEntry = new RichTextBox();
            btn_AddEntry = new Button();
            SuspendLayout();
            // 
            // rtb_DiaryEntry
            // 
            rtb_DiaryEntry.Location = new Point(10, 9);
            rtb_DiaryEntry.Margin = new Padding(3, 2, 3, 2);
            rtb_DiaryEntry.Name = "rtb_DiaryEntry";
            rtb_DiaryEntry.Size = new Size(680, 265);
            rtb_DiaryEntry.TabIndex = 0;
            rtb_DiaryEntry.Text = "";
            // 
            // btn_AddEntry
            // 
            btn_AddEntry.Location = new Point(258, 278);
            btn_AddEntry.Margin = new Padding(3, 2, 3, 2);
            btn_AddEntry.Name = "btn_AddEntry";
            btn_AddEntry.Size = new Size(180, 62);
            btn_AddEntry.TabIndex = 1;
            btn_AddEntry.Text = "Add Entry";
            btn_AddEntry.UseVisualStyleBackColor = true;
            btn_AddEntry.Click += btn_AddEntry_Click;
            // 
            // AddEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 213, 255);
            ClientSize = new Size(700, 338);
            Controls.Add(btn_AddEntry);
            Controls.Add(rtb_DiaryEntry);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddEntry";
            Text = "AddEntry";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtb_DiaryEntry;
        private Button btn_AddEntry;
    }
}