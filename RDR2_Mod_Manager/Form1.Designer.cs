﻿namespace RDR2_Mod_Manager
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.lv_test = new System.Windows.Forms.ListView();
            this.lb_Label = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.btn_changeDir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_directory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lv_test
            // 
            this.lv_test.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lv_test.CheckBoxes = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.lv_test.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.lv_test.HideSelection = false;
            this.lv_test.Location = new System.Drawing.Point(12, 141);
            this.lv_test.Name = "lv_test";
            this.lv_test.Size = new System.Drawing.Size(477, 297);
            this.lv_test.TabIndex = 2;
            this.lv_test.UseCompatibleStateImageBehavior = false;
            this.lv_test.View = System.Windows.Forms.View.List;
            // 
            // lb_Label
            // 
            this.lb_Label.AutoSize = true;
            this.lb_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Label.Location = new System.Drawing.Point(12, 88);
            this.lb_Label.Name = "lb_Label";
            this.lb_Label.Size = new System.Drawing.Size(111, 25);
            this.lb_Label.TabIndex = 3;
            this.lb_Label.Text = "Game Files";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(414, 31);
            this.Title.TabIndex = 4;
            this.Title.Text = "RDR2 File Manager by Jacob450";
            // 
            // btn_changeDir
            // 
            this.btn_changeDir.Location = new System.Drawing.Point(368, 112);
            this.btn_changeDir.Name = "btn_changeDir";
            this.btn_changeDir.Size = new System.Drawing.Size(121, 26);
            this.btn_changeDir.TabIndex = 5;
            this.btn_changeDir.Text = "Change Directory";
            this.btn_changeDir.UseVisualStyleBackColor = true;
            this.btn_changeDir.Click += new System.EventHandler(this.btn_changeDir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Directory:";
            // 
            // lbl_directory
            // 
            this.lbl_directory.AutoSize = true;
            this.lbl_directory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_directory.Location = new System.Drawing.Point(67, 123);
            this.lbl_directory.Name = "lbl_directory";
            this.lbl_directory.Size = new System.Drawing.Size(18, 15);
            this.lbl_directory.TabIndex = 7;
            this.lbl_directory.Text = "C:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_directory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_changeDir);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.lb_Label);
            this.Controls.Add(this.lv_test);
            this.Name = "Form1";
            this.Text = "RDR2 File Manager by Jacob450";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lv_test;
        private System.Windows.Forms.Label lb_Label;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btn_changeDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_directory;
    }
}

