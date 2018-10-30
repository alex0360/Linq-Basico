using System;
using System.Windows.Forms;
// https://www.youtube.com/watch?v=rUBda5WGH0U
namespace Linq1_1
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            _ReSize();
        }
        private void FormInicio_Load(object sender, EventArgs e)
        {
            Mostrar(LBLista);
            Mostrar(CBBuscar);
            ReSize._get_initial_size();
        }
        ClassData obj = new ClassData();
        private void BGuardar_Click(object sender, EventArgs e)
        {
            try {
                obj.Guardar(TBNombre.Text, TBTel.Text);
                Mostrar(LBLista);
                Mostrar(CBBuscar);
            } catch(Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
            finally {}
        }
        private void BMostrar_Click(object sender, EventArgs e)
        {
            try {
                Mostrar(LBLista);
                Mostrar(CBBuscar);
            } catch(Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            } finally { }
        }       
        private void Mostrar(ListBox list) {
            try {
                list.Items.Clear();
                obj.Mostrar(list);
            } catch(Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            } finally { }
        }
        private void Mostrar(ComboBox combo)
        {
            try {
                combo.Items.Clear();
                obj.Mostrar(combo);
            } catch(Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            } finally { }
        }
        private void BCargar_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Cargar(CBBuscar.Text, TBNombre, TBTel);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void BModificar_Click(object sender, EventArgs e){
            try{
                obj.Modificar(TBNombre.Text, TBTel.Text,CBBuscar.Text);
                Mostrar(LBLista);
                Mostrar(CBBuscar);
            } catch(Exception ex){
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void BEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Eliminar(LBLista.SelectedItem.ToString());
                MessageBox.Show("Alerta", "Desea Continual", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                Mostrar(LBLista);
                Mostrar(CBBuscar);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void LBLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CBBuscar.Text = LBLista.SelectedItem.ToString();
                obj.Cargar(CBBuscar.Text, TBNombre, TBTel);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        #region ReSize
        private ReSize ReSize;
        private void _ReSize()
        {
            ReSize = new ReSize(this);
            this.Load += FormInicio_Load;
            this.Resize += _Resize;
        }
        private void _Resize(object sender, EventArgs e) => ReSize._resize();
        #endregion

    }
}
