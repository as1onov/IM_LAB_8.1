using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab8._1.YesNo
{
	public partial class MainForm : Form
	{
		private const double probability = 0.5;
		public MainForm()
		{
			InitializeComponent();
		}

		private void answerBtn_Click(object sender, EventArgs e)
		{
			var rnd = new Random();
			var rndProbability = rnd.NextDouble();

			if (rndProbability < probability)
			{
				answerLabel.Text = "ДА!";
			}
			else
			{
				answerLabel.Text = "НЕТ!";
			}
			answerLabel.BackColor = Color.Blue;
		}
	}
}
