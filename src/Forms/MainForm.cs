using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using Rampage.Controls;
using Rampage.Core.Objects;
using Rampage.Core.Util;
using System.Diagnostics;

namespace Rampage.Forms
{
    /// <summary>
    /// MainForm
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Actually exit?!
        /// </summary>
        private bool exit;

        /// <summary>
        /// The active tab page
        /// </summary>
        private TabPage activeTabPage;

        /// <summary>
        /// MainForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// MainForm_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, System.EventArgs e)
        {
            openFileDialogMain.InitialDirectory = Properties.Settings.Default.WorkingDirectory;
            folderBrowserDialogMain.SelectedPath = Properties.Settings.Default.WorkingDirectory;
            toolStripTextBoxCWD.Text = Properties.Settings.Default.WorkingDirectory;
        }

        /// <summary>
        /// MainForm_FormClosing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var retainFocus = false;

            if (exit)
            {
                if (Properties.Settings.Default.AskExit)
                {
                    using (var quitDialog = new QuitDialog())
                    {
                        if (quitDialog.ShowDialog(this) == DialogResult.OK)
                        {
                            Properties.Settings.Default.AskExit =
                                quitDialog.checkBoxDontAsk.Checked;

                            Properties.Settings.Default.Save();

                            return;
                        }

                        retainFocus = true;
                    }
                }
                else
                {
                    return;
                }
            }

            if (retainFocus)
            {
                exit = false;

                e.Cancel = true;

                return;
            }

            //There are several ways to close an application.
            //We are trying to find the click of the X in the upper right hand corner
            //We will only allow the closing of this app if it is minimized.
            if (WindowState == FormWindowState.Minimized)
            {
                return;
            }

            //we don't close the app...
            e.Cancel = true;

            // minimize the app and then display a message to the user so
            // they understand they didn't close the app they just sent it to the tray.
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// MainForm_Move
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Move(object sender, System.EventArgs e)
        {
            //If we are minimizing the form then hide it so it doesn't show up on the 
            //task bar
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
            else
            {
                //any other windows state show it.
                Show();

                // minimize the app and then display a message to the user so
                // they understand they didn't close the app they just sent it to the tray.
                WindowState = FormWindowState.Normal;
            }
        }

        /// <summary>
        /// notifyIconMain_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIconMain_Click(object sender, System.EventArgs e)
        {

        }

        /// <summary>
        /// notifyIconMain_MouseDoubleClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIconMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        /// <summary>
        /// newToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var frmNewPortfolio = new NewPortfolioForm();

            frmNewPortfolio.FormClosed += (a, b) => { };
            frmNewPortfolio.Show(this);
        }

        /// <summary>
        /// openToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var tmpReturn = openFileDialogMain.ShowDialog(this);

            if (tmpReturn != DialogResult.OK)
                return;

            foreach (var fileName in openFileDialogMain.SafeFileNames)
            {
                try
                {
                    var tmpFullPath = Path.Combine(Properties.Settings.Default.WorkingDirectory, fileName);
                    var tmpPortfolio = Portfolio.Load(tmpFullPath);
                    activeTabPage = new TabPage(tmpPortfolio.Name);
                    activeTabPage.Controls.Add(new PortfolioViewControl(tmpPortfolio) { Dock = DockStyle.Fill });
                    tabControlMain.TabPages.Add(activeTabPage);
                    statusMain.Text = string.Format("Success! Loaded {0}", tmpPortfolio);
                }
                catch (SerializationException serializationException)
                {
                    statusMain.Text = string.Format("Saved failed {0}; serializaton exception", fileName);
                    Debug.Write(serializationException.Message);
                }
                catch (IOException ioException)
                {
                    statusMain.Text = string.Format("Saved failed {0}; I/O exception", fileName);
                    Debug.Write(ioException.Message);
                }
            }
        }

        /// <summary>
        /// exitToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            exit = true;

            Close();
        }

        /// <summary>
        /// toolStripTextBoxCWD_TextChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripTextBoxCWD_TextChanged(object sender, System.EventArgs e)
        {
            if (Directory.Exists(toolStripTextBoxCWD.Text))
            {
                Properties.Settings.Default.WorkingDirectory = toolStripTextBoxCWD.Text;
            }
        }

        /// <summary>
        /// saveToolStripMenuItem_Click
        /// <remarks>saves the active portoflio</remarks>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (activeTabPage == null)
                return;

            var ctrl = activeTabPage.Controls[0] as PortfolioViewControl;

            if (ctrl.Portfolio == null)
                return;

            if (ctrl.Portfolio.Save())
            {
                statusMain.Text = string.Format("{0} saved as {1}",
                    ctrl.Portfolio, ctrl.Portfolio.FileName);
            }
            else
            {
                statusMain.Text = string.Format("Saved failed {0}", ctrl.Portfolio);
            }
        }

        /// <summary>
        /// tabControlMain_Selected
        /// <remarks>just updates the active tab page field.</remarks>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControlMain_Selected(object sender, TabControlEventArgs e)
        {
            activeTabPage = e.TabPage;
        }
    }
}
