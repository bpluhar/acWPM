using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Utilities;

namespace WindowsFormsApp4
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        // Ammo Offsets
        // The start of the ammo value in memory
        uint pAmmoAddress = 0x0010F4F4;
        // The offset from the start of the pAddress to the stored Ammo value(0x0150 = 336)
        int pAmmoOffset = 0x0150;
        // Becomes address where ammo is stored

        // Health Offsets
        // The start of the health value in memory
        uint pHealthAddress = 0x00109B74;
        // The offset from the start of the pHealthAddress to the stored Health value ()
        int pHealthOffset = 0x00F8;

        uint ammooffset = 0;
        uint healthoffset = 0;
        int bytesOut = 0;

        ProcessMemoryReader mReader = new ProcessMemoryReader();

        private void btnReadMemory_Click(object sender, EventArgs e)
        {
            
            Process p = Process.GetProcessesByName("ac_client").ToList().FirstOrDefault();
            if (p != null)
            {
                mReader.ReadProcess = p;
                lblProcessId.Text = String.Format("Process ID: {0:G}", p.Id);
                mReader.OpenProcess();

                // Ammo Reading
                ammooffset = BitConverter.ToUInt32(mReader.ReadMemory((IntPtr)(pAmmoAddress + (uint)p.Modules[0].BaseAddress), 4, out bytesOut), 0);
                if (pAmmoOffset < 0)
                {
                    ammooffset -= (uint)Math.Abs(pAmmoOffset);
                }
                else
                {
                    ammooffset += (uint)pAmmoOffset;
                }

                healthoffset = BitConverter.ToUInt32(mReader.ReadMemory((IntPtr)(pHealthAddress + (uint)p.Modules[0].BaseAddress), 4, out bytesOut), 0);
                if (pHealthOffset < 0)
                {
                    healthoffset -= (uint)Math.Abs(pHealthOffset);
                }
                else
                {
                    healthoffset += (uint)pHealthOffset;
                }

                btnReadMemory.Enabled = false;
                btnReadMemory.Text = "Attached!";
                btnMaxAmmo.Enabled = true;
                btnMaxHealth.Enabled = true;

            }
            else if (p == null)
            {
                lblProcessId.Text = "Process not found! Is it running?";
            }
        }

        private void btnMaxAmmo_Click(object sender, EventArgs e)
        {
            mReader.WriteMemory((IntPtr)ammooffset, BitConverter.GetBytes(1000), out bytesOut);

        }

        private void btnMaxHealth_Click(object sender, EventArgs e)
        {
            mReader.WriteMemory((IntPtr)healthoffset, BitConverter.GetBytes(1000), out bytesOut);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblProcessId.Text = "Not attached";
            btnMaxAmmo.Enabled = false;
            btnMaxHealth.Enabled = false;
        }
    }
}
