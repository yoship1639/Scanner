using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScannerTestForm
{
    public partial class ScannerTest : Form
    {
        Scanner scanner;

        public ScannerTest()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // テキストが変わったらスキャナを再生成
            scanner = new Scanner(textBox1.Text);

            seekLabelChange();
        }

        private void seekLabelChange()
        {
            if (scanner.IsEnd) label2.Text = "EOF";
            else label2.Text = "" + scanner.Seek;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 次のテキストをスキャン
            textBox2.Text = scanner.NextString();
            seekLabelChange();
        }
    }
}
