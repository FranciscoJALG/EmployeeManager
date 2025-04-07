using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManager
{
    public partial class Main : Form
    {
        private EmployeeDB db = new EmployeeDB();
        public Main()
        {
            InitializeComponent();
            getEmployee();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txbNombre.Text.Trim();
            string puesto = txbPuesto.Text.Trim();
            string salarioTexto = txbSalario.Text.Trim();

            // Validaciones
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(puesto) || string.IsNullOrWhiteSpace(salarioTexto))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(salarioTexto, out double salario) || salario < 0)
            {
                MessageBox.Show("El salario debe ser un número positivo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var emp = new Employee
            {
                Nombre = nombre,
                Puesto = puesto,
                Salario = salario
            };

            db.AddEmp(emp);
            MessageBox.Show("Empleado agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiarCampos();
            getEmployee();

        }

        private void getEmployee()
        {
            dgvEmpleados.DataSource = db.GetEmployees();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbNombre.Tag == null) return;

            if (string.IsNullOrWhiteSpace(txbNombre.Text) ||
                string.IsNullOrWhiteSpace(txbPuesto.Text) ||
                !double.TryParse(txbSalario.Text, out double salario))
            {
                MessageBox.Show("Todos los campos deben ser válidos.");
                return;
            }

            var emp = new Employee
            {
                Id = int.Parse(txbNombre.Tag.ToString()),
                Nombre = txbNombre.Text,
                Puesto = txbPuesto.Text,
                Salario = salario
            };

            db.UpdateEmp(emp);
            getEmployee();
            limpiarCampos();
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmpleados.Rows[e.RowIndex];
                txbNombre.Text = row.Cells["Nombre"].Value.ToString();
                txbPuesto.Text = row.Cells["Puesto"].Value.ToString();
                txbSalario.Text = row.Cells["Salario"].Value.ToString();
                txbNombre.Tag = row.Cells["Id"].Value.ToString(); // Guardamos el ID temporalmente
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txbNombre.Tag == null) return;

            int id = int.Parse(txbNombre.Tag.ToString());
            db.DeleteEmp(id);
            getEmployee();
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txbNombre.Clear();
            txbPuesto.Clear();
            txbSalario.Clear();
            txbNombre.Tag = null;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
