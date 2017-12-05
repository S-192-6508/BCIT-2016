using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
namespace LR4
{
	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			InitializeComponent();
								
		}
		string Path;
		List<string> Words = new List<string>();
		
		#region Timers
		TimeSpan currentTimer = new TimeSpan();
		TimeSpan currentTimer2 = new TimeSpan();
		private void RefreshTimer() 
		{  
			textTimer.Text = currentTimer.ToString(); 
		}
		private void RefreshTimer2() 
		{  
			textTimer2.Text = currentTimer2.ToString(); 
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			RefreshTimer();
			RefreshTimer2();
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			currentTimer = currentTimer.Add(new TimeSpan(0, 0, 1));
			RefreshTimer();
		}
		void Timer2Tick(object sender, EventArgs e)
		{
			currentTimer2 = currentTimer2.Add(new TimeSpan(0, 0, 1));
			RefreshTimer2();
		}
		#endregion

		#region Scan
		void TakePathToFileClick(object sender, EventArgs e)
		{
			OpenFileDialog FileDialog = new OpenFileDialog(); 
			FileDialog.Filter = "текстовые файлы|*.txt";
			if(FileDialog.ShowDialog() == DialogResult.OK)
			{
				this.Path=FileDialog.FileName;
				this.textBox1.Text=this.Path;
			}
		}
		
		void StartScanFileClick(object sender, EventArgs e)
		{
			if(Path!=null)
			{
				if(!this.checkBoxMulti.Checked) Words.Clear();
				Stopwatch St1 = new Stopwatch();
				string FileFilling = File.ReadAllText(this.Path);
				St1.Start();
				string[] Words2 = FileFilling.Split(' ','.',',','!','?','/','\t','\n');
				foreach (string strTemp in Words2) 
				{
					string str = strTemp.Trim();
					if (!this.Words.Contains(str))
					{
						this.Words.Add(str);
					}
				}	
				St1.Stop();
				textTimer.Text=St1.Elapsed.ToString();
				if(this.checkBox1.Checked)
				{
					this.listBox1.Items.Clear();
					this.listBox1.BeginUpdate();
					foreach(string str in Words)
					{
						this.listBox1.Items.Add(str);
					}
					this.listBox1.EndUpdate();
				}					
				else
					this.listBox1.Items.Clear();
				this.textBox2.Text = Words.Count.ToString();
			}
			else 
			MessageBox.Show("Chose scaning file!","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);		
		}
		#endregion
		
		#region Empty Elements
		void TextBox2TextChanged(object sender, EventArgs e)
		{
	
		}
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
					
		}
		void MatchingWordTextChanged(object sender, EventArgs e)
		{
	
		}
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void CheckBoxMultiCheckedChanged(object sender, EventArgs e)
		{
	
		}

		#endregion
		
		#region Matcher
		void FindMatchClick(object sender, EventArgs e)
		{
			bool Match=false;
			Stopwatch St2 = new Stopwatch();
			St2.Start();
			foreach(string str in this.Words)
			{ 
				if(String.Equals(str,this.MatchingWord.Text)==true) Match=true;
				
			}
			St2.Stop();
			textTimer2.Text=St2.Elapsed.ToString();
			switch(Match)
			{
					case true:{MessageBox.Show("Match is found.","Match");break;}
					case false:{MessageBox.Show("Match is not found.","Match");break;}
			}
		}

		#endregion
	}
}

