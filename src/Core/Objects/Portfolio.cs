using System;
using System.Collections.Generic;
using Rampage.Core.Interfaces;
using Rampage.Core.Util;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Rampage.Core.Objects
{
    /// <summary>
    /// Portfolio
    /// </summary>
    [Serializable]
    [DebuggerDisplay("{Name} ({Items.Count})")]
    public sealed class Portfolio : ISave
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The file name
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Items
        /// </summary>
        public List<string> Items { get; set; }

        /// <summary>
        /// Portfolio
        /// </summary>
        internal Portfolio(string name, List<string> items)
        {
            Items = items;
            Name = name;
        }

        /// <summary>
        /// Portfolio
        /// </summary>
        public Portfolio() { }

        /// <summary>
        /// Save
        /// </summary>
        /// <returns>true on success</returns>
        public bool Save()
        {
            return Save(FileName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fullPath"></param>
        /// <returns></returns>
        public bool Save(string fullPath)
        {
            FileName = fullPath;

            return Persisted.Write(this, FileName);
        }

        /// <summary>
        /// Portfolio
        /// </summary>
        /// <param name="fullPath">the full path to load a portfolio from</param>
        /// <returns></returns>
        public static Portfolio Load(string fullPath)
        {
            var tmpPortfolio = Persisted.Read<Portfolio>(fullPath);
            tmpPortfolio.FileName = fullPath;
            return tmpPortfolio;
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0} ({1})", Name, Items.Count);
        }
    }
}
