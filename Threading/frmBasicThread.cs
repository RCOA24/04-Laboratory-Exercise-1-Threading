using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threading
{
    public partial class frmBasicThread : Form
    {
        public frmBasicThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            lblThread.Text = "-Before Starting Thread-";
            Console.WriteLine("-Before Starting Thread-");

            Thread ThreadA = new Thread(MyThreadClass.Thread1);
            Thread ThreadB = new Thread(MyThreadClass.Thread1);
            ThreadA.Name = "Thread A Process";
            ThreadB.Name = "Thread B Process";
            ThreadA.Start();
            ThreadB.Start();
            ThreadA.Join();
            ThreadB.Join();

            Console.WriteLine("-End of Thread-");
            lblThread.Text = "-End of Thread-";
        }

        private void frmBasicThread_Load(object sender, EventArgs e)
        {

        }
    }
}
