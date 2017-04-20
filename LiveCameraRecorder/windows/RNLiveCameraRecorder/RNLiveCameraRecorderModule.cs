using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Com.Reactlibrary.RNLiveCameraRecorder
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNLiveCameraRecorderModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNLiveCameraRecorderModule"/>.
        /// </summary>
        internal RNLiveCameraRecorderModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNLiveCameraRecorder";
            }
        }
    }
}
