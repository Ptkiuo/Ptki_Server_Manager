namespace server_manager.Properties
{
	// Token: 0x02000004 RID: 4
	public partial class login : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002DA8 File Offset: 0x00000FA8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002DE0 File Offset: 0x00000FE0
		private void InitializeComponent()
		{
			this.button1 = new global::System.Windows.Forms.Button();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.button1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.button1.Location = new global::System.Drawing.Point(0, 176);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(644, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "login";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.textBox1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.textBox1.Location = new global::System.Drawing.Point(0, 157);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(644, 19);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "パスワード";
			this.textBox2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.textBox2.Location = new global::System.Drawing.Point(0, 138);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(644, 19);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "ユーザー名";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(-2, 123);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(212, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "管理者以外の方はこのアプリを閉じてください";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(644, 199);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.button1);
			base.Name = "login";
			this.Text = "サーバー管理ツール";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000011 RID: 17
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Label label1;
	}
}
