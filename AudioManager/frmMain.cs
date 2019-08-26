using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioManager
{
    public partial class frmMain : Form
    {
        AudioManager am = new AudioManager();
        public frmMain()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            // 取得所有输出设备
            foreach(var dev in am.GetActiveSpeakers())
            {
                comboBoxOutput.Items.Add(dev.FriendlyName);
            }

            // 取得所有输入设备
            foreach (var dev in am.GetActiveInputs())
            {
                comboBoxInput.Items.Add(dev.FriendlyName);
            }

            trackBarOutput.Value = (int)(100 * am.GetDefaultSpeaker().AudioEndpointVolume.MasterVolumeLevelScalar);

            trackBarInput.Value = (int)(100 * am.GetDefaultInput().AudioEndpointVolume.MasterVolumeLevelScalar);
        }

        private void trackBarOutput_ValueChanged(object sender, EventArgs e)
        {
            am.SetDefaultSpeakerVolumeLevelScalar(0.01f * trackBarOutput.Value);
            lblOutputValue.Text = trackBarOutput.Value.ToString();
        }

        private void trackBarInput_ValueChanged(object sender, EventArgs e)
        {
            am.SetDefaultInputVolumeLevelScalar(0.01f * trackBarInput.Value);
            lblInputValue.Text = trackBarInput.Value.ToString();
        }
    }
}
