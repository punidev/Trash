using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StudentWork
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        public string NameS { get; set; }
        public string Subject { get; set; }
        int _count, _trueAns, _falseAns, _index, _checkIndex;
        public StreamReader Reader;
        public string[] _falseArray;
        private int time = 10;
        private void Test_Load(object sender, EventArgs e)
        {
            rtb.Multiline = true;
            label11.ForeColor = Color.Black;
            label11.BackColor = Color.White;
            timer1.Enabled = true;
            timer1.Start();
            BtnNext.Text = "Следующий вопрос";
            BtnExit.Text = "Выход";
            radioButton1.CheckedChanged += EnableAsync;
            radioButton2.CheckedChanged += EnableAsync;
            radioButton3.CheckedChanged += EnableAsync;
            radioButton4.CheckedChanged += EnableAsync;
            StartQuest();
            Text = string.Format("Работа студента {0} по предмету {1}", NameS, Subject);
        }
        private void StartQuest()
        {
            var encode = System.Text.Encoding.GetEncoding(1251);
            try
            {
                Reader = new StreamReader(string.Format("{0}\\tests\\{1}.txt", Directory.GetCurrentDirectory(), Subject), encode);
                Text = Reader.ReadLine(); 
                _count = 0; _trueAns = 0; _falseAns = 0;
                _falseArray = new string[100];
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            NextQuest();
        }

        private string TextboxMultiline()
        {
            var str = new RichTextBox {Text = Reader.ReadLine()};
            var temp = str.Text;
            var isReplace = false;
            string replace = null;
            foreach (char t in temp)
            {
                if (t != '$' || t != '#') continue;
                rtb.Font = new Font("Courier new",9);
                replace = temp.Replace('$', '\n').Replace('#', '\t');
                isReplace = true;
            }
            return isReplace ? replace : temp;
        }

        public void NextQuest()
        {
            rtb.Text = TextboxMultiline();
            label2.Text = Reader.ReadLine();
            label3.Text = Reader.ReadLine();
            label4.Text = Reader.ReadLine();
            label5.Text = Reader.ReadLine();
            _index = int.Parse(Reader.ReadLine());
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            BtnNext.Enabled = false;
            _count = _count + 1;
            if (Reader.EndOfStream) BtnNext.Text = "Завершить";
        }

        public void EnableAsync(object sender, EventArgs e)
        {
            BtnNext.Enabled = true; BtnNext.Focus();
            var rb = (RadioButton)sender;
            var tmp = rb.Name;
            _checkIndex = int.Parse(tmp.Substring(11));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (_checkIndex == _index) _trueAns = _trueAns + 1;
            if (_checkIndex != _index)
            {
                _falseAns = _falseAns + 1;
                _falseArray[_falseAns] = rtb.Text;
            }
            switch (BtnNext.Text)
            {
                case "Начать тестирование сначала":
                    BtnNext.Text = "Следующий вопрос";
                    radioButton1.Visible = true;
                    radioButton2.Visible = true;
                    radioButton3.Visible = true;
                    radioButton4.Visible = true;
                    StartQuest(); return;
                case "Завершить":
                    CloseAns();
                    break;
            }
            if (BtnNext.Text == "Следующий вопрос") NextQuest();
        }

        private void CloseAns()
        {
            Reader.Close();
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            var mark = _trueAns * 5.0F / _count;
            rtb.Text = string.Format("Тестирование завершено.\n" +
                                        "Правильных ответов: {0} из {1}.\n" +
                                        "Оценка в пятибальной системе: {2:F2}.", _trueAns,
                _count, mark);
            if (!IsOop)
            {
                {
                    DBUtils.Insert(
                                   string.Format(
                                                 "UPDATE studentmark SET mark='{0}' WHERE name ='{1}' AND part='{2}' AND subject='АиСД'",
                                       mark, NameS, Students.AsdObjects[Partof]), DBUtils.Markconn);
                }
            }
            else
            {
                DBUtils.Insert(
                               string.Format(
                                             "UPDATE studentmark SET mark='{0}' WHERE name ='{1}' AND part='{2}' AND subject='ООП'",
                                   mark,
                                   NameS, Students.OopObjects[Partof]), DBUtils.Markconn);
            }
            BtnNext.Text = "Начать тестирование сначала";
            var str = "СПИСОК ВОПРОСОВ, НА КОТОРЫЕ ВЫ ДАЛИ " +
                      "НЕПРАВИЛЬНЫЙ ОТВЕТ:\n\n";
            for (var i = 1; i <= _falseAns; i++)
                str = str + _falseArray[i] + "\n";
            if (_falseAns != 0) MessageBox.Show(str, "Тестирование завершено");
        }

        public bool IsOop { get; set; }
        public int Partof { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = string.Format("Время осталось {0}", time--);
            if (time != 0) return;
            timer1.Stop();
            _trueAns--;
        }
    }
}
