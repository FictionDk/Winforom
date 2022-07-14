using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormDemo.Core;


namespace WinFormDemo{
    public partial class Form1 : Form{

        private ComUtil comUtil = new ComUtil();

        public Form1(){
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "HELLO Lable";
            Action<object> action = (object obj) => {
                label1.Text = comUtil.GetValueFromCom1();
            };
            Task t1 = new Task(action, "aplpha");
            t1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
