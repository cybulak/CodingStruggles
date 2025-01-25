using CodingStruggles;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace CodingStruggles.Tests;

[TestFixture]
[TestOf(typeof(TwoSum))]
public class TwoSumTest
{
    [TestCase(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [TestCase(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [TestCase(new[] { 3, 3 }, 6, new[] { 0, 1 })]
    public void TwoSumResolve(int[] nums, int target, int[] expected)
    {
        CollectionAssert.AreEquivalent(expected, TwoSum.Resolve(nums, target));
    }
}