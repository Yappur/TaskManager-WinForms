using System.Data;

namespace Desktop_form
{
    public partial class Form1 : Form
    {
        DataTable tabla;
        Tareas datos = new Tareas();

        public Form1()
        {
            InitializeComponent();
            InicializarGrilla();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarGrilla();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            GuardarTarea();
            InicializarGrilla();
            LimpiarGrilla();
            CargarTareas();
        }

        private void InicializarGrilla()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Tarea");
            tabla.Columns.Add("Urgencia");
            grilla.DataSource = tabla;
        }

        private void GuardarTarea()
        {
            TareaModel tarea = new TareaModel()
            {
                Tarea= txtnombre.Text,
                Urgencia = cmbUrgencia.Text
            };
            datos.GuardarTarea(tarea);
        }

        private void CargarTareas()
        {
            foreach (var item in datos.CargarDatos())
            {
               DataRow fila = tabla.NewRow();
                fila["Tarea"] = item.Tarea;
                fila["Urgencia"] = item.Urgencia;
                tabla.Rows.Add(fila);
            }
        }

        private void LimpiarGrilla()
        {
            tabla.Rows.Clear();
        }
    }
}
