using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUseDelegate_Click(object sender, EventArgs e)
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += ProcessCompletedHandler; // register with an event
            bl.StartProcess();
        }

        // event handler
        public static void ProcessCompletedHandler()
        {
            Debug.WriteLine("Process Completed!");
        }

        private void btnUseBuiltin_Click(object sender, EventArgs e)
        {
            ProcessBusinessLogic_Built_in bl = new ProcessBusinessLogic_Built_in();
            bl.ProcessCompleted += builtin_ProcessCompleted; // register with an event
            bl.StartProcess();
        }

        // event handler
        public static void builtin_ProcessCompleted(object sender, bool IsSuccessful)
        {
            Debug.WriteLine("Process " + (IsSuccessful ? "Completed Successfully" : "failed"));
        }
    }
}
