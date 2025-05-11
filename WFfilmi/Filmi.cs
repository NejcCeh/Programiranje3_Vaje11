using Microsoft.Data.Sqlite;
using System.Data;

namespace WFfilmi
{
    public partial class Filmi : Form
    {
        public Filmi()
        {
            InitializeComponent();
        }

        private void PrikaziFilme(string sqlPoizvedba, Dictionary<string, object> parametri = null)
        {
            string povNiz = "Data source = C:\\Prog3Baze\\filmi.sqlite";
            using (SqliteConnection pov = new SqliteConnection(povNiz))
            {
                using (SqliteCommand povCommand = new SqliteCommand(sqlPoizvedba, pov))
                {
                    povCommand.CommandType = System.Data.CommandType.Text;

                    if (parametri != null)
                    {
                        foreach (var par in parametri)
                        {
                            povCommand.Parameters.AddWithValue(par.Key, par.Value);
                        }
                    }

                    pov.Open();
                    using (SqliteDataReader rez = povCommand.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(rez);
                        dgwPrikaz.DataSource = dt;
                    }
                }
            }

        }

        private void btnPrikazFilmov_Click(object sender, EventArgs e)
        {
            PrikaziFilme("SELECT naslov FROM filmi");
        }

        private void btnOcena_Click(object sender, EventArgs e)
        {
            // preverimo uporabnika
            double iskanaOcena;
            if (double.TryParse(tbOcena.Text, out iskanaOcena))
            {
                var parametri = new Dictionary<string, object> { { "@Ocena", iskanaOcena } };
                PrikaziFilme("SELECT naslov, ocena FROM filmi WHERE ocena >= @Ocena ORDER BY ocena DESC", parametri);
            }
            else
            {
                MessageBox.Show("Neveljavna ocena", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            tbOcena.Text = "";

        }

        private void btnIsciNaslov_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbNaslov.Text))
            {
                var parametri = new Dictionary<string, object> { { "@Naslov", "%" + tbNaslov.Text + "%" } };
                PrikaziFilme("SELECT * FROM filmi WHERE naslov LIKE @Naslov", parametri);
            }
            else
            {
                MessageBox.Show("Neveljaven vnos", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            tbNaslov.Text = "";
        }

        private void btnReziser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbReziser.Text))
            {
                var parametri = new Dictionary<string, object> { { "@Reziser", "%" + tbReziser.Text + "%" } };
                PrikaziFilme("SELECT id, naslov, reziser, ocena, certifikat, opis FROM filmi WHERE reziser LIKE @Reziser", parametri);
            }
            else
            {
                MessageBox.Show("Neveljaven vnos", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            tbReziser.Text = "";

        }
    }
}
