namespace Geometry_Calculator
{
    partial class MainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.StartPage = new System.Windows.Forms.Panel();
            this.StartPageTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AreaBtn = new System.Windows.Forms.Button();
            this.VolumeBtn = new System.Windows.Forms.Button();
            this.PythagorasBtn = new System.Windows.Forms.Button();
            this.StartPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartPage
            // 
            this.StartPage.Controls.Add(this.PythagorasBtn);
            this.StartPage.Controls.Add(this.VolumeBtn);
            this.StartPage.Controls.Add(this.AreaBtn);
            this.StartPage.Controls.Add(this.label2);
            this.StartPage.Controls.Add(this.StartPageTitle);
            this.StartPage.Location = new System.Drawing.Point(8, 4);
            this.StartPage.Name = "StartPage";
            this.StartPage.Size = new System.Drawing.Size(472, 507);
            this.StartPage.TabIndex = 0;
            this.StartPage.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // StartPageTitle
            // 
            this.StartPageTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartPageTitle.AutoSize = true;
            this.StartPageTitle.Font = new System.Drawing.Font("Lato", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartPageTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StartPageTitle.Location = new System.Drawing.Point(72, 5);
            this.StartPageTitle.Name = "StartPageTitle";
            this.StartPageTitle.Size = new System.Drawing.Size(308, 39);
            this.StartPageTitle.TabIndex = 0;
            this.StartPageTitle.Text = "Geometry Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "A Place to Calculate Area, Volume And More";
            // 
            // AreaBtn
            // 
            this.AreaBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AreaBtn.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaBtn.Location = new System.Drawing.Point(135, 156);
            this.AreaBtn.Name = "AreaBtn";
            this.AreaBtn.Size = new System.Drawing.Size(203, 55);
            this.AreaBtn.TabIndex = 2;
            this.AreaBtn.Text = "Calculate Area";
            this.AreaBtn.UseVisualStyleBackColor = true;
            // 
            // VolumeBtn
            // 
            this.VolumeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VolumeBtn.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolumeBtn.Location = new System.Drawing.Point(135, 240);
            this.VolumeBtn.Name = "VolumeBtn";
            this.VolumeBtn.Size = new System.Drawing.Size(203, 55);
            this.VolumeBtn.TabIndex = 3;
            this.VolumeBtn.Text = "Calculate Volume";
            this.VolumeBtn.UseVisualStyleBackColor = true;
            // 
            // PythagorasBtn
            // 
            this.PythagorasBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PythagorasBtn.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PythagorasBtn.Location = new System.Drawing.Point(135, 319);
            this.PythagorasBtn.Name = "PythagorasBtn";
            this.PythagorasBtn.Size = new System.Drawing.Size(203, 55);
            this.PythagorasBtn.TabIndex = 4;
            this.PythagorasBtn.Text = "Pythagoras";
            this.PythagorasBtn.UseVisualStyleBackColor = true;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 523);
            this.Controls.Add(this.StartPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrame";
            this.Text = "Geometry Calculator";
            this.StartPage.ResumeLayout(false);
            this.StartPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StartPage;
        private System.Windows.Forms.Label StartPageTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AreaBtn;
        private System.Windows.Forms.Button PythagorasBtn;
        private System.Windows.Forms.Button VolumeBtn;
    }
}

