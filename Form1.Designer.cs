using RavSoft.GoogleTranslator;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using WinRecognize.Properties;

namespace WinRecognize
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

            this.btnRecordVoice = new System.Windows.Forms.Button();
            this.btnSpeechInfo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRecordVoice
            // 
            this.btnRecordVoice.Location = new System.Drawing.Point(12, 12);
            this.btnRecordVoice.Name = "btnRecordVoice";
            this.btnRecordVoice.Size = new System.Drawing.Size(297, 23);
            this.btnRecordVoice.TabIndex = 0;
            this.btnRecordVoice.Text = "Record Voice";
            this.btnRecordVoice.UseVisualStyleBackColor = true;
            this.btnRecordVoice.Click += new System.EventHandler(this.btnRecordVoice_Click);
            // 
            // btnSpeechInfo
            // 
            this.btnSpeechInfo.Location = new System.Drawing.Point(12, 48);
            this.btnSpeechInfo.Name = "btnSpeechInfo";
            this.btnSpeechInfo.Size = new System.Drawing.Size(297, 34);
            this.btnSpeechInfo.TabIndex = 1;
            this.btnSpeechInfo.Text = "Convert Speech";
            this.btnSpeechInfo.UseVisualStyleBackColor = true;
            this.btnSpeechInfo.Click += new System.EventHandler(this.btnSpeechInfo_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(343, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(273, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 90);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(604, 135);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 274);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 175);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(207, 274);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(198, 175);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(411, 274);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(206, 175);
            this.textBox4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hindi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Urdu";
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tamil";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Translate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this._btnTranslate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSpeechInfo);
            this.Controls.Add(this.btnRecordVoice);
            this.Name = "Form1";
            this.Text = "Speech-Translator";
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecordVoice;
        private System.Windows.Forms.Button btnSpeechInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Button button1;
    }


}

