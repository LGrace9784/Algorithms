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
        public bool ValidAnagram(string s, string t){ 
            if (s.Length != t.Length) { 
                return false; 
            } 
            
            Dictionary<char, int> storage = new Dictionary<char, int>(); 
            
            for (int i = 0; i < s.Length; i++) { 
                if (!storage.ContainsKey(s[i])) { 
                    storage[s[i]] = 0; 
                } 
                storage[s[i]]++; 
            } 
            
            for (int i = 0; i < t.Length; i++) { 
                if (!storage.ContainsKey(t[i])) { 
                    return false; 
                } 
                storage[t[i]]--; 
            } 
            foreach (var count in storage.Values) { 
                if (count != 0) { 
                    return false; 
                } 
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
        public void ReverseString(char[] s){
            // reverses the string
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
        public int RemoveDuplicates(int[] nums){
            // removes any duplicates from a sorted array
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
        public void MergeSort(int[] nums)
            {
                if (nums.Length <= 1)
                {
                    return;
                }

                int mid = nums.Length / 2;

                int[] left = nums[..mid];
                int[] right = nums[mid..];

                MergeSort(left);
                MergeSort(right);

                Merge(nums, left, right);
            }
            public void Merge(int[] nums, int[] left, int[] right)
            {
                int i = 0;
                int j = 0;
                int k = 0;

                while (i < left.Length && j < right.Length)
                {
                    if (left[i] <= right[j])
                    {
                        nums[k] = left[i];
                        i++;
                    }
                    else
                    {
                        nums[k] = right[j];
                        j++;
                    }

                    k++;
                }

                while (i < left.Length)
                {
                    nums[k] = left[i];
                    i++;
                    k++;
                }

                while (j < right.Length)
                {
                    nums[k] = right[j];
                    j++;
                    k++;
                }
            }
        public static double CalculateExpectedScore(double playerRating, double opponentRating)
    {
        return 1.0 / (1.0 + Math.Pow(10, (opponentRating - playerRating) / 400.0));
    }
            public static void UpdateRatings(
                ChessPlayer playerA,
                ChessPlayer playerB,
                double scoreA,
                                int kFactor = 32)
    {
        double expectedA = CalculateExpectedScore(playerA.Rating, playerB.Rating);
        double expectedB = CalculateExpectedScore(playerB.Rating, playerA.Rating);

        double scoreB = 1.0 - scoreA;

        playerA.Rating += kFactor * (scoreA - expectedA);
        playerB.Rating += kFactor * (scoreB - expectedB);
    }
            public static List<ChessPlayer> SortPlayers(List<ChessPlayer> players)
{
    return players
        .OrderByDescending(player => player.Rating)
        .ToList();
}
            public static List<(ChessPlayer, ChessPlayer)> GeneratePairings(
                        List<ChessPlayer> players)
{
    var sortedPlayers = players
        .OrderByDescending(player => player.Score)
        .ThenByDescending(player => player.Rating)
        .ToList();

    var pairings = new List<(ChessPlayer, ChessPlayer)>();

    for (int i = 0; i + 1 < sortedPlayers.Count; i += 2)
    {
        pairings.Add((sortedPlayers[i], sortedPlayers[i + 1]));
    }

    return pairings;
}
        public int[] PlusOne(int[] digits) { 
            // adds one number to the end of the array list
            for (int i = digits.Length - 1; i >= 0; i--) { 
                if (digits[i] < 9) { 
                    digits[i]++; 
                    return digits; 
                } 
                digits[i] = 0; 
            } 
        int[] result = new int[digits.Length + 1]; 
        result[0] = 1; 
        
        return result;
    }

}

