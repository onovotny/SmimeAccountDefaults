﻿namespace SmimeAccountDefaults
{
    partial class SettingsRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public SettingsRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl1 = this.Factory.CreateRibbonDialogLauncher();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.securityGroup = this.Factory.CreateRibbonGroup();
            this.toggleSuspendSigning = this.Factory.CreateRibbonToggleButton();
            this.toggleSuspendEncryption = this.Factory.CreateRibbonToggleButton();
            this.tab1.SuspendLayout();
            this.securityGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.ControlId.OfficeId = "TabOptions";
            this.tab1.Groups.Add(this.securityGroup);
            this.tab1.Label = "TabOptions";
            this.tab1.Name = "tab1";
            this.tab1.Position = this.Factory.RibbonPosition.AfterOfficeId("GroupRightsManagement");
            // 
            // securityGroup
            // 
            ribbonDialogLauncherImpl1.ScreenTip = "Preferences";
            this.securityGroup.DialogLauncher = ribbonDialogLauncherImpl1;
            this.securityGroup.Items.Add(this.toggleSuspendSigning);
            this.securityGroup.Items.Add(this.toggleSuspendEncryption);
            this.securityGroup.Label = "S/MIME";
            this.securityGroup.Name = "securityGroup";
            this.securityGroup.DialogLauncherClick += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.securityGroup_DialogLauncherClick);
            // 
            // toggleSuspendSigning
            // 
            this.toggleSuspendSigning.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.toggleSuspendSigning.Label = "Suspend Signing";
            this.toggleSuspendSigning.Name = "toggleSuspendSigning";
            this.toggleSuspendSigning.ShowImage = true;
            // 
            // toggleSuspendEncryption
            // 
            this.toggleSuspendEncryption.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.toggleSuspendEncryption.Label = "Suspend Encryption";
            this.toggleSuspendEncryption.Name = "toggleSuspendEncryption";
            this.toggleSuspendEncryption.ShowImage = true;
            // 
            // SettingsRibbon
            // 
            this.Name = "SettingsRibbon";
            this.RibbonType = "Microsoft.Outlook.Mail.Compose";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.SettingsRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.securityGroup.ResumeLayout(false);
            this.securityGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup securityGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton toggleSuspendSigning;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton toggleSuspendEncryption;
    }

    partial class ThisRibbonCollection
    {
        internal SettingsRibbon SettingsRibbon
        {
            get { return this.GetRibbon<SettingsRibbon>(); }
        }
    }
}
