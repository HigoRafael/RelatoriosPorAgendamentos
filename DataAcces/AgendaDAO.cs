using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Org.BouncyCastle.Asn1.BC;


namespace DataAcces
{
    public class AgendaDAO : ConnectionFactoryMySQL
    {
        public DataTable agendas;
        public DataTable relatorios;

        public DataTable CarregarDadosAgendas()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT saa.cd_evento 'N.Agendamento',\r\n                     DATE(saa.dt_inicio_evento) AS 'Agendamentos',\r\n                     sa.em_atendente AS 'Email',\r\n\r\n  (SELECT sai.cd_atendente_integracao\r\n   FROM sd_atendente sai\r\n   WHERE sai.em_atendente = sa.em_atendente\r\n     AND NOT(ISNULL(sai.cd_atendente_integracao))) AS 'Custo Atendente',\r\n                     saa.ds_local AS 'Local',\r\n                     saa.ds_assunto AS 'Assunto'\r\nFROM sd_agenda_atendente saa\r\nLEFT\r\nJOIN sd_atendente sa ON saa.cd_atendente = sa.cd_atendente\r\nWHERE saa.dt_inicio_evento >= '2023-12-01'\r\nORDER BY saa.dt_inicio_evento";
                    cmd.CommandType = CommandType.Text;
                    MySqlDataReader reader = cmd.ExecuteReader();

                    DataTable result = new DataTable();
                    DataColumn colunaRAT = new DataColumn("RAT", typeof(int));
                    DataColumn colunaAtividade = new DataColumn("Sequência", typeof(int));

                    result.Load(reader);

                    result.Columns.Add(colunaRAT);
                    result.Columns.Add(colunaAtividade);
                    return result;
                }
            }

        }

        public DataTable CarregarDadosRelatorios()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT DISTINCT sra.cd_rat AS 'RAT',\r\n                sac.cd_atividade_chamado AS 'Sequencia',\r\n                sac.dt_atividade_chamado AS 'DataAtendimento',\r\n                sa.em_atendente AS 'Email',\r\n                sa.cd_atendente_integracao AS 'CustoAtendente',\r\n                sc2.nm_cliente AS 'Cliente',\r\n                sc.ds_chamado AS 'Assunto',\r\n                CASE\r\n                    WHEN sr.st_rat = 1 THEN 'Aguardando Aprovação'\r\n                    WHEN sr.st_rat = 2 THEN 'Aprovado'\r\n                    WHEN sr.st_rat = 3 THEN 'Contestado'\r\n                    WHEN sr.st_rat = 5 THEN 'Em Cobrança'\r\n                    ELSE 'Desconhecido'\r\n                END AS \"Status\"\r\nFROM sd_atividade_chamado sac\r\nINNER JOIN sd_rat_atividade sra ON sra.cd_chamado = sac.cd_chamado\r\nINNER JOIN sd_chamado sc ON sc.cd_chamado = sac.cd_chamado\r\nINNER JOIN sd_rat sr ON sr.cd_rat = sra.cd_rat\r\nLEFT JOIN sd_cliente sc2 ON sc.cd_cliente = sc2.cd_cliente\r\nLEFT JOIN sd_atendente sa ON sc.cd_atendente = sa.cd_atendente\r\nWHERE sac.fl_cobrar_atividade = 1\r\n  AND sac.dt_atividade_chamado >= '2023-12-01'\r\nORDER BY sra.cd_rat, sac.cd_atividade_chamado";
                    cmd.CommandType = CommandType.Text;
                    MySqlDataReader reader = cmd.ExecuteReader();

                    DataTable result = new DataTable();
                    DataColumn numeroAgendamento = new DataColumn("N.Agendamento", typeof(int));
                    result.Load(reader);
                    result.Columns.Add(numeroAgendamento);
                    return result;
                }
            }
        }

        public void CompararListas()
        {
            var listaAgendas = CarregarDadosAgendas();

            var listaRelatorios = CarregarDadosRelatorios();

            foreach (DataRow agenda in listaAgendas.Rows)
            {
                foreach (DataRow relatorio in listaRelatorios.Rows)
                {
                    var dataAgendamento = agenda["Agendamentos"];
                    var custoAtendenteAgenda = agenda["Custo Atendente"];

                    var dataAtendimentoRelatorio = relatorio["DataAtendimento"];
                    var custoAtendenteRelatorio = relatorio["CustoAtendente"];

                    if ((dataAgendamento.ToString() == dataAtendimentoRelatorio.ToString()) && (custoAtendenteAgenda.Equals(custoAtendenteRelatorio)))
                    {
                        agenda["RAT"] = relatorio["RAT"];
                        agenda["Sequência"] = relatorio["Sequencia"];
                        relatorio["N.Agendamento"] = agenda["N.Agendamento"];

                    }

                }
            }
            agendas = listaAgendas;
            relatorios = listaRelatorios;
        }
    }
}
