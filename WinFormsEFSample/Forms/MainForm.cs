using Microsoft.Extensions.Logging;
using System.Linq;
using System.Windows.Forms;
using WinFormsEFSample.Service.Contract;

namespace WinFormsEFSample.Forms
{
    public partial class MainForm : Form
    {
        private readonly ILogger _logger;
        private readonly IHerbService _herbService;

        public MainForm(ILogger<MainForm> logger, IHerbService herbService)
        {
            _logger = logger;
            _herbService = herbService;
            InitializeComponent();
        }

        private async void btnTest_Click(object sender, System.EventArgs e)
        {
            var herbs = await _herbService.GetAllHerbs();

            MessageBox.Show($"In der Datenbank sind {herbs.Count()} Gartenkräuter registriert.");
        }
    }
}
