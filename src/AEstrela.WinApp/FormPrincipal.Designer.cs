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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.radioButtonPontoInicial = new System.Windows.Forms.RadioButton();
            this.radioButtonPontoFinal = new System.Windows.Forms.RadioButton();
            this.radioButtonObstaculos = new System.Windows.Forms.RadioButton();
            this.groupBoxControles = new System.Windows.Forms.GroupBox();
            this.groupBoxVariaveis = new System.Windows.Forms.GroupBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.groupBoxConfigs = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownLargura = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAltura = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCustoDiag = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCustoVH = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBoxControles.SuspendLayout();
            this.groupBoxConfigs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLargura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustoDiag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustoVH)).BeginInit();
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
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Transparent;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ColumnHeadersVisible = false;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.Color.Black;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Transparent;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView.Size = new System.Drawing.Size(975, 713);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDown);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // radioButtonPontoInicial
            // 
            this.radioButtonPontoInicial.AutoSize = true;
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
            this.radioButtonPontoFinal.TabStop = true;
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
            this.radioButtonObstaculos.TabStop = true;
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
            this.groupBoxVariaveis.Location = new System.Drawing.Point(994, 255);
            this.groupBoxVariaveis.Name = "groupBoxVariaveis";
            this.groupBoxVariaveis.Size = new System.Drawing.Size(235, 417);
            this.groupBoxVariaveis.TabIndex = 6;
            this.groupBoxVariaveis.TabStop = false;
            this.groupBoxVariaveis.Text = "Variaveis";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(999, 678);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(230, 47);
            this.buttonBuscar.TabIndex = 7;
            this.buttonBuscar.Text = "Buscar Caminho";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // groupBoxConfigs
            // 
            this.groupBoxConfigs.Controls.Add(this.numericUpDownCustoVH);
            this.groupBoxConfigs.Controls.Add(this.numericUpDownCustoDiag);
            this.groupBoxConfigs.Controls.Add(this.numericUpDownAltura);
            this.groupBoxConfigs.Controls.Add(this.numericUpDownLargura);
            this.groupBoxConfigs.Controls.Add(this.label4);
            this.groupBoxConfigs.Controls.Add(this.label3);
            this.groupBoxConfigs.Controls.Add(this.label2);
            this.groupBoxConfigs.Controls.Add(this.label1);
            this.groupBoxConfigs.Location = new System.Drawing.Point(993, 12);
            this.groupBoxConfigs.Name = "groupBoxConfigs";
            this.groupBoxConfigs.Size = new System.Drawing.Size(236, 134);
            this.groupBoxConfigs.TabIndex = 8;
            this.groupBoxConfigs.TabStop = false;
            this.groupBoxConfigs.Text = "Configurações";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altura Grid:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Largura Grid:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Custo Diagonal:";
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
            // numericUpDownLargura
            // 
            this.numericUpDownLargura.Location = new System.Drawing.Point(125, 101);
            this.numericUpDownLargura.Name = "numericUpDownLargura";
            this.numericUpDownLargura.Size = new System.Drawing.Size(105, 20);
            this.numericUpDownLargura.TabIndex = 4;
            // 
            // numericUpDownAltura
            // 
            this.numericUpDownAltura.Location = new System.Drawing.Point(125, 74);
            this.numericUpDownAltura.Name = "numericUpDownAltura";
            this.numericUpDownAltura.Size = new System.Drawing.Size(105, 20);
            this.numericUpDownAltura.TabIndex = 5;
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
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A Estrela";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBoxControles.ResumeLayout(false);
            this.groupBoxControles.PerformLayout();
            this.groupBoxConfigs.ResumeLayout(false);
            this.groupBoxConfigs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLargura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustoDiag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustoVH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.RadioButton radioButtonPontoInicial;
        private System.Windows.Forms.RadioButton radioButtonPontoFinal;
        private System.Windows.Forms.RadioButton radioButtonObstaculos;
        private System.Windows.Forms.GroupBox groupBoxControles;
        private System.Windows.Forms.GroupBox groupBoxVariaveis;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.GroupBox groupBoxConfigs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownCustoVH;
        private System.Windows.Forms.NumericUpDown numericUpDownCustoDiag;
        private System.Windows.Forms.NumericUpDown numericUpDownAltura;
        private System.Windows.Forms.NumericUpDown numericUpDownLargura;
    }
}

