using System.Linq;
using System.Windows.Forms;

namespace Linq1_1
{
    class ClassData
    {
        private LinqDataDataContext DataContext = new LinqDataDataContext();
        public void Guardar(string nombre, string tel){
            Perssona table = new Perssona {
                Nombre = nombre,
                Tel = tel
            };

            DataContext.Perssona.InsertOnSubmit(table);
            DataContext.SubmitChanges();
        }
        public void Mostrar(System.Windows.Forms.ListBox listBox){
            var Consulta = from x in DataContext.Perssona select x;

            foreach(Perssona table in Consulta) {
                listBox.Items.Add(table.Id + "-" + table.Nombre + "-" + table.Tel);
            }
        }
        public void Mostrar(System.Windows.Forms.ComboBox comboBox){
            var Consulta = from x in DataContext.Perssona select x;

            foreach(Perssona table in Consulta) {
                comboBox.Items.Add(table.Id + "-" + table.Nombre + "-" + table.Tel);
            }
        }
        private int ID;
        public void ObtenerID(string dato){
            ID = 0;
            var consulta = from x in DataContext.Perssona where x.Id == int.Parse(Quitar(dato)) select x;
            foreach(Perssona p in consulta)
                ID = p.Id;
        }
        public void Modificar(string nombre, string tel, string dat){
            ObtenerID(dat);
            var consulta= (from x in DataContext.Perssona where x.Id == ID select x).First();
            consulta.Nombre = nombre;
            consulta.Tel = tel.ToString();
            DataContext.SubmitChanges();
        }
        public void Cargar(string dat, TextBox nombre, TextBox telefono){
            ObtenerID(dat);
            var consulta = from x in DataContext.Perssona where x.Id == ID select x;
            foreach(Perssona p in consulta){
                nombre.Text = p.Nombre;
                telefono.Text = p.Tel;
            }
        }
        public void Eliminar(string dato)
        {
            ObtenerID(dato);
            var consulta = from x in DataContext.Perssona where x.Id == ID select x;
            foreach(Perssona p in consulta)
            {
                DataContext.Perssona.DeleteOnSubmit(p);
            }
            DataContext.SubmitChanges();
        }

        private string Quitar(string cadena) {
            string nuevoID = "0";
            for(int pos = 0; pos < cadena.Length; pos++) {
                if(cadena[pos] != '-')
                    nuevoID += cadena[pos].ToString();
                if(cadena[pos] == '-') break;
            }
            return nuevoID;
        }
    }
}
