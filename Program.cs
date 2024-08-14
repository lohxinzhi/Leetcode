using System;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

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
            // int[] nums = {2,3,1,1,4};
            // int[] y = {7,0,9,6,9,6,1,7,9,0,1,2,9,0,3};
            // // System.Console.WriteLine(Jump(y));
            // // System.Console.WriteLine(Jump(y));
            // int[] w = {9,9,9,9};
            // foreach(int i in PlusOne(w)){
            //     System.Console.WriteLine(i);
            // }

            // TreeNode a = new TreeNode(1);
            // TreeNode b = new TreeNode(2);
            // TreeNode c = new TreeNode(3,a,b);
            // TreeNode e = new TreeNode(4);
            // TreeNode d = new TreeNode(5);
            // TreeNode f = new TreeNode(6,e,d);
            // TreeNode g = new TreeNode(7,c,f);
            
            // TreeNode d = new TreeNode(4);
            // TreeNode a = new TreeNode(1);
            // TreeNode b = new TreeNode(2,a,d);
            // TreeNode c = new TreeNode(3,null,b);

            // // TreeNode h = new TreeNode(8);


            // // IList<int> something = PreorderTraversal(g);
            // IList<int> something = PostorderTraversal(c);
            // foreach(int i in something){
            //     System.Console.WriteLine(i);
            // }

            // System.Console.WriteLine(CountDigitOne(5));
            // System.Console.WriteLine(ClimbStairs(1));
            // System.Console.WriteLine(MySqrt(10));
            // System.Console.WriteLine(MySqrt(11));
            // System.Console.WriteLine(MySqrt(16));
            // System.Console.WriteLine(MySqrt(18));
            // System.Console.WriteLine(MySqrt(100));
            // System.Console.WriteLine(MySqrt(2146468900));
            // System.Console.WriteLine(MaxPoints([[7,3],[19,19],[-16,3],[13,17],[-18,1],[-18,-17],[13,-3],[3,7],[-11,12],[7,19],[19,-12],[20,-18],[-16,-15],[-10,-15],[-16,-18],[-14,-1],[18,10],[-13,8],[7,-5],[-4,-9],[-11,2],[-9,-9],[-5,-16],[10,14],[-3,4],[1,-20],[2,16],[0,14],[-14,5],[15,-11],[3,11],[11,-10],[-1,-7],[16,7],[1,-11],[-8,-3],[1,-6],[19,7],[3,6],[-1,-2],[7,-3],[-6,-8],[7,1],[-15,12],[-17,9],[19,-9],[1,0],[9,-10],[6,20],[-12,-4],[-16,-17],[14,3],[0,-1],[-18,9],[-15,15],[-3,-15],[-5,20],[15,-14],[9,-17],[10,-14],[-7,-11],[14,9],[1,-1],[15,12],[-5,-1],[-17,-5],[15,-2],[-12,11],[19,-18],[8,7],[-5,-3],[-17,-1],[-18,13],[15,-3],[4,18],[-14,-15],[15,8],[-18,-12],[-15,19],[-9,16],[-9,14],[-12,-14],[-2,-20],[-3,-13],[10,-7],[-2,-10],[9,10],[-1,7],[-17,-6],[-15,20],[5,-17],[6,-6],[-11,-8]]));
            // System.Console.WriteLine(GrayCode(4));

            // System.Console.WriteLine(Candy([29,51,87,87,72,12]));
            System.Console.WriteLine(Candy([1,6,10,8,7,3,2]));
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
                return digits.Prepend(1).ToArray();
            
        }

        public class TreeNode {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val=0, TreeNode left=null, TreeNode right =null) {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        static IList<int> PreorderTraversal(TreeNode root) {
            
            List<int> result = new List<int>();
            List<TreeNode> branch = new List<TreeNode>();
            if (root == null){
                return result;
            }
            
            while(true){
                result.Add(root.val);
                if (root.right == null && root.left == null && branch.Count == 0){
                    return result;
                }
                if (root.right != null){
                    branch.Add(root.right);
                }
                if (root.left != null){
                    root = root.left;
                }
                else{
                    root = branch.Last();
                    branch.RemoveAt(branch.Count-1);
                }
            }
        }

        static IList<int> PostorderTraversal(TreeNode root){
                var result = new List<int>{};
                var branch = new List<TreeNode>{root};
                var branchUp = new List<TreeNode>{root};
                if (root == null){
                    return result;
                }
                while(branch.Count > 0){                
                    if (root.left == null && root.right == null){
                        result.Add(root.val);
                        if (root == branchUp.Last()){
                            branchUp.RemoveAt(branchUp.Count-1);
                        }
                        branch.RemoveAt(branch.Count-1);  
                        root = branch.Count <= 0 ? root : branch.Last();
                        while(branchUp.Count > 0 ? root == branchUp.Last(): false){
                            result.Add(root.val);
                            branchUp.RemoveAt(branchUp.Count-1);                        
                            branch.RemoveAt(branch.Count-1); 
                            root = branch.Count <= 0 ? root : branch.Last();
                        } 
                        branchUp.Add(root);
                        continue; 
                    }
                    if (root.right != null){
                        branch.Add(root.right);
                        if (root.left == null){
                            branchUp.Add(root.right);
                            root = root.right;
                            continue;
                        }
                    }
                    if (root.left != null){
                        branch.Add(root.left);
                        branchUp.Add(root.left);
                        root = root.left;
                    }
                }
                return result;
        }
        static int CountDigitOne(int n) {
            // build up from 0 []
            int power; // rounded down
            int temp;
            int tens;
            int result = 0;
            while (n>0){
                power = (int)Math.Log10(n);
                tens = (int)Math.Pow(10,power);
                
                int scale = n / tens;
                if (scale>1){
                    result+= tens;
                }// add in the else statement
                else{
                    result += n - tens + 1;
                }

                temp = power * (tens / 10);
                result += temp * scale;
                n %= tens;
            }
            return result;
        }

        static int ClimbStairs(int n){
            // List<int> store = new List<int>{1,2};
            // for (int i = 2; i<n;i++){
            //     store.Add(store[i-1]+store[i-2]);
            // }
            // return store[n-1];

            int[] store = new int[n+1];
            store[0] = 1;
            store[1] = 2;
            for (int i = 2; i<n;i++){
                store[i] = store[i-1]+store[i-2];
            }
            return store[n-1];
        }

        static int MySqrt(int x) {
            int lower = 0;
            int upper = 46340;
            int result;
            if (x >= 2147395600){
                return 46340;
            }
            while (true){
                result =  (upper+lower)/2;
                if(result*result < x){
                    if ((result+1)*(result+1) > x){
                        return result;
                    }
                    lower = result+1;
                }
                else if (result*result>x){
                    upper = result-1;
                }
                else{
                    return result;
                }
            }
        }

        public class Line{
            public int Count;
            public HashSet<int> Points;

            public Line(){
                Count = 0;
                Points = new HashSet<int>();
            }        
        }

        static int MaxPoints1(int[][] points){
            Dictionary<float, Dictionary<float,Line>> Lines = new Dictionary<float, Dictionary<float, Line>>{}; // Lines[gradient][y_intercept]
            int length = points.Length;
            int max_count = 1;
            for (int i = 0; i < length; i++){
                for (int j = i+1;  j < length; j++){
                    float grad = (float)Math.Round((float)(points[i][1]-points[j][1]) / (float)(points[i][0]-points[j][0]),4);
                    float y = float.IsInfinity(grad) ? (float)points[i][0] : (float)Math.Round((float)points[i][1] - grad * (float)points[i][0],4);
                    if(!Lines.ContainsKey(grad)){
                        Lines.Add(grad, new Dictionary<float, Line>{});
                    }
                    if(!Lines[grad].ContainsKey(y)){
                        Lines[grad].Add(y, new Line());
                    }
                    Lines[grad][y].Count += Lines[grad][y].Points.Add(i) ? 1 : 0 ;
                    Lines[grad][y].Count += Lines[grad][y].Points.Add(j) ? 1 : 0 ;

                    max_count = Lines[grad][y].Count > max_count ? Lines[grad][y].Count : max_count; 
                }
            }
            return max_count;
        }

        static int MaxPoints(int[][] points){
            int length = points.Length;
            int max_count = 1;
            for (int i = 0; i < length; i++){
                var max_base_length = new Dictionary<float,int>{};
                for (int j = i+1;  j < length; j++){
                    float grad = (float)Math.Round((float)(points[i][1]-points[j][1]) / (float)(points[i][0]-points[j][0]),4);
                    // float y = float.IsInfinity(grad) ? (float)points[i][0] : (float)Math.Round((float)points[i][1] - grad * (float)points[i][0],4);
                    if (!max_base_length.ContainsKey(grad)){
                        max_base_length.Add(grad, 1);
                    }
                    max_base_length[grad]+=1;
                    max_count = Math.Max(max_count, max_base_length[grad]);
                    
                }
            }
            return max_count;
        }

        static int FindMin(int[] nums){
            int lower = 0;
            int upper = nums.Length-1;
            while (true){
                int middle = (lower+upper) / 2;
                if (nums[middle] < nums[upper]){
                    upper = middle;
                }
                else if (nums[middle] > nums[upper]) {
                    lower = middle+1;
                }
                if (upper == lower){
                    return nums[upper];
                }
            }
        }

        static int FindMin2(int[] nums){
            int lower = 0;
            int upper = nums.Length-1;
            while (true){
                if (nums[upper] > nums[lower] || upper == lower){
                    return nums[lower];
                }
                int middle = (lower+upper) / 2;
                if (nums[middle] < nums[upper]){
                    upper = middle;
                }
                else if (nums[middle] > nums[upper]) {
                    lower = middle+1;
                }
                else{
                    if (nums[middle] > nums [lower]){
                        lower = middle+1;
                    }
                    else if(nums[middle] < nums [lower]) {
                        upper = middle;
                    }
                    else{
                        while(nums[lower] == nums[upper]){
                            lower++;
                            upper--;
                            if (upper <= lower){
                                return nums[upper];
                            }
                        }
                    }
                }
            }
        }

        static IList<int> GrayCode(int n) {
            if (n == 1){
                return [0,1];
            }
            var result = GrayCode(n-1);
            int length = result.Count;
            for (int i = length-1; i>=0; i--){
                result.Add(result[i] + (2<<(n-2)));
            }
            return result;
        }

        static int Candy(int[] ratings){
            int min = 0;
            int result = 0;
            int[] values = new int[ratings.Length]; 
            int temp = 0;
            int stop = 0;
            for(int i=1; i<ratings.Length; i++){
                if (ratings[i] > ratings[i-1]){
                    temp+=1;
                }
                else if (ratings[i] < ratings[i-1]){
                    temp-=1;
                    // TODO: split and evaluate
                }
                else{ // equal
                    if (i+1>=ratings.Length){
                        temp = 0;
                    }
                    else{
                            values[i] = min;
                            temp = 0;
                            for (int j = stop; j<i; j++){
                                values[j]+=1-min;
                            }
                            result += (1-min) * (i-stop);
                            if(ratings[stop]<=ratings[stop+1]){
                                result+=min;
                            }
                            if(ratings[i]<ratings[i-1]){
                                result+= min-temp;
                            }
                            min = 0;
                            stop = i;
                            continue;
                            
                        
                    }
                }

                min = Math.Min(min, temp);
                result+=temp;
                values[i] = temp;
            }
            for (int i=stop;i<ratings.Length;i++){
                values[i]+=1-min;
            }

            result += (1-min) * (ratings.Length-stop);

            if(ratings[stop]<=ratings[stop+1]){
                result+=min;
            }
            if(ratings[ratings.Length-1] < ratings[ratings.Length-2]){
                result+= min-temp;
            }
            return result;
        }


    }

}
    
