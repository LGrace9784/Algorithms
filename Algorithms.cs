using System;
using System.Collections.Generic;
   public class Algorithms
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++){
                int complement = target - nums[i];
                if (map.ContainsKey(complement)){
                    return new int[] { map[complement], i };
                }

                map[nums[i]] = i;
        }

        return new int[0];
        }
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> storage = new HashSet<int>();

            for(int i = 0; i < nums.Length; i++){
                if (storage.Contains(nums[i])){
                    return true;
                }
                storage.Add(nums[i]);
            }
            return false;
        }
        public bool ValidAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            int[] count = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                count[s[i] - 'a']++;
                count[t[i] - 'a']--;
            }

            for (int i = 0; i < 26; i++)
            {
                if (count[i] != 0) 
                return false;
            }

            return true;
        }
        public int BinarySearch(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    return i;
                }        
            }

            return -1;
        }
        public void ReverseString(char[] s)
        {
            int left = 0;
            int right = s.Length -1;

            while (left < right)
            {
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;

                left++;
                right--;
            }
        }
        public int BuyVsSell(int[] prices)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;

            for(int i = 0; i < prices.Length; i++)
            {
                if(prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }

                int profit = prices[i] - minPrice;

                if (profit > maxProfit)
                {
                    maxProfit = profit;
                }
            }
            return maxProfit;
        }
        public int RemoveElement(int[] nums, int val) {

        int k = 0;

        for(int i = 0; i < nums.Length; i++){
            if(nums[i] != val){
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }
        public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        int k = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[k - 1])
            {
                nums[k] = nums[i];
                k++;
            }
        }

        return k;
    }

}

