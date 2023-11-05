using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace server_manager.Properties
{
	// Token: 0x02000004 RID: 4
	public partial class login : Form
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002D05 File Offset: 0x00000F05
		public login()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002D20 File Offset: 0x00000F20
		private void button1_Click(object sender, EventArgs e)
		{
			bool flag = this.textBox2.Text == "user";
			if (flag)
			{
				bool flag2 = this.textBox1.Text == "admin";
				if (flag2)
				{
					Form1 form = new Form1();
					base.Hide();
					form.Show();
				}
				else
				{
					MessageBox.Show("ユーザー名またはパスワードが間違っています", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			else
			{
				MessageBox.Show("ユーザー名またはパスワードが間違っています", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
	}
}
