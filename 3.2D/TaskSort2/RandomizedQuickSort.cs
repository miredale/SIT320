using System;
using System.Collections.Generic;

namespace Vector
{
    /// Randomized QuickSort Alogrithm
    class RandomizedQuickSort: ISorter
    {
        private Random Random { get; set; } = new Random();
        private int RandomPivot(int a, int b) => Random.Next(a, b);

        // "sequence" The sequence of generic elements to sort
        // "comparer" The IComparer to use for sorting rules
        // "K" The type of the elements
        // "System.ArgumentNullException" Thrown when the sequence is null
        public void Sort<K>(K[] sequence, IComparer<K> comparer) where K : IComparable<K>
        {
            if (sequence == null) throw new ArgumentNullException();
            if (sequence.Length < 2) return; // if array is of size 1 it is already sorted
            if (comparer == null) comparer = Comparer<K>.Default;
            Sort(sequence, comparer, 0, sequence.Length - 1);
        }

        // Using random pivot selection, recursively quick sorts an array
        private void Swap<K>(K[] sequence, int a, int b)
        {
            K temp = sequence[a];
            sequence[a] = sequence[b];
            sequence[b] = temp;
        }

        private void Sort<K>(K[] sequence, IComparer<K> comparer,int a,int b) where K : IComparable<K>
        {
            //left value is larger than right value then that pair is sorted
            if (a >= b) return;

            int left = a;
            int right = b - 1;

            //using the randomly assigned range, array values are swapped
            Swap(sequence, RandomPivot(a, b), b);
            //New pivot becomes the upper bound
            K pivot = sequence[b];

            //Performs operations if right value is larger than or equal to left value
            while(left <= right)
            {
                //if left value is less than pivot value, left index value is moved forward
                while (left <= right && comparer.Compare(sequence[left], pivot) < 0) left++;
                //if right value is greater than pivot value, right index value is moved backward
                while (left <= right && comparer.Compare(sequence[right], pivot) > 0) right--;
                //check again if left value is less than or equal to right value
                if(left <= right)
                {
                    //swap left and right values
                    Swap(sequence, left, right);
                    left++; 
                    right--;
                }
            }

            //swap left and right values
            Swap(sequence, left, b);

            //sort left half
            Sort(sequence, comparer, a, left - 1);
            //sort right half
            Sort(sequence, comparer, left + 1, b);
        }
    }
}