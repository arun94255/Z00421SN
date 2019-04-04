using Microsoft.Practices.Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ModuleA
{
    class ModuleAModule:IModule
    {
        public void Initialize()
        {
            MessageBox.Show("Module Loaded");
        }
    }
}
