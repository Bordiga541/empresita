using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace empresita
{
    public partial class Form1 : Form
    {
        Datos d = new Datos();
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string sql = $@"
                SELECT Nombre, SectorID
                FROM Sectores
            ";
            
            DataTable tabla = d.GetTabla(sql);
            
            foreach (DataRow fila in tabla.Rows)
            {
                cboSector.Items.Add(fila["Nombre"]);
                
            }
            
        }

        private void cboSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = cboSector.SelectedIndex + 1;
            string sql2 = $@"
                SELECT EmpleadoID, Nombre
                FROM Empleados
                WHERE SectorID = '{a}'
            ";
            DataTable tabla2 = d.GetTabla(sql2);
            dataGridView1.DataSource = tabla2;
        }
    }
}
