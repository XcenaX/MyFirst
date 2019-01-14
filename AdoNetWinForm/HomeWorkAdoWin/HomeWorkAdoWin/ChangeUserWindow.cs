using System;
using System.Data;
using System.Windows.Forms;

namespace HomeWorkAdoWin
{
	public partial class ChangeUserWindow : Form
	{
		private DataTable dataTable = null;
		private Form1 Form = null;
		private int number_Rows = 0;
		public ChangeUserWindow(Form1 form, DataTable dTable, int num)
		{
			InitializeComponent();
			Form = form;
			dataTable = dTable;
			number_Rows = num;
			change.Click += Change_Click;
			delete.Click += Delete_Click;
			textBoxLogo.Text = dTable.Rows[num][1].ToString();
			textBoxPassword.Text = dTable.Rows[num][2].ToString();
			textBoxAdress.Text = dTable.Rows[num][3].ToString();
			textBoxPhone.Text = dTable.Rows[num][4].ToString();
			if (dTable.Rows[num][5].ToString() == "True")
			{
				comboBoxAdmin.SelectedIndex = 0;
			}
			else
			{
				comboBoxAdmin.SelectedIndex = 1;
			}
		}

		private void Cancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Delete_Click(object sender, EventArgs e)
		{
			dataTable.Rows[number_Rows].Delete();
			Form.Updete_teble(dataTable);
			this.DialogResult = DialogResult.OK;
		}

		private void Change_Click(object sender, EventArgs e)
		{
			if (textBoxLogo.Text == "" || textBoxAdress.Text == "" || textBoxPassword.Text == "" ||
				textBoxPhone.Text == "")
			{
				MessageBox.Show("Заполните все поля для изменения!", "Предупреждение", MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
				return;
			}
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				if (dataTable.Rows[number_Rows][1].ToString() == textBoxLogo.Text)
				{
					break;
				}
				if (dataTable.Rows[i][1].ToString().Equals(textBoxLogo.Text))
				{
					MessageBox.Show("Такой Login существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			dataTable.Rows[number_Rows][1] = textBoxLogo.Text.ToString();
			dataTable.Rows[number_Rows][2] = textBoxPassword.Text.ToString();
			dataTable.Rows[number_Rows][3] = textBoxAdress.Text.ToString();
			dataTable.Rows[number_Rows][4] = textBoxPhone.Text.ToString();
			if (comboBoxAdmin.SelectedIndex == 0)
			{
				dataTable.Rows[number_Rows][5] = "True";
			}
			else
			{
				dataTable.Rows[number_Rows][5] = "False";
			}
			Form.Updete_teble(dataTable);
			this.DialogResult = DialogResult.OK;
		}

		private void cancel_Click_1(object sender, EventArgs e)
		{

		}

		private void delete_Click_1(object sender, EventArgs e)
		{

		}

		private void change_Click_1(object sender, EventArgs e)
		{

		}

		private void comboBoxAdmin_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void textBoxPhone_TextChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void textBoxAdress_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void textBoxPassword_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBoxLogo_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
