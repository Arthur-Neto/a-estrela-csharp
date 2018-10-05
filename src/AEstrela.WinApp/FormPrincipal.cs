using AEstrela.Dominio;
using System.Drawing;
using System.Windows.Forms;

namespace AEstrela.WinApp
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void dataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCellStyle CellStyle = new DataGridViewCellStyle();
            CellStyle.BackColor = Color.Red;

            DataGridViewButtonColumn c = (DataGridViewButtonColumn)dataGridView.Columns[e.ColumnIndex];
            c.FlatStyle = FlatStyle.Popup;
            dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = CellStyle;
        }
    }
}
