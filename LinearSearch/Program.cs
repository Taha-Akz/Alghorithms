int[] nums = {55,441,5,17,8};


bool LinearSearch (int num)
{
    bool flag;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == num)
        {
            flag = true;
            return flag;
        }

    }
    return false;
}


int number = 8;
LinearSearch(5);