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
    ///The ValidateHBWelcomeScreen recording.
    /// </summary>
    [TestModule("e46c80a6-d7fa-4a4d-817c-02019abb12b8", ModuleType.Recording, 1)]
    public partial class ValidateHBWelcomeScreen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HB_INSTALL_AUTORepository repository.
        /// </summary>
        public static HB_INSTALL_AUTORepository repo = HB_INSTALL_AUTORepository.Instance;

        static ValidateHBWelcomeScreen instance = new ValidateHBWelcomeScreen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateHBWelcomeScreen()
        {
            YearVersion = "2018.1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateHBWelcomeScreen Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable YearVersion.
        /// </summary>
        [TestVariable("dbd6732b-4572-4d2f-854e-815aa9fc2566")]
        public string YearVersion
        {
            get { return repo.YearVersion; }
            set { repo.YearVersion = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.Tabs.HelpTab' at Center.", repo.HeavyBidApp.Tabs.HelpTabInfo, new RecordItemIndex(0));
            repo.HeavyBidApp.Tabs.HelpTab.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.Buttons.Help.WelcomeScreenButton' at Center.", repo.HeavyBidApp.Buttons.Help.WelcomeScreenButtonInfo, new RecordItemIndex(1));
            repo.HeavyBidApp.Buttons.Help.WelcomeScreenButton.Click();
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'HBPopupScreens.FromHelpButtons.WelcomeToHeavyBidScreen.WelcomeToHeavyBidTitle'.", repo.HBPopupScreens.FromHelpButtons.WelcomeToHeavyBidScreen.WelcomeToHeavyBidTitleInfo, new RecordItemIndex(2));
                Validate.Exists(repo.HBPopupScreens.FromHelpButtons.WelcomeToHeavyBidScreen.WelcomeToHeavyBidTitleInfo, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeRegex (Text~$YearVersion) on item 'HBPopupScreens.FromHelpButtons.WelcomeToHeavyBidScreen.WelcomeToHeavyBidTitle'.", repo.HBPopupScreens.FromHelpButtons.WelcomeToHeavyBidScreen.WelcomeToHeavyBidTitleInfo, new RecordItemIndex(3));
                Validate.AttributeRegex(repo.HBPopupScreens.FromHelpButtons.WelcomeToHeavyBidScreen.WelcomeToHeavyBidTitleInfo, "Text", new Regex(YearVersion), null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'HBPopupScreens.FromHelpButtons.WelcomeToHeavyBidScreen.Buttons.OpenCurrentEstimate'.", repo.HBPopupScreens.FromHelpButtons.WelcomeToHeavyBidScreen.Buttons.OpenCurrentEstimateInfo, new RecordItemIndex(4));
                Validate.Exists(repo.HBPopupScreens.FromHelpButtons.WelcomeToHeavyBidScreen.Buttons.OpenCurrentEstimateInfo, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'HBPopupScreens.FromHelpButtons.WelcomeToHeavyBidScreen.Buttons.CreateNewEstimate'.", repo.HBPopupScreens.FromHelpButtons.WelcomeToHeavyBidScreen.Buttons.CreateNewEstimateInfo, new RecordItemIndex(5));
                Validate.Exists(repo.HBPopupScreens.FromHelpButtons.WelcomeToHeavyBidScreen.Buttons.CreateNewEstimateInfo, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'HBPopupScreens.FromHelpButtons.WelcomeToHeavyBidScreen.Buttons.OpenExistingEstimate'.", repo.HBPopupScreens.FromHelpButtons.WelcomeToHeavyBidScreen.Buttons.OpenExistingEstimateInfo, new RecordItemIndex(6));
                Validate.Exists(repo.HBPopupScreens.FromHelpButtons.WelcomeToHeavyBidScreen.Buttons.OpenExistingEstimateInfo, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'HBPopupScreens.FromHelpButtons.WelcomeToHeavyBidScreen.LinkNewUserWelcomeScreen'.", repo.HBPopupScreens.FromHelpButtons.WelcomeToHeavyBidScreen.LinkNewUserWelcomeScreenInfo, new RecordItemIndex(7));
                Validate.Exists(repo.HBPopupScreens.FromHelpButtons.WelcomeToHeavyBidScreen.LinkNewUserWelcomeScreenInfo, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
