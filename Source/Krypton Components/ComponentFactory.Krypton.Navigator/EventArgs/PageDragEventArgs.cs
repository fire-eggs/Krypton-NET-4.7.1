﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2017. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.5.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System;
using System.Drawing;

namespace ComponentFactory.Krypton.Navigator
{
	/// <summary>
    /// Details for an event that provides pages associated with a page dragging event.
	/// </summary>
	public class PageDragEventArgs : EventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the KryptonPageDragEventArgs class.
		/// </summary>
        /// <param name="screenPoint">Screen point of the mouse.</param>
        /// <param name="pages">Array of event associated pages.</param>
        public PageDragEventArgs(Point screenPoint,
                                 KryptonPage[] pages)
		{
            ScreenPoint = screenPoint;
            Pages = new KryptonPageCollection();

            if (pages != null)
            {
<<<<<<< HEAD
                Pages.AddRange(pages);
=======
                _pages.AddRange(pages);
>>>>>>> 34c21c928b71cd4ee4309f654c1d3400dc34b747
            }
		}

        /// <summary>
        /// Initialize a new instance of the KryptonPageDragEventArgs class.
        /// </summary>
        /// <param name="screenPoint">Screen point of the mouse.</param>
        /// <param name="pages">Collection of event associated pages.</param>
        public PageDragEventArgs(Point screenPoint,
                                 KryptonPageCollection pages)
        {
            ScreenPoint = screenPoint;
            Pages = pages;
        }
        #endregion

        #region ScreenPoint
        /// <summary>
        /// Gets access to the associated screen point.
        /// </summary>
        public Point ScreenPoint { get; }

	    #endregion

        #region Pages
        /// <summary>
        /// Gets access to the collection of pages.
        /// </summary>
        public KryptonPageCollection Pages { get; }

	    #endregion
    }
}
