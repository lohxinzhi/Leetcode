using System;
using System.ComponentModel;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.Marshalling;

namespace SortedArray
{
    class Program{
        static void Main(string[] args)
        {
            // int x = 2147483647;
            // int x =-2147483648;
            // System.Console.WriteLine(Reverse(x));

            // int x = 2549;
            // System.Console.WriteLine(IntToRoman(x));

            // int[] nums = {6,1,7,4,6,3,4,2,1,6,3,7,1,3,7,4};
            // int[] nums = {43,16,45,89,45,-2147483648,45,2147483646,-2147483647,-2147483648,43,2147483647,-2147483646,-2147483648,89,-2147483646,89,-2147483646,-2147483647,2147483646,-2147483647,16,16,2147483646,43};
            // System.Console.WriteLine(SingleNumber2(nums));

            // int[] nums = {1,1,2,5,4,3,2,1,4};
            int[] nums = {2,3,1,1,4};
            int[] y = {7,0,9,6,9,6,1,7,9,0,1,2,9,0,3};
            // System.Console.WriteLine(Jump(y));
            // System.Console.WriteLine(Jump(y));
            int[] w = {9,9,9,9};
            foreach(int i in PlusOne(w)){
                System.Console.WriteLine(i);
            }


        }
        
        static int Reverse(int x){
            int result = 0;
            while (x!=0){
                if (result > 0){
                    if (result > 214748364 ||(result == 214748364 && x%10 >= 7)){
                        return 0;             
                    }
                }
                else if (result < 0){
                    if (result < -214748364 ||(result == -214748364 && x%10 < -7)){
                        return 0;
                    }
                }
                result *=10;
                result += x % 10 ;
                x /= 10;
            }
            return result;
        }

        static string IntToRoman(int num){
            string roman = "MDCLXVI";
            int[] pos = {1000,500,100,50,10,5,1};
            string result = "";
            for (int i = 0; i<pos.Count(); i+=2){
                int temp = num/pos[i];
                switch (temp){
                    case 0:
                    case 1:
                    case 2:
                    case 3:{
                        for(int j = 0; j<temp; j++){
                            result += roman[i];
                        }
                        break;
                    }
                    case 4:{
                        result = result + roman[i] + roman[i-1];
                        break;
                    }
                    case 5:
                    case 6:
                    case 7:
                    case 8:{
                        int remain = temp - pos[i-1]/pos[i];
                        result += roman[i-1];
                        for (int j=0; j<remain; j++){
                            result += roman[i];
                        }
                        break;
                    }
                    case 9:
                        result = result + roman[i] + roman[i-2];
                        break;
                    default:
                        break;
                }
                num%=pos[i];
            }
            return result;
        }
    
        static int SingleNumber( int[] nums){

            HashSet<int> appeared = new HashSet<int>();

            foreach(int num in nums){
                if (appeared.Contains(num)){
                    appeared.Remove(num);
                }
                else{
                    appeared.Add(num);
                }
            }

            return appeared.ElementAt(0);
        }

        static int SingleNumber3( int[] nums){

            HashSet<int> appeared = new HashSet<int>();
            HashSet<int> appeared2 = new HashSet<int>();

            foreach(int num in nums){
                if (!appeared.Add(num)){ // if alr exist
                    if (!appeared2.Add(num)){
                        appeared.Remove(num);
                        appeared2.Remove(num);
                    }
                }
            }
            return appeared.ElementAt(0);

        }
    
        static int SingleNumber2 (int[] nums){
            int result = 0;
            for (int i=0; i<32; i++){
                int sum = 0;
                foreach(int num in nums){
                    sum += num >> i & 1; // sum of the number of rep in that bit position
                }
                result |= sum%3 << i;    // if never repeat 3 times, the value at that bit is 1
            }
            return result;
        }

        static int MinimumTotal(IList<IList<int>> triangle) {
            for(int i = triangle.Count-2; i>=0; i--){
                for (int j = 0; j < triangle[i].Count; j++){
                    triangle[i][j] += triangle[i+1][j] < triangle[i+1][j+1] ? triangle[i+1][j] : triangle[i+1][j+1];
                }
            }
            return triangle[0][0];
        }

        static bool CanJump(int[] nums) {
            int zero_i = -1;
            for(int i = nums.Count()-2; i>=0; i--){
                if (nums[i] == 0){
                    zero_i = Math.Max(zero_i,i);
                }
                if (zero_i >= 0){
                    if ((zero_i-i < nums[i])){
                        zero_i = -1;
                    }
                }
            }
            return zero_i < 0;
        }

        static int Jump(int[] nums){
            int result = 0;
            int current1 = 0;
            int current2 = 0;
            int length = nums.Length;


            for(int i = 0; i < length-1 ; i++ ){
                if (nums[i] > current1){
                    current2 = Math.Max(current2,nums[i]);
                }                

                if(current1 <= 0){
                    current1 = current2;
                    result++;
                }
                current1--;
                current2--;
            }
            return length == 1 ? 0 : result;
        }

        static int[] PlusOne(int[] digits){
            int carry = 1;
            for (int i = digits.Length-1; i>=0; i--){
                int temp = digits[i]+carry;
                digits[i] = temp%10;
                carry = temp/10;
                if(carry == 0){
                    return digits;
                }
            }

                return digits;

                return digits.Prepend(1).ToArray();
            
        }

    }

}
    
