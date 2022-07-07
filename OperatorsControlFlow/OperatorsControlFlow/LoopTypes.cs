namespace OperatorsControlFlow
{
    public static class LoopTypes
    {
        public static int HighestForEachLoop(List<int> nums)
        {
            if (nums.Count < 1)
            {
                throw new ArgumentException("Invalid List");
            }

            int highest = int.MinValue;
            foreach(int i in nums)
            {
                highest = i > highest ? i : highest;

            }
            return highest;
        }

        public static int HighestForLoop(List<int> nums)
        {
            int highest = int.MinValue;
            for(int i = 0; i < nums.Count; i++)
            {
                highest = nums[i] > highest ? nums[i] : highest;
            }
            return highest;
        }

        public static int HighestWhileLoop(List<int> nums)
        {
            int i = 0;
            int highest = int.MinValue;

            while ( i < nums.Count){
                highest = nums[i] > highest ? nums[i] : highest;
                i++;
            }
            return highest;

        }

        public static int HighestDoWhileLoop(List<int> nums)
        {
            int i = 0;
            int highest = int.MinValue;
            do
            {
                highest = nums[i] > highest ? nums[i] : highest;
                i++;
            } while (i < nums.Count);
            return highest;

        }
    }
}
