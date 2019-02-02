namespace HeavyProblemsGenerator.Heavy.Frontend.MainForm
{
    partial class HeavyProblemsGenerator
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDestination = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.menuBar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(648, 28);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemDestination});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(44, 24);
            this.fileMenu.Text = "File";
            // 
            // itemDestination
            // 
            this.itemDestination.Name = "itemDestination";
            this.itemDestination.Size = new System.Drawing.Size(211, 26);
            this.itemDestination.Text = "Choose destination";
            this.itemDestination.Click += new System.EventHandler(this.itemDestination_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(20, 34);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(96, 24);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Size [byte]";
            // 
            // txtSize
            // 
            this.txtSize.Enabled = false;
            this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Location = new System.Drawing.Point(122, 30);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(227, 28);
            this.txtSize.TabIndex = 2;
            this.txtSize.TextChanged += new System.EventHandler(this.txtSize_TextChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Enabled = false;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(355, 30);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(122, 30);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.progress);
            this.pnlMain.Controls.Add(this.btnCreate);
            this.pnlMain.Controls.Add(this.txtSize);
            this.pnlMain.Controls.Add(this.lblSize);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 28);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(648, 246);
            this.pnlMain.TabIndex = 4;
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(24, 89);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(453, 47);
            this.progress.TabIndex = 4;
            // 
            // HeavyProblemsGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 274);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "HeavyProblemsGenerator";
            this.Text = "HeavyProblemsGenerator";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem itemDestination;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ProgressBar progress;
    }
}