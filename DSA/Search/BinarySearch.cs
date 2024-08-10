public class BinarySearch {
    public int Search(int[] numbers, int target) {
        int left=0;
        int right=numbers.Length-1;

        while(left<=right)
        {
            int mid=(left+right)/2;

            if(target==numbers[mid])
            {
                return mid;
            }
            else if(target<numbers[mid])
            {
                right=mid-1;
            }
            else
            {
                left=mid+1;
            }
        }
        return -1;
    }
}