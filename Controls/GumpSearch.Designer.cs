/***************************************************************************
 *
 * $Author: Turley
 * 
 * "THE BEER-WARE LICENSE"
 * As long as you retain this notice you can do whatever you want with 
 * this stuff. If we meet some day, and you think this stuff is worth it,
 * you can buy me a beer in return.
 *
 ***************************************************************************/

namespace FiddlerControls
{
    partial class GumpSearch
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
            this.textBoxGraphic = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxGraphic
            // 
            this.textBoxGraphic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGraphic.Location = new System.Drawing.Point(18, 12);
            this.textBoxGraphic.Name = "textBoxGraphic";
            this.textBoxGraphic.Size = new System.Drawing.Size(256, 20);
            this.textBoxGraphic.TabIndex = 0;
            this.textBoxGraphic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownSearch);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(101, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SearchId);
            // 
            // GumpSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 73);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxGraphic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "GumpSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gump Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGraphic;
        private System.Windows.Forms.Button button1;
    }
}