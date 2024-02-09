using DataAcces;
using Dominio;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid;
using System.Data;

namespace Agendamentos
{
    public partial class FAgendamentos : Form
    {
        private AgendaDAO agendaDAO = new AgendaDAO();

        public FAgendamentos()
        {
            InitializeComponent();
            CarregarDadosAgendas();
            CarregaDadosRelatorios();



        }

        private void CarregarDadosAgendas()
        {
            agendaDAO.CompararListas();
            sfDataGridAgendas.DataSource = agendaDAO.agendas;
            sfDataGridAgendas.GroupColumnDescriptions.Add(new GroupColumnDescription() { ColumnName = "Agendamentos" });
        }

        private void CarregaDadosRelatorios()
        {
            agendaDAO.CompararListas();
            sfDataGridRelatorios.DataSource = agendaDAO.relatorios;
            sfDataGridRelatorios.GroupColumnDescriptions.Add(new GroupColumnDescription() { ColumnName = "DataAtendimento" });

        }

    }
}