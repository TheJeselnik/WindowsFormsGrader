using System.Collections.Generic;
using System.Data;
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

        private const string FileLocation = "C:\\temp\\gradeData.xml";

        #endregion

        #region Methods

        /// <summary>
        ///     Loads the grade entries.
        /// </summary>
        public List<DataSet> LoadGradeEntries()
        {
            var serializer = new XmlSerializer(typeof(List<DataSet>));
            var fileStream = new FileStream(FileLocation, FileMode.OpenOrCreate);
            var fromFile = serializer.Deserialize(fileStream) as List<DataSet>;
            fileStream.Close();
            return fromFile;
        }

        /// <summary>
        /// Saves the grade entries.
        /// </summary>
        /// <param name="dataSets">The grade controls.</param>
        public void SaveGradeEntries(List<DataSet> dataSets)
        {
            var serializer = new XmlSerializer(typeof(List<DataSet>));
            var fileStream = new FileStream(FileLocation, FileMode.OpenOrCreate);
            serializer.Serialize(fileStream, dataSets);
            fileStream.Close();
        }

        #endregion
    }
}