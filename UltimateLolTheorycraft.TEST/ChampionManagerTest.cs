using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UltimateLolTheorycraft.BLL;

namespace UltimateLolTheorycraft.TEST
{
    [TestClass]
    public class ChampionManagerTest
    {
        [TestMethod]
        public void ChampionManager_Test()
        {
            var championManager = new ChampionManager();
            Assert.AreEqual(null, championManager["This champion do not exist"]);
            var champion = championManager["Akali"];
            Assert.AreNotEqual(null, champion);
            Assert.AreEqual("Akali", champion.name);
            Assert.AreEqual("Akali", champion.id);
            Assert.AreEqual("Poing des ombres", champion.title);
            Assert.AreEqual(445, champion.stats.hp);
            Assert.AreEqual(85, champion.stats.hpperlevel);
            Assert.AreEqual(200, champion.stats.mp);
            Assert.AreEqual(0, champion.stats.mpperlevel);
            Assert.AreEqual(350, champion.stats.movespeed);
            Assert.AreEqual(16.5, champion.stats.armor);
            Assert.AreEqual(3.5, champion.stats.armorperlevel);
            Assert.AreEqual(30, champion.stats.spellblock);
            Assert.AreEqual(1.25, champion.stats.spellblockperlevel);
            Assert.AreEqual(125, champion.stats.attackrange);
        }
    }
}
