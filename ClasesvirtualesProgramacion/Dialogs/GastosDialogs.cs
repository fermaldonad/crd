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
    public partial class GastosDialogs : baseDialog
        
    {
        public GastosDialogs()
        {
            InitializeComponent();
        }
        protected override bool ValidarEntrada()
        {
         
           
            erp.Clear();
            if (categoriaComboBox.SelectedIndex < 0)
                return NotificacionDeValidacion("Por favor seleccione una de las opciones de categoria ",categoriaComboBox);

            if (subcategoriaComboBox.SelectedIndex < 0)
                return NotificacionDeValidacion("Por favor seleccione una de la opciones de la subcategoria ", subcategoriaComboBox);

            if (descripcionTextBox.Text.Trim() == string.Empty)
                return NotificacionDeValidacion("Por favor escriba las observaciones del gasto", descripcionTextBox);

            if (formapagoComboBox.Text.Trim() == string.Empty)
                return NotificacionDeValidacion("Por favor elija una forma de pago "
                    , subcategoriaComboBox);
            return true;

        }

        private void GastosDialogs_Load(object sender, EventArgs e)
        {

        }

       
    }
}
