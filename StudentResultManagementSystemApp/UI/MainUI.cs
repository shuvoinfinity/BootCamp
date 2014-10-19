using System;
using System.Windows.Forms;

namespace StudentResultManagementSystemApp.UI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            EnrollUI aEnrollUi = new EnrollUI();
            aEnrollUi.ShowDialog();
        }

        private void enterResultButton_Click(object sender, EventArgs e)
        {
            ResultEntryUI aResultEntryUi = new ResultEntryUI();
            aResultEntryUi.ShowDialog();
        }

        private void showResultSheetButton_Click(object sender, EventArgs e)
        {
            ResultSheetUI aResultSheetUi = new ResultSheetUI();
            aResultSheetUi.ShowDialog();
        }
    }
}
