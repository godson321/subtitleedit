﻿namespace Nikse.SubtitleEdit.Forms
{
    partial class ImportCdg
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
            this.labelFileName = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelDuration = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelProgress = new System.Windows.Forms.Label();
            this.radioButtonBluRaySup = new System.Windows.Forms.RadioButton();
            this.labelProgress2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(12, 18);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(55, 13);
            this.labelFileName.TabIndex = 6;
            this.labelFileName.Text = "File name:";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(15, 135);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(154, 32);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(322, 175);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(12, 39);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(50, 13);
            this.labelDuration.TabIndex = 7;
            this.labelDuration.Text = "Duration:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Target format";
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(15, 170);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(70, 13);
            this.labelProgress.TabIndex = 11;
            this.labelProgress.Text = "labelProgress";
            // 
            // radioButtonBluRaySup
            // 
            this.radioButtonBluRaySup.AutoSize = true;
            this.radioButtonBluRaySup.Checked = true;
            this.radioButtonBluRaySup.Location = new System.Drawing.Point(29, 99);
            this.radioButtonBluRaySup.Name = "radioButtonBluRaySup";
            this.radioButtonBluRaySup.Size = new System.Drawing.Size(200, 17);
            this.radioButtonBluRaySup.TabIndex = 13;
            this.radioButtonBluRaySup.TabStop = true;
            this.radioButtonBluRaySup.Text = "Blu-ray  (.sup) - does not require OCR";
            this.radioButtonBluRaySup.UseVisualStyleBackColor = true;
            // 
            // labelProgress2
            // 
            this.labelProgress2.AutoSize = true;
            this.labelProgress2.Location = new System.Drawing.Point(15, 188);
            this.labelProgress2.Name = "labelProgress2";
            this.labelProgress2.Size = new System.Drawing.Size(76, 13);
            this.labelProgress2.TabIndex = 14;
            this.labelProgress2.Text = "labelProgress2";
            // 
            // ImportCdg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 210);
            this.Controls.Add(this.labelProgress2);
            this.Controls.Add(this.radioButtonBluRaySup);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportCdg";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import CD+G kareoke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.RadioButton radioButtonBluRaySup;
        private System.Windows.Forms.Label labelProgress2;
    }
}