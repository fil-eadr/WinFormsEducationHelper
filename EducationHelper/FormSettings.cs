﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace EducationHelper
{
    public partial class FormSettings : Form
    {
        SettingsChanger _changer = new SettingsChanger();
        static public event Action LanguageChanged; 


        public FormSettings()
        {
            InitializeComponent();
            SetIcon();
            InitControls();
            _changer.OldInterval = Settings.Interval;
           
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            //this.KeyPreview = true;
            //this.KeyDown += FormSettings_KeyDown;
        }

        private void FormSettings_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode.ToString() == "F1")
            //{
            //    MessageBox.Show("F1 pressed");
            //}
        }

        private void SetIcon()
        {
            if (Settings.Lang == Language.Spanish)
            {
                this.Icon = EducationHelper.Properties.Resources.IconSpain;
                checkBox_verbs.Visible = false;
            }
            else if (Settings.Lang == Language.Italian)
            {
                this.Icon = EducationHelper.Properties.Resources.IconItaly;
                checkBox_verbs.Visible = false;
            }
            else
            {
                this.Icon = EducationHelper.Properties.Resources.IconEnglish;
                checkBox_verbs.Visible = true;
                if (Settings.IsIrVerbs == true)
                {
                    checkBox_verbs.Checked = true;
                }
                else
                {
                    checkBox_verbs.Checked = false;
                }
            }
        }

        void InitControls()
        {
            numericUpDown_interval.Value = Settings.Interval/60000; // to minutes    
            comboBox_language.Items.Add(Language.Spanish);
            comboBox_language.Items.Add(Language.Italian);
            comboBox_language.Items.Add(Language.English);

            switch (EducationHelper.Settings.Lang)
            {
                case Language.Spanish:
                    comboBox_language.SelectedIndex = 0;
                    break;
                case Language.Italian:
                    comboBox_language.SelectedIndex = 1;
                    break;
                case Language.English:
                    comboBox_language.SelectedIndex = 2;
                    break;
                default:
                    comboBox_language.SelectedIndex = 0;
                    break;
            }
        }

        private void button_settings_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                

        private void button_settings_ok_Click(object sender, EventArgs e)
        {            
            try
            {
                if ((int)numericUpDown_interval.Value < 1)
                {
                    MessageBox.Show("Not correct values!");
                    return;
                }
                Settings.Interval = (int)numericUpDown_interval.Value * 60000; //to milliseconds
                WriteSettingsToFile(Settings.Lang.ToString(), numericUpDown_interval.Value);
                _changer.IsIntervalChange();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception from FormSettings. Method button_settings_ok_Click. " + ex.Message);
            }            
        }

        private void WriteSettingsToFile(string language, decimal interval)
        {
            if (!File.Exists("Data\\settings.txt"))
            {
                File.Create("Data\\settings.txt").Close();                
            }
            string settings = $"{language}:{interval.ToString()}" ;
            File.WriteAllText("Data\\settings.txt", settings, Encoding.Default);
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            try
            {
                using (var selectFileDialog = new OpenFileDialog())
                {
                    selectFileDialog.Filter = "Text Files|*.txt;";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception from button_select_Click method. " + ex.Message);
            }
        }
        
        private void comboBox_language_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Lang = (Language)comboBox_language.SelectedItem;
            if (LanguageChanged != null)
            {                
                LanguageChanged();
            }
            if (Settings.Lang == Language.English)
            {
                Settings.IsIrVerbs = true;
                checkBox_verbs.Visible = true;
            }
            else
            {
                Settings.IsIrVerbs = false;
                checkBox_verbs.Visible = false;
            }
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    DirectoryInfo di = new DirectoryInfo(fbd.SelectedPath);
                    FileInfo[] list = di.GetFiles();
                    string destDir = Path.Combine("Data", Settings.Lang == Language.Italian ? "Italian" : "Spain", "Images");
                    foreach (var item in list)
                    {
                        string destPath = Path.Combine(destDir, item.Name);
                        File.Copy(item.FullName, destPath, true);
                    }
                    CreateListToRecord(list, destDir);                    
                }
            }
        }

        private void CreateListToRecord(FileInfo[] list, string pathToDir)
        {
            List<string> strList = new List<string>();
            foreach (var item in list)
            {
                string question = Path.GetFileNameWithoutExtension(item.FullName);
                if (question.Contains("_")) question = question.Replace("_", " ");
                string str = question + " | " + Path.Combine(pathToDir, item.Name);
                strList.Add(str);
            }
            RecToTxt(strList, pathToDir);            
        }

        private void RecToTxt(List<string> strList, string pathToDir)
        {
            string pathToTxtDir = pathToDir.Substring(0, pathToDir.LastIndexOf("\\"));
            string pathToTxt = Path.Combine(pathToTxtDir, "questions.txt");
            File.WriteAllText(pathToTxt, "");
            File.AppendAllLines(pathToTxt, strList, System.Text.Encoding.UTF8);
            MessageBox.Show("Questions list updated. (" + strList.Count + ")", Settings.Lang.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox_verbs_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_verbs.Checked == true)
            {
                Settings.IsIrVerbs = true;
            }
            else
            {
                Settings.IsIrVerbs = false;
            }
            if (LanguageChanged != null)
            {
                LanguageChanged();
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            FormEdit fe = new FormEdit();
            fe.ShowDialog();
        }


    }
}
