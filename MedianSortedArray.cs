// using System;

// namespace SortedArray
// {
//     class Program{
//         static void Main(string[] args)
//         {

//             int[] a = {1,2,5,6,7}; 
//             int[] b = {3,4,8,9,10};            

//             System.Console.WriteLine($"median = {FindMedianSortedArrays(a,b)}");

//         }
        
//         static double FindMedianSortedArrays(int[] nums1, int[] nums2) {


//             int l1 = nums1.Length;
//             int l2 = nums2.Length;
//             if (l1 == 0){
//                 if (l2%2 == 0){
//                     return (float)(nums2[l2/2]+nums2[l2/2-1])/2;
//                 }
//                 else{
//                     return nums2[l2/2];
//                 }
//             }
//             if (l2 == 0){
//                 if (l1%2 == 0){
//                     return (float)(nums1[l1/2]+nums1[l1/2-1])/2;
//                 }
//                 else{
//                     return nums1[l1/2];
//                 }
//             }   
//             int total = l1 + l2;
//             int[] longer = l1>=l2 ? nums1 :nums2;
//             int[] shorter = l1>=l2 ? nums2 :nums1;

//             int[] mainWindow = {0, (total-1)/2}; // 0 to total median index
//             int[] subWindow = {0, shorter.Length-1};
//             int j = FindInsertIndex(longer,shorter, (total-1)/2, subWindow); // number of elements to remove later - 1
//             if (j>=0){
//                 int mainMiddle,subMiddle;
//                 int shift = 0;
//                 mainWindow[0] = (total-1)/2 - j;
//                 subWindow[1] = j;                
//                 while (mainWindow[0] != mainWindow[1]){
//                     if ((mainWindow[1]-mainWindow[0]+1) % 2 == 0){ // if even
//                         mainMiddle = (mainWindow[1]+mainWindow[0])/2+1;
//                         subMiddle = (subWindow[1]+subWindow[0])/2+1;
//                         shift = 0;

//                     }
//                     else{ // if odd
//                         mainMiddle = (mainWindow[1]+mainWindow[0])/2;
//                         subMiddle = (subWindow[1]+subWindow[0])/2;
//                         shift = 1;
//                     }    
//                     // compare values
//                     if (longer[mainMiddle] > shorter[subMiddle]){
//                         mainWindow[1] = mainMiddle - 1;
//                         subWindow[0] = subMiddle + shift;
//                     }
//                     else if (longer[mainMiddle] < shorter[subMiddle]){
//                         mainWindow[0] = mainMiddle + shift;
//                         subWindow[1] = subMiddle - 1;
//                     }
//                     else{   // equals 
//                         return longer[mainMiddle];
//                     }                        

//                 }
//                 if (total % 2 == 0){ // if even number of elements in final array
//                     if (longer[mainWindow[0]] < shorter[subWindow[0]]){
//                         return (double)(Math.Max(longer[mainWindow[0]], subWindow[0] > 0 ? shorter[subWindow[0]-1] : mainWindow[0]) + Math.Min( mainWindow[0]+1 < longer.Length ? longer[mainWindow[0]+1] : shorter[subWindow[0]], shorter[subWindow[0]])) /2;
//                     } 
//                     else{
//                         return (double)(Math.Max(shorter[subWindow[0]], mainWindow[0] > 0 ? longer[mainWindow[0]-1] : subWindow[0]) + Math.Min(subWindow[0]+1 < shorter.Length ? shorter[subWindow[0]+1] : longer[mainWindow[0]] , longer[mainWindow[0]])) /2; // error
//                     }
//                 }
//                 else{
//                     if (longer[mainWindow[0]] < shorter[subWindow[0]]){
//                         return Math.Max(longer[mainWindow[0]], subWindow[0] > 0 ? shorter[subWindow[0]-1] : longer[mainWindow[0]]);
//                     }
//                     else{
//                         return Math.Max(shorter[subWindow[0]], mainWindow[0] > 0 ? longer[mainWindow[0]-1] : shorter[subWindow[0]]);
//                     }
//                 }
                
//             }
//             else{
//                 if (total%2==0){
//                     int upper;
//                     int lower = longer[(total-1)/2];
//                     if (longer.Length-1 < (total-1)/2+1){
//                         upper = shorter[0];
//                     }
//                     else{
//                         upper = Math.Min(longer[((total-1)/2)+1],shorter[0]);
//                     }
//                     return (double)(lower+upper)/2;
//                 }
//                 else{
//                     return longer[(total-1)/2];
//                 }
//             }
//         }

//         static int FindInsertIndex(int[]longer, int[]shorter, int i, int[] sub_Window){
//             int[] subWindow = {sub_Window[0], sub_Window[1]};
//             int j = (subWindow[1]+subWindow[0])/2;
//             while (true){
//                 if (subWindow[0] == subWindow[1]){
//                     if (shorter[subWindow[0]] < longer[i]){
//                         return subWindow[0];
//                     }
//                     else {
//                         return -1;
//                     }
//                 }
//                 if((shorter[j] < longer[i]) && (shorter[j+1] < longer[i])){
//                     subWindow[0] = j+1;
//                 }
//                 else if(shorter[j] > longer[i]){
//                     subWindow[1] = j > 0 ? j-1 : 0;
//                 }
//                 else{
//                     return j;
//                 }
//                 j = (subWindow[0]+subWindow[1])/2;
//                 if((j == shorter.Length-1) || (j == 0 && subWindow[0] == subWindow[1])){
//                     if (longer[i] < shorter[j]){
//                         return -1;
//                     }
//                     else{
//                         return j;
//                     }
//                 }

//             }

//         }

        
//     }
// }
    
