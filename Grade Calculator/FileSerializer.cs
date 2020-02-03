using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using GradeControl;

namespace Grade_Calculator
{
    /// <summary>
    ///     Loads and saves files using XML Serialization
    /// </summary>
    public class FileSerializer
    {
        #region Data members

        private const string FileLocation = "C:\\temp\\gradeData.xml";

        private readonly List<GradeCategory> emptyGradeCategories = new List<GradeCategory>
            {new GradeCategory(), new GradeCategory(), new GradeCategory()};

        #endregion

        #region Methods

        /// <summary>
        ///     Loads the grade entries.
        /// </summary>
        public List<GradeCategory> LoadGradeEntries()
        {
            var serializer = new XmlSerializer(typeof(List<GradeCategory>));
            var fileStream = new FileStream(FileLocation, FileMode.OpenOrCreate);

            if (fileStream.Length.Equals(0))
            {
                fileStream.Close();
                return this.emptyGradeCategories;
            }

            var fromFile = serializer.Deserialize(fileStream) as List<GradeCategory>;
            fileStream.Close();
            return fromFile;
        }

        /// <summary>
        ///     Saves the grade entries.
        /// </summary>
        /// <param name="gradeCategories">The grade categories.</param>
        public void SaveGradeEntries(List<GradeCategory> gradeCategories)
        {
            var serializer = new XmlSerializer(typeof(List<GradeCategory>));
            var fileStream = new FileStream(FileLocation, FileMode.OpenOrCreate);
            serializer.Serialize(fileStream, gradeCategories);
            fileStream.Close();
        }

        #endregion
    }
}