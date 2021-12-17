using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Management.Automation;

namespace KriptekSearch
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtDosyaYol.Text = fbd.SelectedPath + "\\";
                }
            }
        }

        private void btnSimdiAra_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtAranacakKelime.Text.Trim() == "")
                {
                    MessageBox.Show("Lütfen aranacak kelimeyi girin.", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                listBoxSonuc.Items.Clear();

                string folderPath = txtDosyaYol.Text;
                string searchStr = txtAranacakKelime.Text;
                string filtre = txtFiltre.Text;

                using (PowerShell powerShell = PowerShell.Create())
                {
                    powerShell.AddScript($@"Get-ChildItem -Path '{folderPath}*.{filtre}' -Recurse |Select-String -Pattern '{searchStr}'");
                    powerShell.Invoke();

                    IAsyncResult asyncpl = powerShell.BeginInvoke();

                    foreach (var item in powerShell.EndInvoke(asyncpl))
                    {
                        listBoxSonuc.Items.Add(item.ToString());
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void listBoxSonuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] karakterSplit = listBoxSonuc.SelectedItem.ToString().Split(':');

            string diskYolu = karakterSplit[0] + ":";
            string dosyaYolu = karakterSplit[1];

            Clipboard.SetText(diskYolu + dosyaYolu);
        }
    }
}
