﻿namespace CharMapCF
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.mnuExit = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuZoomIn = new System.Windows.Forms.MenuItem();
            this.mnuZoomOut = new System.Windows.Forms.MenuItem();
            this.cboUnicodePlane = new System.Windows.Forms.ComboBox();
            this.cboFont = new System.Windows.Forms.ComboBox();
            this.lblFont = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUniChar = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.mnuBold = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.mnuExit);
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // mnuExit
            // 
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.mnuZoomIn);
            this.menuItem1.MenuItems.Add(this.mnuZoomOut);
            this.menuItem1.MenuItems.Add(this.mnuBold);
            this.menuItem1.Text = "Options";
            // 
            // mnuZoomIn
            // 
            this.mnuZoomIn.Text = "Zoom In";
            this.mnuZoomIn.Click += new System.EventHandler(this.mnuZoomIn_Click);
            // 
            // mnuZoomOut
            // 
            this.mnuZoomOut.Text = "Zoom Out";
            this.mnuZoomOut.Click += new System.EventHandler(this.mnuZoomOut_Click);
            // 
            // cboUnicodePlane
            // 
            this.cboUnicodePlane.Location = new System.Drawing.Point(100, 3);
            this.cboUnicodePlane.Name = "cboUnicodePlane";
            this.cboUnicodePlane.Size = new System.Drawing.Size(73, 22);
            this.cboUnicodePlane.TabIndex = 0;
            this.cboUnicodePlane.SelectedIndexChanged += new System.EventHandler(this.cboUnicodePlane_SelectedIndexChanged);
            // 
            // cboFont
            // 
            this.cboFont.Location = new System.Drawing.Point(3, 28);
            this.cboFont.Name = "cboFont";
            this.cboFont.Size = new System.Drawing.Size(91, 22);
            this.cboFont.TabIndex = 0;
            this.cboFont.SelectedIndexChanged += new System.EventHandler(this.cboFont_SelectedIndexChanged);
            // 
            // lblFont
            // 
            this.lblFont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblFont.Location = new System.Drawing.Point(100, 28);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(102, 22);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.Text = "Unicode Plane:";
            // 
            // txtUniChar
            // 
            this.txtUniChar.Location = new System.Drawing.Point(179, 3);
            this.txtUniChar.Name = "txtUniChar";
            this.txtUniChar.ReadOnly = true;
            this.txtUniChar.Size = new System.Drawing.Size(23, 21);
            this.txtUniChar.TabIndex = 2;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(208, 3);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(22, 21);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "C";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // mnuBold
            // 
            this.mnuBold.Text = "Bold";
            this.mnuBold.Click += new System.EventHandler(this.mnuBold_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.ControlBox = false;
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtUniChar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFont);
            this.Controls.Add(this.cboFont);
            this.Controls.Add(this.cboUnicodePlane);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem mnuExit;
        private System.Windows.Forms.ComboBox cboUnicodePlane;
        private System.Windows.Forms.ComboBox cboFont;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUniChar;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem mnuZoomIn;
        private System.Windows.Forms.MenuItem mnuZoomOut;
        private System.Windows.Forms.MenuItem mnuBold;
    }
}

