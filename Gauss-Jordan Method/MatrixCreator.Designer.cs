namespace Gauss_Jordan_Method
{
	partial class MatrixCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatrixCreator));
            this.label1 = new System.Windows.Forms.Label();
            this.matrix_size = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.matrix_table = new System.Windows.Forms.DataGridView();
            this.result_matrix = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matrix_size)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrix_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamaño de la matriz (nxn): ";
            // 
            // matrix_size
            // 
            this.matrix_size.Location = new System.Drawing.Point(183, 8);
            this.matrix_size.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.matrix_size.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.matrix_size.Name = "matrix_size";
            this.matrix_size.Size = new System.Drawing.Size(52, 23);
            this.matrix_size.TabIndex = 1;
            this.matrix_size.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.matrix_size.ValueChanged += new System.EventHandler(this.OnResizeMatrixChange);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.matrix_size);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 40);
            this.panel1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(365, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Resolver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OnSolveClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(446, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Abrir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnOpenClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnSaveClicked);
            // 
            // matrix_table
            // 
            this.matrix_table.AllowUserToAddRows = false;
            this.matrix_table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matrix_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matrix_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.matrix_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix_table.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.matrix_table.DefaultCellStyle = dataGridViewCellStyle1;
            this.matrix_table.Location = new System.Drawing.Point(12, 58);
            this.matrix_table.Name = "matrix_table";
            this.matrix_table.RowHeadersVisible = false;
            this.matrix_table.RowTemplate.Height = 25;
            this.matrix_table.Size = new System.Drawing.Size(500, 218);
            this.matrix_table.TabIndex = 4;
            this.matrix_table.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.ValidateIsNumber);
            // 
            // result_matrix
            // 
            this.result_matrix.AllowUserToAddRows = false;
            this.result_matrix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result_matrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.result_matrix.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.result_matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result_matrix.ColumnHeadersVisible = false;
            this.result_matrix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.result_matrix.Location = new System.Drawing.Point(560, 58);
            this.result_matrix.Name = "result_matrix";
            this.result_matrix.RowHeadersVisible = false;
            this.result_matrix.RowTemplate.Height = 25;
            this.result_matrix.Size = new System.Drawing.Size(57, 218);
            this.result_matrix.TabIndex = 5;
            this.result_matrix.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.ValidateIsNumber);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "=";
            // 
            // MatrixCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 288);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.result_matrix);
            this.Controls.Add(this.matrix_table);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MatrixCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Método de eliminación completa Gauss-Jordan";
            ((System.ComponentModel.ISupportInitialize)(this.matrix_size)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrix_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_matrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Label label1;
		private NumericUpDown matrix_size;
		private Panel panel1;
		private DataGridView matrix_table;
		private DataGridView result_matrix;
		private DataGridViewTextBoxColumn Column1;
		private Label label2;
		private Button button1;
		private Button button3;
		private Button button2;
	}
}