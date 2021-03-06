﻿using System;

namespace log4netParser {
    /// <summary>
    /// Summary description for EventHub.
    /// </summary>
    /// <remarks>
    /// 2014-11-11 dan: Created
    /// </remarks>
    public static class EventHub {

        /* *******************************************************************
         *  Events 
         * *******************************************************************/
        /// <summary>
        /// This event is fired when 
        /// </summary>
        public static event LogEntryEventHandler HideLogger;
        public static event LogEntryEventHandler FindEntry;
        public static event LogEntryEventHandler FilterThread;

        #region protected virtual void OnHideLogger(HideLoggerEventArgs e)
        /// <summary>
        /// Notifies the listeners of the HideLogger event
        /// </summary>
        /// <param name="e">The argument to send to the listeners</param>
        public static void OnHideLogger(LogEntryEventArgs e) {
            HideLogger?.Invoke(null, e);
        }

        #endregion

        public static void OnFindEntry(LogEntryEventArgs e) {
            FindEntry?.Invoke(null, e);
        }

        public static void OnFilterThread(LogEntryEventArgs e) {
            FilterThread?.Invoke(null, e);
        }
    }

    public delegate void LogEntryEventHandler(object source, LogEntryEventArgs e);
    public class LogEntryEventArgs : EventArgs {
        #region public LogEntry Entry
        /// <summary>
        /// Get/Sets the Entry of the HideLoggerEventArgs
        /// </summary>
        /// <value></value>
        public LogEntry Entry { get; set; }
        #endregion
        #region public HideLoggerEventArgs()
        /// <summary>
        /// Initializes a new instance of the <b>HideLoggerEventArgs</b> class.
        /// </summary>
        public LogEntryEventArgs() { }
        #endregion
        #region public HideLoggerEventArgs(LogEntry entry)
        /// <summary>
        /// Initializes a new instance of the <b>HideLoggerEventArgs</b> class.
        /// </summary>
        /// <param name="entry"></param>
        public LogEntryEventArgs(LogEntry entry) {
            Entry = entry;
        }
        #endregion
    }
}