using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catalogo_Biblioteca.Modelo;

namespace Catalogo_Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (BibliotecaEntities db = new BibliotecaEntities())
            {
                var lst = from libros in db.Catalogo select libros;
                dtg_Libros.DataSource = lst.ToList();
            }
        }
    }
}
