using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryPeriottiEtapa5
{
    internal class clsVehiculo
    {
        string Nombre;
        public PictureBox Vehiculo;

        public void crearAuto()
        {
            Nombre = "Zentorno";
            Vehiculo = new PictureBox();
            Vehiculo.SizeMode = PictureBoxSizeMode.Zoom;
            Vehiculo.Size = new Size(100, 100);
            Vehiculo.ImageLocation = @"../../../" + "/Resources/" + "Zentorno.jpg";
        }

        public void crearMoto()
        {
            Nombre = "Bati 801";
            Vehiculo = new PictureBox();
            Vehiculo.SizeMode = PictureBoxSizeMode.Zoom;
            Vehiculo.Size = new Size(100, 100);
            Vehiculo.ImageLocation = @"../../../" + "/Resources/" + "Bati801.jpg";
        }

        public void crearAvion()
        {
            Nombre = "Besra";
            Vehiculo = new PictureBox();
            Vehiculo.SizeMode = PictureBoxSizeMode.Zoom;
            Vehiculo.Size = new Size(100, 100);
            Vehiculo.ImageLocation = @"../../../" + "/Resources/" + "Besra.jpg";
        }

        public void crearVehiculoAleatorio()
        {
            Random vehiculoRandom = new Random();
            int Vehiculo;
            Vehiculo = vehiculoRandom.Next(1, 4);
            if (Vehiculo == 1)
            {
                crearAuto();
            }
            if (Vehiculo == 2)
            {
                crearMoto ();
            }
            if (Vehiculo == 3)
            {
                crearAvion ();
            }

        }
    }
}
