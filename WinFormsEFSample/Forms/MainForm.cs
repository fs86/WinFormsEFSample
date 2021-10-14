using Microsoft.Extensions.Logging;
using System.Windows.Forms;

namespace WinFormsEFSample.Forms
{
    public partial class MainForm : Form
    {
        private readonly ILogger _logger;

        public MainForm(ILogger<MainForm> logger)
        {
            _logger = logger;
            InitializeComponent();
        }
    }
}
