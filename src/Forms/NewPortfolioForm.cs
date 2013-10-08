using Rampage.Core.Objects;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Rampage.Forms
{
    /// <summary>
    /// NewPortfolioForm
    /// </summary>
    public partial class NewPortfolioForm : Form
    {
        /// <summary>
        /// NewPortfolioForm
        /// </summary>
        public NewPortfolioForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// NewPortfolioForm_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewPortfolioForm_Load(object sender, EventArgs e)
        {
            saveFileDialogPortfolio.InitialDirectory = Properties.Settings.Default.WorkingDirectory;
        }

        /// <summary>
        /// saveFileDialogPortfolio_FileOk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveFileDialogPortfolio_FileOk(object sender, CancelEventArgs e)
        {
            var newPortfolio = new Portfolio(textBoxName.Text,
                listBoxItems.Items.Cast<string>().ToList());

            if (newPortfolio.Save(saveFileDialogPortfolio.FileName))
            {
                Close();
            }
        }

        /// <summary>
        /// buttonSave_Click
        /// </summary>
        /// <param name="sender">event sender</param>
        /// <param name="e">event args</param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialogPortfolio.ShowDialog(this);
        }

        /// <summary>
        /// removeToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender">event sender</param>
        /// <param name="e">event args</param>
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedIndex >= 0)
            {
                listBoxItems.Items.RemoveAt(listBoxItems.SelectedIndex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItemAdd_Click(object sender, EventArgs e)
        {
            if (!listBoxItems.Items.Contains(textBoxItemName.Text))
            {
                listBoxItems.Items.Add(textBoxItemName.Text);
            }
        }
    }
}
