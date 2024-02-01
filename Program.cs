using System.Collections.Generic;

List<byte> nums = new List<byte>() {
    15, 22, 100, 10, 5
};
nums.Add(30);
nums.Add(20);
nums.Add(1);
nums.Reverse();
nums.Remove(100);
nums.Sort();
foreach (byte el in nums)
{
    Console.WriteLine("El: " + el);
}