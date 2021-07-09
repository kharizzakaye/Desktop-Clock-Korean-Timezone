using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime GetKoreanTime = DateTime.UtcNow;
            GetKoreanTime = GetKoreanTime.AddHours(9);
            label1.Text = GetKoreanTime.ToString("HH:mm");
            label2.Text = GetKoreanTime.ToString("ss");
        }
    }
}
