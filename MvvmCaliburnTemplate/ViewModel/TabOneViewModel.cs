using Caliburn.Micro;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCaliburnTemplate.ViewModel
{
    [Export(typeof(IScreen))]
    [ImplementPropertyChanged]
    public class TabOneViewModel : Screen
    {
        public TabOneViewModel()
        {
            DisplayName = "One";
        }
    }
}
