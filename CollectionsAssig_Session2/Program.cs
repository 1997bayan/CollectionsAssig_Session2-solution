using System.Collections;

namespace CollectionsAssig_Session2
{
    internal class Program
    {


        #region Try1
        public static void Reverse1(ArrayList arrayList)
        {


            int n = arrayList.Count; //5
            if (arrayList is not null)
            {

                for (int i = n - 1; (i < n && i >= 0); i--)
                {
                    Console.Write($" {arrayList[i]} ");

                }
            }
        } 
        #endregion

        public static void Reverse2(ArrayList arrayList)
        {  int n = arrayList.Count;
            if (arrayList is not null)
            {
                for(int i = 0; i <n/2 ; i++)
                { 
                    ArrayList temp = new ArrayList();
                    temp.Add(arrayList[i]);
                    arrayList[i] = arrayList[n - i - 1];
                    arrayList[n-i-1] = temp[0];

                }

            }
        }

        public static List<int> EvenList (List<int> list)
        {   

            List <int> EvenList = new List<int>();
            for (int i = 0;i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                   EvenList.Add(list[i]);

                }
            }
            return EvenList;


        }
        static void Main(string[] args)
        {
            #region Q1:You are given an ArrayList containing a sequence of elements. 
            //try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.
            ArrayList arrayList = new ArrayList() { 1,2,3,4,5};
            #region Try 1
            ////Reverse1(arrayList);
            ////Console.WriteLine();
            ////foreach (int i in arrayList)
            ////{
            ////    Console.Write(i);
            ////} 
            #endregion


            Reverse2(arrayList);
            Console.WriteLine();
            foreach (int i in arrayList)
            {
                Console.Write($"{i} ");
            }
            #endregion

            #region Q2 2.	You are given a list of integers.
            //Your task is to find and return a new list containing only the even numbers from the given list.

            List<int>list = new List<int>() { 33,5,10,20,30,40};
            List<int> even = EvenList(list);
            Console.WriteLine();
            Console.WriteLine("Even List ");
            foreach (int i in even)
            { 
                Console.Write ($" {i} ");
            }

            #endregion

            #region Q3- 1.	implement a custom list called FixedSizeList<T> with a predetermined capacity. This list should not allow more elements than its capacity and should provide clear messages if one tries to exceed it or access invalid indices.
            // Requirements:
            //1. Create a generic class named FixedSizeList<T>.
            //2. a constructor that takes the fixed capacity of the list as a
            //parameter.
            //3.Implement an Add method that adds an element to the list, but throws an exception if the list is already full.
            //4.Implement a Get method that retrieves an element at a specific index in the list but throws an exception for invalid indices.
            FixedSizeList<int> fixedSizeList = new FixedSizeList<int>(4);
            fixedSizeList.AddElement(1);
            fixedSizeList.AddElement(10);
            fixedSizeList.AddElement(100);
           fixedSizeList.AddElement(100);
            //fixedSizeList.AddElement(100); //InvalidOperationException: The list is Full , Count >= Capacity




            Console.WriteLine();
            Console.WriteLine($"fixedSizeList Count = {fixedSizeList.count} , fixedSizeList Capacity ={fixedSizeList.Capacity} ");
            int x = fixedSizeList.Get(5);
            Console.WriteLine(x);










            #endregion

        }
}
}
