using System;
using System.Collections.Generic;

namespace Vector
{
    //Top-down MergeSort algorithm (Recursive)
    class MergeSortTopDown : ISorter
    {
        // "sequence" The sequence of generic elements to sort
        // "comparer" The IComparer to use for sorting rules
        // "K" The type of the elements
        // "System.ArgumentNullException" Thrown when the sequence is null
        public void Sort<K>(K[] sequence, IComparer<K> comparer) where K : IComparable<K>
        {
            if (sequence is null) throw new ArgumentNullException();
            if (sequence.Length < 2) return; // if array is of size 1 it is already sorted
            if (comparer is null) comparer = Comparer<K>.Default;

            int mid = sequence.Length / 2; //
            K[] left = sequence[0..mid]; //Left half of array is from index 0 to mid
            K[] right = sequence[mid..sequence.Length]; // Right half of array is from index mid to last

            Sort(left, comparer); //Perform sorting on left half
            Sort(right, comparer); // Perform sorting on right half
            Merge(left, right, sequence, comparer); //Merge the two sorted arrays
        }

        // Merges two arrays in order that abides by the IComparer
        // "left" One array of elements to merge
        // "right" Second array of elements to merge
        private void Merge<K>(K[] left, K[] right, K[] sequence, IComparer<K> comparer) where K : IComparable<K>
        {
            int i = 0;
            int j = 0;
            //Check if net length of the two arrays is still less than array's total legnth
            while (i + j < sequence.Length)
            {
                //j is same as right array length and i is less than left array's length then
                //comapre left array's value and right array's value
                //if less than 0 then left array contains smaller values and is moved into the array first
                if (j == right.Length || (i < left.Length && comparer.Compare(left[i], right[j]) < 0))
                    sequence[i + j] = left[i++];
                else
                //otherwise right array has smaller values and moved into the array first
                    sequence[i + j] = right[j++];
            }
        }
    }
}