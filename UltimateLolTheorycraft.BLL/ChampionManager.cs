using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateLolTheorycraft.BO;
using UltimateLolTheorycraft.DAL;

namespace UltimateLolTheorycraft.BLL
{
    /// <summary>
    /// Manager of champions
    /// </summary>
    public class ChampionManager
    {
        #region Path of ressources
        static string dragonPath = Environment.ExpandEnvironmentVariables
    (@"%ProgramData%\UltimateLolTheorycraft\dragontail-4.4.3\4.4.3");
        static string championFolderPath = Path.Combine(dragonPath, @"data\fr_FR\champion");
        static string championPath = championFolderPath + ".json";
        #endregion

        /// <summary>
        /// Collection of champions
        /// </summary>
        private IEnumerable<Champion> _champions;

        #region Getter/Setter
        /// <summary>
        /// Return a champion from her id.
        /// </summary>
        /// <param name="id">champion's id</param>
        /// <returns>champion</returns>
        public Champion this[string id]
        {
            get
            {
                foreach (var champion in _champions)
                    if (champion.id == id)
                        return champion;
                return null;
            }
        }
        #endregion

        /// <summary>
        /// Default constructor that load all champions.
        /// </summary>
        public ChampionManager()
        {
            _champions = ChampionReader.Load(championPath);
        }
    }
}
