using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace LR4
{
	public partial class Form1 : Form
	{
		public Form1(List<string> Words)
		{
			
			Words2 = Words;
			InitializeComponent();

		}
		List<string> Words2 = new List<string>();
		
		#region Empty Elements
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void ComboBox2SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void ListBox2SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
	
		}

		#endregion
		
		#region Search
		void Button1Click(object sender, EventArgs e)
		{	
			if(comboBox1.Text=="") MessageBox.Show("Chose Quantity of treads.","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
			else
			{
				if(comboBox2.Text=="") MessageBox.Show("Chose Distance.","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
				else
				{
					if(textBox1.Text=="") MessageBox.Show("Enter Word.","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
					else
					{
						List<string> Rezult = new List<string>();
						int A = (int.Parse(comboBox1.Text));
						int B = (int.Parse(comboBox2.Text));
						string S = (textBox1.Text);
						Stopwatch St2 = new Stopwatch();
						St2.Start();
						ASearch ASH = new ASearch();
						Rezult = ASH.ASearcher(Words2, A, B, S);
						textBox2.Text=St2.Elapsed.ToString();
						listBox2.BeginUpdate();
						listBox2.Items.Clear();
						foreach(string STR in Rezult)
							listBox2.Items.Add(STR);
						listBox2.EndUpdate();
					}
				}
			}
		}

		#endregion
	}
}
