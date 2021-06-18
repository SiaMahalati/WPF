using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataContextExamples.Models
{
    class DataBaseClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.  
        // The CallerMemberName attribute that is applied to the optional propertyName  
        // parameter causes the property name of the caller to be substituted as an argument.
        public void NotifyPropertyChanged([CallerMemberName] string propName = null)
        {
            //the '?' is a null-conditional operator - Invoke is executed if PropertyChanged is not Null
            //https://www.pluralsight.com/guides/using-conditional-and-null-coalescing-operators
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
