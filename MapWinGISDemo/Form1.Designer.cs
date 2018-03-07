namespace MapWinGISDemo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolCursor = new System.Windows.Forms.Button();
            this.toolZoomIn = new System.Windows.Forms.Button();
            this.toolZoomOut = new System.Windows.Forms.Button();
            this.toolPan = new System.Windows.Forms.Button();
            this.axMap1 = new AxMapWinGIS.AxMap();
            this.toolZoomExtent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(932, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolCursor
            // 
            this.toolCursor.Location = new System.Drawing.Point(71, 0);
            this.toolCursor.Name = "toolCursor";
            this.toolCursor.Size = new System.Drawing.Size(75, 23);
            this.toolCursor.TabIndex = 1;
            this.toolCursor.Text = "Cursor";
            this.toolCursor.UseVisualStyleBackColor = true;
            this.toolCursor.Click += new System.EventHandler(this.toolCursor_Click);
            // 
            // toolZoomIn
            // 
            this.toolZoomIn.Location = new System.Drawing.Point(351, -4);
            this.toolZoomIn.Name = "toolZoomIn";
            this.toolZoomIn.Size = new System.Drawing.Size(96, 23);
            this.toolZoomIn.TabIndex = 3;
            this.toolZoomIn.Text = "Zoom In";
            this.toolZoomIn.UseVisualStyleBackColor = true;
            this.toolZoomIn.Click += new System.EventHandler(this.toolZoomIn_Click);
            // 
            // toolZoomOut
            // 
            this.toolZoomOut.Location = new System.Drawing.Point(488, -4);
            this.toolZoomOut.Name = "toolZoomOut";
            this.toolZoomOut.Size = new System.Drawing.Size(94, 23);
            this.toolZoomOut.TabIndex = 4;
            this.toolZoomOut.Text = "Zoom Out";
            this.toolZoomOut.UseVisualStyleBackColor = true;
            this.toolZoomOut.Click += new System.EventHandler(this.toolZoomOut_Click);
            // 
            // toolPan
            // 
            this.toolPan.Location = new System.Drawing.Point(657, -4);
            this.toolPan.Name = "toolPan";
            this.toolPan.Size = new System.Drawing.Size(100, 23);
            this.toolPan.TabIndex = 5;
            this.toolPan.Text = "Pan";
            this.toolPan.UseVisualStyleBackColor = true;
            this.toolPan.Click += new System.EventHandler(this.toolPan_Click);
            // 
            // axMap1
            // 
            this.axMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMap1.Enabled = true;
            this.axMap1.Location = new System.Drawing.Point(0, 25);
            this.axMap1.Name = "axMap1";
            this.axMap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMap1.OcxState")));
            this.axMap1.Size = new System.Drawing.Size(932, 468);
            this.axMap1.TabIndex = 6;
            this.axMap1.MouseDownEvent += new AxMapWinGIS._DMapEvents_MouseDownEventHandler(this.axMap1_MouseDownEvent);
            // 
            // toolZoomExtent
            // 
            this.toolZoomExtent.Location = new System.Drawing.Point(183, 0);
            this.toolZoomExtent.Name = "toolZoomExtent";
            this.toolZoomExtent.Size = new System.Drawing.Size(138, 23);
            this.toolZoomExtent.TabIndex = 7;
            this.toolZoomExtent.Text = "Zoom Extent";
            this.toolZoomExtent.UseVisualStyleBackColor = true;
            this.toolZoomExtent.Click += new System.EventHandler(this.toolZoomExtent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 493);
            this.Controls.Add(this.toolZoomExtent);
            this.Controls.Add(this.axMap1);
            this.Controls.Add(this.toolPan);
            this.Controls.Add(this.toolZoomOut);
            this.Controls.Add(this.toolZoomIn);
            this.Controls.Add(this.toolCursor);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button toolCursor;
        private System.Windows.Forms.Button toolZoomIn;
        private System.Windows.Forms.Button toolZoomOut;
        private System.Windows.Forms.Button toolPan;
        private AxMapWinGIS.AxMap axMap1;
        private System.Windows.Forms.Button toolZoomExtent;
    }
}

