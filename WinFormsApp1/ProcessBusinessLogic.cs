using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WinFormsApp1
{

    public delegate void Notify();  // delegate

    public class ProcessBusinessLogic
    {
        public event Notify ProcessCompleted; // event

        public void StartProcess()
        {
            Debug.WriteLine("Process Started!");
            // some code here..
            OnProcessCompleted();
        }


        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }
    }
}