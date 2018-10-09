using AEstrela.Dominio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AEstrela.WinApp
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private Stopwatch _timer;
        private AEstrelaPathfind _algoritmo;
        private IList<Nodo> _gerados;
        private IList<Nodo> _expandidos;
        private IList<Nodo> _caminho;
        private IList<Nodo> _bloqueados;
        private Nodo _inicial;
        private Nodo _destino;

        private void dataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCellStyle CellStyle = new DataGridViewCellStyle();

            if (radioButtonPontoInicial.Checked)
            {
                CellStyle.BackColor = Color.White;
                _inicial.X = e.RowIndex;
                _inicial.Y = e.ColumnIndex;
            }
            if (radioButtonPontoFinal.Checked)
            {
                CellStyle.BackColor = Color.Black;
                _destino.X = e.RowIndex;
                _destino.Y = e.ColumnIndex;
            }
            if (radioButtonObstaculos.Checked)
            {
                CellStyle.BackColor = Color.Yellow;
                _bloqueados.Add(new Nodo(e.RowIndex, e.ColumnIndex));
            }

            DataGridViewButtonColumn c = (DataGridViewButtonColumn)dataGridView.Columns[e.ColumnIndex];
            c.FlatStyle = FlatStyle.Popup;
            dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = CellStyle;

        }

        private void buttonBuscar_Click(object sender, System.EventArgs e)
        {
            _timer = new Stopwatch();
            _timer.Start();

            _algoritmo = new AEstrelaPathfind(
                Convert.ToInt32(Math.Round(numericUpDownDimensao.Value)),
                Convert.ToInt32(Math.Round(numericUpDownDimensao.Value)),
                _bloqueados,
                _inicial,
                _destino,
                numericUpDownCustoDiag.Value,
                numericUpDownCustoVH.Value);
            _caminho = _algoritmo.ProcurarCaminho();
            _gerados = _algoritmo.Gerados;
            _expandidos = _algoritmo.Expandidos;

            _timer.Stop();
            PintarGrid();
            AtribuirEstatisticas();
        }

        private void AtribuirEstatisticas()
        {
            labelExpandidos.Text = _expandidos.Count().ToString();
            labelGerados.Text = _gerados.Count().ToString();
            labelTempo.Text = _timer.Elapsed.TotalMilliseconds + "ms";
        }

        private void PintarGrid()
        {
            DataGridViewCellStyle cellStyle;
            DataGridViewButtonColumn c;

            foreach (Nodo nodo in _gerados)
            {
                c = (DataGridViewButtonColumn)dataGridView.Columns[nodo.Y];
                c.FlatStyle = FlatStyle.Popup;
                cellStyle = new DataGridViewCellStyle() { BackColor = Color.Green };
                dataGridView.Rows[nodo.X].Cells[nodo.Y].Style = cellStyle;
            }

            foreach (Nodo nodo in _expandidos)
            {
                c = (DataGridViewButtonColumn)dataGridView.Columns[nodo.Y];
                c.FlatStyle = FlatStyle.Popup;
                cellStyle = new DataGridViewCellStyle() { BackColor = Color.Blue };
                dataGridView.Rows[nodo.X].Cells[nodo.Y].Style = cellStyle;
            }

            foreach (Nodo nodo in _caminho)
            {
                c = (DataGridViewButtonColumn)dataGridView.Columns[nodo.Y];
                c.FlatStyle = FlatStyle.Popup;
                cellStyle = new DataGridViewCellStyle() { BackColor = Color.Red };
                dataGridView.Rows[nodo.X].Cells[nodo.Y].Style = cellStyle;
            }

            foreach (Nodo nodo in _bloqueados)
            {
                c = (DataGridViewButtonColumn)dataGridView.Columns[nodo.Y];
                c.FlatStyle = FlatStyle.Popup;
                cellStyle = new DataGridViewCellStyle() { BackColor = Color.Yellow };
                dataGridView.Rows[nodo.X].Cells[nodo.Y].Style = cellStyle;
            }

            c = (DataGridViewButtonColumn)dataGridView.Columns[_inicial.Y];
            c.FlatStyle = FlatStyle.Popup;
            cellStyle = new DataGridViewCellStyle() { BackColor = Color.White };
            dataGridView.Rows[_inicial.X].Cells[_inicial.Y].Style = cellStyle;

            c = (DataGridViewButtonColumn)dataGridView.Columns[_destino.Y];
            c.FlatStyle = FlatStyle.Popup;
            cellStyle = new DataGridViewCellStyle() { BackColor = Color.Black };
            dataGridView.Rows[_destino.X].Cells[_destino.Y].Style = cellStyle;
        }

        private void buttonDesenharGrid_Click(object sender, EventArgs e)
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();

            for (int i = 0; i < Convert.ToInt32(Math.Round(numericUpDownDimensao.Value)); i++)
            {
                DataGridViewButtonColumn column = new DataGridViewButtonColumn();
                dataGridView.Columns.Add(column);
            }

            for (int i = 0; i < Convert.ToInt32(Math.Round(numericUpDownDimensao.Value)); i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                dataGridView.Rows.Add(row);
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            _inicial = new Nodo(0, 0);
            _destino = new Nodo(0, 1);
            _bloqueados = new List<Nodo>();
        }
    }
}
