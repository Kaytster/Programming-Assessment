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
            btn_Entry.Location = new Point(694, 13);
            btn_Entry.Name = "btn_Entry";
            btn_Entry.Size = new Size(94, 29);
            btn_Entry.TabIndex = 0;
            btn_Entry.Text = "Add Entry";
            btn_Entry.UseVisualStyleBackColor = true;
            btn_Entry.Click += btn_Entry_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.IndianRed;
            groupBox1.Controls.Add(txt_DiaryText);
            groupBox1.Location = new Point(23, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(654, 391);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txt_DiaryText
            // 
            txt_DiaryText.Location = new Point(6, 23);
            txt_DiaryText.Multiline = true;
            txt_DiaryText.Name = "txt_DiaryText";
            txt_DiaryText.ReadOnly = true;
            txt_DiaryText.Size = new Size(642, 362);
            txt_DiaryText.TabIndex = 0;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.CornflowerBlue;
            btn_Back.Location = new Point(12, 13);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(53, 29);
            btn_Back.TabIndex = 2;
            btn_Back.Text = "<<<";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // lbl_Date
            // 
            lbl_Date.AutoSize = true;
            lbl_Date.Location = new Point(328, 13);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(50, 20);
            lbl_Date.TabIndex = 3;
            lbl_Date.Text = "label1";
            // 
            // DiaryPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Date);
            Controls.Add(btn_Back);
            Controls.Add(groupBox1);
            Controls.Add(btn_Entry);
            Name = "DiaryPage";
            Text = "DiaryPage";
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