﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Microsoft.Office.Tools.Ribbon;
using SmimeAccountDefaults.Properties;

namespace SmimeAccountDefaults
{
    public partial class SettingsRibbon
    {
        private void SettingsRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            toggleSuspend.Checked = Settings.Default.IsSuspended;
        }

        private void securityGroup_DialogLauncherClick(object sender, RibbonControlEventArgs e)
        {
            var configWindow = new ConfigurationWindow();
            configWindow.ShowDialog();
            
        }

        private void toggleSuspend_Click(object sender, RibbonControlEventArgs e)
        {
            Settings.Default.IsSuspended = toggleSuspend.Checked;
            Settings.Default.Save();
        }
    }
}
