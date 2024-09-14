using System;
using System.Collections.Generic;

public static class 数据结构整理 {

    public class Human {
        public Human next;
    }

    public static void Entry() {

        // 数组
        int[] array = new int[10];

        // 链表
        // LinkedList<int> linklist = new LinkedList<int>(); 一般不用，会子写一个，用next；
        Human root = new Human();
        Human cur = root;
        for (int i = 0; i < 10; i++) {
            Human human = new Human();
            cur.next = human;
            cur = human;
        }

        // === 扩展实现 ===
        // List 可扩容的有序数组，内部是数组
        // 添加的时候不会排序
        List<int> list = new List<int>();  // 一开始可以不确认数据的大小，添加的时候默认生成一个Count为4的，超出大小会自动扩容
        list.Add(100);

        // sortedList 有序字典，内部是两个数组，一个存key[],一个存value[]
        // 每次添加都会排序一遍
        SortedList<int, string> sortedlist = new SortedList<int, string>();
        sortedlist.Add(1, "yo");
        sortedlist.Add(0, "h");
        // 结果： 0, 1  复杂度O(n)

        // 数组+链表 数组来存储每个链表的节点
        // HashSet哈希表 key用链表来存，与字典的区别是没有存Value

        // Dictionary 字典
        Dictionary<int, string> dict = new Dictionary<int, string>();
        dict.Add(1, "yo");
        dict.Add(0, "h");

        // stack 栈 内部是链表（或者数组）
        // 是LIFO(Last In First Out) 性能好
        Stack<int> stack = new Stack<int>();
        // 入列
        stack.Push(0);
        stack.Push(1);
        // 出
        stack.Pop();  // 1先出；
        // Peek
        int peek = stack.Peek(); // 只读 获取后入的1；

        // Queue 队列 内部是链表（或数组）
        // FIFO （first In First Out) 更符合排队的概念，先来的人优先处理
        Queue<int> queue = new Queue<int>();
        // 入
        queue.Enqueue(0);
        queue.Enqueue(1);
        // 出
        queue.Dequeue();  // 获得0；
        // peek
        peek = queue.Peek();   // 只读 获取陷入的0；

        // sortedlist 排序的List   用的有序数组排序
        // 插入移除的性能是O(n)
        // 查找O(logn)

        // sortedSet  排序的哈希表  用的二叉树排序
        // 插入移除的性能是O(logn); 性能更高
        // 查找O(logn)

        // sortedDIctionary 排序的字典 用二叉树排序
        
    }
}