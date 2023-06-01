class Solution(object):
    def twoSum(self, nums, target):
        solution = []
        for i in range(len(nums)):
            for j in range(i+1, len(nums)):
                if (nums[i] + nums[j] == target):
                    solution.append(i)
                    solution.append(j)
                    break
                else:
                    continue

        return solution