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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cargar_usuarios();
        }

        List<Usuario> user = new List<Usuario>();

        private void button1_Click(object sender, EventArgs e)
        {

            Epleado usuario = new Epleado();
            Form1 inicio = new Form1();
            Administrador Adsd = new Administrador();
        

            for (int i = 0; i < user.Count; i++)
            {
                if (nickname.Text == user[i].Nick && contra.Text == user[i].Contrasena)
                {

                    if (nickname.Text == "Admin")
                    {
                        Adsd.Show();
                        adas(i);
                    }
                    else
                    {
                        usuario.Show();
                        adas(i);
                    }

                }
                if (nickname.Text != user[i].Nick && contra.Text != user[i].Contrasena)
                {
                    if (nickname.Text != " " && contra.Text != " ")
                    {

                        MessageBox.Show("Error Usuario Incorrecto");

                    }
 
                }
                
            }


        }


        void adas(int i)
        {
     
            string fileName = "Ingresos.txt";
            FileStream stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);


            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(user[i].Codigo);
            writer.WriteLine(DateTime.Now);


            writer.Close();
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

 
    }
}
