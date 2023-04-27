using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WeatherApp
{
    public partial class WeatherForm : Form
    {
        private WeatherDatabase _weather;

        public WeatherForm()
        {
            InitializeComponent();

            _weather = new WeatherDatabase();
            _weather.Initialize();

            WeatherDataGrid.DataSource = _weather.AvtoMagazs.ToList();
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

            WeatherDataGrid.DataSource = _weather.AvtoMagazs.Where(u=>u.ZapName.ToLower().Contains(textBox1.Text.ToLower())).ToList();
            WeatherDataGrid.DataSource = _weather.AvtoMagazs.Where(u => u.RasName.ToLower().Contains(textBox1.Text.ToLower())).ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (comboBox1.SelectedIndex) 
            { 
                case 0:
                    WeatherDataGrid.DataSource = _weather.AvtoMagazs.Where(u => u.Avto== Avto.Honda).ToList();
                   break; 
                case 1:
                    WeatherDataGrid.DataSource = _weather.AvtoMagazs.Where(u => u.Avto == Avto.Nissan).ToList();
                    break;
                case 2:
                    WeatherDataGrid.DataSource = _weather.AvtoMagazs.Where(u => u.Avto == Avto.Toyoat).ToList();
                    break;
                    
            }
            
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            textBox1.Text = "";
            WeatherDataGrid.DataSource = _weather.AvtoMagazs.ToList();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            WeatherDataGrid.DataSource = _weather.AvtoMagazs.Where(u => u.Cena>0 ).ToList();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            WeatherDataGrid.DataSource = _weather.AvtoMagazs.OrderBy(u => u.Cena).ToList();
        }

        private void WeatherDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void WeatherForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}