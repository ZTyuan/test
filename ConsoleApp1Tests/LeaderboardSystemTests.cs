using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class LeaderboardSystemTests
    {
        [TestMethod()]
        public void TestGetTopScores()
        {
            // 测试正常情况
            CollectionAssert.AreEqual(new List<int> { 5, 4, 3 }, LeaderboardSystem.GetTopScores(new int[] { 1, 2, 3, 4, 5 }, 3));
            CollectionAssert.AreEqual(new List<int> { 50, 40 }, LeaderboardSystem.GetTopScores(new int[] { 10, 20, 30, 40, 50 }, 2));

            // 测试边界情况
            CollectionAssert.AreEqual(new List<int>(), LeaderboardSystem.GetTopScores(new int[] { }, 5));
            CollectionAssert.AreEqual(new List<int> { 3, 2, 1 }, LeaderboardSystem.GetTopScores(new int[] { 1, 2, 3 }, 5));
            CollectionAssert.AreEqual(new List<int> { 5 }, LeaderboardSystem.GetTopScores(new int[] { 5 }, 1));
            CollectionAssert.AreEqual(new List<int>(), LeaderboardSystem.GetTopScores(new int[] { 1, 2, 3 }, 0));
            CollectionAssert.AreEqual(new List<int>(), LeaderboardSystem.GetTopScores(null, 5));
        }
    
    }
}