using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMDemo.ViewModels
{
    public class ViewModelOperaciones :ViewModelBase
    {

        #region  Atributos
        int valorA;
        public int ValorA
        {
            get { return valorA; }
            set
            {
                if (valorA != value)
                {
                    valorA = value;
                    OnPropertyChanged();
                }
            }
        }

        int valorB;
        public int ValorB
        {
            get { return valorB; }
            set
            {
                if (valorB != value)
                {
                    valorB = value;
                    OnPropertyChanged();
                }
            }
        }

        int resultadoOperacion;
        public int ResultadoOperacion
        {
            get { return resultadoOperacion; }
            set
            {
                if (resultadoOperacion != value)
                {
                    resultadoOperacion = value;
                    OnPropertyChanged();
                }
            }
        }
        string messageValidation;
        public string MessageValidation
        {
            get { return messageValidation; }
            set
            {
                if (messageValidation != value)
                {
                    messageValidation = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion

        public ICommand Sumar { protected set; get; }
        public ICommand Restar { protected set; get; }
        public ICommand Multiplicar { protected set; get; }
        public ICommand Dividir { protected set; get; }
        public ViewModelOperaciones()
        {
            /*OPERACIONES SUMAR - RESTAR - MULTIPLICAR - DIVIDIR */
            Sumar = new Command(() =>
            {
                ResultadoOperacion = ValorA + ValorB;
                MessageValidation = "";
            });

            Restar = new Command(() =>
            {
                ResultadoOperacion = ValorA - ValorB;
                MessageValidation = "";
            });

            Multiplicar = new Command(() =>
            {
                ResultadoOperacion = ValorA * ValorB;
                MessageValidation = "";
            });

            Dividir = new Command(() =>
            {
                /*Validación */
                if(ValorB != 0)
                {
                    MessageValidation = "";
                    ResultadoOperacion = ValorA / ValorB;      
                }
                else
                {
                    MessageValidation = "NO ES POSIBLE DIVIDIR ENTRE 0";
                }              
            });
        }       
    }
}
