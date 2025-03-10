using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

class Producto
{
    public int ID { get; set; }
    public string Nombre { get; set; }
    public string Categoria { get; set; }
    public double Precio { get; set; }
    public int CantidadStock { get; set; }
}

class Cliente
{
    public int ID { get; set; }
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
}

class Venta
{
    public int ID { get; set; }
    public Cliente Cliente { get; set; }
    public Dictionary<int, int> ProductosVendidos { get; set; }
    public double Total { get; set; }
}

namespace Inventario_Machote
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WelcomeForm());
        }
    }
}
