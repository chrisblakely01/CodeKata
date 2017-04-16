public class Kata
{
    public static int FindEvenIndex(int[] arr)
    {
        int leftSum;
        int rightSum;
        int index = 1;

        while (index < arr.Length - 1)
        {
            leftSum = 0;
            rightSum = 0;
            for (int i = 0; i < index; i++)
            {
                leftSum += arr[i];
            }

            for (int j = arr.Length-1; j > index; j--)
            {
                rightSum += arr[j];
            }

            if (leftSum == rightSum)
            {
                return index;
            }
            index++;
        }
        return -1;
    }
}