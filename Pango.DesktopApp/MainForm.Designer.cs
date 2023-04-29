namespace Pango.DesktopApp
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            loginToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            AboutToolStripMenuItem = new ToolStripMenuItem();
            lbSubscriptions = new Label();
            cbSubscription = new ComboBox();
            cbResourceGroup = new ComboBox();
            lbResourceGroup = new Label();
            cbVirtualMachine = new ComboBox();
            lbVirtualMachine = new Label();
            cbBastion = new ComboBox();
            lbBastion = new Label();
            btnConnect = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { loginToolStripMenuItem, logoutToolStripMenuItem, AboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(638, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(116, 20);
            loginToolStripMenuItem.Text = "Login to Azure CLI";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(57, 20);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Visible = false;
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // AboutToolStripMenuItem
            // 
            AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            AboutToolStripMenuItem.Size = new Size(52, 20);
            AboutToolStripMenuItem.Text = "About";
            AboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            // 
            // lbSubscriptions
            // 
            lbSubscriptions.AutoSize = true;
            lbSubscriptions.Location = new Point(12, 24);
            lbSubscriptions.Name = "lbSubscriptions";
            lbSubscriptions.Size = new Size(73, 15);
            lbSubscriptions.TabIndex = 1;
            lbSubscriptions.Text = "Subscription";
            // 
            // cbSubscription
            // 
            cbSubscription.FormattingEnabled = true;
            cbSubscription.Location = new Point(12, 42);
            cbSubscription.Name = "cbSubscription";
            cbSubscription.Size = new Size(302, 23);
            cbSubscription.TabIndex = 2;
            cbSubscription.SelectedIndexChanged += cbSubscription_SelectedIndexChanged;
            // 
            // cbResourceGroup
            // 
            cbResourceGroup.FormattingEnabled = true;
            cbResourceGroup.Location = new Point(324, 42);
            cbResourceGroup.Name = "cbResourceGroup";
            cbResourceGroup.Size = new Size(302, 23);
            cbResourceGroup.TabIndex = 4;
            cbResourceGroup.SelectedIndexChanged += cbResourceGroup_SelectedIndexChanged;
            // 
            // lbResourceGroup
            // 
            lbResourceGroup.AutoSize = true;
            lbResourceGroup.Location = new Point(324, 24);
            lbResourceGroup.Name = "lbResourceGroup";
            lbResourceGroup.Size = new Size(91, 15);
            lbResourceGroup.TabIndex = 3;
            lbResourceGroup.Text = "Resource Group";
            // 
            // cbVirtualMachine
            // 
            cbVirtualMachine.FormattingEnabled = true;
            cbVirtualMachine.Location = new Point(12, 95);
            cbVirtualMachine.Name = "cbVirtualMachine";
            cbVirtualMachine.Size = new Size(302, 23);
            cbVirtualMachine.TabIndex = 6;
            // 
            // lbVirtualMachine
            // 
            lbVirtualMachine.AutoSize = true;
            lbVirtualMachine.Location = new Point(12, 77);
            lbVirtualMachine.Name = "lbVirtualMachine";
            lbVirtualMachine.Size = new Size(90, 15);
            lbVirtualMachine.TabIndex = 5;
            lbVirtualMachine.Text = "Virtual Machine";
            // 
            // cbBastion
            // 
            cbBastion.FormattingEnabled = true;
            cbBastion.Location = new Point(324, 95);
            cbBastion.Name = "cbBastion";
            cbBastion.Size = new Size(302, 23);
            cbBastion.TabIndex = 8;
            // 
            // lbBastion
            // 
            lbBastion.AutoSize = true;
            lbBastion.Location = new Point(324, 77);
            lbBastion.Name = "lbBastion";
            lbBastion.Size = new Size(46, 15);
            lbBastion.TabIndex = 7;
            lbBastion.Text = "Bastion";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(12, 134);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(614, 23);
            btnConnect.TabIndex = 9;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 172);
            Controls.Add(btnConnect);
            Controls.Add(cbBastion);
            Controls.Add(lbBastion);
            Controls.Add(cbVirtualMachine);
            Controls.Add(lbVirtualMachine);
            Controls.Add(cbResourceGroup);
            Controls.Add(lbResourceGroup);
            Controls.Add(cbSubscription);
            Controls.Add(lbSubscriptions);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem AboutToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private Label lbSubscriptions;
        private ComboBox cbSubscription;
        private ComboBox cbResourceGroup;
        private Label lbResourceGroup;
        private ComboBox cbVirtualMachine;
        private Label lbVirtualMachine;
        private ComboBox cbBastion;
        private Label lbBastion;
        private Button btnConnect;
    }
}