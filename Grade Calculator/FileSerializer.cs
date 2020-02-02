using System.IO;
using System.Xml.Serialization;

namespace Grade_Calculator
{
    /// <summary>
    ///     Loads and saves files using XML Serialization
    /// </summary>
    public class FileSerializer
    {
        #region Data members

        private const string FileLocation = "gradeData.xml";

        #endregion

        #region Methods

        /// <summary>
        ///     Loads the grade entries.
        /// </summary>
        public GradeControl.GradeControl LoadGradeEntries()
        {
            var serializer = new XmlSerializer(typeof(GradeControl.GradeControl));
            var fileStream = new FileStream(FileLocation, FileMode.OpenOrCreate);
            var fromFile = serializer.Deserialize(fileStream) as GradeControl.GradeControl;
            fileStream.Close();
            return fromFile;
        }

        /// <summary>
        ///     Saves the grade entries.
        /// </summary>
        /// <param name="gradeControl">The grade control.</param>
        public void SaveGradeEntries(GradeControl.GradeControl gradeControl)
        {
            var serializer = new XmlSerializer(typeof(GradeControl.GradeControl));
            var fileStream = new FileStream(FileLocation, FileMode.OpenOrCreate);
            serializer.Serialize(fileStream, gradeControl);
            fileStream.Close();
        }

        #endregion
    }
}