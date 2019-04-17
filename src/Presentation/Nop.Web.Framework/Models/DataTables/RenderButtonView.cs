﻿namespace Nop.Web.Framework.Models.DataTables
{
    /// <summary>
    /// Represents button view render for DataTables column
    /// </summary>
    public partial class RenderButtonView : IRender
    {
        #region Ctor

        /// <summary>
        /// Initializes a new instance of the RenderButtonEdit class 
        /// </summary>
        /// <param name="url">URL to the edit action</param>
        public RenderButtonView(DataUrl url)
        {
            Url = url;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets Url to action edit
        /// </summary>
        public DataUrl Url { get; set; }

        /// <summary>
        /// Gets or sets button style
        /// </summary>
        public StyleButton Style { get; set; }

        #endregion
    }
}