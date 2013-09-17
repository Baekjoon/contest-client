using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Web.Script.Serialization;
using System.IO;
using System.Web;

namespace BaekjoonOnlineJudge
{
    public partial class ProblemForm : Form
    {

        private BackgroundWorker backgroundWorker;
        private BackgroundWorker titleBackgroundWorker;
        private const int CONTEST_INFO = 1;
        private const int CONTEST_SUBMIT = 2;
        private const int CONTEST_STATUS = 3;
        private Dictionary<string, object> contest;
        private DateTime server_time;
        private TimeSpan server_diff;
        private System.Timers.Timer contestStatusUpdateTimer;
        private ArrayList languages, problems;
        private int contest_status = -1;
        private ArrayList solutionWatch = new ArrayList();
        private System.Timers.Timer solutionWatchTimer;
        private Dictionary<int,string> solution_problem = new Dictionary<int,string>();
        private Dictionary<int,string> solution_language = new Dictionary<int,string>();
        private Dictionary<int, string> solution_key = new Dictionary<int, string>();
        bool updating = false;
        public ProblemForm()
        {
            InitializeComponent();
            this.FormClosing += ProblemForm_FormClosing;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProblemForm_FormClosed);
            backgroundWorker = new BackgroundWorker();
            //backgroundWorker.WorkerReportsProgress = true;
            //backgroundWorker.WorkerSupportsCancellation = true;
            //backgroundWorker.ProgressChanged += backgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            Dictionary<string, object> d = new Dictionary<string, object>();
            d["what"] = CONTEST_INFO;
            backgroundWorker.RunWorkerAsync(d);
        }

        void ProblemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("종료할까요?", "종료", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Dictionary<string, object> d = (Dictionary<string, object>)e.Argument;
            int what = (int)d["what"];
            if (what == CONTEST_INFO)
            {
                MyWebRequest loginRequest = new MyWebRequest("https://www.acmicpc.net/client/contest", "POST", String.Format("login_key={0}", Info.login_key));
                string response = loginRequest.GetResponse();
                Console.WriteLine(response);
                var dict = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(response);
                dict["what"] = what;
                e.Result = dict;
            }
            else if (what == CONTEST_SUBMIT)
            {
                MyWebRequest loginRequest = new MyWebRequest("https://www.acmicpc.net/client/submit", "POST", String.Format("login_key={0}&contest_id={1}&contest_number={2}&language={3}&source={4}", Info.login_key,d["contest_id"],d["contest_number"],d["language"],d["source"]));
                string response = loginRequest.GetResponse();
                Console.WriteLine(response);
                var dict = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(response);
                dict["what"] = what;
                dict["problem_title"] = d["problem_title"];
                dict["language_name"] = d["language_name"];
                e.Result = dict;
            }
            else if (what == CONTEST_STATUS)
            {
                updating = true;
                MyWebRequest loginRequest = new MyWebRequest("https://www.acmicpc.net/client/status", "POST", String.Format("login_key={0}&solution_id={1}&key={2}", Info.login_key,d["solution_id"],d["key"]));
                string response = loginRequest.GetResponse();
                Console.WriteLine(response);
                var dict = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(response);
                dict["what"] = what;
                dict["solution_id"] = d["solution_id"];
                e.Result = dict;
            }
        }

        void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Dictionary<string,object> dict = (Dictionary<string,object>)e.Result;
            if ((int)dict["what"] == CONTEST_INFO)
            {
                if ((bool)dict["error"] == true)
                {
                    contestStatusLabel.Text = (string)dict["error_text"];
                }
                else
                {
                    server_time = (new DateTime(1970, 1, 1, 0, 0, 0, 0)).AddSeconds(System.Convert.ToDouble((int)dict["server_time"])).ToLocalTime();
                    server_diff = (DateTime.Now - server_time);
                    contest = (Dictionary<string,object>)dict["contest"];
                    languages = (ArrayList)dict["language"];
                    update_language();
                    problems = (ArrayList)dict["problems"];
                    update_problem();
                    this.Text = String.Format("BOJ Client ({0}) - {1}", Info.user_id, (string)contest["contest_title"]);
                    titleBackgroundWorker = new BackgroundWorker();
                    titleBackgroundWorker.RunWorkerCompleted += titleBackgroundWorker_RunWorkerCompleted;
                    titleBackgroundWorker.DoWork += titleBackgroundWorker_DoWork;
                    titleBackgroundWorker.RunWorkerAsync();
                    contestStatusUpdateTimer = new System.Timers.Timer();
                    contestStatusUpdateTimer.Elapsed += contestStatusUpdateTimer_Elapsed;
                    contestStatusUpdateTimer.Interval = 1000;
                    contestStatusUpdateTimer.Start();
                    solutionWatchTimer = new System.Timers.Timer();
                    solutionWatchTimer.Elapsed += solutionWatchTimer_Elapsed;
                    solutionWatchTimer.Interval = 5000;
                    solutionWatchTimer.Start();
                }
            }
            else if ((int)dict["what"] == CONTEST_SUBMIT)
            {
                if ((bool)dict["error"] == true)
                {
                    MessageBox.Show((string)dict["error_text"]);
                }
                else
                {
                    solutionWatch.Add(dict["solution_id"]);
                    solution_key[(int)dict["solution_id"]] = (string)dict["key"];
                    solution_problem[(int)dict["solution_id"]] = (string)dict["problem_title"];
                    solution_language[(int)dict["solution_id"]] = (string)dict["language_name"];
                    MessageBox.Show(String.Format("제출 확인\n\n문제: {0}\n\n언어: {1}\n\n제출 번호: {2}", dict["problem_title"], dict["language_name"], dict["solution_id"]), "제출 확인", MessageBoxButtons.OK);

                }
            }
            else if ((int)dict["what"] == CONTEST_STATUS)
            {
                if ((bool)dict["error"] == true)
                {
                    solutionWatch.Remove(dict["solution_id"]);
                }
                else
                {
                    if ((int)dict["result_id"] >= 4)
                    {
                        int solution_id = (int)dict["solution_id"];
                        solutionWatch.Remove(dict["solution_id"]);
                        MessageBox.Show(String.Format("채점 결과\n\n문제: {0}\n\n언어: {1}\n\n제출 번호: {2}\n\n\n\n채점 결과: {3}", solution_problem[solution_id], solution_language[solution_id], dict["solution_id"],dict["result_name"]), "채점 결과", MessageBoxButtons.OK);
                    }
                }
                updating = false;
            }
        }

        void titleBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            DateTime current_server_time = DateTime.Now - server_diff;
            DateTime contest_start = DateTime.Parse((string)contest["contest_start"]);
            DateTime contest_end = DateTime.Parse((string)contest["contest_end"]);
            if (current_server_time < contest_start)
            {
                contest_status = -1;
            }
            else if (current_server_time > contest_end)
            {
                contest_status = 1;
            }
            else
            {
                contest_status = 0;
            }
            TimeSpan diff = contest_end - current_server_time;
            string x = "";
            if (contest_status == -1)
            {
                diff = current_server_time - contest_start;
                x += "-";
            }
            else if (contest_status == 0)
            {
                diff = contest_end - current_server_time;
            }
            else
            {
                diff = current_server_time - contest_end;
                x += "+";
            }
            if (diff.Days > 0)
            {
                x += String.Format("{0}일 {1:D2}:{2:D2}:{3:D2}", diff.Days, diff.Hours, diff.Minutes, diff.Seconds);
            }
            else
            {
                x += String.Format("{0:D2}:{1:D2}:{2:D2}", diff.Hours, diff.Minutes, diff.Seconds);
            }
            e.Result = x;
        }

        void titleBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string res = (string)e.Result;
            Action updateLabel = () => contestStatusLabel.Text = res;
            contestStatusLabel.Invoke(updateLabel);
        }

        void solutionWatchTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (solutionWatch.Count > 0 && !updating)
            {
                Dictionary<string, object> d = new Dictionary<string, object>();
                d["what"] = CONTEST_STATUS;
                d["solution_id"] = solutionWatch[0];
                d["key"] = solution_key[(int)solutionWatch[0]];
                backgroundWorker.RunWorkerAsync(d);
            }
        }

        void contestStatusUpdateTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            titleBackgroundWorker.RunWorkerAsync();
        }

        void update_language()
        {
            for (int i = 0; i < languages.Count; i++)
            {
                Dictionary<string, object> d = (Dictionary<string, object>)languages[i];
                languageComboBox.Items.Add(d["language_name"]);
            }
        }

        void update_problem()
        {
            for (int i = 0; i < problems.Count; i++)
            {
                Dictionary<string, object> d = (Dictionary<string, object>)problems[i];
                problemComboBox.Items.Add(String.Format("{0}번. {1}",d["contest_problem_number"],d["title"]));
            }
        }

        void update_contest_status()
        {
            
            
        }
        void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        private void ProblemForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ProblemForm_Load(object sender, EventArgs e)
        {
            problemComboBox.SelectedIndex = 0;
            languageComboBox.SelectedIndex = 0;
            questionProblemComboBox.SelectedIndex = 0;
            updateSubmitButtonStatus();
            additionalFileListView.Clear();
            additionalFileListView.Columns.Add("추가 파일");
            additionalFileListView.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.Text = String.Format("BOJ Client ({0})", Info.user_id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void problemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateSubmitButtonStatus();
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateSubmitButtonStatus();

        }

        private void updateSubmitButtonStatus()
        {
            if (problemComboBox.SelectedIndex == 0 || languageComboBox.SelectedIndex == 0)
            {
                fileSelectButton.Enabled = false;
                submitButton.Enabled = false;
            }
            else
            {
                fileSelectButton.Enabled = true;
                if (fileLocationLabel.Text.Length > 0)
                {
                    submitButton.Enabled = true;
                }
                else
                {
                    submitButton.Enabled = false;
                }
            }
        }

        private void fileSelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            DialogResult result = o.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileLocationLabel.Text = o.FileName;
            }
            updateSubmitButtonStatus();
        }

        private void questionProblemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void questionButton_Click(object sender, EventArgs e)
        {
            if (questionProblemComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("문제를 선택해 주세요");
            }
            else if (questionTextBox.Text.Length == 0)
            {
                MessageBox.Show("질문을 입력해 주세요");
            }
            else
            {
                
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (problemComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("문제를 선택해 주세요");
            }
            else if (languageComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("언어를 선택해 주세요");
            }
            else
            {
                try
                {
                    string source = File.ReadAllText(fileLocationLabel.Text);
                    int size = source.Length;
                    if (size < 2)
                    {
                        MessageBox.Show("소스 코드가 너무 짧아요");
                    }
                    else if (size > 65536)
                    {
                        MessageBox.Show("소스 코드가 너무 길어요");
                    }
                    else
                    {
                        int p = problemComboBox.SelectedIndex - 1;
                        int l = languageComboBox.SelectedIndex - 1;
                        Dictionary<string, object> pd = (Dictionary<string, object>)problems[p];
                        Dictionary<string, object> pl = (Dictionary<string, object>)languages[l];
                        //Console.WriteLine(p + " " + l);
                        source  = HttpUtility.UrlEncode(source);
                        //Console.WriteLine(source);
                        Dictionary<string, object> d = new Dictionary<string, object>();
                        d["what"] = CONTEST_SUBMIT;
                        d["contest_id"] = contest["contest_id"];
                        d["language"] = pl["language_id"];
                        d["contest_number"] = pd["problem_order"];
                        d["source"] = source;
                        d["language_name"] = pl["language_name"];
                        d["problem_title"] = String.Format("{0}번. {1}",pd["contest_problem_number"],pd["title"]);
                        DialogResult res = MessageBox.Show(String.Format("문제: {0}\n\n언어: {1}\n\n파일: {2}\n\n을 제출할까요?", pd["title"], pl["language_name"], fileLocationLabel.Text), "제출 확인", MessageBoxButtons.YesNoCancel);
                        if (res == DialogResult.Yes)
                        {
                            backgroundWorker.RunWorkerAsync(d);
                        }
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("파일을 찾을 수 없습니다");
                }
            }
        }
    }
}