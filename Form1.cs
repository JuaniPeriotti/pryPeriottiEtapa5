namespace pryPeriottiEtapa5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        clsVehiculo objVehiculo = new clsVehiculo();
        Random aleatorioY = new Random();
        Random aleatorioX = new Random();
        int X = 0;
        int Y = 0;
        private void btnCrearVehiculos_Click(object sender, EventArgs e)
        {
            X = aleatorioX.Next(0, 500);
            Y = aleatorioY.Next(0, 400);
            objVehiculo = new clsVehiculo();
            objVehiculo.crearVehiculoAleatorio();
            objVehiculo.Vehiculo.Location = new Point(X, Y);
            Controls.Add(objVehiculo.Vehiculo);

        }
    }
}
