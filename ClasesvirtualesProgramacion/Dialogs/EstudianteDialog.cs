using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesvirtualesProgramacion.Dialogs;
namespace ClasesvirtualesProgramacion.Dialogs
{
    public partial class EstudianteDialog : baseDialog
    {
        public EstudianteDialog()
        {
            InitializeComponent();
        }
        protected override bool ValidarEntrada()
        {
            erp.Clear();
            if (identidadTextBox.Text.Trim() == String.Empty)
                return NotificacionDeValidacion("Por favor escriba el numero de identidad del estudiante", identidadTextBox);

            if (sexoComboBox.SelectedIndex < 0)
                return NotificacionDeValidacion("Por favor seleccione Masculino o Femenino para el sexo del estudiante ", sexoComboBox);

            if (nombresTextBox.Text.Trim() == string.Empty)
                return NotificacionDeValidacion("Por favor escriba los nombres completos del estudiante", nombresTextBox);

            if (apellidosTextBox.Text.Trim() == string.Empty)
                return NotificacionDeValidacion("Por favor escriba los apellidos completos del estudiante", apellidosTextBox);

            if (direccionTextBox.Text.Trim() == string.Empty)
                return NotificacionDeValidacion("Por favor escriba la dirección donde el estudiante vive", direccionTextBox);

            if (fechanacDateTimePicker.Text.Trim() == string.Empty)
                return NotificacionDeValidacion("Por favor escriba la fecha de  nacimiento del studiante", fechanacDateTimePicker);
            return true;

        }
    } 
}
