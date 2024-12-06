using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_implementacion_EESA.VistaModelo
{
    internal class VMCalculadora : BaseViewModel
    {
        #region VARIABLES
        double _numero1;
        double _numero2;
        double _resultado;
        bool _esSuma;
        bool _esResta;
        bool _esMultiplicacion;
        bool _esDivision;
        #endregion

        #region CONTRUCTOR
        public VMCalculadora(INavigation navigation)
        {
            Navigation = navigation;
            CalcularCommand = new Command(Calcular);
        }
        #endregion

        #region OBJETOS
        public double Numero1
        {
            get { return _numero1; }
            set { SetValue(ref _numero1, value); }
        }

        public double Numero2
        {
            get { return _numero2; }
            set { SetValue(ref _numero2, value); }
        }

        public double Resultado
        {
            get { return _resultado; }
            set { SetValue(ref _resultado, value); }
        }

        public bool EsSuma
        {
            get { return _esSuma; }
            set { SetValue(ref _esSuma, value); }
        }

        public bool EsResta
        {
            get { return _esResta; }
            set { SetValue(ref _esResta, value); }
        }

        public bool EsMultiplicacion
        {
            get { return _esMultiplicacion; }
            set { SetValue(ref _esMultiplicacion, value); }
        }

        public bool EsDivision
        {
            get { return _esDivision; }
            set { SetValue(ref _esDivision, value); }
        }
        #endregion

        #region COMANDO
        public ICommand CalcularCommand { get; set; }

        private void Calcular()
        {
            if (EsSuma)
            {
                Resultado = Numero1 + Numero2;
            }
            else if (EsResta)
            {
                Resultado = Numero1 - Numero2;
            }
            else if (EsMultiplicacion)
            {
                Resultado = Numero1 * Numero2;
            }
            else if (EsDivision)
            {
                if (Numero2 != 0)
                {
                    Resultado = Numero1 / Numero2;
                }
                else
                {
                    Resultado = 0;
                }
            }
        }
        #endregion
    }
}
