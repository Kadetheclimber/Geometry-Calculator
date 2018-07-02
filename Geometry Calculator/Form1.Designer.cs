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
            this.AreaFrame = new System.Windows.Forms.Panel();
            this.VolumeFrame = new System.Windows.Forms.Panel();
            this.VolumeBackBtn = new System.Windows.Forms.Button();
            this.CylinderVolumeBtn = new System.Windows.Forms.Button();
            this.ConeVolumeBtn = new System.Windows.Forms.Button();
            this.SphereVolumeBtn = new System.Windows.Forms.Button();
            this.RectangularPrismVolumeBtn = new System.Windows.Forms.Button();
            this.CubeVolumeBtn = new System.Windows.Forms.Button();
            this.PyramidVolumeBtn = new System.Windows.Forms.Button();
            this.TriangularPrismVolumeBtn = new System.Windows.Forms.Button();
            this.VolumeTitle = new System.Windows.Forms.Label();
            this.AreaBackBtn = new System.Windows.Forms.Button();
            this.CircleAreaBtn = new System.Windows.Forms.Button();
            this.RectangleAreaBtn = new System.Windows.Forms.Button();
            this.SquareAreaBtn = new System.Windows.Forms.Button();
            this.TriangleAreaBtn = new System.Windows.Forms.Button();
            this.AreaTitle = new System.Windows.Forms.Label();
            this.PythagorasBtn = new System.Windows.Forms.Button();
            this.VolumeBtn = new System.Windows.Forms.Button();
            this.AreaBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.StartPageTitle = new System.Windows.Forms.Label();
            this.StartPage.SuspendLayout();
            this.AreaFrame.SuspendLayout();
            this.VolumeFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartPage
            // 
            this.StartPage.Controls.Add(this.PythagorasBtn);
            this.StartPage.Controls.Add(this.VolumeBtn);
            this.StartPage.Controls.Add(this.AreaBtn);
            this.StartPage.Controls.Add(this.label2);
            this.StartPage.Controls.Add(this.StartPageTitle);
            this.StartPage.Controls.Add(this.AreaFrame);
            this.StartPage.Location = new System.Drawing.Point(8, 4);
            this.StartPage.Name = "StartPage";
            this.StartPage.Size = new System.Drawing.Size(472, 507);
            this.StartPage.TabIndex = 0;
            this.StartPage.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AreaFrame
            // 
            this.AreaFrame.Controls.Add(this.AreaBackBtn);
            this.AreaFrame.Controls.Add(this.CircleAreaBtn);
            this.AreaFrame.Controls.Add(this.RectangleAreaBtn);
            this.AreaFrame.Controls.Add(this.SquareAreaBtn);
            this.AreaFrame.Controls.Add(this.TriangleAreaBtn);
            this.AreaFrame.Controls.Add(this.AreaTitle);
            this.AreaFrame.Location = new System.Drawing.Point(0, 0);
            this.AreaFrame.Name = "AreaFrame";
            this.AreaFrame.Size = new System.Drawing.Size(472, 507);
            this.AreaFrame.TabIndex = 1;
            // 
            // VolumeFrame
            // 
            this.VolumeFrame.Controls.Add(this.VolumeBackBtn);
            this.VolumeFrame.Controls.Add(this.CylinderVolumeBtn);
            this.VolumeFrame.Controls.Add(this.ConeVolumeBtn);
            this.VolumeFrame.Controls.Add(this.SphereVolumeBtn);
            this.VolumeFrame.Controls.Add(this.RectangularPrismVolumeBtn);
            this.VolumeFrame.Controls.Add(this.CubeVolumeBtn);
            this.VolumeFrame.Controls.Add(this.PyramidVolumeBtn);
            this.VolumeFrame.Controls.Add(this.TriangularPrismVolumeBtn);
            this.VolumeFrame.Controls.Add(this.VolumeTitle);
            this.VolumeFrame.Location = new System.Drawing.Point(8, 4);
            this.VolumeFrame.Name = "VolumeFrame";
            this.VolumeFrame.Size = new System.Drawing.Size(472, 507);
            this.VolumeFrame.TabIndex = 2;
            // 
            // VolumeBackBtn
            // 
            this.VolumeBackBtn.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolumeBackBtn.Location = new System.Drawing.Point(120, 425);
            this.VolumeBackBtn.Name = "VolumeBackBtn";
            this.VolumeBackBtn.Size = new System.Drawing.Size(233, 45);
            this.VolumeBackBtn.TabIndex = 9;
            this.VolumeBackBtn.Text = "Back";
            this.VolumeBackBtn.UseVisualStyleBackColor = true;
            // 
            // CylinderVolumeBtn
            // 
            this.CylinderVolumeBtn.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CylinderVolumeBtn.Location = new System.Drawing.Point(38, 304);
            this.CylinderVolumeBtn.Name = "CylinderVolumeBtn";
            this.CylinderVolumeBtn.Size = new System.Drawing.Size(203, 55);
            this.CylinderVolumeBtn.TabIndex = 8;
            this.CylinderVolumeBtn.Text = "Cylinder";
            this.CylinderVolumeBtn.UseVisualStyleBackColor = true;
            // 
            // ConeVolumeBtn
            // 
            this.ConeVolumeBtn.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConeVolumeBtn.Location = new System.Drawing.Point(247, 243);
            this.ConeVolumeBtn.Name = "ConeVolumeBtn";
            this.ConeVolumeBtn.Size = new System.Drawing.Size(203, 55);
            this.ConeVolumeBtn.TabIndex = 7;
            this.ConeVolumeBtn.Text = "Cone";
            this.ConeVolumeBtn.UseVisualStyleBackColor = true;
            // 
            // SphereVolumeBtn
            // 
            this.SphereVolumeBtn.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SphereVolumeBtn.Location = new System.Drawing.Point(38, 243);
            this.SphereVolumeBtn.Name = "SphereVolumeBtn";
            this.SphereVolumeBtn.Size = new System.Drawing.Size(203, 55);
            this.SphereVolumeBtn.TabIndex = 6;
            this.SphereVolumeBtn.Text = "Sphere";
            this.SphereVolumeBtn.UseVisualStyleBackColor = true;
            // 
            // RectangularPrismVolumeBtn
            // 
            this.RectangularPrismVolumeBtn.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RectangularPrismVolumeBtn.Location = new System.Drawing.Point(247, 182);
            this.RectangularPrismVolumeBtn.Name = "RectangularPrismVolumeBtn";
            this.RectangularPrismVolumeBtn.Size = new System.Drawing.Size(203, 55);
            this.RectangularPrismVolumeBtn.TabIndex = 5;
            this.RectangularPrismVolumeBtn.Text = "Rectgular Prism";
            this.RectangularPrismVolumeBtn.UseVisualStyleBackColor = true;
            // 
            // CubeVolumeBtn
            // 
            this.CubeVolumeBtn.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CubeVolumeBtn.Location = new System.Drawing.Point(38, 182);
            this.CubeVolumeBtn.Name = "CubeVolumeBtn";
            this.CubeVolumeBtn.Size = new System.Drawing.Size(203, 55);
            this.CubeVolumeBtn.TabIndex = 4;
            this.CubeVolumeBtn.Text = "Cube";
            this.CubeVolumeBtn.UseVisualStyleBackColor = true;
            // 
            // PyramidVolumeBtn
            // 
            this.PyramidVolumeBtn.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PyramidVolumeBtn.Location = new System.Drawing.Point(247, 121);
            this.PyramidVolumeBtn.Name = "PyramidVolumeBtn";
            this.PyramidVolumeBtn.Size = new System.Drawing.Size(203, 55);
            this.PyramidVolumeBtn.TabIndex = 2;
            this.PyramidVolumeBtn.Text = "Pyramid";
            this.PyramidVolumeBtn.UseVisualStyleBackColor = true;
            // 
            // TriangularPrismVolumeBtn
            // 
            this.TriangularPrismVolumeBtn.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TriangularPrismVolumeBtn.Location = new System.Drawing.Point(38, 121);
            this.TriangularPrismVolumeBtn.Name = "TriangularPrismVolumeBtn";
            this.TriangularPrismVolumeBtn.Size = new System.Drawing.Size(203, 55);
            this.TriangularPrismVolumeBtn.TabIndex = 1;
            this.TriangularPrismVolumeBtn.Text = "Triangular Prism";
            this.TriangularPrismVolumeBtn.UseVisualStyleBackColor = true;
            // 
            // VolumeTitle
            // 
            this.VolumeTitle.AutoSize = true;
            this.VolumeTitle.Font = new System.Drawing.Font("Lato", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolumeTitle.Location = new System.Drawing.Point(174, 21);
            this.VolumeTitle.Name = "VolumeTitle";
            this.VolumeTitle.Size = new System.Drawing.Size(124, 39);
            this.VolumeTitle.TabIndex = 0;
            this.VolumeTitle.Text = "Volume";
            // 
            // AreaBackBtn
            // 
            this.AreaBackBtn.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaBackBtn.Location = new System.Drawing.Point(120, 425);
            this.AreaBackBtn.Name = "AreaBackBtn";
            this.AreaBackBtn.Size = new System.Drawing.Size(233, 45);
            this.AreaBackBtn.TabIndex = 10;
            this.AreaBackBtn.Text = "Back";
            this.AreaBackBtn.UseVisualStyleBackColor = true;
            // 
            // CircleAreaBtn
            // 
            this.CircleAreaBtn.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CircleAreaBtn.Location = new System.Drawing.Point(135, 308);
            this.CircleAreaBtn.Name = "CircleAreaBtn";
            this.CircleAreaBtn.Size = new System.Drawing.Size(203, 55);
            this.CircleAreaBtn.TabIndex = 5;
            this.CircleAreaBtn.Text = "Circle";
            this.CircleAreaBtn.UseVisualStyleBackColor = true;
            // 
            // RectangleAreaBtn
            // 
            this.RectangleAreaBtn.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RectangleAreaBtn.Location = new System.Drawing.Point(135, 247);
            this.RectangleAreaBtn.Name = "RectangleAreaBtn";
            this.RectangleAreaBtn.Size = new System.Drawing.Size(203, 55);
            this.RectangleAreaBtn.TabIndex = 4;
            this.RectangleAreaBtn.Text = "Rectangle";
            this.RectangleAreaBtn.UseVisualStyleBackColor = true;
            // 
            // SquareAreaBtn
            // 
            this.SquareAreaBtn.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SquareAreaBtn.Location = new System.Drawing.Point(135, 186);
            this.SquareAreaBtn.Name = "SquareAreaBtn";
            this.SquareAreaBtn.Size = new System.Drawing.Size(203, 55);
            this.SquareAreaBtn.TabIndex = 2;
            this.SquareAreaBtn.Text = "Square";
            this.SquareAreaBtn.UseVisualStyleBackColor = true;
            // 
            // TriangleAreaBtn
            // 
            this.TriangleAreaBtn.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TriangleAreaBtn.Location = new System.Drawing.Point(135, 125);
            this.TriangleAreaBtn.Name = "TriangleAreaBtn";
            this.TriangleAreaBtn.Size = new System.Drawing.Size(203, 55);
            this.TriangleAreaBtn.TabIndex = 1;
            this.TriangleAreaBtn.Text = "Triangle";
            this.TriangleAreaBtn.UseVisualStyleBackColor = true;
            // 
            // AreaTitle
            // 
            this.AreaTitle.AutoSize = true;
            this.AreaTitle.Font = new System.Drawing.Font("Lato", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaTitle.Location = new System.Drawing.Point(198, 21);
            this.AreaTitle.Name = "AreaTitle";
            this.AreaTitle.Size = new System.Drawing.Size(83, 39);
            this.AreaTitle.TabIndex = 0;
            this.AreaTitle.Text = "Area";
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
            this.AreaBtn.Click += new System.EventHandler(this.AreaBtn_Click);
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
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 522);
            this.Controls.Add(this.StartPage);
            this.Controls.Add(this.VolumeFrame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrame";
            this.Text = "Geometry Calculator";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.StartPage.ResumeLayout(false);
            this.StartPage.PerformLayout();
            this.AreaFrame.ResumeLayout(false);
            this.AreaFrame.PerformLayout();
            this.VolumeFrame.ResumeLayout(false);
            this.VolumeFrame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StartPage;
        private System.Windows.Forms.Label StartPageTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AreaBtn;
        private System.Windows.Forms.Button PythagorasBtn;
        private System.Windows.Forms.Button VolumeBtn;
        private System.Windows.Forms.Panel AreaFrame;
        private System.Windows.Forms.Label AreaTitle;
        private System.Windows.Forms.Button TriangleAreaBtn;
        private System.Windows.Forms.Button RectangleAreaBtn;
        private System.Windows.Forms.Button SquareAreaBtn;
        private System.Windows.Forms.Button CircleAreaBtn;
        private System.Windows.Forms.Panel VolumeFrame;
        private System.Windows.Forms.Button CylinderVolumeBtn;
        private System.Windows.Forms.Button ConeVolumeBtn;
        private System.Windows.Forms.Button SphereVolumeBtn;
        private System.Windows.Forms.Button RectangularPrismVolumeBtn;
        private System.Windows.Forms.Button CubeVolumeBtn;
        private System.Windows.Forms.Button PyramidVolumeBtn;
        private System.Windows.Forms.Button TriangularPrismVolumeBtn;
        private System.Windows.Forms.Label VolumeTitle;
        private System.Windows.Forms.Button AreaBackBtn;
        private System.Windows.Forms.Button VolumeBackBtn;
    }
}

