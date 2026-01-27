namespace find_missing_num;

class Program
{
    static int MissingNum(int[]arr){
        int n = arr.Length+1;
        
        int sum =0;
		for(int i=0; i<arr.Length; i++){
            sum+=arr[i];
        }

        long expsum = (long)(n*(n+1)/2);

        return (int)(expsum-sum);
    }
    static void Main(string[] args)
    {
        int[] arr = { 8, 2, 4, 5, 3, 7, 1 };
        Console.WriteLine(MissingNum(arr));
    }
}
