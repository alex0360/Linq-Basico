using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq1_1
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        ClassData obj = new ClassData();
        private void BGuardar_Click(object sender, EventArgs e)
        {
            try {
                obj.Guardar(TBNombre.Text, TBTel.Text);
                obj.Mostrar(LBLista);
            } catch(Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
            finally {}
        }

        private void BMostrar_Click(object sender, EventArgs e)
        {
            try {
                obj.Mostrar(LBLista);
            } catch(Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            } finally { }
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            try {
                obj.Mostrar(LBLista);
            } catch(Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            } finally { }
        }
    }
}
