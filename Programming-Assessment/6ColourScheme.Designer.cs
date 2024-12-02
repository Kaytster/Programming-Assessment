namespace Programming_Assessment
{
    partial class Theme
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
            btn_Default = new Button();
            btn_Dark = new Button();
            btn_Light = new Button();
            SuspendLayout();
            // 
            // btn_Default
            // 
            btn_Default.Location = new Point(37, 23);
            btn_Default.Name = "btn_Default";
            btn_Default.Size = new Size(115, 117);
            btn_Default.TabIndex = 0;
            btn_Default.Text = "Default";
            btn_Default.UseVisualStyleBackColor = true;
            // 
            // btn_Dark
            // 
            btn_Dark.Location = new Point(184, 23);
            btn_Dark.Name = "btn_Dark";
            btn_Dark.Size = new Size(112, 117);
            btn_Dark.TabIndex = 1;
            btn_Dark.Text = "Dark Mode";
            btn_Dark.UseVisualStyleBackColor = true;
            btn_Dark.Click += btn_Dark_Click;
            // 
            // btn_Light
            // 
            btn_Light.Location = new Point(324, 23);
            btn_Light.Name = "btn_Light";
            btn_Light.Size = new Size(117, 117);
            btn_Light.TabIndex = 2;
            btn_Light.Text = "Light Mode";
            btn_Light.UseVisualStyleBackColor = true;
            // 
            // Theme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Light);
            Controls.Add(btn_Dark);
            Controls.Add(btn_Default);
            Name = "Theme";
            Text = "Theme";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Default;
        private Button btn_Dark;
        private Button btn_Light;
    }
}