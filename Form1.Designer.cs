namespace RedBadgerForms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            maxXCoordinateTextBox = new TextBox();
            XPromptTextBox = new TextBox();
            button1 = new Button();
            YPromptTextBox = new TextBox();
            maxYCoordinateTextBox = new TextBox();
            SuspendLayout();
            // 
            // maxXCoordinateTextBox
            // 
            resources.ApplyResources(maxXCoordinateTextBox, "maxXCoordinateTextBox");
            maxXCoordinateTextBox.Name = "maxXCoordinateTextBox";
            // 
            // XPromptTextBox
            // 
            resources.ApplyResources(XPromptTextBox, "XPromptTextBox");
            XPromptTextBox.Name = "XPromptTextBox";
            XPromptTextBox.ReadOnly = true;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // YPromptTextBox
            // 
            resources.ApplyResources(YPromptTextBox, "YPromptTextBox");
            YPromptTextBox.Name = "YPromptTextBox";
            YPromptTextBox.ReadOnly = true;
            // 
            // maxYCoordinateTextBox
            // 
            resources.ApplyResources(maxYCoordinateTextBox, "maxYCoordinateTextBox");
            maxYCoordinateTextBox.Name = "maxYCoordinateTextBox";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(maxYCoordinateTextBox);
            Controls.Add(YPromptTextBox);
            Controls.Add(button1);
            Controls.Add(XPromptTextBox);
            Controls.Add(maxXCoordinateTextBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox maxXCoordinateTextBox;
        private TextBox XPromptTextBox;
        private Button button1;
        private TextBox YPromptTextBox;
        private TextBox maxYCoordinateTextBox;
    }
}
