﻿namespace EducationHelper
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_interval = new System.Windows.Forms.NumericUpDown();
            this.button_settings_ok = new System.Windows.Forms.Button();
            this.button_settings_cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_language = new System.Windows.Forms.ComboBox();
            this.button_load = new System.Windows.Forms.Button();
            this.checkBox_verbs = new System.Windows.Forms.CheckBox();
            this.button_edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_interval)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Interval (min):";
            // 
            // numericUpDown_interval
            // 
            this.numericUpDown_interval.Location = new System.Drawing.Point(88, 64);
            this.numericUpDown_interval.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown_interval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_interval.Name = "numericUpDown_interval";
            this.numericUpDown_interval.Size = new System.Drawing.Size(106, 20);
            this.numericUpDown_interval.TabIndex = 4;
            this.numericUpDown_interval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_settings_ok
            // 
            this.button_settings_ok.Location = new System.Drawing.Point(119, 174);
            this.button_settings_ok.Name = "button_settings_ok";
            this.button_settings_ok.Size = new System.Drawing.Size(75, 23);
            this.button_settings_ok.TabIndex = 5;
            this.button_settings_ok.Text = "Ok";
            this.button_settings_ok.UseVisualStyleBackColor = true;
            this.button_settings_ok.Click += new System.EventHandler(this.button_settings_ok_Click);
            // 
            // button_settings_cancel
            // 
            this.button_settings_cancel.Location = new System.Drawing.Point(19, 174);
            this.button_settings_cancel.Name = "button_settings_cancel";
            this.button_settings_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_settings_cancel.TabIndex = 6;
            this.button_settings_cancel.Text = "Cancel";
            this.button_settings_cancel.UseVisualStyleBackColor = true;
            this.button_settings_cancel.Click += new System.EventHandler(this.button_settings_cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Langueage:";
            // 
            // comboBox_language
            // 
            this.comboBox_language.FormattingEnabled = true;
            this.comboBox_language.Location = new System.Drawing.Point(88, 96);
            this.comboBox_language.Name = "comboBox_language";
            this.comboBox_language.Size = new System.Drawing.Size(106, 21);
            this.comboBox_language.TabIndex = 9;
            this.comboBox_language.SelectedIndexChanged += new System.EventHandler(this.comboBox_language_SelectedIndexChanged);
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(19, 1);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(175, 23);
            this.button_load.TabIndex = 10;
            this.button_load.Text = "Load questions";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Visible = false;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // checkBox_verbs
            // 
            this.checkBox_verbs.AutoSize = true;
            this.checkBox_verbs.Location = new System.Drawing.Point(19, 133);
            this.checkBox_verbs.Name = "checkBox_verbs";
            this.checkBox_verbs.Size = new System.Drawing.Size(94, 17);
            this.checkBox_verbs.TabIndex = 12;
            this.checkBox_verbs.Text = "Irregular Verbs";
            this.checkBox_verbs.UseVisualStyleBackColor = true;
            this.checkBox_verbs.CheckedChanged += new System.EventHandler(this.checkBox_verbs_CheckedChanged);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(19, 21);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(175, 23);
            this.button_edit.TabIndex = 13;
            this.button_edit.Text = "Edit questions";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 209);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.checkBox_verbs);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.comboBox_language);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_settings_cancel);
            this.Controls.Add(this.button_settings_ok);
            this.Controls.Add(this.numericUpDown_interval);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_interval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_interval;
        private System.Windows.Forms.Button button_settings_ok;
        private System.Windows.Forms.Button button_settings_cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_language;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.CheckBox checkBox_verbs;
        public System.Windows.Forms.Button button_edit;
    }
}