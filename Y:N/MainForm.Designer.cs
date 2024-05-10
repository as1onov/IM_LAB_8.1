namespace Lab8._1.YesNo
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.answerBtn = new System.Windows.Forms.Button();
			this.answerLabel = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// answerBtn
			// 
			this.answerBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.answerBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.answerBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.answerBtn.Location = new System.Drawing.Point(192, 101);
			this.answerBtn.Name = "answerBtn";
			this.answerBtn.Size = new System.Drawing.Size(177, 73);
			this.answerBtn.TabIndex = 2;
			this.answerBtn.Text = "Ответ";
			this.answerBtn.UseVisualStyleBackColor = false;
			this.answerBtn.Click += new System.EventHandler(this.answerBtn_Click);
			// 
			// answerLabel
			// 
			this.answerLabel.AutoSize = true;
			this.answerLabel.BackColor = System.Drawing.SystemColors.ControlLight;
			this.answerLabel.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.answerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.answerLabel.Location = new System.Drawing.Point(147, 201);
			this.answerLabel.Name = "answerLabel";
			this.answerLabel.Size = new System.Drawing.Size(0, 111);
			this.answerLabel.TabIndex = 3;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(57, 23);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(470, 40);
			this.textBox1.TabIndex = 4;
			this.textBox1.Text = "Пойти в университет?";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(568, 341);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.answerLabel);
			this.Controls.Add(this.answerBtn);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "YesNo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button answerBtn;
		private System.Windows.Forms.Label answerLabel;
		private System.Windows.Forms.TextBox textBox1;
	}
}

