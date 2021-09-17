using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Suma;
using Suma.Commands.RelayCommands;

namespace Suma.ViewModel.SumaViewModel
{
    class SumaViewModel 
    {
        private SumaViewModel variable1 = new SumaViewModel();
        int variableX, variableY;

        public RelayCommand addNew { get; set; }

     
    private SumaModelo resultado;
    
    public SumaModelo Resultado
        {
            get { return resultado; }
            set { }
        }

    }
}
