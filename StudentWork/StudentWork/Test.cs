using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
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
        private void Test_Load(object sender, EventArgs e)
        {
           
            BtnNext.Text = "Следующий вопрос";
            BtnExit.Text = "Выход";
            radioButton1.CheckedChanged += EnableAsync;
            radioButton2.CheckedChanged += EnableAsync;
            radioButton3.CheckedChanged += EnableAsync;
            radioButton4.CheckedChanged += EnableAsync;
            StartQuest();
            Text = string.Format("Работа студента {0} по предмету {1}", NameS, Subject);
        }

        int _count,_trueAns,_falseAns,_index,_checkIndex; 
        public StreamReader _reader;
        string[] _falseArray; 
  
    
        void StartQuest()
        {
            var encode = System.Text.Encoding.GetEncoding(1251);
            try
            {
                _reader = new StreamReader(string.Format("{0}\\{1}.txt", Directory.GetCurrentDirectory(), Subject), encode);
                Text = _reader.ReadLine(); 
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

        public void NextQuest()
        {
            rtb.Text = _reader.ReadLine();
            radioButton1.Text = _reader.ReadLine();
            radioButton2.Text = _reader.ReadLine();
            radioButton3.Text = _reader.ReadLine();
            radioButton4.Text = _reader.ReadLine();
            _index = int.Parse(_reader.ReadLine());
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            BtnNext.Enabled = false;
            _count = _count + 1;
            if (_reader.EndOfStream) BtnNext.Text = "Завершить";
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
                    _reader.Close();
                    radioButton1.Visible = false;
                    radioButton2.Visible = false;
                    radioButton3.Visible = false;
                    radioButton4.Visible = false;
                    var mark = _trueAns*5.0F/_count;
                    rtb.Text = String.Format("Тестирование завершено.\n" +
                                                "Правильных ответов: {0} из {1}.\n" +
                                                "Оценка в пятибальной системе: {2:F2}.", _trueAns,
                        _count, mark);
                    DBUtils.Insert("UPDATE students SET mark='" + mark + "' WHERE name ='"+NameS+"'");
                    BtnNext.Text = "Начать тестирование сначала";
                    var Str = "СПИСОК ВОПРОСОВ, НА КОТОРЫЕ ВЫ ДАЛИ " +
                              "НЕПРАВИЛЬНЫЙ ОТВЕТ:\n\n";
                    for (int i = 1; i <= _falseAns; i++)
                        Str = Str + _falseArray[i] + "\n";
                    if (_falseAns != 0) MessageBox.Show(Str, "Тестирование завершено");
                    break;
            }
            if (BtnNext.Text == "Следующий вопрос") NextQuest();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
