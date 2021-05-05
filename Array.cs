using System;
using System.Collections;

namespace LeetCodeSolutions.ArraySolution
{
	class ArraySolution
	{
        public int FindMaxConsecutiveOnes(int[] nums)
        {

            int maxConsecutive = 0;
            int currentConsecutive = 0;

            for (int i = 0; i < nums.Length; i++)
            {

                int currentItem = nums[i];

                if (currentItem == 1)
                {
                    currentConsecutive++;
                }

                if (currentItem == 0 || i == nums.Length - 1)
                {

                    if (currentConsecutive > maxConsecutive)
                    {
                        maxConsecutive = currentConsecutive;
                    }

                    currentConsecutive = 0;
                }
            }

            return maxConsecutive;
        }

        public int FindNumbers(int[] nums)
        {
            int evenNumbersCount = 0;
            foreach (int number in nums)
            {
                int digitsCount = (int)Math.Log10(number) + 1;
                if (digitsCount % 2 == 0)
                {
                    evenNumbersCount++;
                }
            }
            return evenNumbersCount;

        }

        public int[] SortedSquares(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = (int)Math.Pow((double)nums[i], 2);
            }
            Array.Sort(nums);
            return nums;
        }

        public void DuplicateZeros(int[] arr)
        {
            int arrayLength = 0;
            foreach (var item in arr)
            {
                if (item == 0)
                {
                    arrayLength += 2;
                }
                else
                {
                    arrayLength += 1;
                }
            }

            int[] newArray = new int[arrayLength];
            int addedIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    addedIndex++;
                }
                else
                {
                    newArray[i + addedIndex] = arr[i];
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = newArray[i];
            }
        }

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int j = 0;
            for (int i = m; i < nums1.Length; i++)
            {
                nums1[i] = nums2[j];
                j++;
            }

            Array.Sort(nums1);
        }

        public int RemoveElement(int[] nums, int val)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            var length = nums.Length;

            for (int i = 0; i < length;)
            {
                if (nums[i] == val)
                {
                    for (int j = i; j < length - 1; j++)
                    {
                        nums[j] = nums[j + 1];
                    }
                    length--;
                }
                else
                {
                    i++;
                }
            }

            return length;
        }

        public bool CheckIfExist(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return false;
            }

            if (arr.Length < 2 || arr.Length > 500)
            {
                return false;
            }


            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j)
                    {
                        if (arr[i] == 2 * arr[j])
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public bool ValidMountainArray(int[] arr)
        {
            if (arr == null || arr.Length == 0 || arr.Length < 3)
            {
                return false;
            }

            int pick = 0;

            for (int i = 1; i < arr.Length; i++)
            {

                if (arr[i] > arr[i - 1])
                {
                    if (arr[i] > pick)
                    {
                        pick = arr[i];
                    }
                }
                else
                {
                    for (int j = i; j < arr.Length; j++)
                    {
                        if (arr[j] >= arr[j - 1])
                        {
                            return false;
                        }
                    }
                }

            }

            if (arr[arr.Length - 1] == pick)
            {
                return false;
            }

            return true;
        }

        public int[] ReplaceElements(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return null;
            }

            if (arr.Length == 1)
            {
                arr[0] = -1;
                return arr;
            }


            for (int i = 0; i < arr.Length; i++)
            {

                if (i == arr.Length - 1)
                {
                    arr[arr.Length - 1] = -1;
                    break;
                }

                int maxValue = 0;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > maxValue)
                    {
                        maxValue = arr[j];
                    }
                }
                arr[i] = maxValue;

            }

            return arr;
        }

        public void MoveZeroes(int[] nums)
        {

            int writePointer = nums.Length - 1;

            for (int readPointer = 0; readPointer <= writePointer;)
            {
                if (nums[readPointer] == 0)
                {
                    for (int j = readPointer; j < writePointer; j++)
                    {
                        nums[j] = nums[j + 1];
                    }
                    nums[writePointer] = 0;
                    writePointer--;
                }
                else
                {
                    readPointer++;
                }
            }

        }

        public int[] SortArrayByParity(int[] A)
        {
            if (A == null || A.Length == 0 || A.Length > 5000)
            {
                return null;
            }

            if (A.Length == 1)
            {
                return A;
            }

            var lastIndex = A.Length - 1;
            var firstIndex = 0;
            for (int i = 0; firstIndex < lastIndex; i++)
            {
                if (A[firstIndex] % 2 == 0 && A[lastIndex] % 2 == 0)
                {
                    firstIndex++;
                }
                if (A[firstIndex] % 2 == 1 && A[lastIndex] % 2 == 0)
                {
                    int tmp = A[firstIndex];
                    A[firstIndex] = A[lastIndex];
                    A[lastIndex] = tmp;

                    firstIndex++;
                    lastIndex--;
                }
                if (A[firstIndex] % 2 == 0 && A[lastIndex] % 2 == 1)
                {
                    firstIndex++;
                    lastIndex--;
                }
                if (A[firstIndex] % 2 == 1 && A[lastIndex] % 2 == 1)
                {
                    lastIndex--;
                }
            }
            return A;
        }

        public int RemoveElementInPlace(int[] nums, int val)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            var length = nums.Length;

            for (int i = 0; i < length;)
            {
                if (nums[i] == val)
                {
                    for (int j = i; j < length - 1; j++)
                    {
                        nums[j] = nums[j + 1];
                    }
                    length--;
                }
                else
                {
                    i++;
                }
            }

            return length;
        }

        public int HeightChecker(int[] heights)
        {
            if (heights == null || heights.Length == 0)
            {
                return 0;
            }
            int result = 0;
            int[] nums = new int[heights.Length];
            heights.CopyTo(nums, 0);
            //sorting
            Array.Sort(heights);
            //comparing 

            for (int i = 0; i < heights.Length; i++)
            {
                if (nums[i] != heights[i])
                {
                    result++;
                }
            }

            return result;
        }

        public int[] SortedSquares2(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = (int)Math.Pow((double)nums[i], 2);
            }
            Array.Sort(nums);
            return nums;
        }
    }
}
