using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    }

    // Update is called once per frame
    void Update() {

    }


    // 两数之和 等于 目标数
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

    // 回文数
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
        while (x > revertedNumber) {
            revertedNumber = revertedNumber * 10 + x % 10;
            x /= 10;
        }
        System.Console.WriteLine(x + "  " + revertedNumber);
        //       x的位数为偶位           x的位数为奇位数
        return x == revertedNumber || x == revertedNumber / 10;
    }

    // 罗马数字转整数
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

    // 公共最长前缀
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
}
