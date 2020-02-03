using System.Collections.Generic;

namespace GradeControl
{
    /// <summary>
    ///     Contains Grade Entries and a Weight for a defined Category
    /// </summary>
    public class GradeCategory
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the grade entries.
        /// </summary>
        /// <value>
        ///     The grade entries.
        /// </value>
        public List<GradeEntry> GradeEntries { get; set; }

        /// <summary>
        ///     Gets or sets the weight.
        /// </summary>
        /// <value>
        ///     The weight.
        /// </value>
        public int Weight { get; set; } = 0;

        #endregion

        public GradeCategory()
        {
            this.GradeEntries = new List<GradeEntry>();
        }
    }
}