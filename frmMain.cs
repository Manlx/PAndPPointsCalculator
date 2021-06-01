using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PAndPPointsCalculator
{
    public partial class frmMain : Form
    {
        private static OleDbConnection myConnection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|CardsDB.mdb;Persist Security Info=True");
        private static OleDbCommand myCommand = new OleDbCommand("", myConnection);
        public frmMain()
        {
            InitializeComponent();
            PlaySelect = new frmPlayerSelector(this);
        }
        private static frmPlayerSelector PlaySelect;
        public int PlayerCount;
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                myConnection.Open();
                //MessageBox.Show("Connection Successful");
            }
            catch (Exception E)
            {
                MessageBox.Show($"Connection could not have been made: {E.Message}");
                throw;
            }
            myConnection.Close();
            PlaySelect.ShowDialog();
            
        }
    }
}
