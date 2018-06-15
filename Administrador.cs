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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
            Cargar_Produc();


        }

        List<Inventario> productos = new List<Inventario>();


        private void button1_Click(object sender, EventArgs e)
        {

            List<Inventario> intem = new List<Inventario>();
            intem = productos;

            for (int i = 0; i < productos.Count; i++)
            {

                if (textBox2.Text == intem[i].Producto)
                {
                    intem[i].Cantidid = textBox1.Text;
                    intem[i].Precio = textBox3.Text;
                }
                else if (textBox2.Text != intem[i].Producto)
                {

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
                intemp.Precio = reader.ReadLine();
                productos.Add(intemp);

            }
            reader.Close();

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = productos;
            dataGridView1.Refresh();

        }

    }
}
