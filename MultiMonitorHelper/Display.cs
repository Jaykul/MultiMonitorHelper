﻿#region Usings

using System.Drawing;

#endregion

namespace MultiMonitorHelper
{
    /// <summary>
    ///     Each monitor is abstraced away with help of IDisplay.
    /// </summary>
    public class Display
    {
        /// <summary>
        ///     Display representation on system. Such as \\.\\DISPLAY1
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        ///     Returns the resolution of display. In pixels.
        /// </summary>
        public Size Resolution { get; internal set; }

        /// <summary>
        ///     Indicates the cordinates of origin where monitor area starts from.
        ///     That is left-top cordinates.
        /// </summary>
        public Point Origin { get; internal set; }

        /// <summary>
        ///     Indicates degrees of rotation.
        /// </summary>
        public DisplayRotation Rotation { get; internal set; }

        /// <summary>
        ///     Indicates refresh rate of monitor. This is vertical refresh rate.
        /// </summary>
        public int RefreshRate { get; internal set; }

        /// <summary>
        ///     Indicates whenever display is primary or not.
        ///     The logic is simple, according to MSDN:
        ///     For display devices only, a POINTL structure that indicates the positional coordinates of
        ///     the display device in reference to the desktop area. The primary display device is always located
        ///     at coordinates (0,0).
        /// </summary>
        /// <returns></returns>
        public bool IsPrimary
        {
            get
            {
                return
                    Origin.X == 0 && Origin.Y == 0;
            }
        }

        public bool IsActive { get; internal set; }

        /// <summary>
        ///     Tries to set to rotation of display.
        /// </summary>
        /// <param name="rotation">the value of rotation</param>
        /// <returns>true if successful, false otherwise.</returns>
        public bool SetRotation(DisplayRotation rotation)
        {
            return false;
        }

        /// <summary>
        ///     Tries to set resolution of a display.
        /// </summary>
        /// <param name="newResolution">new resolution</param>
        /// <returns>true if successful, false otherwise.</returns>
        public virtual bool SetResolution(Size newResolution)
        {
            return false;
        }

        /// <summary>
        ///     Tries to set display as active.
        /// </summary>
        /// <returns>true if successful, false otherwise.</returns>
        public virtual bool SetActive()
        {
            return false;
        }

        /// <summary>
        ///     Tries to set display as deactive.
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        public virtual bool SetDeactive()
        {
            return false;
        }
    }
}