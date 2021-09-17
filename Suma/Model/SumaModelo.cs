using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Suma
{
    public class SumaModelo : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(String PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        private string resultado;
        public string Resultado
        {
            get { return resultado; }
            set
            {
                resultado = value;
                OnPropertyChanged("Resultado");
            }
        }

        private int variableX;

        public int VariableX
        {
            get { return variableX; }
            set 
            { 
                variableX = value;
                OnPropertyChanged("VariableX");
            }
        }

        private int variableY;
        public int VariableY
        {
            get { return variableY; }
            set
            {
                variableY = value;
                OnPropertyChanged("VariableY");
            }
        }

        public void calcular()
        {
            resultado = (variableX + variableY).ToString();
        }
    }
}
