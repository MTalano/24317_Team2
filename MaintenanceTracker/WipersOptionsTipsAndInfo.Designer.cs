﻿namespace MaintenanceTracker
{
    partial class WipersOptionsTipsAndInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WipersOptionsTipsAndInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exitTipsInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wiper Maintenance Tips";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 425);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // exitTipsInfoButton
            // 
            this.exitTipsInfoButton.BackColor = System.Drawing.SystemColors.Control;
            this.exitTipsInfoButton.Location = new System.Drawing.Point(134, 560);
            this.exitTipsInfoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitTipsInfoButton.Name = "exitTipsInfoButton";
            this.exitTipsInfoButton.Size = new System.Drawing.Size(112, 35);
            this.exitTipsInfoButton.TabIndex = 3;
            this.exitTipsInfoButton.Text = "Exit";
            this.exitTipsInfoButton.UseVisualStyleBackColor = false;
            this.exitTipsInfoButton.Click += new System.EventHandler(this.exitTipsInfoButton_Click);
            // 
            // WipersOptionsTipsAndInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(406, 668);
            this.ControlBox = false;
            this.Controls.Add(this.exitTipsInfoButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WipersOptionsTipsAndInfo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "WipersOptionsTipsAndInfo";
            this.Load += new System.EventHandler(this.WipersOptionsTipsAndInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitTipsInfoButton;
    }
}