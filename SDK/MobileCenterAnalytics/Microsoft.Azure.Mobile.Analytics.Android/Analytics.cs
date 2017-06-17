using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Android.Runtime;
using Com.Microsoft.Azure.Mobile.Analytics;

namespace Microsoft.Azure.Mobile.Analytics
{
    /// <summary>
    /// Analytics service.
    /// </summary>
    public class Analytics : MobileCenterService
    {
        internal Analytics()
        {
        }

        /// <summary>
        /// Internal SDK property not intended for public use.
        /// </summary>
        /// <value>
        /// The Android SDK Analytics bindings type.
        /// </value>
        [Preserve]
        public static Type BindingType => typeof(AndroidAnalytics);

        /// <summary>
        /// Check whether the Analytics service is enabled or not.
        /// </summary>
        /// <returns>A task with result being true if enabled, false if disabled.</returns>
        public static Task<bool> IsEnabledAsync()
        {
            return Task.Run(() => (bool)AndroidAnalytics.IsEnabled().Get());
        }

        /// <summary>
        /// Enable or disable the Analytics service.
        /// </summary>
        public static void SetEnabled(bool enabled)
        {
            AndroidAnalytics.SetEnabled(enabled);
        }

        ///// <summary>
        ///// Enable or disable automatic page tracking.
        ///// Set this to false to if you plan to call <see cref="TrackPage"/> manually.
        ///// </summary>
        //public static bool AutoPageTrackingEnabled
        //{
        //    get { return AndroidAnalytics.AutoPageTrackingEnabled; }
        //    set { AndroidAnalytics.AutoPageTrackingEnabled = value; }
        //}

        /// <summary>
        /// Track a custom event.
        /// </summary>
        /// <param name="name">An event name.</param>
        /// <param name="properties">Optional properties.</param>
        public static void TrackEvent(string name, IDictionary<string, string> properties = null)
        {
            AndroidAnalytics.TrackEvent(name, properties);
        }

        ///// <summary>
        ///// Track a custom page.
        ///// </summary>
        ///// <param name="name">A page name.</param>
        ///// <param name="properties">Optional properties.</param>
        //public static void TrackPage(string name, [Optional] IDictionary<string, string> properties)
        //{
        //    AndroidAnalytics.TrackPage(name, properties);
        //}
    }
}
