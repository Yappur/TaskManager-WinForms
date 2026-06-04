using System.Data;
using System.Drawing;
using System.Windows.Forms;

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


        // Logica de Grilla
        private void InicializarGrilla()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Tarea", typeof(string));
            tabla.Columns.Add("Urgencia", typeof(string));
         
      
            tabla.Columns.Add("Estado", typeof(string));       // Columna para mostrar el estado en texto al lado del checkbox

            tabla.Columns.Add("Completada", typeof(bool));             // Columna booleana para que el DataGridView muestre un CheckBox

            grilla.DataSource = tabla;

            // Configuración visual
            if (grilla.Columns["Estado"] != null)
            {
                grilla.Columns["Estado"].ReadOnly = true;
                grilla.Columns["Estado"].Width = 120;
            }

            // Eventos para detectar cambios en el CheckBox y formatear la celda
            grilla.CurrentCellDirtyStateChanged -= grilla_CurrentCellDirtyStateChanged;
            grilla.CurrentCellDirtyStateChanged += grilla_CurrentCellDirtyStateChanged;
            grilla.CellValueChanged -= grilla_CellValueChanged;
            grilla.CellValueChanged += grilla_CellValueChanged;
            grilla.CellFormatting -= grilla_CellFormatting;
            grilla.CellFormatting += grilla_CellFormatting;
        }

        private void GuardarTarea()
        {
            TareaModel tarea = new TareaModel()
            {
                Tarea = txtnombre.Text,
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
                fila["Completada"] = false;
                fila["Estado"] = "Incompleta";
                tabla.Rows.Add(fila);
            }
        }

        private void LimpiarGrilla()
        {
            txtnombre.Clear();
            cmbUrgencia.SelectedIndex = -1; // Deselecciona cualquier opción
        }

        private void checkBoxComplete()
        {
            foreach (DataGridViewRow row in grilla.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["Complete"] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                {
                    // Realiza la acción deseada para las filas marcadas
                    string tarea = row.Cells["Tarea"].Value.ToString();
                    string urgencia = row.Cells["Urgencia"].Value.ToString();
                    MessageBox.Show($"Tarea: {tarea}, Urgencia: {urgencia} marcada como completa.");
                }
            }
        }

        private void grilla_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            // Cuando el usuario hace click en el checkbox, commit inmediato para disparar CellValueChanged
            if (grilla.IsCurrentCellDirty)
            {
                grilla.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void grilla_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var col = grilla.Columns[e.ColumnIndex];
            if (col != null && col.Name == "Completada")
            {
                var row = grilla.Rows[e.RowIndex];
                bool completada = false;
                var val = row.Cells["Completada"].Value;
                if (val != null && val != DBNull.Value) completada = (bool)val;

                var estadoCell = row.Cells["Estado"];
                if (completada)
                {
                    estadoCell.Value = "Completada";
                    estadoCell.Style.ForeColor = Color.Green;
                }
                else
                {
                    estadoCell.Value = "Incompleta";
                    estadoCell.Style.ForeColor = Color.Red;
                }
            }
        }

        private void grilla_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (grilla.Columns[e.ColumnIndex].Name == "Estado")
            {
                if (e.Value != null)
                {
                    var s = e.Value.ToString();
                    if (s == "Incompleta")
                    {
                        e.CellStyle.ForeColor = Color.Red;
                    }
                    else if (s == "Completada")
                    {
                        e.CellStyle.ForeColor = Color.Green;
                    }
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
