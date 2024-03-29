﻿using DisparadoresXam.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace DisparadoresXam.VistaModelo
{
    public class VMpatron:BaseViewModel
    {
        #region VARIABLES
        string _Mensaje;
        #endregion
        #region CONSTRUCTOR
        public VMpatron(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        public string Mensaje
        {
            get { return _Mensaje; }
            set { SetValue(ref _Mensaje, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoAsynCommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        #endregion
    }
}
