using System.Text;

namespace Gauss_Jordan_Method
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void MainWindow_Load(object sender, EventArgs e)
		{
			mainLabel = new Label();

			StringBuilder sb = new StringBuilder();
			sb.AppendLine("ANÁLISIS NUMÉRICO");
			sb.AppendLine("GRUPO: 6");
			sb.AppendLine("MÉTODO DE ELIMINACIÓN COMPLETA GAUSS-JORDAN");
			sb.AppendLine();
			sb.AppendLine("Integrantes del equipo:");
			sb.AppendLine("-Bravo Moreno Gustavo Ulises");
			sb.AppendLine("- Flores González Brandon Uriel");
			sb.AppendLine("- Martinez Cruz Lizeth");
			sb.AppendLine("- Moreno Chalico Edgar Ulises");
			sb.AppendLine("- Yañez García Fernando");
			string title = sb.ToString();
			mainLabel.Text = title;

			mainLabel.Font = new Font("Arial", 12, FontStyle.Bold);

			mainLabel.AutoSize = false;
			mainLabel.TextAlign = ContentAlignment.MiddleCenter;
			mainLabel.Dock = DockStyle.Fill;

			this.Controls.Add(mainLabel);
		}

		private void OnContinueClick(object sender, EventArgs e)
		{
			this.Hide();
			var matrixForm = new MatrixCreator();
			matrixForm.Closed += (s, args) => this.Close();
			matrixForm.Show();
		}
	}
}