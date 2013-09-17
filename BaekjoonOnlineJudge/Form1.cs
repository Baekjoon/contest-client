using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;

namespace BaekjoonOnlineJudge
{
    public partial class Form1 : Form
    {
        private bool problem_form_showing = false;
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!problem_form_showing)
            {
                DialogResult result = MessageBox.Show("종료할까요?", "종료", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (problem_form_showing)
            {
            }
            else
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Length == 0)
            {
                MessageBox.Show("아이디를 입력해 주세요.");
                usernameTextBox.Focus();
            }
            else if (passwordTextBox.Text.Length == 0)
            {
                MessageBox.Show("비밀번호를 입력해 주세요.");
                passwordTextBox.Focus();
            }
            else
            {
                resultLabel.ForeColor = Color.Black;
                resultLabel.Text = "로그인 중";
                MyWebRequest loginRequest = new MyWebRequest("https://www.acmicpc.net/client/login", "POST", String.Format("username={0}&password={1}", usernameTextBox.Text, passwordTextBox.Text));
                string response = loginRequest.GetResponse();
                var dict = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(response);
                if ((bool)dict["error"] == true)
                {
                    resultLabel.ForeColor = Color.Red;
                    resultLabel.Text = (string)dict["error_text"];
                }
                else
                {
                    Info.login_key = (string)dict["login_key"];
                    Info.user_id = (string)dict["user_id"];
                    resultLabel.Text = "";
                    problem_form_showing = true;
                    this.Close();
                    new ProblemForm().Show();
                }
            }
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                loginButton.PerformClick();
            }
        }
    }
}
