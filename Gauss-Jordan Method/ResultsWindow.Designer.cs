namespace Gauss_Jordan_Method
{
	partial class ResultsWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsWindow));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblPivot = new System.Windows.Forms.Label();
			this.btnPrev = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.label_determinant = new System.Windows.Forms.Label();
			this.exitButton = new System.Windows.Forms.Button();
			this.matrix_table = new System.Windows.Forms.DataGridView();
			this.result_matrix = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.matrix_table)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.result_matrix)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.lblPivot);
			this.panel1.Controls.Add(this.btnPrev);
			this.panel1.Controls.Add(this.btnNext);
			this.panel1.Controls.Add(this.label_determinant);
			this.panel1.Controls.Add(this.exitButton);
			this.panel1.Location = new System.Drawing.Point(12, 237);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(643, 67);
			this.panel1.TabIndex = 3;
			// 
			// lblPivot
			// 
			this.lblPivot.AutoSize = true;
			this.lblPivot.Location = new System.Drawing.Point(3, 37);
			this.lblPivot.Name = "lblPivot";
			this.lblPivot.Size = new System.Drawing.Size(115, 15);
			this.lblPivot.TabIndex = 6;
			this.lblPivot.Text = "Pivote seleccionado:";
			// 
			// btnPrev
			// 
			this.btnPrev.Location = new System.Drawing.Point(484, 8);
			this.btnPrev.Name = "btnPrev";
			this.btnPrev.Size = new System.Drawing.Size(75, 23);
			this.btnPrev.TabIndex = 5;
			this.btnPrev.Text = "Anterior";
			this.btnPrev.UseVisualStyleBackColor = true;
			this.btnPrev.Click += new System.EventHandler(this.OnPrevClicked);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(565, 8);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(75, 23);
			this.btnNext.TabIndex = 4;
			this.btnNext.Text = "Siguiente";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.OnNextClicked);
			// 
			// label_determinant
			// 
			this.label_determinant.AutoSize = true;
			this.label_determinant.Location = new System.Drawing.Point(3, 12);
			this.label_determinant.Name = "label_determinant";
			this.label_determinant.Size = new System.Drawing.Size(107, 15);
			this.label_determinant.TabIndex = 3;
			this.label_determinant.Text = "El determinante es:";
			this.label_determinant.UseMnemonic = false;
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(565, 37);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 23);
			this.exitButton.TabIndex = 2;
			this.exitButton.Text = "Regresar";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.OnExitClicked);
			// 
			// matrix_table
			// 
			this.matrix_table.AllowUserToAddRows = false;
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
			this.matrix_table.Enabled = false;
			this.matrix_table.Location = new System.Drawing.Point(12, 12);
			this.matrix_table.Name = "matrix_table";
			this.matrix_table.RowHeadersVisible = false;
			this.matrix_table.RowTemplate.Height = 25;
			this.matrix_table.Size = new System.Drawing.Size(500, 218);
			this.matrix_table.TabIndex = 5;
			// 
			// result_matrix
			// 
			this.result_matrix.AllowUserToAddRows = false;
			this.result_matrix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.result_matrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.result_matrix.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.result_matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.result_matrix.ColumnHeadersVisible = false;
			this.result_matrix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
			this.result_matrix.Location = new System.Drawing.Point(539, 12);
			this.result_matrix.Name = "result_matrix";
			this.result_matrix.RowTemplate.Height = 25;
			this.result_matrix.Size = new System.Drawing.Size(116, 218);
			this.result_matrix.TabIndex = 6;
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
			this.label2.Location = new System.Drawing.Point(518, 115);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(15, 15);
			this.label2.TabIndex = 7;
			this.label2.Text = "=";
			// 
			// ResultsWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(667, 316);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.result_matrix);
			this.Controls.Add(this.matrix_table);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ResultsWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Solución";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.matrix_table)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.result_matrix)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Panel panel1;
		private Button exitButton;
		private DataGridView matrix_table;
		private DataGridView result_matrix;
		private DataGridViewTextBoxColumn Column1;
		private Label label2;
		private Label label_determinant;
		private Label lblPivot;
		private Button btnPrev;
		private Button btnNext;
	}
}