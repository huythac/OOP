namespace ProjectOOP
{
    partial class formHistory
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
            indicator = new Panel();
            statusBar = new Panel();
            SuspendLayout();
            // 
            // indicator
            // 
            indicator.BackgroundImage = Properties.Resources.homeIndicator1;
            indicator.Location = new Point(-3, 767);
            indicator.Margin = new Padding(2, 2, 2, 2);
            indicator.Name = "indicator";
            indicator.Size = new Size(382, 33);
            indicator.TabIndex = 28;
            // 
            // statusBar
            // 
            statusBar.BackgroundImage = Properties.Resources.Status_Bar___iPhone;
            statusBar.Location = new Point(0, 0);
            statusBar.Margin = new Padding(2, 2, 2, 2);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(382, 56);
            statusBar.TabIndex = 20;
            // 
            // formHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 703);
            Controls.Add(statusBar);
            Controls.Add(indicator);
            Margin = new Padding(2, 2, 2, 2);
            Name = "formHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formHistory";
            ResumeLayout(false);
        }

        #endregion

        private Panel indicator;
        private Panel statusBar;
    }
}