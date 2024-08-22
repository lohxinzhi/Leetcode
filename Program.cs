using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.XPath;

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



            // TreeNode a = new TreeNode(7);
            // TreeNode b = new TreeNode(2);
            // TreeNode c = new TreeNode(13);
            // TreeNode d = new TreeNode(1);
            // TreeNode e = new TreeNode(11,a,b);
            // TreeNode f = new TreeNode(4,null,d);
            // TreeNode g = new TreeNode(4,e);
            // TreeNode h = new TreeNode(8,c,f);
            // TreeNode i = new TreeNode(5,g,h);

            // System.Console.WriteLine(HasPathSum(i,18));
            
            // TreeNode d = new TreeNode(4);
            // TreeNode a = new TreeNode(1);
            // TreeNode b = new TreeNode(2,a,d);
            // TreeNode c = new TreeNode(3,null,b);

            // // TreeNode h = new TreeNode(8);

            // IList<int> something = InorderTraversal(g);
            // // // IList<int> something = PreorderTraversal(g);
            // // IList<int> something = PostorderTraversal(c);
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
         
            // System.Console.WriteLine(Candy([1,5,4,5,10,10,20,5]));

            // System.Console.WriteLine(Candy([1,6,10,8,7,3,2]));
            // System.Console.WriteLine(ConvertToTitle(701));

            // var smt = RestoreIpAddresses("00000");
            // foreach(string i in smt){
            //     System.Console.WriteLine(i);

            // var xinzhi = new Dictionary<int,int>{};
            // xinzhi.Add(1,1);
            // xinzhi.Add(2,2);
            // xinzhi.Add(3,3);
            // xinzhi.Remove(1);
            // foreach(var i in xinzhi){
            //     System.Console.WriteLine(i.Key);
            // }

        //     var triangle = Generate(10);


        //     foreach(var x in triangle){
        //         foreach(var y in x){
        //             System.Console.Write($"  {y} ");
        //         }
        //         System.Console.WriteLine();
        //     }

        //     var row = GetRow(9);
        //     foreach(var x in row){
        //         System.Console.Write($"{x} ,");
        //     }
        //     System.Console.WriteLine();
        // System.Console.WriteLine(AddBinary("1010", "1011"));
        // System.Console.WriteLine(ConvertZigZag("PAYPALISHIRING",3));
        // System.Console.WriteLine(UniquePathsWithObstacles([[0,0,0],[0,1,0],[0,0,0]]));

        // System.Console.WriteLine(MinPathSum([[1,3,1],[1,5,1],[4,2,1]]));

        // System.Console.WriteLine(MaximalRectangle([['1','0','1','0','0'],['1','0','1','1','1'],['1','1','1','1','1'],['1','0','0','1','0']]));

        // System.Console.WriteLine(TitleToNumber("AB"));
        // System.Console.WriteLine(Divide(2147483647,-1));

        // Rotate([[1,2,3],[4,5,6],[7,8,9]]);
        // SortColors([2,0,2,1,1,0]);
        // System.Console.WriteLine(Combine(4,3));
        // System.Console.WriteLine(Rob([1,2,3,1]));
        // System.Console.WriteLine(CoinChange([2147483647],2));
        // var a = new ListNode(1);
        // var b = new ListNode(2);
        // var c = new ListNode(3);
        // var d = new ListNode(4);
        // var e = new ListNode(5);
        // var f = new ListNode(6);
        // var g = new ListNode(7);
        // var h = new ListNode(8);
        // a.next = b;
        // b.next = c;
        // c.next = d;
        // d.next = e;
        // e.next = f;
        // f.next = g;
        // g.next = h;


        // var x = OddEvenList(a);
        // while(x!=null){
        //     System.Console.WriteLine(x.val);
        //     x = x.next;
        // }

        // System.Console.WriteLine(GuessNumber(2126753390,1702766719));

        System.Console.WriteLine(MaxProfit2([7,1,5,3,6,4]));

        }

        public class ListNode{
            public int val;
            public ListNode next;
            public ListNode(int x){
                val = x;
                next = null;
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
        
        static IList<int> InorderTraversal(TreeNode root){
            var branchUp = new List<TreeNode>{};
            var result = new List<int> {};

            if (root==null){
                return result;
            }

            while(branchUp.Count>0 || root.right != null || root.left != null){
                if(root.left != null){
                    branchUp.Add(root);
                    root = root.left;
                }
                else{ // if left is null
                    result.Add(root.val);
                    if (root.right != null){
                        root=root.right;
                    }
                    else{ // root.right == null                       
                        while(root.right == null && branchUp.Count > 0){
                            root = branchUp.Last();
                            branchUp.RemoveAt(branchUp.Count-1);
                            result.Add(root.val);
                        }
                        if (root.right != null){
                            root = root.right;
                        }
                        else{
                            break;
                        }
                    }

                }
            }
            if(root.left==null){
                result.Add(root.val);
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

        static int Candy( int[] ratings){
            if(ratings.Length<=1){
                return ratings.Length;
            }
            int[] values = new int[ratings.Length];
            Array.Fill<int> (values, 1);

            for (int i = 1; i<ratings.Length; i++){
                if(ratings[i]>ratings[i-1]){
                    values[i]=values[i-1]+1;
                }
            }

            for(int i = ratings.Length-2; i>=0; i--){
                if (ratings[i]> ratings[i+1]){
                    values[i] = Math.Max(values[i], values[i-1]+1);
                }
            }

            return values.Sum();
        }

        static int Candy1(int[] ratings){
            int temp = 0;
            int prev_temp = 0;
            int curr_min = 0;
            int prev_min = 0;
            int length = ratings.Length;
            int stop = 0;
            int[] values = new int[length];
            int result = 0;
            values[0] = 0;
            for(int i = 1; i < length; i++){
                if (ratings[i] > ratings[i-1]){ // if increasing
                    if( i < length-1 ? ratings[i] > ratings[i+1] : false){ // if at peak
                        // evaluate result from stop to i-1
                        result += (1-curr_min) * (i-stop) ;
                        for (int j = stop; j<i; j++){
                            values[j] += 1-curr_min;
                        }
                        if ( stop>0 ? ratings[stop] > ratings[stop-1] : false){
                            values[stop] = Math.Max(1-curr_min, prev_temp+1-prev_min);
                            result+= Math.Max(1-curr_min, prev_temp+1-prev_min) - (1-curr_min); 
                        }
                        //update
                        stop = i;
                        prev_min = curr_min;
                        curr_min = 0;
                        prev_temp = temp+1;
                        temp = 0;
                        values[i] = temp;
                    }
                    else{
                        temp++;
                        // curr_min = Math.Min(temp, curr_min); // MAYBE NO NEED
                        result+=temp;
                        values[i] = temp;
                    }
                }
                else if (ratings[i] < ratings[i-1]){
                    temp--;
                    curr_min = Math.Min(temp, curr_min);
                    result+=temp;
                    values[i] = temp;
                }
                else{ // if equals to prev
                    result += (1-curr_min) * (i-stop);
                    for(int j = stop; j<i;j++){
                        values[j] += 1-curr_min;
                    }
                    if ( stop>0 ? ratings[stop] > ratings[stop-1] : false){
                        values[stop] = Math.Max(1-curr_min, prev_temp+1-prev_min);
                        result+= Math.Max(1-curr_min, prev_temp+1-prev_min) - (1-curr_min); 
                    }

                    stop = i;
                    prev_min = curr_min;
                    curr_min = 0;
                    temp = 0;
                    values[i] = temp;
                }
            }
            for(int j = stop; j<length; j++){
                values[j] += 1-curr_min;
            }
            result += (1-curr_min) * (length-stop);
            if ( stop>0 ? ratings[stop] > ratings[stop-1] : false){
                values[stop] = Math.Max(1-curr_min, prev_temp+1-prev_min);
                result+= Math.Max(1-curr_min, prev_temp+1-prev_min) - (1-curr_min); 
            }
            

            for(int i = 0; i< length; i++){
                System.Console.Write($"{ratings[i]}  ");
            }
            System.Console.WriteLine();

            for(int i = 0; i< length; i++){
                System.Console.Write($"{values[i]}  ");
            }
            System.Console.WriteLine();

            return result;
        }
        
        static string ConvertToTitle(int columnNumber){
            StringBuilder sb = new StringBuilder();
            while(columnNumber>0){
                char temp;
                if(columnNumber%26 == 0){
                    temp = 'Z';
                    columnNumber--;
                }
                else{
                    temp = (char)('A'-1+columnNumber%26);
                }
                sb.Insert(0, temp);
                columnNumber/=26;
            }
            return sb.ToString();
        }

        static IList<string> RestoreIpAddresses(string s) {
            var addresses = new List<string>{};
            int length = s.Length;

            int[] ip = new int[4];

            for (int i = 0; i<3; i++){
                if(length-i-1>9 || length-i-1<3){
                    continue;
                }
                int temp;
                if (!int.TryParse(s.Substring(0,i+1),out temp)){
                    break;
                }
                if(temp > 255){
                    break;
                }
                ip[0] = temp;
                for(int j = i+1; j<i+4; j++){
                    if(length-j-1>6 || length-j-1<2){
                        continue;
                    }
                    if (!int.TryParse(s.Substring(i+1,j-i), out temp)){
                        break;
                    }
                    if(temp > 255){
                        break;
                    }
                    ip[1] = temp;
                    for(int k = j+1; k<j+4;k++){
                        if (length-k-1>3 || length-k-1<1){
                            continue;
                        }
                        if (!int.TryParse(s.Substring(j+1, k-j),out temp)){
                            break;
                        }
                        if (temp > 255 || (temp != 0 && s[j+1].Equals('0'))){
                            break;
                        }
                        ip[2] = temp;
                        if(!int.TryParse(s.Substring(k+1),out temp)){
                            break;
                        }
                        if (temp > 255){
                            continue;
                        }

                        if(temp!=0 && s[k+1].Equals('0')){
                            if(ip[2] == 0){
                                break;
                            }
                            continue;
                        }
                        if(temp == 0 && length-k-1>1){
                            break;
                        }

                        ip[3] = temp;
                        addresses.Add(string.Join('.', ip));

                        if(ip[2] == 0){
                            break;
                        }
                    }
                    if(ip[1] == 0){
                        break;
                    }
                }
                if(ip[0] == 0){
                    break;
                }
            }

            return addresses;
        }

        static bool HasPathSum(TreeNode root, int targetSum) {
            
            if (root == null){
                return false;
            }


            int sum = root.val;
            var branch = new Dictionary<TreeNode,int>{};
            while(true){
                if(root.right != null){
                    branch.Add(root.right,sum+root.right.val);
                }
                if (root.left != null){
                    root = root.left;
                    sum += root.val;
                }
                else if (root.right != null){
                    root = branch.Last().Key;
                    sum = branch[root];
                    branch.Remove(root);
                }
                if (root.left == null && root.right == null){
                    if (sum == targetSum){
                        return true;
                    }
                    else{
                        if(branch.Count == 0){
                            return false;
                        }
                        root = branch.Last().Key;
                        sum = branch[root];
                        branch.Remove(root);
                    }
                }
            }
        }

        static IList<IList<int>> Generate(int numRows){ //Pascal Triangle

            // [1] 0 = 0
            // [1]  [1]  1 = 0
            // [1]  [2]  [1] 2  = 1
            // [1]  [3]  [3]  [1] 3 = 1
            // [1]  [4]  [6]  [4]  [1]  4
            // [1]  [5]  [10] [10] [5]  [1] 5

            var result = new List<IList<int>>(numRows);
            for(int i=0; i<numRows; i++){
                result.Add(new List<int>(i+1));
                result[i].Add(1);
                for(int j=1; j<= i/2; j++){
                    result[i].Add(result[i-1][j] + result[i-1][j-1]);
                }
                if(i%2 == 1){
                    for(int j = i/2; j >= 0; j--){
                        result[i].Add(result[i][j]);
                    }
                }
                else{
                    for(int j = i/2-1; j>=0; j--){
                        result[i].Add(result[i][j]);
                    }
                }
            }
            return result;
        }
    
        static IList<int> GetRow(int rowIndex){
            var result = new List<int>(rowIndex+1);
            result.Add(1);
            for (int i = 1; i< rowIndex+1; i++){
                if (i%2 == 0){
                    result.Add(result[i/2-1]*2);
                    int temp1 = 1;
                    int temp2 = 1;
                    for(int j = 1; j<=i/2-1; j++){
                        temp1 = result[j];
                        result[j] = result[j] + temp2;
                        temp2 = temp1;
                    }
                }
                else{
                    int temp1 = 1;
                    int temp2 = 1;
                    for(int j = 1; j<=i/2; j++){
                        temp1 = result[j];
                        result[j] = result[j] + temp2;
                        temp2 = temp1;
                    } 
                }

            }
            for(int i = result.Count-(rowIndex%2 == 1 ? 1 : 2); i>=0; i--){
                result.Add(result[i]);
            }
            return result;
        }

        static string AddBinary(string a, string b){
            int l1 = a.Length;
            int l2 = b.Length;
            bool carry = false;
            string result = "";
            for (int i = 0; i<Math.Min(l1,l2); i++){
                if((a[l1-1-i] == b[l2-1-i] && !carry) || a[l1-1-i] != b[l2-1-i] && carry){
                    result = '0' + result;
                }
                else{
                    result = '1' + result;
                }
                if(a[l1-1-i]+b[l2-1-i]+(carry?1:0) - 0x60 >= 2){
                    carry = true;
                }
                else{
                    carry = false;
                }
                
            }
            if (l1!=l2){
                for(int i = Math.Min(l1,l2); i<Math.Max(l1,l2); i++){
                    if((l1>l2 ? a[l1-1-i]:b[l2-1-i]) == '0'){
                        result= (carry ? '1':'0' ) + result;
                    }
                    else{
                        if(carry){
                            result = '0' + result;

                        }
                        else{
                            result = '1' + result;
                            carry = false;
                        }
                    }
                }      
            }
            if (carry){
                if (result[0]=='0'){
                    result.Remove(0,1);
                }
                else{
                    result.Remove(0,1);
                    result = '0'+ result;
                }
                result = '1' + result; 
            }
            return result;
        }

        static string ConvertZigZag(string s, int numRows) {

            if(numRows == 1){
                return s;
            }

            StringBuilder sb =  new StringBuilder();
            int length = s.Length;
            int index;
            for(int i = 0; i<=numRows;  i++){
                for (int j = 0; j<(int) Math.Ceiling((double)length/((numRows-1)*2)); j++){
                    if (i==0){
                        index = j * (numRows-1) * 2;
                        if(index < length){
                            sb.Append(s[index]);
                        }
                    }            
                    else{
                        index = j * (numRows-1) * 2 - i;
                        if(index < length && index  >= 0){
                            sb.Append(s[index]);
                        }
                        index = j * (numRows-1) * 2 + i;
                        if(index < length && i < numRows-1){
                            sb.Append(s[index]);                    
                        }
                    }
                }
            }
            return sb.ToString();
        }

        static int UniquePaths(int m, int n) {
            int[,] pathCount = new int[m,n];
            
            for(int i = 0; i<m; i++){
                for (int j = 0; j<n; j++){
                    if(i*j == 0){
                        pathCount[i,j] = 1;
                    }
                    else{
                        pathCount[i,j] = pathCount[i-1,j] + pathCount[i, j-1];
                    }
                }    
            }
            return pathCount[m-1,n-1];
        }

        static int UniquePathsWithObstacles(int[][] obstacleGrid){
            int[] size = {obstacleGrid.Length, obstacleGrid[0].Length};
            int[,] pathCount = new int[size[0],size[1]] ;
            pathCount[0,0] = obstacleGrid[0][0] == 1 ? 0:1;
            for(int i = 0; i < size[0]; i++){
                for(int j = 0; j < size[1]; j++){
                    if (obstacleGrid[i][j] == 1){
                        pathCount[i,j] = 0;
                    }
                    else if(i==0 && j==0){
                        pathCount[0,0] = 1;
                    }
                    
                    else{
                        pathCount[i,j] = (i == 0 ? 0: pathCount[i-1,j]) +(j==0? 0 : pathCount[i,j-1]);
                    }
                }
            }
            return pathCount[size[0]-1,size[1]-1];
        }

        static int MinPathSum(int[][] grid){
            int[] size = {grid.Length, grid[0].Length};
            int[,] costMap = new int[size[0], size[1]];
            for (int i = 0; i < size[0]; i++){
                for (int j = 0; j < size[1]; j++){
                    costMap[i,j] = grid[i][j];
                    if (i!=0 || j !=0){
                        costMap[i,j] += Math.Min((i==0? int.MaxValue: costMap[i-1,j]), (j==0? int.MaxValue: costMap[i,j-1]));
                    }
                }
            }
            return costMap[size[0]-1,size[1]-1];
        }

        static int MinDistance(string word1, string word2){
            int[,] table = new int[word1.Length+1, word2.Length+1];
            for(int i=0; i<word1.Length+1; i++){
                for(int j=0; j<word2.Length+1; j++){
                    if(i*j == 0){
                        table[i,j] =i+j;
                    }
                    else if(word2[j-1] == word1[i-1]){
                        table[i,j] = table[i-1,j-1];
                    }
                    else{
                        table[i,j] = 1 + Math.Min(table[i-1,j-1], Math.Min(table[i,j-1], table[i-1,j]));
                    }
                }
            }
            return table[word1.Length, word2.Length];
        }

        static int MaximalRectangle(char[][] matrix){
                int max_area = 0;
                int rows = matrix.Length;
                int cols = matrix[0].Length;
                int[,] dp = new int[rows,cols];

                for(int j = 0; j<cols; j++ ){
                    dp[0,j] = matrix[0][j] == '1'? 1:0; 
                }
                for(int i = 1; i< rows; i++){
                    for (int j = 0; j<cols; j++){
                        if (matrix[i][j] == '1'){
                            dp[i,j] = 1 + dp[i-1,j];
                        }
                        else{
                            dp[i,j] = 0;
                        }
                    }
                }

                for(int i = 0; i< rows; i++){
                    for(int j = 0; j<cols; j++){
                        int min_height = dp[i,j];
                        for (int k = j; k>=0; k--){
                            if (dp[i,k] == 0){
                                break;
                            }
                            min_height = Math.Min(min_height, dp[i,k]);
                            max_area = Math.Max(max_area, min_height * (j-k+1));
                        }
                    }
                }
                return max_area;
        }

        static int MaximalRectangle1(char[][] matrix){
            int result = 0;
            for (int i = 0; i<matrix.Length; i++){
                for(int j = 0; j<matrix[0].Length; j++ ){
                    if (matrix[i][j] == '1'){
                        int[] end = {i,matrix[0].Length-1};
                        for(int x = i; x<matrix.Length; x++){
                            if(matrix[x][j] == '0'){
                                // do smt
                                break;
                            }
                            int row_end = end[1];
                            for(int y = j; y<=end[1]; y++){
                                if(matrix[x][y] == '0'){
                                    row_end = y-1;
                                    break;
                                }
                            }
                            end[0] = x;
                            end[1] = Math.Min(row_end, end[1]);
                            result = Math.Max(result, (end[0]-i+1) * (end[1]-j+1));
                        }
                    } 
                }
            }
            return result;
        }

        static int TitleToNumber(string columnTitle){
            int result = 0;
            int length = columnTitle.Length;
            for(int i = 0; i<length; i++){
                result+= (int)Math.Pow(26, i) * columnTitle[length-1-i]-'A'+1;
            }
            return result;
            } 

        static int Divide(int dividend, int divisor){
            int result = 0;
            int remaining = dividend>=0? -dividend: dividend;
            int temp=divisor>0 ? divisor: -divisor;
            int i=0;
            while(remaining<=-temp){
                while (remaining<-temp<<1 && temp<<1 > 0){
                    temp = temp<<1;
                    i++;
                }
                result -= 1<<i;

                remaining = remaining+temp;
                temp = divisor>0 ? divisor: -divisor;
                i=0;
            }
            if (result== int.MinValue){
                return dividend>=0 ^ divisor>0 ?  result :int.MaxValue;
            }
            return dividend>=0 ^ divisor>0 ? result: -result;
        }

        static void Rotate(int[][] matrix){
            for(int i = 0; i<matrix.Length; i++){
                for(int j = i+1; j<matrix[i].Length; j++){
                    matrix[i][j] = matrix[i][j] ^ matrix[j][i];
                    matrix[j][i] = matrix[i][j] ^ matrix[j][i];
                    matrix[i][j] = matrix[i][j] ^ matrix[j][i];
                }
            }
            int size = matrix.Length;
            for(int j = 0; j<size/2; j++){
                for (int i = 0; i<size; i++){
                    matrix[i][j] = matrix[i][j] ^ matrix [i][size-1-j];
                    matrix[i][size-1-j] = matrix[i][j] ^ matrix [i][size-1-j];
                    matrix[i][j] = matrix[i][j] ^ matrix [i][size-1-j];
                }
            }
            
        }

        static void SortColors(int[] nums){
            int pivot = 1;
            int j=  -1;
            for(int i = 0; i< nums.Length; i++){
                if (nums[i] < pivot){
                    j++;
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
            pivot = 2;
            for(int i = j+1; i<nums.Length; i++){
                if (nums[i] < pivot){
                    j++;
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        }

        static IList<IList<int>> Combine(int n, int k){
            float temp=1;            
            int[] indexes = new int[k];
            for(int i = 0; i<k; i++){
                temp*=(float)(n-i)/(float)(i+1);
                indexes[i] = i;

            }
            int length = (int)Math.Round(temp); // length of final list
            
            var result = new List<IList<int>>(length);
            int j = 0;
            while(j<length){

                // add numbers to result list
                result.Add(new List<int>(k));
                for(int l = 0; l<k; l++){
                    result[j].Add(indexes[l]+1);
                }

                
                indexes[k-1]++;  // increment the index to get the next set of numbers
                if (indexes[k-1] >= n){ // if last number overflow
                    for(int i = 1; i<k; i++){ // loop through index from the back
                        indexes[k-1-i]++; //increment previous index
                        if (indexes[k-1-i] < n-i){ // if previous index overflow, reset current number to end 
                            for(int x = k-i; x<k; x++){
                                indexes[x] = indexes[x-1]+1;
                            }
                            break;
                        }
                    }
                }

                j++;
            }
            return result;
            


        }

        static bool HasCycle(ListNode head){
            var hash = new HashSet<ListNode>{};
            while(head != null){
                if(!hash.Add(head)){
                    return true;
                }
                head = head.next;
            }
            return false;
        }

        static ListNode DetectCycle(ListNode head) {
            var fast = head;
            var slow = head;
            while(fast !=null && fast.next!=null){
                fast = fast.next.next;
                slow = slow.next;
                if(fast==slow){
                    while (head!=slow){
                        head = head.next;
                        slow = slow.next;
                    }
                    return head;
                }
            }
            return null;
        }
        static int Rob(int[] nums){
            if (nums.Length == 1){
                return nums[0];
            }
            if (nums.Length == 2){
                return Math.Max(nums[0], nums[1]);
            }
            List<int> dp =new List<int> {nums[0], Math.Max(nums[0],nums[1])};
            for (int i = 2; i<nums.Length; i++){
                dp.Add(Math.Max(dp[i-2]+nums[i], dp[i-1]));
            }
            return dp[nums.Length-1];
        }

        static int NumSquares(int n){
            int[] dp = new int[n];
            int square = 1;
            List<int> squares = new List<int> {};
            for(int i=0; i<n; i++){
                if (i+1 == square*square){
                    dp[i] = 1;
                    squares.Add(square*square);
                    square++;
                }
                else{
                    int min = dp[i-1]+dp[0];
                    for (int j = 0; j<squares.Count; j++){
                        min = Math.Min(min, dp[squares[j]-1]+dp[i-squares[j]]);
                    }
                    dp[i] = min;
                }
            }
            return dp.Last();
        }
        static int CoinChange(int[] coins, int amount){
            if (amount == 0){
                return 0;
            }
            int[] dp = new int[amount];
            var coinSet = new HashSet<int>(coins); 
            for (int i = 0; i<amount; i++){
                if (coinSet.Contains(i+1)){
                    dp[i] = 1;
                }
                else if(i==0){
                    dp[i] =-1;
                }
                else{
                    int min = dp[i-1] <0 || dp[0] < 0 ? -1 : dp[i-1]+dp[0];
                    foreach(int coin in coinSet){
                        if (coin-1>i){
                            continue;
                        }
                        int temp = dp[coin-1]*dp[i-coin] <0 ? -1 : dp[coin-1]+dp[i-coin];
                        if (min>0 && temp >0){
                            min = Math.Min(min, temp);
                        }
                        else{
                            min = Math.Max(min, temp);
                        }
                        
                    } 
                    dp[i] = min;
                }
            }
            return dp.Last();
        }

        static ListNode OddEvenList(ListNode head){
            if(head == null || head.next == null){
                return head;
            }
            var tempOdd = head;
            var tempEven = new ListNode(0);
            var head2 = head.next;
            while(tempOdd!=null ? tempOdd.next != null : false ){
                tempEven.next = tempOdd.next;
                tempOdd.next = tempOdd.next.next;
                if (tempOdd.next == null){
                    break;
                }
                tempOdd =tempOdd.next;
                tempEven = tempEven.next; 
            }

            if (tempOdd==tempEven.next){
                tempEven.next = null;
                tempOdd.next = head2;
            }
            else{
                tempOdd.next = head2;
            }
            return head;

        }

        static int guess(int num, int pick){
            if (num>pick){
                return -1;
            }
            else if (num<pick){
                return 1;
            }
            else{
                return 0;
            }
        }

        static int GuessNumber(int n, int pick) {
            int upper = n;
            int lower = 1;
            int middle = lower+(upper-lower)/2;
            while(true){
                int ans = guess(middle,pick);
                if(ans ==-1){
                    upper = middle-1;
                }
                else if (ans == 1){
                    lower = middle+1;
                }
                else{
                    return middle;
                }
                middle = lower+(upper-lower)/2;
            }
        }   

        static int MaxProfit(int[] prices) {
            int profit = 0;
            int min = prices[0];
            for(int i = 1; i<prices.Length; i++){
                profit = Math.Max(profit, prices[i]-min);
                min = Math.Min(min, prices[i]);
            }
            return profit;
        }

        static int MaxProfit2(int[] prices){
            int profit = 0;
            int min = prices[0];
            for(int i=1; i<prices.Length-1; i++){
                if (prices[i+1]<prices[i] && prices[i] > min){
                    profit += prices[i] - min;
                    min = prices[i];
                }
                else{
                    min = Math.Min(min, prices[i]);
                }
            }
            return profit;
        }



    }

}
    
