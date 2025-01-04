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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100; //타이머 간격 100ms
            timer1.Start();  //타이머 시작  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            yyyymmdd.Text = DateTime.Now.ToString("F"); // label1에 현재날짜시간 표시, F:자세한 전체 날짜/시간
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void 매출관ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 재고현황ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Check check = new Check();
            check.ShowDialog();
        }

        private void 메뉴추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void 매출현황ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Date date = new Date();
            date.ShowDialog();
        }

        private void 초기화면ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            First first = new First();
            first.ShowDialog();
        }
    }
}
