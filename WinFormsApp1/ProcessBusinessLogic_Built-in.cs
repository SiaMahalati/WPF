using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
   public class ProcessBusinessLogic_Built_in
    {
        // declaring an event using built-in EventHandler
        public event EventHandler<bool> ProcessCompleted;

        public void StartProcess()
        {
            try
            {
                Console.WriteLine("Process Started!");

                // some code here..

                OnProcessCompleted(true);
            }
            catch (Exception ex)
            {
                OnProcessCompleted(false);
            }
        }

        protected virtual void OnProcessCompleted(bool IsSuccessful)
        {
            ProcessCompleted?.Invoke(this, IsSuccessful);
        }
    }
}
