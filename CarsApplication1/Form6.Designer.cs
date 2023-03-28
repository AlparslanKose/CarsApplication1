namespace CarsApplication1
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            menuStrip1 = new MenuStrip();
            applicationToolStripMenuItem = new ToolStripMenuItem();
            form2ToolStripMenuItem = new ToolStripMenuItem();
            form3ToolStripMenuItem = new ToolStripMenuItem();
            form4ToolStripMenuItem = new ToolStripMenuItem();
            form5ToolStripMenuItem = new ToolStripMenuItem();
            exitApplicationToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { applicationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            applicationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { form2ToolStripMenuItem, form3ToolStripMenuItem, form4ToolStripMenuItem, form5ToolStripMenuItem, exitApplicationToolStripMenuItem });
            applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            applicationToolStripMenuItem.Size = new Size(100, 24);
            applicationToolStripMenuItem.Text = "Application";
            // 
            // form2ToolStripMenuItem
            // 
            form2ToolStripMenuItem.Name = "form2ToolStripMenuItem";
            form2ToolStripMenuItem.Size = new Size(197, 26);
            form2ToolStripMenuItem.Text = "Goods";
            form2ToolStripMenuItem.Click += form2ToolStripMenuItem_Click;
            // 
            // form3ToolStripMenuItem
            // 
            form3ToolStripMenuItem.Name = "form3ToolStripMenuItem";
            form3ToolStripMenuItem.Size = new Size(197, 26);
            form3ToolStripMenuItem.Text = "Providers";
            form3ToolStripMenuItem.Click += form3ToolStripMenuItem_Click;
            // 
            // form4ToolStripMenuItem
            // 
            form4ToolStripMenuItem.Name = "form4ToolStripMenuItem";
            form4ToolStripMenuItem.Size = new Size(197, 26);
            form4ToolStripMenuItem.Text = "Delivery";
            form4ToolStripMenuItem.Click += form4ToolStripMenuItem_Click;
            // 
            // form5ToolStripMenuItem
            // 
            form5ToolStripMenuItem.Name = "form5ToolStripMenuItem";
            form5ToolStripMenuItem.Size = new Size(197, 26);
            form5ToolStripMenuItem.Text = "Show";
            form5ToolStripMenuItem.Click += form5ToolStripMenuItem_Click;
            // 
            // exitApplicationToolStripMenuItem
            // 
            exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            exitApplicationToolStripMenuItem.Size = new Size(197, 26);
            exitApplicationToolStripMenuItem.Text = "Exit Application";
            exitApplicationToolStripMenuItem.Click += exitApplicationToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(767, 416);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form6";
            Text = "Cars Application";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem applicationToolStripMenuItem;
        private ToolStripMenuItem form2ToolStripMenuItem;
        private ToolStripMenuItem form3ToolStripMenuItem;
        private ToolStripMenuItem form4ToolStripMenuItem;
        private ToolStripMenuItem form5ToolStripMenuItem;
        private ToolStripMenuItem exitApplicationToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}