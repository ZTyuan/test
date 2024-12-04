using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;


public class LeaderboardSystem
{
    public static List<int> GetTopScores(int[] scores, int m)
    {
        // 检查边界情况
        if (scores == null || scores.Length == 0 || m <= 0)
        {
            return new List<int>();
        }

        // 对分数进行降序排序
        var sortedScores = scores.OrderByDescending(score => score).ToList();

        // 获取前m个分数
        return sortedScores.Take(m).ToList();
    }
     static void Main()
    {
        Console.ReadKey();
        GetTopScores(new int[] { 1, 2, 3, 4, 5 }, 3);
        Console.WriteLine("Fin");
    }
}

//// 单元测试
//[TestFixture]
//public class LeaderboardSystemTests
//{
//    [Test]
//    public void TestGetTopScores()
//    {
//        // 测试正常情况
//        Assert.Equals(new List<int> { 5, 4, 3 }, LeaderboardSystem.GetTopScores(new int[] { 1, 2, 3, 4, 5 }, 3));
//        Assert.Equals(new List<int> { 50, 40 }, LeaderboardSystem.GetTopScores(new int[] { 10, 20, 30, 40, 50 }, 2));

//        // 测试边界情况
//        Assert.Equals(new List<int>(), LeaderboardSystem.GetTopScores(new int[] { }, 5));
//        Assert.Equals(new List<int> { 3, 2, 1 }, LeaderboardSystem.GetTopScores(new int[] { 1, 2, 3 }, 5));
//        Assert.Equals(new List<int> { 5 }, LeaderboardSystem.GetTopScores(new int[] { 5 }, 1));
//        Assert.Equals(new List<int>(), LeaderboardSystem.GetTopScores(new int[] { 1, 2, 3 }, 0));
//        Assert.Equals(new List<int>(), LeaderboardSystem.GetTopScores(null, 5));
//    }
//}

