using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Rampage.Core.Util
{
    /// <summary>
    /// Extension method that rides on top of all obects.
    /// This came from a project that i've been "ruminating" on for a while
    /// <seealso cref="http://github.com/PJensen/Persisted"/>
    /// </summary>
    public static class Persisted
    {
        /// <summary>
        /// Read a templated type from a fully qualified file-path; return the deserialized object.
        /// </summary>
        /// <typeparam name="T">The templated type that willl be returned.</typeparam>
        /// <param name="strFullPath">The fully qualified file path that will be deserialized.</param>
        /// <returns>The result of deserialize, casted as <c>T</c></returns>
        /// <exception cref="IOException">{strFullPath} not found</exception>
        public static T Read<T>(string strFullPath)
        {
            if (string.IsNullOrEmpty(strFullPath))
                throw new ArgumentException("strFullPath cannot be null or empty");
            if (!File.Exists(strFullPath))
                throw new IOException(string.Format("The file \"{0}\" was not found", strFullPath));
            using (Stream fs = new FileStream(strFullPath, FileMode.Open))
            {
                var serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(fs);
            }
        }

        /// <summary>
        /// Write the templated type (aObj) <c>to</c> the fully qualified file-path.  
        /// <remarks>If the path <c>does not</c> exist, the full-directory-tree <c>will</c> be created.</remarks>
        /// </summary>
        /// <typeparam name="T">The templated type that willl be written to disk.</typeparam>
        /// <param name="aObj">The actual object that is written to disk.</param>
        /// <param name="strFullPath">The fully qualified file-path.
        /// <example>c:\temp\out\1.xml</example>
        /// <example>.\out\2.xml</example>
        /// <example>3.xml</example>
        /// </param>
        /// <returns>true when the operation was a success.</returns>
        public static bool Write<T>(T aObj, string strFullPath)
            where T : class, new()
        {
            if (aObj == null)
                throw new ArgumentException("The object to serialize cannot be null.");
            if (string.IsNullOrEmpty(strFullPath))
                throw new ArgumentException("The fullpath was null or empty.");

            try
            {
                using (var tmpRawStream = File.Open(strFullPath,
                    File.Exists(strFullPath) ? FileMode.Truncate : FileMode.CreateNew))
                using (var tmpXmlWriter = new XmlTextWriter(tmpRawStream, new System.Text.UTF8Encoding()))
                    new XmlSerializer(aObj.GetType()).Serialize(tmpXmlWriter, aObj);
                return true;
            }
            catch { return false; }
        }
    }
}
