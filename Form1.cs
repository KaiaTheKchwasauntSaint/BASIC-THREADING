using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Basic_Threading
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        public void Threads ()
        {
            lblYAY.Text = ("Before Starting Thread");
            Console.WriteLine("-Before Starting Thread-");
            
            MyThreadClass obj = new MyThreadClass(); 
            Thread ThreadA = new Thread(new ThreadStart(obj.Thread1));
            Thread ThreadB = new Thread(new ThreadStart(obj.Thread1));
            

            ThreadA.Priority = ThreadPriority.Highest;
            ThreadA.Name = "Thread A Process";
            ThreadB.Priority = ThreadPriority.Highest;
            ThreadB.Name = "Thread B Process";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            Console.WriteLine("-End of Thread-");
            lblYAY.Text = ("-End of Thread-");



        }

        

        private void btnRun_Click(object sender, EventArgs e)
        {
            Threads();
        }
    }
}
