using System;
using System.Linq;

namespace Project;

class Program
{    
    static void Main(string[] args)
    {
        int [] nums = {5,7,4,30,45,-3,-2,57,9};
        nums = nums.Where(mas => mas % 2 != 0 && mas >=0).ToArray();
        foreach(int mas in nums)
        Console.WriteLine(mas);   
    }
}