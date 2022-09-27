using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobManagerDemo
{
    public partial class MainForm : Form
    {
        private HourlyCalculator _hourlyCalculator;

        public MainForm()
        {
            InitializeComponent();
            _hourlyCalculator = new HourlyCalculator();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DtHoraEntradaManha.Value = DateTime.Now.Date + TimeSpan.FromHours(8);
            DtHoraSaidaManha.Value = DateTime.Now.Date + TimeSpan.FromHours(12);
            DtHoraEntradaTarde.Value = DateTime.Now.Date + TimeSpan.FromHours(13);
            DtHoraSaidaTarde.Value = DateTime.Now.Date + TimeSpan.FromHours(17);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string horaEntradaManha = DtHoraEntradaManha.Text;
            string horaSaidaManha = DtHoraSaidaManha.Text;
            string horaEntradaTarde = DtHoraEntradaTarde.Text;
            string horaSaidaTarde = DtHoraSaidaTarde.Text;

            ListViewItem horarios = new ListViewItem(new[] {
                horaEntradaManha,
                horaSaidaManha,
                horaEntradaTarde,
                horaSaidaTarde
            });

            _hourlyCalculator.AddPointRecord(horaEntradaManha, horaSaidaManha, horaEntradaTarde, horaSaidaTarde);
            ListViewCargasHorarias.Items.Add(horarios);

            AtualizarHorasTotaisTrabalhadas();
        }

        private void BtnRemoverRegistro_Click(object sender, EventArgs e)
        {
            var itemToBeRemoved = ListViewCargasHorarias.SelectedItems[0];
            _hourlyCalculator.RemovePointRecord(itemToBeRemoved.Index);
            ListViewCargasHorarias.Items.Remove(itemToBeRemoved);

            AtualizarHorasTotaisTrabalhadas();

            BtnRemoverRegistro.Enabled = false;
        }

        private void ListViewCargasHorarias_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            BtnRemoverRegistro.Enabled = true;
        }

        private void AtualizarHorasTotaisTrabalhadas()
        {
            var horasTotais = _hourlyCalculator.TotalHoursWork;
            LblTotalHoras.Text = $"Total Horas: {horasTotais}";
        }
    }
}
