using DisparadoresXam.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DisparadoresXam.Datos
{
    public class Dcategorias
    {
        public static ObservableCollection<Mcategorias> MostrarCategorias()
        {
            return new ObservableCollection<Mcategorias>()
            {
                new Mcategorias()
                {
                    descripcion = "Cena",
                    numeroItem = 4512,
                    imagen="https://i.ibb.co/BKKdd7Q/comida.png",
                    backgroundColor="#EAEDF6",
                    textColor = "#000000"
                },
                new Mcategorias()
                {
                    descripcion = "Hotel",
                    numeroItem = 4512,
                    imagen="https://i.ibb.co/Pc85qfM/hotel.png",
                    backgroundColor="#EAEDF6",
                    textColor = "#000000"
                },
                new Mcategorias()
                {
                    descripcion = "Fiesta",
                    numeroItem = 4512,
                    imagen="https://i.ibb.co/Nr2d5DN/papel-picado.png",
                    backgroundColor="#EAEDF6",
                    textColor = "#000000"
                },
                new Mcategorias()
                {
                    descripcion = "Flores",
                    numeroItem = 4512,
                    imagen="https://i.ibb.co/Wx8kFN3/maceta.png",
                    backgroundColor="#EAEDF6",
                    textColor = "#000000"
                }
            };
        }
    }
}
