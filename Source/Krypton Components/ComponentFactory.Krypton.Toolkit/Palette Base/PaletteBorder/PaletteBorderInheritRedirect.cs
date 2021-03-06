﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2017. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.5.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System.Drawing;

namespace ComponentFactory.Krypton.Toolkit
{
	/// <summary>
	/// Provide inheritance of palette border properties from source redirector.
	/// </summary>
	public class PaletteBorderInheritRedirect : PaletteBorderInherit
	{
		#region Instance Fields
		private PaletteRedirect _redirect;

	    #endregion

		#region Identity
		/// <summary>
		/// Initialize a new instance of the PaletteBorderInheritRedirect class.
		/// </summary>
		/// <param name="redirect">Source for inherit requests.</param>
        public PaletteBorderInheritRedirect(PaletteRedirect redirect)
            : this(redirect, PaletteBorderStyle.ButtonStandalone)
        {
        }

        /// <summary>
		/// Initialize a new instance of the PaletteBorderInheritRedirect class.
		/// </summary>
		/// <param name="redirect">Source for inherit requests.</param>
		/// <param name="style">Style used in requests.</param>
		public PaletteBorderInheritRedirect(PaletteRedirect redirect,
											PaletteBorderStyle style)
		{
			_redirect = redirect;
			Style = style;
		}
		#endregion

        #region OverrideBorderToFalse
        /// <summary>
        /// Gets and sets the overriding of the border draw to always be false.
        /// </summary>
        public bool OverrideBorderToFalse { get; set; }

	    #endregion

        #region GetRedirector
        /// <summary>
        /// Gets the redirector instance.
        /// </summary>
        /// <returns>Return the currently used redirector.</returns>
        public PaletteRedirect GetRedirector()
        {
            return _redirect;
        }
        #endregion

        #region SetRedirector
        /// <summary>
        /// Update the redirector with new reference.
        /// </summary>
        /// <param name="redirect">Target redirector.</param>
        public void SetRedirector(PaletteRedirect redirect)
        {
            _redirect = redirect;
        }
        #endregion

		#region Style
		/// <summary>
		/// Gets and sets the style to use when inheriting.
		/// </summary>
		public PaletteBorderStyle Style { get; set; }

	    #endregion

		#region IPaletteBorder
		/// <summary>
		/// Gets a value indicating if border should be drawn.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>InheritBool value.</returns>
		public override InheritBool GetBorderDraw(PaletteState state)
		{
<<<<<<< HEAD
            if (OverrideBorderToFalse)
=======
            if (_overrideBorderToFalse)
>>>>>>> 34c21c928b71cd4ee4309f654c1d3400dc34b747
            {
                return InheritBool.False;
            }
            else
            {
<<<<<<< HEAD
                return _redirect.GetBorderDraw(Style, state);
=======
                return _redirect.GetBorderDraw(_style, state);
>>>>>>> 34c21c928b71cd4ee4309f654c1d3400dc34b747
            }
        }

        /// <summary>
        /// Gets a value indicating which borders to draw.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>PaletteDrawBorders value.</returns>
        public override PaletteDrawBorders GetBorderDrawBorders(PaletteState state)
        {
            return _redirect.GetBorderDrawBorders(Style, state);
        }

		/// <summary>
		/// Gets the graphics drawing hint.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>PaletteGraphicsHint value.</returns>
		public override PaletteGraphicsHint GetBorderGraphicsHint(PaletteState state)
		{
			return _redirect.GetBorderGraphicsHint(Style, state);
		}

		/// <summary>
		/// Gets the first border color from the redirector.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>Color value.</returns>
		public override Color GetBorderColor1(PaletteState state)
		{
			return _redirect.GetBorderColor1(Style, state);
		}

		/// <summary>
		/// Gets the second border color from the redirector.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>Color value.</returns>
		public override Color GetBorderColor2(PaletteState state)
		{
			return _redirect.GetBorderColor2(Style, state);
		}

		/// <summary>
		/// Gets the color drawing style from the redirector.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>Color drawing style.</returns>
		public override PaletteColorStyle GetBorderColorStyle(PaletteState state)
		{
			return _redirect.GetBorderColorStyle(Style, state);
		}

		/// <summary>
		/// Gets the color alignment style from the redirector.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>Color alignment style.</returns>
		public override PaletteRectangleAlign GetBorderColorAlign(PaletteState state)
		{
			return _redirect.GetBorderColorAlign(Style, state);
		}

		/// <summary>
		/// Gets the color border angle from the redirector.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>Angle used for color drawing.</returns>
		public override float GetBorderColorAngle(PaletteState state)
		{
			return _redirect.GetBorderColorAngle(Style, state);
		}

		/// <summary>
		/// Gets the border width from the redirector.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>Border width.</returns>
		public override int GetBorderWidth(PaletteState state)
		{
			return _redirect.GetBorderWidth(Style, state);
		}

		/// <summary>
		/// Gets the border rounding from the redirector.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>Border rounding.</returns>
		public override int GetBorderRounding(PaletteState state)
		{
			return _redirect.GetBorderRounding(Style, state);
		}

		/// <summary>
		/// Gets a border image from the redirector.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>Image instance.</returns>
		public override Image GetBorderImage(PaletteState state)
		{
			return _redirect.GetBorderImage(Style, state);
		}

		/// <summary>
		/// Gets the border image style from the redirector.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>Image style value.</returns>
		public override PaletteImageStyle GetBorderImageStyle(PaletteState state)
		{
			return _redirect.GetBorderImageStyle(Style, state);
		}

		/// <summary>
		/// Gets the image alignment style from the redirector.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>Image alignment style.</returns>
		public override PaletteRectangleAlign GetBorderImageAlign(PaletteState state)
		{
			return _redirect.GetBorderImageAlign(Style, state);
		}
        #endregion
	}
}
