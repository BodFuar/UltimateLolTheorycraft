using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateLolTheorycraft.BO;
using System.Runtime.CompilerServices;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

[assembly: InternalsVisibleTo("UltimateLolTheorycraft.BLL")]
namespace UltimateLolTheorycraft.DAL
{
    /// <summary>
    /// Access to data of champion.
    /// </summary>
    internal class ChampionReader
    {
        /// <summary>
        /// Load the list of champion from a json file.
        /// </summary>
        /// <param name="pathFile">File's file</param>
        /// <returns>Champion from file</returns>
        public static IEnumerable<Champion> Load(string championPath)
        {
            return  JObject.Parse(File.ReadAllText(championPath))["data"].Children().
                Select(d => JsonConvert.DeserializeObject<Champion>(d.First.ToString()));
        }
    }
}
