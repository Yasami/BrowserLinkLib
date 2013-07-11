namespace Sample
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.Location = new System.Drawing.Point(124, 10);
			this.button1.Margin = new System.Windows.Forms.Padding(13);
			this.button1.Name = "button1";
			this.button1.Padding = new System.Windows.Forms.Padding(5);
			this.button1.Size = new System.Drawing.Size(75, 38);
			this.button1.TabIndex = 2;
			this.button1.Text = "&Open";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(0, 22);
			this.textBox1.MinimumSize = new System.Drawing.Size(4, 100);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(332, 211);
			this.textBox1.TabIndex = 1;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// button2
			// 
			this.button2.AutoSize = true;
			this.button2.Location = new System.Drawing.Point(231, 10);
			this.button2.Margin = new System.Windows.Forms.Padding(10);
			this.button2.Name = "button2";
			this.button2.Padding = new System.Windows.Forms.Padding(5);
			this.button2.Size = new System.Drawing.Size(75, 38);
			this.button2.TabIndex = 3;
			this.button2.Text = "&Send";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 233);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(332, 61);
			this.panel1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(5);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(2);
			this.label1.Size = new System.Drawing.Size(76, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Message";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(332, 294);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.MinimumSize = new System.Drawing.Size(350, 350);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
	}
}

