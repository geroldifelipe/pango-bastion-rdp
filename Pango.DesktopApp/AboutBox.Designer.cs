namespace Pango.DesktopApp
{
    partial class AboutBox
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
            panel1 = new Panel();
            panel2 = new Panel();
            tbAzureCliInformation = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lbPangoTitle = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(566, 254);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(tbAzureCliInformation);
            panel2.Location = new Point(3, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(561, 207);
            panel2.TabIndex = 1;
            // 
            // tbAzureCliInformation
            // 
            tbAzureCliInformation.Enabled = false;
            tbAzureCliInformation.Location = new Point(0, 0);
            tbAzureCliInformation.Multiline = true;
            tbAzureCliInformation.Name = "tbAzureCliInformation";
            tbAzureCliInformation.ReadOnly = true;
            tbAzureCliInformation.Size = new Size(556, 202);
            tbAzureCliInformation.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lbPangoTitle);
            flowLayoutPanel1.Location = new Point(2, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(564, 23);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // lbPangoTitle
            // 
            lbPangoTitle.AutoSize = true;
            lbPangoTitle.Location = new Point(3, 0);
            lbPangoTitle.Name = "lbPangoTitle";
            lbPangoTitle.Size = new Size(142, 15);
            lbPangoTitle.TabIndex = 0;
            lbPangoTitle.Text = "Pango Bastion Connector";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Location = new Point(3, 32);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(564, 23);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 1;
            label2.Text = "Azure CLI Information:";
            // 
            // AboutBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 277);
            Controls.Add(panel1);
            Name = "AboutBox";
            Text = "AboutBox";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox tbAzureCliInformation;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lbPangoTitle;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label2;
    }
}