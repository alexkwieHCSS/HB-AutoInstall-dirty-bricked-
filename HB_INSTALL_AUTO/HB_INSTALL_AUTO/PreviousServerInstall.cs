﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace HB_INSTALL_AUTO
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The PreviousServerInstall recording.
    /// </summary>
    [TestModule("6936efa7-f3ef-4abb-967f-75ea9f63544b", ModuleType.Recording, 1)]
    public partial class PreviousServerInstall : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HB_INSTALL_AUTORepository repository.
        /// </summary>
        public static HB_INSTALL_AUTORepository repo = HB_INSTALL_AUTORepository.Instance;

        static PreviousServerInstall instance = new PreviousServerInstall();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PreviousServerInstall()
        {
            YearVersion = "2018.1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PreviousServerInstall Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable YearVersion.
        /// </summary>
        [TestVariable("14080096-9f7d-4e4d-b702-8245c47ff8d5")]
        public string YearVersion
        {
            get { return repo.YearVersion; }
            set { repo.YearVersion = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.1")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            // B.3
            Report.Log(ReportLevel.Info, "Validation", "B.3\r\nValidating AttributeRegEx (Text~'[HeavyBid][Setup]') on item 'HeavyBidServerSetup.Titlebar'.", repo.HeavyBidServerSetup.TitlebarInfo, new RecordItemIndex(0));
            Validate.Attribute(repo.HeavyBidServerSetup.TitlebarInfo, "Text", new Regex("[HeavyBid][Setup]"));
            Delay.Milliseconds(0);
            
            // B.3
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nB.3\r\nValidating AttributeRegEx (Text~$YearVersion) on item 'HeavyBidServerSetup.Titlebar'.", repo.HeavyBidServerSetup.TitlebarInfo, new RecordItemIndex(1));
                Validate.Attribute(repo.HeavyBidServerSetup.TitlebarInfo, "Text", new Regex(YearVersion), Validate.DefaultMessage, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'HeavyBidServerSetup.TextBoxForValidation.PreviousInstallPopup'.", repo.HeavyBidServerSetup.TextBoxForValidation.PreviousInstallPopupInfo, new RecordItemIndex(2));
                Validate.Exists(repo.HeavyBidServerSetup.TextBoxForValidation.PreviousInstallPopupInfo, Validate.DefaultMessage, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'HeavyBidServerSetup.Buttons.ButtonYes' at Center.", repo.HeavyBidServerSetup.Buttons.ButtonYesInfo, new RecordItemIndex(3));
                repo.HeavyBidServerSetup.Buttons.ButtonYes.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
