const nums = [2, 7, 11, 15];
const target = 9;

var twoSum = function (nums, target) {
    for (var i = 0; i > nums.length; i++)
    {
        if ((nums[i] + nums[i+1]) === target)
        {
            return [nums[i],nums[i+1]]
        }
    }
};

twoSum(nums, target)