using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace AssemblyBrowserLab
{
    internal class AssemblyTreeViewModel
    {
        public AssemblyTreeViewModel() { }

        private string? _assemblyName;
        public string? SourceName
        {
            get { return _assemblyName; }
            set
            {
                if (value == null)
                    return;

                _assemblyName = value;
                MessageBox.Show(_assemblyName);             
            }
        }
    }
}
