/*
 * Created by Ranorex
 * User: Administrator
 * Date: 4/17/2019
 * Time: 2:22 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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

namespace AutomationSQLdm.BVT.TC_722025
{
    /// <summary>
    /// Description of Verifydatacollectionhappensandshowsdata.
    /// </summary>
    [TestModule("5CF80798-92C0-4187-9903-324AC2100BBE", ModuleType.UserCode, 1)]
    public class Verifydatacollectionhappensandshowsdata : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verifydatacollectionhappensandshowsdata()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
        }
    }
}
