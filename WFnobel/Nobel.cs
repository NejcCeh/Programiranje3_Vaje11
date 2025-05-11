using System;
using Npgsql;
using System.Data;
using Microsoft.Data.Sqlite;

namespace WFnobel
{
    public partial class Nobel : Form
    {
        public Nobel()
        {
            InitializeComponent();
            string slikaPot = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\nobel.jpg"); // ozadje
            this.BackgroundImage = Image.FromFile(slikaPot);
            this.BackgroundImageLayout = ImageLayout.Stretch;

            NapolniCBleta();    // napolni listbox z leti
            NapolniCBpodrocja(); // napolni listbox s podroèji

        }

        private void PrikaziNobel(string sqlPoizvedba, Dictionary<string, object> parametri = null)
        {
            string povNiz = "Server= baza.fmf.uni-lj.si; User Id= student11; Password= student; Database= nobel2012;";
            using (NpgsqlConnection pov = new NpgsqlConnection(povNiz))
            {
                using (NpgsqlCommand povCommand = new NpgsqlCommand(sqlPoizvedba, pov))
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
                    using (NpgsqlDataReader rez = povCommand.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(rez);
                        dgwPrikaz.DataSource = dt; // prikaži podatke v gridu viewerju
                    }
                }
            }

        }

        private void NapolniCBleta()
        {
            string povNiz = "Server=baza.fmf.uni-lj.si; User Id=student11; Password=student; Database=nobel2012;";

            using (NpgsqlConnection pov = new NpgsqlConnection(povNiz))
            {
                using (NpgsqlCommand povCommand = new NpgsqlCommand("SELECT DISTINCT yr FROM nobel ORDER BY yr DESC", pov))
                {
                    pov.Open();
                    using (NpgsqlDataReader rez = povCommand.ExecuteReader())
                    {
                        while (rez.Read())
                        {
                            cbLeta.Items.Add(rez["yr"].ToString()); // Dodaj letnico v ListBox
                        }
                    }
                }
            }
        }

        private void NapolniCBpodrocja()
        {
            string povNiz = "Server=baza.fmf.uni-lj.si; User Id=student11; Password=student; Database=nobel2012;";

            using (NpgsqlConnection pov = new NpgsqlConnection(povNiz))
            {
                using (NpgsqlCommand povCommand = new NpgsqlCommand("SELECT DISTINCT subject FROM nobel ORDER BY subject ASC", pov))
                {
                    pov.Open();
                    using (NpgsqlDataReader rez = povCommand.ExecuteReader())
                    {
                        while (rez.Read())
                        {
                            cbPodrocja.Items.Add(rez["subject"].ToString()); // Dodaj podroèje v ListBox
                        }
                    }
                }
            }
        }

        private void btnIsci_Click(object sender, EventArgs e)
        {
            if(cbLeta.SelectedItem != null && cbPodrocja.SelectedItem != null) // preverimo èe je uporabnik zbral podroèje in leto
            {
                // Pretvorimo izbrano leto v integer
                int izbranoLeto;
                if (!int.TryParse(cbLeta.SelectedItem.ToString(), out izbranoLeto))
                {
                    MessageBox.Show("Napaka pri pretvorbi leta!", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var parametri = new Dictionary<string, object>
                {
                    { "@Leto", izbranoLeto }, // Leto kot integer
                    { "@Podrocje", cbPodrocja.SelectedItem.ToString() }
                };

                PrikaziNobel("SELECT yr, subject, winner FROM nobel WHERE yr = @Leto AND subject = @Podrocje", parametri);
            }
            else
            {
                MessageBox.Show("Izberi leto in podroèje!", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
