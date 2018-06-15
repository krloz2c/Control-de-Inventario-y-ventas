using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Control_de_Inventario_y_ventas
{
    public partial class Epleado : Form
    {
        public Epleado()
        {

            InitializeComponent();
            cargar_usuarios();
            ingresos();
            Cargar_Produc();
            cargar_lista_usuarios();
            cargar_compadores();
            
        }


        List<Usuario> user = new List<Usuario>();
        List<Inventario> productos = new List<Inventario>();
        List<Clientes> comprador = new List<Clientes>();
 

        private void button3_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < comprador.Count; i++)
            {
                if (textBox1.Text == comprador[i].Nit)
                {

                    label2.Text = comprador[i].Nombre;
                }

            }


        }
        


        string cod;
        string fech;

        void ingresos()
        {

            string fileName = @"C:\Users\Carlos\source\repos\Control de Inventario y ventas\Control de Inventario y ventas\bin\Debug\Ingresos.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
 
            while (reader.Peek() > -1)

            {
                
                cod = reader.ReadLine();
                fech = reader.ReadLine();

            }
            reader.Close();


        }

        void cargar_lista_usuarios()
        {

            for (int i = 0; i < user.Count; i++)
            {
                if (cod == user[i].Codigo)
                {

                    NombreCajero.Text = user[i].Nombre;
                }

            }

        }


        void Cargar_Produc()
        {

            string fileName = @"C:\Users\Carlos\source\repos\Control de Inventario y ventas\Control de Inventario y ventas\bin\Debug\Productos.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)

            {
                Inventario intemp = new Inventario();

                intemp.Cantidid = reader.ReadLine();
                intemp.Producto = reader.ReadLine();
                comboBox1.Items.Add(intemp.Producto);
                intemp.Precio = reader.ReadLine();
                productos.Add(intemp);

            }
            reader.Close();
        }
        void cargar_compadores()
        {

            string fileName = @"C:\Users\Carlos\source\repos\Control de Inventario y ventas\Control de Inventario y ventas\bin\Debug\Compradores.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)

            {
                Clientes clitemp = new Clientes();
                
                clitemp.Nit = reader.ReadLine();
                clitemp.Nombre = reader.ReadLine();
                comprador.Add(clitemp);

            }
            reader.Close();

        }


        void cargar_usuarios()
        {

            string fileName = @"C:\Users\Carlos\source\repos\Control de Inventario y ventas\Control de Inventario y ventas\bin\Debug\Usuarios.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)

            {
                Usuario Ustemp = new Usuario();
                Ustemp.Codigo = reader.ReadLine();
                Ustemp.Nombre = reader.ReadLine();
                Ustemp.Nick = reader.ReadLine();
                Ustemp.Contrasena = reader.ReadLine();
                user.Add(Ustemp);

            }
            reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            Inventario nuevo = new Inventario();

            nuevo.Cantidid = textBox2.Text;
            nuevo.Producto = comboBox1.Text;



            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = productos;
            dataGridView1.Refresh();
        }
    }
}
