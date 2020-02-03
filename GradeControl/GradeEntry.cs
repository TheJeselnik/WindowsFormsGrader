namespace GradeControl
{
    /// <summary>
    ///     Encapsulates a row of a GradeControl's DataGridView
    /// </summary>
    public class GradeEntry
    {
        #region Properties

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="GradeEntry" /> is included.
        /// </summary>
        /// <value>
        ///     <c>true</c> if included; otherwise, <c>false</c>.
        /// </value>
        public bool Included { get; set; }

        /// <summary>
        ///     Gets or sets the grade.
        /// </summary>
        /// <value>
        ///     The grade.
        /// </value>
        public string Grade { get; set; }

        /// <summary>
        ///     Gets or sets the description.
        /// </summary>
        /// <value>
        ///     The description.
        /// </value>
        public string Description { get; set; }

        #endregion
    }
}