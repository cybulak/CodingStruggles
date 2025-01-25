using System.Collections;

namespace CodingStruggles;

public class TwoSum
{
    public static int[] Resolve(int[] nums, int target)
    {
        Hashtable ht = new Hashtable();
        
        var dic = new Dictionary<int, List<int>>();
        // nums.Select((value, index) => new { value, index })
        // .ToDictionary(x => x.value, x => x.index);

        for (var i = 0; i < nums.Length; i++)
        {
            if (dic.ContainsKey(nums[i]))
            {
                dic[nums[i]].Add(i);
            }
            else
            {
                dic.Add(nums[i], new List<int> { i });
            }
        }


        for (int i = 0; i < nums.Length; i++)
        {
            var desired = target - nums[i];
            if (dic.ContainsKey(desired) && dic[desired].First() != i)
            {
                return [dic[desired].First(), i];
            }

            if (dic.ContainsKey(desired) && dic[desired].Count == 2)
            {
                return dic[desired].ToArray();
            }
        }

        return [];
    }
}