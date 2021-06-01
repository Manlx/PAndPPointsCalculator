using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAndPPointsCalculator
{
    public partial class frmPlayerSelector : Form
    {
        frmMain Creator;
        public frmPlayerSelector(frmMain X)
        {
            InitializeComponent();
            Creator = X;
        }

        private void frmPlayerSelector_Load(object sender, EventArgs e)
        {
            tabPlayerSetup.Appearance = TabAppearance.FlatButtons;
            tabPlayerSetup.ItemSize = new Size(0,1);
            tabPlayerSetup.SizeMode = TabSizeMode.Fixed;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            lblPlayers.Text = $"Players: {hsbPlayers.Value.ToString()}";
        }
        List<PlayerDisplay> lstPD = new List<PlayerDisplay>();
        string[] PlayerList = {"Player One","Player Two","Player Three","Player Four","Player Five" };
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            tabPlayerSetup.SelectedTab = tabPlayerAvatar;
            Creator.PlayerCount = hsbPlayers.Value;
            for (int x = 0; x < Creator.PlayerCount; x++)
            {
                PlayerDisplay Temp = new PlayerDisplay();
            }
        }
    }
}
