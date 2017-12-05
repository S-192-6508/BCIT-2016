/*
 * Created by SharpDevelop.
 * User: Павел
 * Date: 03.12.2017
 * Time: 17:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LR4
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button StartScanFile;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textTimer;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button FindMatch;
		private System.Windows.Forms.TextBox MatchingWord;
		private System.Windows.Forms.Button TakePathToFile;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textTimer2;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.CheckBox checkBoxMulti;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.StartScanFile = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textTimer = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.FindMatch = new System.Windows.Forms.Button();
			this.MatchingWord = new System.Windows.Forms.TextBox();
			this.TakePathToFile = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.textTimer2 = new System.Windows.Forms.TextBox();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.checkBoxMulti = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Interval = 100000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(127, 7);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 1;
			// 
			// StartScanFile
			// 
			this.StartScanFile.Location = new System.Drawing.Point(343, 5);
			this.StartScanFile.Name = "StartScanFile";
			this.StartScanFile.Size = new System.Drawing.Size(86, 23);
			this.StartScanFile.TabIndex = 2;
			this.StartScanFile.Text = "Start Scan File";
			this.StartScanFile.UseVisualStyleBackColor = true;
			this.StartScanFile.Click += new System.EventHandler(this.StartScanFileClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Path to Scanning file:";
			// 
			// textTimer
			// 
			this.textTimer.Location = new System.Drawing.Point(127, 33);
			this.textTimer.Name = "textTimer";
			this.textTimer.Size = new System.Drawing.Size(100, 20);
			this.textTimer.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Time of scanning:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(127, 59);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(55, 20);
			this.textBox2.TabIndex = 6;
			this.textBox2.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Uniqe Words Found:";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(127, 86);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(147, 24);
			this.checkBox1.TabIndex = 8;
			this.checkBox1.Text = "Show found uniqe words ";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// FindMatch
			// 
			this.FindMatch.Location = new System.Drawing.Point(233, 116);
			this.FindMatch.Name = "FindMatch";
			this.FindMatch.Size = new System.Drawing.Size(104, 23);
			this.FindMatch.TabIndex = 9;
			this.FindMatch.Text = "Find Match";
			this.FindMatch.UseVisualStyleBackColor = true;
			this.FindMatch.Click += new System.EventHandler(this.FindMatchClick);
			// 
			// MatchingWord
			// 
			this.MatchingWord.Location = new System.Drawing.Point(127, 118);
			this.MatchingWord.Name = "MatchingWord";
			this.MatchingWord.Size = new System.Drawing.Size(100, 20);
			this.MatchingWord.TabIndex = 10;
			this.MatchingWord.TextChanged += new System.EventHandler(this.MatchingWordTextChanged);
			// 
			// TakePathToFile
			// 
			this.TakePathToFile.Location = new System.Drawing.Point(233, 5);
			this.TakePathToFile.Name = "TakePathToFile";
			this.TakePathToFile.Size = new System.Drawing.Size(104, 23);
			this.TakePathToFile.TabIndex = 11;
			this.TakePathToFile.Text = "Chose file to scan";
			this.TakePathToFile.UseVisualStyleBackColor = true;
			this.TakePathToFile.Click += new System.EventHandler(this.TakePathToFileClick);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 146);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 20);
			this.label4.TabIndex = 13;
			this.label4.Text = "Time of scanning:";
			// 
			// textTimer2
			// 
			this.textTimer2.Location = new System.Drawing.Point(127, 146);
			this.textTimer2.Name = "textTimer2";
			this.textTimer2.Size = new System.Drawing.Size(100, 20);
			this.textTimer2.TabIndex = 12;
			// 
			// timer2
			// 
			this.timer2.Interval = 100000;
			this.timer2.Tick += new System.EventHandler(this.Timer2Tick);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(436, 7);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(152, 225);
			this.listBox1.TabIndex = 14;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1SelectedIndexChanged);
			// 
			// checkBoxMulti
			// 
			this.checkBoxMulti.Location = new System.Drawing.Point(234, 35);
			this.checkBoxMulti.Name = "checkBoxMulti";
			this.checkBoxMulti.Size = new System.Drawing.Size(153, 24);
			this.checkBoxMulti.TabIndex = 15;
			this.checkBoxMulti.Text = "take list from multiple files";
			this.checkBoxMulti.UseVisualStyleBackColor = true;
			this.checkBoxMulti.CheckedChanged += new System.EventHandler(this.CheckBoxMultiCheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 239);
			this.Controls.Add(this.checkBoxMulti);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textTimer2);
			this.Controls.Add(this.TakePathToFile);
			this.Controls.Add(this.MatchingWord);
			this.Controls.Add(this.FindMatch);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textTimer);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.StartScanFile);
			this.Controls.Add(this.textBox1);
			this.Name = "MainForm";
			this.Text = "FileReader";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
