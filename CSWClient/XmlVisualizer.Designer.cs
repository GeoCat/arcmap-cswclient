﻿namespace ArcMapAddin1
{
    partial class XmlVisualizerWin
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
            this.tviewXml = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tviewXml
            // 
            this.tviewXml.Location = new System.Drawing.Point(13, 13);
            this.tviewXml.Name = "tviewXml";
            this.tviewXml.Size = new System.Drawing.Size(259, 237);
            this.tviewXml.TabIndex = 0;
            // 
            // XmlVisualizerWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tviewXml);
            this.Name = "XmlVisualizerWin";
            this.Text = "XmlVisualizer";
            this.Shown += new System.EventHandler(this.XmlVisualizerWin_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tviewXml;
    }
}