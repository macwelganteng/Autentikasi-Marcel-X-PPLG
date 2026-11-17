using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScholAPP2
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Registrasi Gagal! Full name, username dan password wajib diisi..");

                return;
            }


            bool validation = Validation.UniqueData("users", "username", txtUsername.Text);

            if (validation)
            {
                MessageBox.Show("Registrasi Gagal! Username sudah terdaftar!.");

                return;
            }

            string passwordHashed = ScurityHelper.HashingPassword(txtPassword.Text);

            Connection conn = new Connection();

            using (MySqlConnection connection = conn.ConnectionToSQL())
            {
                connection.Open();

                string query = "INSERT INTO users (full_name, username, password) VALUES (@full_name, @user, @pass)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@full_name", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@pass", passwordHashed);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Registrasi Berhasil! Silakan Login.");
            this.Hide();
            FormLogin frmLogin = new FormLogin();
            frmLogin.Show();
        }

        private void txtPassword_Load(object sender, EventArgs e)
        {

        }

        private void txtFulName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNavToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister frmregister = new FormRegister();
            frmregister.Show();
        }
    }
}
