namespace AEstrela.WinApp
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonPontoInicial = new System.Windows.Forms.RadioButton();
            this.radioButtonPontoFinal = new System.Windows.Forms.RadioButton();
            this.radioButtonObstaculos = new System.Windows.Forms.RadioButton();
            this.groupBoxControles = new System.Windows.Forms.GroupBox();
            this.groupBoxVariaveis = new System.Windows.Forms.GroupBox();
            this.labelTempo = new System.Windows.Forms.Label();
            this.labelCaminho = new System.Windows.Forms.Label();
            this.labelGerados = new System.Windows.Forms.Label();
            this.labelExpandidos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.groupBoxConfigs = new System.Windows.Forms.GroupBox();
            this.buttonDesenharGrid = new System.Windows.Forms.Button();
            this.numericUpDownCustoVH = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCustoDiag = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDimensao = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBoxControles.SuspendLayout();
            this.groupBoxVariaveis.SuspendLayout();
            this.groupBoxConfigs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustoVH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustoDiag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDimensao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 713);
            this.panel1.TabIndex = 0;
            // 
            // radioButtonPontoInicial
            // 
            this.radioButtonPontoInicial.AutoSize = true;
            this.radioButtonPontoInicial.Checked = true;
            this.radioButtonPontoInicial.Location = new System.Drawing.Point(6, 19);
            this.radioButtonPontoInicial.Name = "radioButtonPontoInicial";
            this.radioButtonPontoInicial.Size = new System.Drawing.Size(83, 17);
            this.radioButtonPontoInicial.TabIndex = 2;
            this.radioButtonPontoInicial.TabStop = true;
            this.radioButtonPontoInicial.Text = "Ponto Inicial";
            this.radioButtonPontoInicial.UseVisualStyleBackColor = true;
            // 
            // radioButtonPontoFinal
            // 
            this.radioButtonPontoFinal.AutoSize = true;
            this.radioButtonPontoFinal.Location = new System.Drawing.Point(6, 42);
            this.radioButtonPontoFinal.Name = "radioButtonPontoFinal";
            this.radioButtonPontoFinal.Size = new System.Drawing.Size(78, 17);
            this.radioButtonPontoFinal.TabIndex = 3;
            this.radioButtonPontoFinal.Text = "Ponto Final";
            this.radioButtonPontoFinal.UseVisualStyleBackColor = true;
            // 
            // radioButtonObstaculos
            // 
            this.radioButtonObstaculos.AutoSize = true;
            this.radioButtonObstaculos.Location = new System.Drawing.Point(6, 65);
            this.radioButtonObstaculos.Name = "radioButtonObstaculos";
            this.radioButtonObstaculos.Size = new System.Drawing.Size(78, 17);
            this.radioButtonObstaculos.TabIndex = 4;
            this.radioButtonObstaculos.Text = "Obstaculos";
            this.radioButtonObstaculos.UseVisualStyleBackColor = true;
            // 
            // groupBoxControles
            // 
            this.groupBoxControles.Controls.Add(this.radioButtonObstaculos);
            this.groupBoxControles.Controls.Add(this.radioButtonPontoInicial);
            this.groupBoxControles.Controls.Add(this.radioButtonPontoFinal);
            this.groupBoxControles.Location = new System.Drawing.Point(994, 152);
            this.groupBoxControles.Name = "groupBoxControles";
            this.groupBoxControles.Size = new System.Drawing.Size(236, 97);
            this.groupBoxControles.TabIndex = 5;
            this.groupBoxControles.TabStop = false;
            this.groupBoxControles.Text = "Controles Grid";
            // 
            // groupBoxVariaveis
            // 
            this.groupBoxVariaveis.Controls.Add(this.labelTempo);
            this.groupBoxVariaveis.Controls.Add(this.labelCaminho);
            this.groupBoxVariaveis.Controls.Add(this.labelGerados);
            this.groupBoxVariaveis.Controls.Add(this.labelExpandidos);
            this.groupBoxVariaveis.Controls.Add(this.label7);
            this.groupBoxVariaveis.Controls.Add(this.label6);
            this.groupBoxVariaveis.Controls.Add(this.label5);
            this.groupBoxVariaveis.Location = new System.Drawing.Point(994, 255);
            this.groupBoxVariaveis.Name = "groupBoxVariaveis";
            this.groupBoxVariaveis.Size = new System.Drawing.Size(235, 417);
            this.groupBoxVariaveis.TabIndex = 6;
            this.groupBoxVariaveis.TabStop = false;
            this.groupBoxVariaveis.Text = "Variaveis";
            // 
            // labelTempo
            // 
            this.labelTempo.AutoSize = true;
            this.labelTempo.Location = new System.Drawing.Point(99, 85);
            this.labelTempo.Name = "labelTempo";
            this.labelTempo.Size = new System.Drawing.Size(18, 13);
            this.labelTempo.TabIndex = 8;
            this.labelTempo.Text = "0s";
            // 
            // labelCaminho
            // 
            this.labelCaminho.AutoSize = true;
            this.labelCaminho.Location = new System.Drawing.Point(99, 85);
            this.labelCaminho.Name = "labelCaminho";
            this.labelCaminho.Size = new System.Drawing.Size(0, 13);
            this.labelCaminho.TabIndex = 7;
            // 
            // labelGerados
            // 
            this.labelGerados.AutoSize = true;
            this.labelGerados.Location = new System.Drawing.Point(99, 55);
            this.labelGerados.Name = "labelGerados";
            this.labelGerados.Size = new System.Drawing.Size(13, 13);
            this.labelGerados.TabIndex = 6;
            this.labelGerados.Text = "0";
            // 
            // labelExpandidos
            // 
            this.labelExpandidos.AutoSize = true;
            this.labelExpandidos.Location = new System.Drawing.Point(99, 25);
            this.labelExpandidos.Name = "labelExpandidos";
            this.labelExpandidos.Size = new System.Drawing.Size(13, 13);
            this.labelExpandidos.TabIndex = 5;
            this.labelExpandidos.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tempo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nós Expandidos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nós Gerados:";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(999, 678);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(230, 47);
            this.buttonBuscar.TabIndex = 7;
            this.buttonBuscar.Text = "Buscar Caminho";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // groupBoxConfigs
            // 
            this.groupBoxConfigs.Controls.Add(this.buttonDesenharGrid);
            this.groupBoxConfigs.Controls.Add(this.numericUpDownCustoVH);
            this.groupBoxConfigs.Controls.Add(this.numericUpDownCustoDiag);
            this.groupBoxConfigs.Controls.Add(this.numericUpDownDimensao);
            this.groupBoxConfigs.Controls.Add(this.label4);
            this.groupBoxConfigs.Controls.Add(this.label3);
            this.groupBoxConfigs.Controls.Add(this.label2);
            this.groupBoxConfigs.Location = new System.Drawing.Point(993, 12);
            this.groupBoxConfigs.Name = "groupBoxConfigs";
            this.groupBoxConfigs.Size = new System.Drawing.Size(236, 134);
            this.groupBoxConfigs.TabIndex = 8;
            this.groupBoxConfigs.TabStop = false;
            this.groupBoxConfigs.Text = "Configurações";
            // 
            // buttonDesenharGrid
            // 
            this.buttonDesenharGrid.Location = new System.Drawing.Point(10, 100);
            this.buttonDesenharGrid.Name = "buttonDesenharGrid";
            this.buttonDesenharGrid.Size = new System.Drawing.Size(220, 28);
            this.buttonDesenharGrid.TabIndex = 9;
            this.buttonDesenharGrid.Text = "Desenhar Grid";
            this.buttonDesenharGrid.UseVisualStyleBackColor = true;
            this.buttonDesenharGrid.Click += new System.EventHandler(this.buttonDesenharGrid_Click);
            // 
            // numericUpDownCustoVH
            // 
            this.numericUpDownCustoVH.Location = new System.Drawing.Point(125, 23);
            this.numericUpDownCustoVH.Minimum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            -2147483648});
            this.numericUpDownCustoVH.Name = "numericUpDownCustoVH";
            this.numericUpDownCustoVH.Size = new System.Drawing.Size(105, 20);
            this.numericUpDownCustoVH.TabIndex = 7;
            // 
            // numericUpDownCustoDiag
            // 
            this.numericUpDownCustoDiag.Location = new System.Drawing.Point(125, 48);
            this.numericUpDownCustoDiag.Minimum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            -2147483648});
            this.numericUpDownCustoDiag.Name = "numericUpDownCustoDiag";
            this.numericUpDownCustoDiag.Size = new System.Drawing.Size(105, 20);
            this.numericUpDownCustoDiag.TabIndex = 6;
            // 
            // numericUpDownDimensao
            // 
            this.numericUpDownDimensao.Location = new System.Drawing.Point(125, 74);
            this.numericUpDownDimensao.Name = "numericUpDownDimensao";
            this.numericUpDownDimensao.Size = new System.Drawing.Size(105, 20);
            this.numericUpDownDimensao.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Custo Vert. Horizontal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Custo Diagonal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dimensão da matriz:";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.Color.White;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Transparent;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView.Size = new System.Drawing.Size(975, 713);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDown);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 737);
            this.Controls.Add(this.groupBoxConfigs);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.groupBoxVariaveis);
            this.Controls.Add(this.groupBoxControles);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A Estrela";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.groupBoxControles.ResumeLayout(false);
            this.groupBoxControles.PerformLayout();
            this.groupBoxVariaveis.ResumeLayout(false);
            this.groupBoxVariaveis.PerformLayout();
            this.groupBoxConfigs.ResumeLayout(false);
            this.groupBoxConfigs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustoVH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustoDiag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDimensao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonPontoInicial;
        private System.Windows.Forms.RadioButton radioButtonPontoFinal;
        private System.Windows.Forms.RadioButton radioButtonObstaculos;
        private System.Windows.Forms.GroupBox groupBoxControles;
        private System.Windows.Forms.GroupBox groupBoxVariaveis;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.GroupBox groupBoxConfigs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownCustoVH;
        private System.Windows.Forms.NumericUpDown numericUpDownCustoDiag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTempo;
        private System.Windows.Forms.Label labelCaminho;
        private System.Windows.Forms.Label labelGerados;
        private System.Windows.Forms.Label labelExpandidos;
        private System.Windows.Forms.NumericUpDown numericUpDownDimensao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDesenharGrid;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

