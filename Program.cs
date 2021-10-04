using System;

namespace Day15_BinarySearchTree_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("\n***********BINARY SEARCH TREE OPERATIONS************");

                
                #region UC1_Create_A_BST

                UC1_Create_A_BST<int> binarySearch = new UC1_Create_A_BST<int>(56);
                binarySearch.Add(30);
                binarySearch.Add(70);
                binarySearch.Display();

                #endregion




                #region UC2_InsertAllValues

                UC2_InsertAllValues<int> binarySearchAll = new UC2_InsertAllValues<int>(56);
                binarySearchAll.Insert(30);
                binarySearchAll.Insert(70);
                binarySearchAll.Insert(22);
                binarySearchAll.Insert(40);
                binarySearchAll.Insert(60);
                binarySearchAll.Insert(95);
                binarySearchAll.Insert(11);
                binarySearchAll.Insert(65);
                binarySearchAll.Insert(3);
                binarySearchAll.Insert(16);
                binarySearchAll.Insert(63);
                binarySearchAll.Insert(67);
                binarySearchAll.Display();

                #endregion


                #region UC3_SearchValueFromTree

                UC3_SearchValueFromTree<int> binarySearch1 = new UC3_SearchValueFromTree<int>(56);
                binarySearch1.Insert(30);
                binarySearch1.Insert(70);
                binarySearch1.Insert(22);
                binarySearch1.Insert(40);
                binarySearch1.Insert(60);
                binarySearch1.Insert(95);
                binarySearch1.Insert(11);
                binarySearch1.Insert(65);
                binarySearch1.Insert(3);
                binarySearch1.Insert(16);
                binarySearch1.Insert(63);
                binarySearch1.Insert(67);

                binarySearch1.Display();

                bool result = binarySearch1.Search(67, binarySearch1);
                Console.WriteLine(result);

                #endregion
            }
        }
    }
}
    
