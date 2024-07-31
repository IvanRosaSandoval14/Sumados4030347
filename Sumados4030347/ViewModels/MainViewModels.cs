using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace Sumados4030347.ViewModels
{
    public partial class MainViewModels : ObservableObject
    {
        [ObservableProperty]
        private string dato1;
        [ObservableProperty]
        private string dato2;
        [ObservableProperty]
        private string respuesta;

        [RelayCommand]
        private void Sumar()
        {
            if (!string.IsNullOrEmpty(Dato1)|| !string.IsNullOrEmpty(Dato2))
            {
                if(int.TryParse(dato1, out int dat1) && int.TryParse(Dato2, out int dat2))
                {
                    Respuesta = (dat1 + dat2).ToString();
                }
                else
                {
                    Respuesta = "Digite numeros correctos";
                }
            }
            else
            {
                Respuesta = "Falta ingresar datos";
            }

        }
    }
}
