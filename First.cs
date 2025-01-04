using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            yyyymmdd.Text = DateTime.Now.ToString("F"); // label1에 현재날짜시간 표시, F:자세한 전체 날짜/시간
        }

        private void First_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100; //타이머 간격 100ms
            timer1.Start();  //타이머 시작  
        }

        private void 종료ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Main main = new Main();
            main.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Date date = new Date();
            date.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Check check = new Check();
            check.ShowDialog();
        }
    }
}
