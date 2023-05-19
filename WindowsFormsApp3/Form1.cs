using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp3
{
	public partial class Form1 : Form
	{
		bool rulenum = true;
		List<Control> labels = new List<Control>();
		string Num;
		List<int> Startline;
		Color[,] Colors;
		List<int> line1 = new List<int>(new int[15]);
		List<int> line2 = new List<int>(new int[15]);

		int count = 1;
		bool first = true;
		public Form1()
		{
			InitializeComponent();

			Colors = new Color[15, 14];
			for (int i = 0; i < 15; i++)
				for (int j = 0; j < 14; j++)
					Colors[i, j] = SystemColors.Control; 
		}

		public int check(string rulenum)
		{
			switch (rulenum)
			{
				case "000":
					return Num[7] - 48;
				case "001":
					return Num[6] - 48;
				case "010":
					return Num[5] - 48;
				case "011":
					return Num[4] - 48;
				case "100":
					return Num[3] - 48;
				case "101":
					return Num[2] - 48;
				case "110":
					return Num[1] - 48;
				case "111":
					return Num[0] - 48;
				default:
					return Num[0] - 48;
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			labels[count].Text = count.ToString();
			if (first == true) first = false;
			else for (int i = 0; i < line2.Count; i++) line1[i] = line2[i];
			for (int i = 0; i < line1.Count; i++)
				if (i != 0 && i != line1.Count - 1)
				{
					string Result = "";
					Result = line1[i - 1].ToString() + line1[i].ToString() + line1[i + 1].ToString();
					int result = check(Result);
					line2[i] = result;
					if (line2[i] == 1) Colors[i, count] = Color.Green;
				}
			tabl.Refresh();
			count++;
			if (count == 13) timer1.Stop();
		}

		private void btStart_Click(object sender, EventArgs e)
		{
			if (rulenum)
			{
				labels.Add(lb0);
				labels.Add(lb1);
				labels.Add(lb2);
				labels.Add(lb3);
				labels.Add(lb4);
				labels.Add(lb5);
				labels.Add(lb6);
				labels.Add(lb7);
				labels.Add(lb8);
				labels.Add(lb9);
				labels.Add(lb10);
				labels.Add(lb11);
				labels.Add(lb12);
				tabl.Refresh();
				Num = Convert.ToString((int)edRule.Value, 2);
				if (Num.Length != 8)
				{
					int n = 8 - Num.Length; 
					for (int i = 0; i < n; i++) Num = Num.Insert(0, "0");
					Startline = new List<int>(new int[15]);
					for (int i = 0; i < Startline.Count; i++)
					{
						if (i == 7 || i == 8 || i == 12)
						{
							Startline[i] = 1;
							Colors[i, 0] = Color.Green;
						}
						else Startline[i] = 0;
					}
					for (int i = 0; i < line2.Count; i++) line2[i] = 0;
					tabl.Refresh();
					line1 = Startline;
				}
				rulenum = false;
				if (btStart.Text == "Старт")
				{
					btStart.Text = "Стоп";
					timer1.Start();
				}
				else
				{
					btStart.Text = "Старт";
					timer1.Stop();
				}
				tabl.Refresh();
			}
		}

		private void tabl_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
		{
			if (Colors != null)
			{
				using (var brush = new SolidBrush(Colors[e.Column, e.Row]))
					e.Graphics.FillRectangle(brush, e.CellBounds);
			}
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btClear_Click(object sender, EventArgs e)
		{
            tabl.RowCount = 0;
			if (btStart.Text == "Стоп")
				btStart.Text = "Старт";
			count = 1;
			first = true;
            for (int i = 0; i < 15; i++)
                for (int j = 0; j < 14; j++)
                    Colors[i, j] = SystemColors.Control;
            rulenum = true;
        }
	}
}
