
namespace ArrayMaxConsecutiveSum{
    class Program{
        static void Main(){
            int[] teste = new int[] {5,9,-30,15,20};            
            Console.WriteLine(GetMaxConsecutiveSum(teste));
        }

        public static int GetMaxConsecutiveSum(int[] sourceArray){
            int maxSum = Int32.MinValue, sum = Int32.MinValue;

            for(int i=0; i < sourceArray.Length; i++){
                if(i==0) maxSum = sum = sourceArray[i];
                else 
                    if(sum + sourceArray[i] > sourceArray[i])
                        sum = sum + sourceArray[i];
                    else sum = sourceArray[i];

                if(sum > maxSum) maxSum = sum;
            }
            return maxSum;
        }
    }
}