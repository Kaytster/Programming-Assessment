namespace Programming_Assessment
{
    partial class DiaryPage
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
            btn_Entry = new Button();
            groupBox1 = new GroupBox();
            txt_DiaryText = new TextBox();
            btn_Back = new Button();
            lbl_Date = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Entry
            // 
            btn_Entry.Location = new Point(607, 10);
            btn_Entry.Margin = new Padding(3, 2, 3, 2);
            btn_Entry.Name = "btn_Entry";
            btn_Entry.Size = new Size(82, 22);
            btn_Entry.TabIndex = 0;
            btn_Entry.Text = "Add Entry";
            btn_Entry.UseVisualStyleBackColor = true;
            btn_Entry.Click += btn_Entry_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.IndianRed;
            groupBox1.Controls.Add(txt_DiaryText);
            groupBox1.Location = new Point(20, 35);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(572, 293);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txt_DiaryText
            // 
            txt_DiaryText.Location = new Point(5, 17);
            txt_DiaryText.Margin = new Padding(3, 2, 3, 2);
            txt_DiaryText.Multiline = true;
            txt_DiaryText.Name = "txt_DiaryText";
            txt_DiaryText.ReadOnly = true;
            txt_DiaryText.Size = new Size(562, 272);
            txt_DiaryText.TabIndex = 0;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.CornflowerBlue;
            btn_Back.Location = new Point(10, 10);
            btn_Back.Margin = new Padding(3, 2, 3, 2);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(46, 22);
            btn_Back.TabIndex = 2;
            btn_Back.Text = "<<<";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // lbl_Date
            // 
            lbl_Date.AutoSize = true;
            lbl_Date.Location = new Point(287, 10);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(38, 15);
            lbl_Date.TabIndex = 3;
            lbl_Date.Text = "label1";
            // 
            // DiaryPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 213, 255);
            ClientSize = new Size(700, 338);
            Controls.Add(lbl_Date);
            Controls.Add(btn_Back);
            Controls.Add(groupBox1);
            Controls.Add(btn_Entry);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DiaryPage";
            Text = "DiaryPage";
            Load += DiaryPage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Entry;
        private GroupBox groupBox1;
        private Button btn_Back;
        private TextBox txt_DiaryText;
        private Label lbl_Date;
    }
}