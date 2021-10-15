using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
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

            dgvHerbs.AutoGenerateColumns = false;
            lblStatus.Text = string.Empty;
        }

        private async Task LoadData()
        {
            lblStatus.Text = "Loading data ...";

            dgvHerbs.DataSource = null;

            var herbs = await _herbService.GetAllHerbs();

            var bindingSource = new BindingSource();
            bindingSource.DataSource = herbs;

            dgvHerbs.DataSource = bindingSource;

            lblStatus.Text = $"{herbs.Count()} herbs found in database.";
        }

        private async void MainForm_Load(object sender, System.EventArgs e)
        {
            await LoadData();
        }

        private async void btnRefresh_Click(object sender, System.EventArgs e)
        {
            await LoadData();
        }
    }
}
