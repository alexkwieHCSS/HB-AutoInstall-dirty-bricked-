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
    ///The RestoreEstimate recording.
    /// </summary>
    [TestModule("96d67d1e-50eb-4f1d-95a2-6513f38e016c", ModuleType.Recording, 1)]
    public partial class RestoreEstimate : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HB_INSTALL_AUTORepository repository.
        /// </summary>
        public static HB_INSTALL_AUTORepository repo = HB_INSTALL_AUTORepository.Instance;

        static RestoreEstimate instance = new RestoreEstimate();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RestoreEstimate()
        {
            DefaultEstimates = "1-BRIDGE";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RestoreEstimate Instance
        {
            get { return instance; }
        }

#region Variables

        string _DefaultEstimates;

        /// <summary>
        /// Gets or sets the value of variable DefaultEstimates.
        /// </summary>
        [TestVariable("56d32c59-1af1-401f-b7c9-c153b4a1f33a")]
        public string DefaultEstimates
        {
            get { return _DefaultEstimates; }
            set { _DefaultEstimates = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidTabs.FileTab' at Center.", repo.HeavyBidTabs.FileTabInfo, new RecordItemIndex(0));
            repo.HeavyBidTabs.FileTab.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidTabs.ButtonRestoreEsimate' at Center.", repo.HeavyBidTabs.ButtonRestoreEsimateInfo, new RecordItemIndex(1));
            repo.HeavyBidTabs.ButtonRestoreEsimate.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBButtonDropdownOptions.Estimate' at Center.", repo.HBButtonDropdownOptions.EstimateInfo, new RecordItemIndex(2));
            repo.HBButtonDropdownOptions.Estimate.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RestoreEstimates.ButtonNext' at Center.", repo.RestoreEstimates.ButtonNextInfo, new RecordItemIndex(3));
            repo.RestoreEstimates.ButtonNext.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DefaultEstimates'.", new RecordItemIndex(4));
            Keyboard.Press(DefaultEstimates);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RestoreEstimatesFound.ButtonOk' at Center.", repo.RestoreEstimatesFound.ButtonOkInfo, new RecordItemIndex(5));
            repo.RestoreEstimatesFound.ButtonOk.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RestoreEstimates.ButtonFinish' at Center.", repo.RestoreEstimates.ButtonFinishInfo, new RecordItemIndex(6));
            repo.RestoreEstimates.ButtonFinish.Click();
            Delay.Milliseconds(200);
            
            // This step takes TOO long!
            Report.Log(ReportLevel.Info, "Mouse", "This step takes TOO long!\r\nMouse Left Click item 'RestoreEstimates.ButtonOk' at Center.", repo.RestoreEstimates.ButtonOkInfo, new RecordItemIndex(7));
            repo.RestoreEstimates.ButtonOk.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(8));
            Delay.Duration(5000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
