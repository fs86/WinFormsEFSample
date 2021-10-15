using Microsoft.Extensions.Logging;
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
    }
}
