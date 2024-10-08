using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;
using System.Linq;

public class Main : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        Debug.Log("罗马数 IV 转整数 is:" + RomanToInt("IV"));
        Debug.Log("罗马数 IX 转整数 is:" + RomanToInt("IX"));
        Debug.Log("罗马数 LVIII 转整数 is:" + RomanToInt("LVIII"));
        Debug.Log("罗马数 MCMXCIV 转整数 is:" + RomanToInt("MCMXCIV"));
        Debug.Log("罗马数 MDL 转整数 is:" + RomanToInt_1("MDL"));

        Debug.Log("字符串组{'ABCDEFG', 'ABCDE', 'ABCD', 'ABC' }的最长前缀是：" + LongestCommonPrefix(new string[] { "ABCDEFG", "ABCDE", "ABCD", "ABC" }));

        Debug.Log("回文数 1799999971 res:" + IsPalindrome_1(1799999971));
        Debug.Log("回文数 1999999991 res:" + IsPalindrome_1(1999999991));
        Debug.Log("删除有序数组{[0,0,1,1,1,2,2,3,3,4]}中的重复元素后的个数是：" + RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }));
        Debug.Log("mississippi/sippia 第一个匹配项的下标是：" + StrStr("mississippi", "sippia"));

        Debug.Log(SearchInsert(new int[] { 1, 3, 5, 6 }, 2));
        Debug.Log(FindMedianSortedArrays_1(new int[] { 1, 1 }, new int[] { 1, 2 }));
        List<ListNode> l1 = NumberToListNode(new int[] { 9, 9, 9, 9, 9, 9, 9 });
        List<ListNode> l2 = NumberToListNode(new int[] { 9, 9, 9, 9 });
        Debug.Log(AddTwoNumbers(l1[0], l2[0]).val);

        Debug.Log(LengthOfLongestSubstring("abcabcbb"));

        Debug.Log(LengthOfLastWord("   fly me   to   the moon  "));
        Debug.Log(IsValidSudoku(new char[][]{
        new char[] {'5','3','.','.','7','.','.','.','.' },
        new char[] {'6','.','.','1','9','5','.','.','.' },
        new char[] {'.','9','8','.','.','.','.','6','.'},
        new char[] {'8','.','.','.','6','.','.','.','3'},
        new char[] {'4','.','.','8','.','3','.','.','1'},
        new char[] {'7','.','.','.','2','.','.','.','6'},
        new char[] {'.','6','.','.','.','.','2','8','.' },
        new char[] {'.','.','.','4','1','9','.','.','5'},
        new char[] { '.','.','.','.','8','.','.','7','9' }}));
        ThreeSum(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 });
        bool has = ContainsNearbyDuplicate(new int[] { 1, 0, 1, 1 }, 1);
        Debug.Log(has);

        Convert("S", 1);

        IsPalindrome("0p");

        IntToRoman(3749);
        // FindTheDifference_1("abcd", "abcde");

        FindWords(new string[] { "Hello", "Alaska", "Dad", "Peace" });

        WordPattern("abba", "dog cat cat dog");

        FindErrorNums(new int[] { 3, 2, 3, 4, 6, 5 });

        ReplaceWords(new List<string>() { "cat", "bat", "rat" }, "the cattle was rattled by the battery");

        IsAnagram("anagram", "nagaram");

        TopKFrequent(new int[] { 1, 1, 1, 2, 2, 3 }, 2);

        MinMutation("AAAACCCC", "CCCCCCCC", new string[] { "AAAACCCA", "AAACCCCA", "AACCCCCA", "AACCCCCC", "ACCCCCCC", "CCCCCCCC", "AAACCCCC", "AACCCCCC" });

        HasGroupsSizeX(new int[] { 1, 1, 2, 2, 2, 2 });
    }
    // Update is called once per frame
    void Update() {

    }
    #region 卡牌分组
    public static bool HasGroupsSizeX(int[] deck) {
        Dictionary<int, int> res = new Dictionary<int, int>();
        foreach (var num in deck) {
            if (res.ContainsKey(num)) {
                res[num]++;
            } else {
                res.Add(num, 1);
            }
        }
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int i = 0; i < deck.Length; i++) {
            if (!dic.ContainsKey(deck[i])) {
                dic.Add(deck[i], 1);
            } else {
                dic[deck[i]]++;
            }
        }
        int tag = -1;
        foreach (int value in dic.Values) {
            if (tag == -1) {
                tag = value;
            } else {
                tag = Get(tag, value);
            }
        }
        return tag >= 2 ? true : false;
    }
    public static int Get(int x, int y) {
        return x % y == 0 ? y : Get(y, x % y);
    }

    #endregion

    #region 最小基因变化
    public static int MinMutation(string start, string end, string[] bank) {
        ISet<string> cnt = new HashSet<string>();
        ISet<string> visited = new HashSet<string>();
        char[] keys = { 'A', 'C', 'G', 'T' };
        foreach (string w in bank) {
            cnt.Add(w);
        }
        if (start.Equals(end)) {
            return 0;
        }
        if (!cnt.Contains(end)) {
            return -1;
        }
        Queue<string> queue = new Queue<string>();
        queue.Enqueue(start);
        visited.Add(start);
        int step = 1;
        while (queue.Count > 0) {
            int sz = queue.Count;
            for (int i = 0; i < sz; i++) {
                string curr = queue.Dequeue();
                for (int j = 0; j < 8; j++) {
                    for (int k = 0; k < 4; k++) {
                        if (keys[k] != curr[j]) {
                            StringBuilder sb = new StringBuilder(curr);
                            sb.Replace(curr[j], keys[k], j, 1);
                            string next = sb.ToString();
                            if (!visited.Contains(next) && cnt.Contains(next)) {
                                if (next.Equals(end)) {
                                    return step;
                                }
                                queue.Enqueue(next);
                                visited.Add(next);
                            }
                        }
                    }
                }
            }
            step++;
        }
        return -1;
    }
    #endregion

    #region 前k个高频元素
    public static int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dic = new();
        for (int i = 0; i < nums.Length; i++) {
            if (dic.ContainsKey(nums[i])) {
                dic[nums[i]]++;
            } else {
                dic.Add(nums[i], 1);
            }
        }
        //优先队列-从小到大排列
        var ordic = dic.OrderByDescending(kvp => kvp.Value).ToList();

        //数组倒装
        int[] res = new int[k];
        int index = 0;
        foreach (var val in ordic) {
            if (index >= k) {
                break;
            }
            res[index++] = val.Key;
        }
        return res;
    }
    #endregion

    #region 有效的字母异位词
    public static bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
        Dictionary<char, int> temp = new Dictionary<char, int>();
        foreach (var cur in s) {
            if (!t.Contains(cur)) {
                return false;
            }
            if (temp.ContainsKey(cur)) {
                temp[cur]++;
            } else {
                temp.Add(cur, 1);
            }
        }
        foreach (var cur in t) {
            if (!temp.ContainsKey(cur)) {
                return false;
            }
            temp[cur]--;
            if (temp[cur] < 0) {
                return false;
            }
        }
        return true;
    }
    public static bool IsAnagram_1(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
        int[] a = new int[26];
        for (int i = 0; i < s.Length; i++) {
            a[s[i] - 'a']++;
            a[t[i] - 'a']--;
        }
        foreach (var cur in a) {
            if (cur != 0) {
                return false;
            }
        }
        return true;
    }
    #endregion

    #region  单词替换
    public static string ReplaceWords(IList<string> dictionary, string sentence) {
        HashSet<string> dic = new HashSet<string>();
        foreach (var s in dictionary) {
            dic.Add(s);
        }
        StringBuilder res = new StringBuilder();
        StringBuilder cur = new StringBuilder();
        bool find = false;
        for (int i = 0; i < sentence.Length; i++) {
            cur.Append(sentence[i]);
            if (sentence[i] == ' ' || i == sentence.Length - 1) {
                if (!find) {
                    res.Append(cur);
                }
                find = false;
                cur.Clear();
                continue;
            }
            if (!find && dic.Contains(cur.ToString())) {
                res.Append(cur + " ");
                find = true;
            }
        }
        if (res[res.Length - 1] == ' ') {
            res.Remove(res.Length - 1, 1);
        }
        return res.ToString();
    }
    #endregion

    #region 两个数组的交集
    public static int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> temp1 = new HashSet<int>();
        foreach (var num in nums1) {
            temp1.Add(num);
        }

        HashSet<int> temp2 = new HashSet<int>();
        foreach (var num in nums2) {
            if (temp1.Contains(num)) {
                temp2.Add(num);
            }
        }
        int[] res = new int[temp2.Count];
        temp2.CopyTo(res);
        return res;
    }
    #endregion

    #region 错误的集合
    public static int[] FindErrorNums(int[] nums) {
        int[] res = new int[2];
        HashSet<int> temp = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++) {
            temp.Add(nums[i]);
        }

        for (int i = 1; i <= nums.Length; i++) {
            if (!temp.Contains(i)) {
                res[1] = i;
                break;
            }
        }

        foreach (var num in nums) {
            if (temp.Contains(num)) {
                temp.Remove(num);
            } else {
                res[0] = num;
            }
        }
        return res;
    }
    #endregion

    #region 单词规律
    public static bool WordPattern(string pattern, string s) {
        List<string> temp = new List<string>();
        string cur = "";
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == ' ') {
                temp.Add(cur);
                cur = "";
            } else {
                cur += s[i];
                if (i == s.Length - 1) {
                    temp.Add(cur);
                }
            }
        }
        if (temp.Count != pattern.Length) {
            return false;
        }
        Dictionary<char, string> res = new Dictionary<char, string>();
        for (int i = 0; i < pattern.Length; i++) {
            if (res.ContainsKey(pattern[i])) {
                if (res[pattern[i]] == temp[i]) {
                    continue;
                } else {
                    Debug.Log(temp[i]);
                    return false;
                }
            }
            if (res.ContainsValue(temp[i])) {
                Debug.Log(temp[i]);
                return false;
            }
            res.Add(pattern[i], temp[i]);
        }
        return true;
    }
    #endregion

    #region 找到所有数组中消失的数
    public static IList<int> FindDisappearedNumbers(int[] nums) {
        HashSet<int> temp = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++) {
            temp.Add(i + 1);
        }

        foreach (var num in nums) {
            if (temp.Contains(num)) {
                temp.Remove(num);
            }
        }

        int[] res = new int[temp.Count];
        temp.CopyTo(res);
        return res;
    }
    #endregion

    #region 键盘行
    public static string[] FindWords(string[] words) {

        List<string> res = new List<string>();

        HashSet<string> temp = new HashSet<string>(){
            "QqWwEeRrTtYyUuIiOoPp","AaSsDdFfGgHhJjKkLl","ZzXxCcVvBbNnMm"
        };
        foreach (var w in words) {
            foreach (var s in temp) {
                bool isfind = false;
                for (int i = 0; i < w.Length; i++) {
                    if (!s.Contains(w[i])) {
                        break;
                    }
                    if (i == w.Length - 1) {
                        res.Add(w);
                        isfind = true;
                    }
                }
                if (isfind) {
                    break;
                }
            }
        }
        string[] re = new string[res.Count];
        res.CopyTo(re);
        return re;
    }
    #endregion

    #region 电话号码的字母
    public static IList<string> LetterCombinations(string digits) {
        List<string> res = new List<string>();

        if (digits.Length == 0) {
            return res;
        }
        Dictionary<char, string> temp = new Dictionary<char, string>() {
            {'2',"abc"},
            {'3',"def"},
            {'4',"ghi"},
            {'5',"jkl"},
            {'6',"mno"},
            {'7',"pqrs"},
            {'8',"tuv"},
            {'9',"wxyz"},
        };
        res.Add("");
        int count = 1;
        for (int i = 0; i < digits.Length; i++) {
            string cur = temp[digits[i]];
            for (int j = 0; j < count; j++) {
                res.Add(res[j] + cur[1].ToString());
                res.Add(res[j] + cur[2].ToString());
                if (digits[i] == '7' || digits[i] == '9') {
                    res.Add(res[j] + cur[3].ToString());
                }
                res[j] = (res[j] + cur[0].ToString());
            }
            count = res.Count;
        }
        return res;
    }
    #endregion

    #region 位1的个数
    public static int HammingWeight(int n) {
        const int BITS = 32;
        int res = 0;
        for (int i = 0; i < BITS; i++) {
            res += (int)(n >> i) & 1;
        }
        return res;
    }
    #endregion

    #region 丢失的数字
    public static int MissingNumber(int[] nums) {
        int n = nums.Length;
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != i) {
                return i;
            }
        }
        return n;
    }
    #endregion

    #region 只出现一次的数
    public static int SingleNumber(int[] nums) {
        HashSet<int> res = new HashSet<int>();
        foreach (var num in nums) {
            if (res.Contains(num)) {
                res.Remove(num);
            } else {
                res.Add(num);
            }
        }
        foreach (var num in res) {
            return num;
        }
        return 0;
    }

    public static int SingleNumber_1(int[] nums) {
        int res = 0;
        foreach (var e in nums) {
            res ^= e;
        }
        return res;
    }

    #endregion

    #region 找不同
    public static char FindTheDifference(string s, string t) {
        if (s.Length == 0) {
            return t[0];
        }
        Dictionary<char, int> sRes = new Dictionary<char, int>();
        foreach (var ch in s) {
            if (sRes.ContainsKey(ch)) {
                sRes[ch]++;
            } else {
                sRes.Add(ch, 1);
            }
        }

        foreach (var ch in t) {
            if (sRes.ContainsKey(ch)) {
                if (sRes[ch] == 1) {
                    sRes.Remove(ch);
                } else {
                    sRes[ch]--;
                }
            } else {
                sRes.Add(ch, 1);
            }
        }

        foreach (var k in sRes) {
            return k.Key;
        }

        return ' ';
    }

    public static char FindTheDifference_1(string s, string t) {
        if (s.Length == 0) {
            return t[0];
        }

        char[] sArr = s.ToCharArray();
        char[] tArr = t.ToCharArray();
        Array.Sort(sArr);
        Array.Sort(tArr);

        for (int i = 0; i < t.Length; i++) {
            if (i >= s.Length || tArr[i] != sArr[i]) {
                Debug.Log(i);
                return tArr[i];
            }
        }
        return ' ';
    }

    #endregion

    #region 整数转罗马
    // 内存更省
    public static string IntToRoman(int num) {
        int index = 0;
        StringBuilder res = new StringBuilder();
        while (num > 0) {
            int cur = num % 10;
            index++;
            num /= 10;
            if (index == 1) {
                if (cur < 4) {
                    for (int i = 0; i < cur; i++) {
                        res.Append("I");
                    }
                } else if (cur == 4) {
                    res.Append("VI");
                } else if (cur == 9) {
                    res.Append("XI");
                } else {
                    for (int i = 0; i < cur - 5; i++) {
                        res.Append("I");
                    }
                    res.Append("V");
                }
            } else if (index == 2) {
                if (cur < 4) {
                    for (int i = 0; i < cur - 1; i++) {
                        res.Append("X");
                    }
                } else if (cur == 4) {
                    res.Append("LX");
                } else if (cur == 9) {
                    res.Append("CX");
                } else {
                    for (int i = 0; i < cur - 5; i++) {
                        res.Append("X");
                    }
                    res.Append("L");
                }
            } else if (index == 3) {
                if (cur < 4) {
                    for (int i = 0; i < cur - 1; i++) {
                        res.Append("C");
                    }
                } else if (cur == 4) {
                    res.Append("DC");
                } else if (cur == 9) {
                    res.Append("MC");
                } else {
                    for (int i = 0; i < cur - 5; i++) {
                        res.Append("C");
                    }
                    res.Append("D");
                }
            } else if (index == 4) {
                for (int i = 0; i < cur; i++) {
                    res.Append("M");
                }
            }
        }

        StringBuilder re = new StringBuilder();
        for (int i = res.Length - 1; i >= 0; i--) {
            re.Append(res[i]);
        }
        return re.ToString();
    }

    public static string IntToRoman_1(int num) {

        // Tuple<int, string>[] values = {
        //     new Tuple<int, string>(1000, "M")
        // };
        Tuple<int, string>[] values = new Tuple<int, string>[]{
            new Tuple<int, string>(1000, "M"),
            new Tuple<int, string>(900,"CM"),
            new Tuple<int, string>(500,"D"),
            new Tuple<int, string>(400,"CD"),
            new Tuple<int, string>(100,"C"),
            new Tuple<int, string>(90,"XC"),
            new Tuple<int, string>(50, "L"),
            new Tuple<int, string>(40, "XL"),
            new Tuple<int, string>(10, "X"),
            new Tuple<int, string>(9, "IX"),
            new Tuple<int, string>(5, "V"),
            new Tuple<int, string>(4, "IV"),
            new Tuple<int, string>(1, "I")
        };

        StringBuilder res = new StringBuilder();
        foreach (var tupple in values) {
            int value = tupple.Item1;
            string symbol = tupple.Item2;
            while (num >= value) {
                num -= value;
                res.Append(symbol);
            }
            if (num == 0) {
                break;
            }
        }
        return res.ToString();
    }

    #endregion

    #region 整数反转
    public static int Reverse(int x) {
        int res = 0;

        return res;
    }
    #endregion

    #region 验证回文串
    public static bool IsPalindrome(string s) {
        StringBuilder res = new StringBuilder();
        foreach (var ch in s) {
            int cur = (int)ch;
            if (cur >= 65 && cur <= 90 || cur >= 48 && cur <= 57) {
                res.Append(ch);
            }
            if (cur >= 97 && cur <= 122) {
                cur -= 32;
                char big = (char)cur;
                res.Append(big);
            }
        }
        StringBuilder newRes = new StringBuilder();
        for (int i = res.Length - 1; i >= 0; i--) {
            newRes.Append(res[i]);
        }
        return res.ToString() == newRes.ToString() ? true : false;
    }
    #endregion

    #region Z字形变换
    public static string Convert(string s, int numRows) {
        if (s.Length == 1 || numRows == 1) {
            return s;
        }

        string[] all = new string[numRows];
        int size = 2 * numRows - 2;
        for (int i = 0; i < s.Length; i++) {
            var cur = s[i];
            int curIndex = i % size;
            if (curIndex >= numRows) {
                curIndex = size - curIndex;
            }
            all[curIndex] += cur;
        }
        // 节省性能
        StringBuilder res = new StringBuilder();
        for (int j = 0; j < all.Length; j++) {
            res.Append(all[j]);
        }
        return res.ToString();
    }
    #endregion

    #region 存在重复元素II
    public static bool ContainsNearbyDuplicate(int[] nums, int k) {
        bool has = false;
        Dictionary<int, int> temp = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            var cur = nums[i];
            if (temp.TryGetValue(cur, out int index1)) {
                Debug.Log(index1 + " " + i);
                if (Math.Abs(index1 - i) <= k) {
                    has = true;
                    return has;
                } else {
                    temp[cur] = i;
                }
            } else {
                temp.Add(cur, i);
            }
        }
        return has;
    }
    #endregion

    #region 存在重复元素
    public static bool ContainsDuplicate(int[] nums) {
        bool has = false;
        HashSet<int> res = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++) {
            var cur = nums[i];
            if (!res.Contains(cur)) {
                res.Add(cur);
            } else {
                has = true;
                return has;
            }
        }
        return has;
    }
    #endregion

    #region 乘最多水的容器
    public static int MaxArea_1(int[] height) {
        if (height.Length == 1) {
            return 0;
        }
        if (height.Length == 2) {
            return Math.Min(height[0], height[1]);
        }
        int max = 0;
        int smallIndex = 0;
        int bigIndex = 0;
        if (height[0] >= height[height.Length - 1]) {
            smallIndex = height.Length - 1;
        } else {
            bigIndex = height.Length - 1;
        }

        while (smallIndex != bigIndex) {
            int cur = height[smallIndex] * Math.Abs(bigIndex - smallIndex);
            if (cur >= max) {
                max = cur;
            }
            if (smallIndex > bigIndex) {
                smallIndex--;
            } else {
                smallIndex++;
            }
            if (smallIndex == bigIndex) {
                break;
            }
            if (height[smallIndex] >= height[bigIndex]) {
                int temp = smallIndex;
                smallIndex = bigIndex;
                bigIndex = temp;
            }
        }

        return max;
    }

    public static int MaxArea(int[] height) {
        int left = 0;
        int right = height.Length - 1;
        int max = 0;
        while (left < right) {
            int curArea = (right - left) * (Math.Min(height[right], height[left]));
            max = Math.Max(curArea, max);
            if (height[left] >= height[right]) {
                right--;
            } else {
                left++;
            }
        }

        return max;
    }

    #endregion

    #region  两数之和等于目标数
    public static int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length - 1; i++) {
            for (int j = i + 1; j < nums.Length; j++) {
                if (nums[i] + nums[j] == target) {
                    return new int[] { i, j };
                }
            }
        }
        return new int[] { -1, -1 };
    }
    #endregion

    #region 回文数
    // - 我的思路
    public static bool IsPalindrome_1(int x) {
        if (x < 0) {
            return false;
        }
        List<byte> tarList = new List<byte>();
        // int 类型最多是10位数，有9个零，求得每位数的十进制数字，放进list
        for (int i = 9; i >= 0; i--) {
            byte cur;
            if (tarList.Count == 0) {
                cur = (byte)(x / (int)Mathf.Pow(10, i));
            } else {
                int curX = x % (int)Mathf.Pow(10, i + 1);
                cur = (byte)(curX / (int)Mathf.Pow(10, i)); // Mathf.Pow(10,i);是float 类型的，要转（int） 不然会有误差
                                                            // if (i == 8) {
                                                            //     Debug.Log(cur + "  " + curX / 100000000);
                                                            // }
            }
            if (tarList.Count == 0) {
                if (cur > 0) {
                    tarList.Add(cur);
                }
            } else {
                tarList.Add(cur);
            }
        }

        if (tarList.Count == 0) {
            // 说明这个数是0；
            return true;
        }

        int res = 0;
        for (int i = 0; i < tarList.Count; i++) {
            res += (int)Mathf.Pow(10, i) * tarList[i];
        }
        if (res == x) {
            return true;
        } else {
            return false;
        }
    }
    public static bool IsPalindrome(int x) {
        // x小于0，或者，个位数是0（0%10也是0，所以要排除）
        if (x < 0 || x % 10 == 0 && x != 0) {
            return false;
        }
        // 从x的个位数开始
        int revertedNumber = 0;
        // 偶 1221         奇 12321
        // 只需要做左右两边的比较，x是左边剩下的值，revertedNumber是生成的右边的值
        while (x > revertedNumber) {
            revertedNumber = revertedNumber * 10 + x % 10;
            x /= 10;
        }
        System.Console.WriteLine(x + "  " + revertedNumber);
        //       x的位数为偶位           x的位数为奇位数
        return x == revertedNumber || x == revertedNumber / 10;
    }
    #endregion

    #region 罗马数字转整数
    public static int RomanToInt_1(string s) {
        int res = 0;
        char[] chars = s.ToCharArray();
        for (int i = 0; i < chars.Length; i++) {
            var cur = chars[i];
            int j = i + 1 < chars.Length ? i + 1 : -1;
            var next = 'A';
            if (j != -1) {
                next = chars[j];
            }

            // 剩最后一位
            if (next == 'A') {
                if (cur == 'V') {
                    res += 5;
                } else if (cur == 'I') {
                    res += 1;
                } else if (cur == 'X') {
                    res += 10;
                } else if (cur == 'L') {
                    res += 50;
                } else if (cur == 'C') {
                    res += 100;
                } else if (cur == 'D') {
                    res += 500;
                } else if (cur == 'M') {
                    res += 1000;
                }
                return res;
            }


            if (cur == 'I') {

                if (next == 'V') {
                    res += 4;
                    i++;
                } else if (next == 'X') {
                    res += 9;
                    i++;
                } else {
                    res += 1;
                }
            } else if (cur == 'X') {
                if (next == 'L') {
                    res += 40;
                    i++;
                } else if (next == 'C') {
                    res += 90;
                    i++;
                } else {
                    res += 10;
                }
            } else if (cur == 'C') {
                if (next == 'D') {
                    res += 400;
                    i++;
                } else if (next == 'M') {
                    res += 900;
                    i++;
                } else {
                    res += 100;
                }

            } else {
                if (cur == 'V') {
                    res += 5;
                } else if (cur == 'L') {
                    res += 50;
                } else if (cur == 'D') {
                    res += 500;
                } else if (cur == 'M') {
                    res += 1000;
                }
            }

        }
        return res;
    }

    public static int RomanToInt(string s) {

        Dictionary<char, int> symbolValues = new Dictionary<char, int>(){
            {'I',1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000}
        };

        int res = 0;
        char[] chars = s.ToCharArray();
        for (int i = 0; i < chars.Length; i++) {
            int value = symbolValues[chars[i]];
            if (i < chars.Length - 1 && value < symbolValues[chars[i + 1]]) {
                res -= value;
            } else {
                res += value;
            }
        }
        return res;
    }
    #endregion

    #region 公共最长前缀
    public static string LongestCommonPrefix(string[] strs) {
        string res = "";
        string first = strs[0];
        for (int j = 0; j < first.Length; j++) {
            for (int i = 1; i < strs.Length; i++) {
                string cur = strs[i];
                if (cur.Length - 1 < j) {
                    return res;
                }
                if (first[j] != cur[j]) {
                    return res;
                }
            }
            res += first[j];
        }
        return res;
    }
    #endregion

    #region 三数之和 
    public static IList<IList<int>> ThreeSum_1(int[] nums) {
        List<IList<int>> res = new List<IList<int>>();
        List<Vector3> vs = new List<Vector3>();
        if (nums.Length < 3) {
            return res;
        }
        List<int> temp = new List<int>();
        int count = 0;
        for (int i = 0; i < nums.Length; i++) {
            var cur = nums[i];
            if (cur == 0) {
                count++;
            }
            if (temp.Contains(cur)) {
                continue;
            } else {
                temp.Add(cur);
            }
        }

        if (count >= 3) {
            res.Add(new List<int>() { 0, 0, 0 });
            vs.Add(new Vector3(0, 0, 0));
        }

        temp.Sort();
        if (temp.Count == 1 && temp[0] == 0) {
            if (res.Count == 0) {
                res.Add(new List<int>() { 0, 0, 0 });
            }
            return res;
        }
        if (temp.Count == 3) {
            if (temp[0] + temp[1] + temp[2] == 0) {
                res.Add(new List<int>() { temp[0], temp[1], temp[2] });
                return res;
            }
        }
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 2; i++) {
            int cur1 = nums[i];
            if (cur1 > 0) {
                break;
            }
            for (int j = i + 1; j < nums.Length; j++) {
                int cur2 = nums[j];
                for (int k = j + 1; k < nums.Length; k++) {
                    int cur3 = nums[k];
                    if (cur1 + cur2 + cur3 == 0) {
                        List<int> cur = new List<int>(3){
                            cur1,cur2,cur3
                        };
                        Vector3 v = new Vector3(cur[0], cur[1], cur[2]);
                        if (!vs.Contains(v)) {
                            vs.Add(v);
                            res.Add(cur);
                        }
                    }
                }
            }
        }
        return res;
    }

    public static IList<IList<int>> ThreeSum(int[] nums) {
        List<IList<int>> res = new List<IList<int>>();
        List<Vector3> v = new List<Vector3>();
        Array.Sort(nums);
        if (nums[0] > 0) {
            return res;
        }
        int left = 1;
        int right = nums.Length - 1;

        for (int i = 0; i < nums.Length - 2; i++) {
            var cur = nums[i];
            if (cur > 0) {
                break;
            }

            if (i > 0 && cur == nums[i - 1]) {
                continue;
            }

            left = i + 1;
            right = nums.Length - 1;

            while (left < right) {
                if (cur + nums[left] + nums[right] == 0) {
                    Vector3 vs = new Vector3(cur, nums[left], nums[right]);
                    if (!v.Contains(vs)) {
                        v.Add(vs);
                        res.Add(new List<int>() { cur, nums[left], nums[right] });
                    }
                    right--;
                    left++;
                } else if (cur + nums[left] + nums[right] > 0) {
                    right--;
                } else if (cur + nums[left] + nums[right] < 0) {
                    left++;
                }
            }
        }
        return res;
    }

    #endregion

    #region 有效的括号
    public static bool IsValid(string s) {
        // 新建一个堆栈
        Stack<char> stk = new Stack<char>();
        for (int i = 0; i < s.Length; i++) {
            var cur = s[i];
            // 如果是半边左边就推上去
            if (cur == '(' || cur == '{' || cur == '[') {
                stk.Push(cur);
            } else {
                // 不是第一个，且上一个是对应的 '('，就pop这个'(',抵消了
                if (stk.Count == 0) {
                    stk.Push(cur);
                    break;
                }
                if (cur == ')' && stk.Peek() == '(') {
                    stk.Pop();
                } else if (cur == ']' && stk.Peek() == '[') {
                    stk.Pop();
                } else if (cur == '}' && stk.Peek() == '{') {
                    stk.Pop();
                } else {
                    return false;
                }
            }
        }

        if (stk.Count > 0) {
            return false;
        } else {
            return true;
        }
    }
    #endregion

    #region 删除有序数组中的重复元素
    public static int RemoveDuplicates_1(int[] nums) {
        // [0,0,1,1,1,2,2,3,3,4]
        // [1,1,2]
        if (nums.Length <= 1) {
            return nums.Length;
        }
        List<int> res = new List<int>();
        for (int i = 0; i < nums.Length - 1; i++) {
            var cur = nums[i];
            if (res.Count == 0 || res.Count > 0 && cur != res[res.Count - 1]) {
                res.Add(cur);
            }
            int next = nums[i + 1];
            while (next == cur) {
                i++;
                if (i == nums.Length - 1) {
                    break;
                }
                Debug.Log(i);
                next = nums[i + 1];
            }

            if (cur != next) {
                res.Add(next);
            }
        }
        for (int i = 0; i < res.Count; i++) {
            nums[i] = res[i];
        }
        return res.Count;
    }

    public static int RemoveDuplicates(int[] nums) {
        if (nums.Length <= 1) {
            return nums.Length;
        }
        int slow = 0;
        int fast = 1;
        while (fast < nums.Length) {
            if (nums[slow] != nums[fast]) {
                slow += 1;
                nums[slow] = nums[fast];
            }
            fast += 1;
        }
        return slow + 1;// slow 是下标，数量要+1；
    }
    #endregion

    #region 移除元素
    public static int RemoveElement_1(int[] nums, int val) {
        Stack<int> stk = new Stack<int>();
        for (int i = 0; i < nums.Length; i++) {
            var cur = nums[i];
            if (cur == val) {
                continue;
            } else {
                stk.Push(cur);
            }
        }
        int count = 0;
        foreach (var s in stk) {
            nums[count] = s;
            count++;
        }
        return count;
    }

    public static int RemoveElement(int[] nums, int val) {
        int k = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != val) {
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }
    #endregion

    #region 找出字符串中第一个匹配项的下标
    // 我这个性能更好，内存消耗差不多
    public static int StrStr_1(string haystack, string needle) {
        if (haystack.Length < needle.Length) {
            return -1;
        }
        for (int i = 0; i < haystack.Length; i++) {
            char cur = haystack[i];
            if (cur == needle[0]) {
                if (i + needle.Length > haystack.Length) {
                    return -1;
                }
                bool istrue = true;
                for (int j = 1; j < needle.Length; j++) {
                    cur = haystack[i + j];
                    var need = needle[j];
                    if (cur != need) {
                        istrue = false;
                        continue;
                    }
                }
                if (istrue) {
                    return i;
                }
            } else {
                continue;
            }
        }

        return -1;

    }

    public static int StrStr(string haystack, string needle) {
        int j = 0;
        for (int i = 0; i < haystack.Length; i++) {
            if (haystack[i] == needle[j]) {
                j++;
                if (j == needle.Length)
                    return i - j + 1;

            } else {
                i -= j;
                j = 0;
            }
        }
        return -1;
    }
    #endregion

    #region 搜索插入位置
    public static int SearchInsert_1(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++) {
            var cur = nums[i];
            if (cur < target) {
                continue;
            } else if (cur > target) {
                return i;
            } else if (cur == target) {
                return i;
            }
        }
        return nums.Length;
    }
    // 二分法
    public static int SearchInsert(int[] nums, int target) {
        if (target <= nums[0]) {
            return 0;
        } else if (target > nums[nums.Length - 1]) {
            return nums.Length;
        }

        int start = 0;
        int end = nums.Length - 1;
        return FindIndex(nums, target, start, end);
    }

    public static int FindIndex(int[] nums, int target, int start, int end) {
        int index;
        if (start > end) {
            index = start;
            return index;
        }
        int middle = (int)((start + end) / 2);
        int midNum = nums[middle];
        if (midNum == target) {
            index = middle;
            return index;
        } else if (midNum < target) {
            start = middle + 1;
        } else {
            end = middle - 1;
        }
        index = FindIndex(nums, target, start, end);
        return index;
    }
    #endregion

    #region 寻找两个正序数组的中位数
    // 合并的数组不能重复元素
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        List<int> res = new List<int>();
        int j = 0;
        for (int i = 0; i < nums1.Length; i++) {
            var cur1 = nums1[i];
            if (j >= nums2.Length) {
                if (!res.Contains(cur1)) {
                    res.Add(cur1);
                }
                continue;
            }
            if (cur1 > nums2[j]) {
                if (!res.Contains(nums2[j])) {
                    res.Add(nums2[j]);
                }
                i--;
                j++;
            } else if (cur1 == nums2[j]) {
                if (!res.Contains(cur1)) {
                    res.Add(cur1);
                }
                j++;
            } else if (cur1 < nums2[j]) {
                if (!res.Contains(cur1)) {
                    res.Add(cur1);
                }
            }
        }

        if (j < nums2.Length) {
            for (int i = j; i < nums2.Length; i++) {
                if (!res.Contains(nums2[i])) {
                    res.Add(nums2[i]);
                }
            }
        }
        string s = "";
        foreach (var re in res) {
            s += re.ToString() + ",";
        }
        Debug.Log(s);

        int index;
        if (res.Count % 2 == 1) {
            index = (int)res.Count / 2;
            return res[index];
        } else {
            index = res.Count / 2;
            Debug.Log(res[index - 1] + " " + res[index]);
            return (double)(res[index - 1] + res[index]) / 2;
        }

    }

    // 合并的数组重复元素
    public static double FindMedianSortedArrays_1(int[] nums1, int[] nums2) {
        int count = nums1.Length + nums2.Length;
        int[] res = new int[count];
        for (int i = 0; i < count; i++) {
            if (i < nums1.Length && i >= 0) {
                res[i] = nums1[i];
            } else {
                res[i] = nums2[i - nums1.Length];
            }
        }
        Array.Sort(res);

        int index;
        if (res.Length % 2 == 1) {
            index = (int)res.Length / 2;
            return res[index];
        } else {
            index = res.Length / 2;
            return (double)(res[index - 1] + res[index]) / 2;
        }
    }
    #endregion

    #region 两数相加
    // /**
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null) {
            this.val = val;
            this.next = next;
        }
    }
    //  */

    public static List<ListNode> NumberToListNode(int[] nums) {
        List<ListNode> all = new List<ListNode>();
        foreach (var num in nums) {
            ListNode node = new ListNode(num);
            all.Add(node);
        }
        for (int i = 0; i < all.Count - 1; i++) {
            all[i].next = all[i + 1];
        }
        return all;
    }

    // 我这个有问题，数据会超出int范围 flaot a= mathf.Pow(10,count);返回的是float 类型的，当count 加大，很容易超出范围
    public static ListNode AddTwoNumbers_1(ListNode l1, ListNode l2) {
        uint value = 0;
        uint A = (uint)l1.val;
        uint B = (uint)l2.val;
        int Acount = 1;
        int Bcount = 1;
        while (l1.next != null) {
            A += (uint)l1.next.val * (uint)MathF.Pow(10, Acount);
            l1 = l1.next;
            Acount++;
        }
        while (l2.next != null) {
            B += (uint)l2.next.val * (uint)MathF.Pow(10, Bcount);
            Debug.Log(l2.next.val + " B IS" + B);
            l2 = l2.next;
            Bcount++;
        }
        value = A + B;
        Debug.Log(value + "A:" + A + "  B:" + B);
        int val = 0;
        List<ListNode> temp = new List<ListNode>();
        while (value >= 1) {
            val = (int)value % 10;
            ListNode newNode = new ListNode(val);
            temp.Add(newNode);
            value /= 10;
        }
        for (int i = 0; i < temp.Count - 1; i++) {
            var node = temp[i];
            node.next = temp[i + 1];
            Debug.Log(node.val);
        }
        // Debug.Log(temp[temp.Count - 1].val);
        if (temp.Count == 0) {
            return new ListNode(0);
        } else {
            return temp[0];
        }
    }

    // 转变思想： 从整体 转为一位一位，每位数字的范围都是0-9；
    // 两个数相加，最多是9+9=18, 这时候进了1位，要存到高一位十进制单位里，用一个int carry 来存储，因为限定了位数是<=100位，所以carry最多位为99（不过超了也没事，carry会一直求余 /10 直到为0);
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode head = null;
        ListNode cur = null;
        int sum = 0;
        int carry = 0;
        List<ListNode> all = new List<ListNode>();
        while (l1 != null || l2 != null || carry != 0) {
            int A = l1 != null ? l1.val : 0;
            int B = l2 != null ? l2.val : 0;
            sum = A + B + carry;
            cur = new ListNode(sum % 10);
            all.Add(cur);
            if (head == null) {
                head = cur;
            }
            carry = sum / 10;
            cur = cur.next;
            if (l1 != null && l1.next != null) {
                l1 = l1.next;
            } else {
                l1 = null;
            }
            if (l2 != null && l2.next != null) {
                l2 = l2.next;
            } else {
                l2 = null;
            }
        }
        for (int i = 0; i < all.Count - 1; i++) {
            all[i].next = all[i + 1];
        }

        if (head == null) {
            return new ListNode(0);
        }
        return head;
    }
    #endregion

    #region 无重复字符的最长子串
    // 我这个速度性能都不够
    public static int LengthOfLongestSubstring_1(string s) {
        List<char> res = new List<char>();
        int count = 0;

        for (int i = 0; i < s.Length; i++) {
            var cur = s[i];
            if (res.Contains(cur)) {
                if (res.Count >= count) {
                    count = res.Count;
                    // Debug.Log(res);
                }
                if (res[res.Count - 1] == cur) {
                    if (count > s.Length - 1 - i || res.Count > s.Length - 1 - i) {
                        break;
                    }
                    res.Clear();
                    res.Add(cur);
                    continue;
                } else {
                    bool isfind = false;
                    List<char> newRes = new List<char>();
                    for (int j = 0; j < res.Count; j++) {
                        if (!isfind && res[j] == cur) {
                            if (count > s.Length - 1 - j || res.Count > s.Length - 1 - j) {
                                break;
                            }
                            isfind = true;
                            continue;
                        }
                        if (isfind) {
                            newRes.Add(res[j]);
                        }
                    }
                    res = newRes;
                }
            }
            res.Add(cur);
        }

        // Debug.Log(res);

        if (count < res.Count) {
            // Debug.Log(res);
            return res.Count;
        }
        return count;
    }

    public static int LengthOfLongestSubstring(string s) {
        // 字符0或者1个的，不会重复，直接返回数量
        if (s.Length <= 1) {
            return s.Length;
        }
        // 
        HashSet<char> res = new HashSet<char>();
        int left = 0;
        int right = 1;

        // 加入第一个
        res.Add(s[0]);
        int count = 0;

        while (right < s.Length) {
            // res里没有这个元素
            if (!res.Contains(s[right])) {
                res.Add(s[right]);
                // 这里比较是因为res是一直更新的，count在变，我们要的是曾经最大的那个
                count = Mathf.Max(count, res.Count);
                // 添加完右移
                right++;
            } else {
                // 已经有这个元素了,从左边开始移除,直到没s[right]了为止
                res.Remove(s[left]);
                left++;
            }
        }
        return count;
    }

    #endregion

    #region 最后一个单词的长度
    public static int LengthOfLastWord_1(string s) {
        int length = 0;
        for (int i = 0; i < s.Length; i++) {
            var cur = s[i];
            if (cur == ' ') {
                if (i + 1 < s.Length && s[i + 1] != ' ') {
                    length = 0;
                } else {
                    continue;
                }
            } else {
                length++;
            }
        }
        return length;
    }

    public static int LengthOfLastWord_2(string s) {
        int length = 0;
        bool isFind = false;
        if (s[s.Length - 1] != ' ') {
            isFind = true;
        }
        for (int i = s.Length - 1; i >= 0; i--) {
            var cur = s[i];
            if (cur == ' ') {
                if (isFind) {
                    break;
                }
                if (s[i - 1] == ' ') {
                    continue;
                } else {
                    isFind = true;
                    continue;
                }
            } else {
                length++;
            }
        }
        return length;
    }

    // 最简洁
    public static int LengthOfLastWord(string s) {
        int length = 0;
        int index = s.Length - 1;
        while (index >= 0 && s[index] == ' ') {
            index--;
        }

        while (index >= 0 && s[index] != ' ') {
            length++;
            index--;
        }

        return length;
    }
    #endregion

    #region 有效的数独
    public static bool IsValidSudoku_1(char[][] board) {
        HashSet<char> board1 = new HashSet<char>();
        HashSet<char> board2 = new HashSet<char>();
        HashSet<char> board3 = new HashSet<char>();
        HashSet<char> board4 = new HashSet<char>();
        HashSet<char> board5 = new HashSet<char>();
        HashSet<char> board6 = new HashSet<char>();
        HashSet<char> board7 = new HashSet<char>();
        HashSet<char> board8 = new HashSet<char>();
        HashSet<char> board9 = new HashSet<char>();

        HashSet<char> colum = new HashSet<char>();
        int columCount = 0;
        while (columCount < 9) {
            for (int y = 0; y < board.Length; y++) {
                var cur = board[y];
                if (cur[columCount] == '.') {
                    continue;
                }
                if (colum.Contains(cur[columCount])) {
                    Debug.Log(columCount);
                    return false;
                } else {
                    colum.Add(cur[columCount]);
                }
            }
            columCount++;
            colum.Clear();
        }


        for (int i = 0; i < board.Length; i++) {
            char[] cur = board[i];
            HashSet<char> curRow = new HashSet<char>();
            for (int j = 0; j < cur.Length; j++) {
                var ch = cur[j];
                if (ch == '.') {
                    continue;
                }
                if (curRow.Contains(ch)) {
                    return false;
                } else {
                    curRow.Add(ch);
                }
                if (i < 3 && i >= 0 && j >= 0 && j < 3) {
                    if (board1.Contains(ch)) {
                        return false;
                    } else {
                        board1.Add(ch);
                    }
                } else if (i < 3 && i >= 0 && j >= 3 && j < 6) {
                    if (board2.Contains(ch)) {
                        return false;
                    } else {
                        board2.Add(ch);
                    }
                } else if (i < 3 && i >= 0 && j >= 6 && j < 9) {
                    if (board3.Contains(ch)) {
                        return false;
                    } else {
                        board3.Add(ch);
                    }
                } else if (i < 6 && i >= 3 && j >= 0 && j < 3) {
                    if (board4.Contains(ch)) {
                        return false;
                    } else {
                        board4.Add(ch);
                    }
                } else if (i < 6 && i >= 3 && j >= 3 && j < 6) {
                    if (board5.Contains(ch)) {
                        return false;
                    } else {
                        board5.Add(ch);
                    }
                } else if (i < 6 && i >= 3 && j >= 6 && j < 9) {
                    if (board6.Contains(ch)) {
                        return false;
                    } else {
                        board6.Add(ch);
                    }
                } else if (i < 9 && i >= 6 && j >= 0 && j < 3) {
                    if (board7.Contains(ch)) {
                        return false;
                    } else {
                        board7.Add(ch);
                    }
                } else if (i < 9 && i >= 6 && j >= 3 && j < 6) {
                    if (board8.Contains(ch)) {
                        return false;
                    } else {
                        board8.Add(ch);
                    }
                } else if (i < 9 && i >= 6 && j >= 6 && j < 9) {
                    if (board9.Contains(ch)) {
                        return false;
                    } else {
                        board9.Add(ch);
                    }
                }
            }
        }
        return true;
    }

    // 二维数组的应用(矩阵)
    public static bool IsValidSudoku(char[][] board) {
        int[,] row = new int[9, 9];
        int[,] colum = new int[9, 9];
        int[,,] subBoxex = new int[3, 3, 9];
        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                var cur = board[i][j];
                if (cur == '.') {
                    continue;
                }
                int index = cur - '0' - 1;
                row[i, index]++;
                colum[j, index]++;
                subBoxex[i / 3, j / 3, index]++;
                if (row[i, index] > 1 || colum[j, index] > 1 || subBoxex[i / 3, j / 3, index] > 1) {
                    return false;
                }
            }
        }
        return true;
    }

    #endregion

    #region 加一
    public static int[] PlusOne(int[] digits) {
        if (digits[0] == 0) {
            return new int[] { 1 };
        }

        bool needAdd = false;

        for (int i = digits.Length - 1; i >= 0; i--) {
            var cur = digits[i];
            if (cur == 9) {
                if (i == 0) {
                    needAdd = true;
                }
                digits[i] = 0;
            } else {
                digits[i]++;
                break;
            }
        }

        if (needAdd) {
            int[] res = new int[digits.Length + 1];
            res[0] = 1;
            for (int i = 1; i < res.Length; i++) {
                res[i] = digits[i - 1];
            }
            return res;
        }

        return digits;

    }
    #endregion

    #region 合并两个有序链表
    public static ListNode MergeTwoLists_1(ListNode list1, ListNode list2) {

        if (list1 == null && list2 == null) {
            return list1;
        }

        List<ListNode> all = new List<ListNode>();

        while (list1 != null || list2 != null) {
            if (list1 == null) {
                all.Add(list2);
                list2 = list2.next;
                continue;
            }
            if (list2 == null) {
                all.Add(list1);
                list1 = list1.next;
                continue;
            }

            if (list1.val <= list2.val) {
                all.Add(list1);
                list1 = list1.next;
            } else {
                all.Add(list2);
                list2 = list2.next;
            }
        }
        for (int i = 0; i < all.Count - 1; i++) {
            all[i].next = all[i + 1];
        }
        return all[0];
    }

    public static ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 == null) {
            return list2;
        } else if (list2 == null) {
            return list1;
        } else if (list1.val < list2.val) {
            list1.next = MergeTwoLists(list1.next, list2);
            return list1;
        } else {
            list2.next = MergeTwoLists(list1, list2.next);
            return list2;
        }
    }
    #endregion

    #region 删除排序链表中重复的重复元素
    public static ListNode DeleteDuplicates(ListNode head) {
        if (head == null) {
            return head;
        }
        var temp = head;
        while (temp.next != null) {
            if (temp.val == temp.next.val) {
                temp.next = temp.next.next;
            } else {
                temp = temp.next;
            }
        }
        return head;
    }
    #endregion

}
