using System;
using System.Collections.Generic;

namespace Vector
{
    //Bottom-up MergeSort algorithm (Iterative)
    class MergeSortBottomUp: ISorter
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

            K[] nonr = sequence; //the input array
            K[] dest = new K[sequence.Length]; // the output array
            K[] temp; //empty array for swapping

            //starts with array of size 2 and doubles until the array contains all sorted elements
            for (int i = 1; i < sequence.Length; i *= 2)
            {
                //the sorted input array is merged and swapped with the ouput array ready for the next iteration
                for (int j = 0; j < sequence.Length; j += 2 * i) Merge(nonr, dest, comparer, j, i);
                temp = nonr;
                nonr = dest;
                dest = temp;
            }
            //if the input array (sequence) doesn't equal its clone (nonr) then the input array is copied
            if (sequence != nonr)
                Array.Copy(nonr, 0, sequence, 0, sequence.Length);
        }

        // "ins" input array for merging
        // "outs" output array for sending merged array
        // "start" The start index to merge
        // "inc" The number of elements to merge
        private void Merge<K>(K[] ins, K[] outs, IComparer<K> comparer, int start, int inc) where K : IComparable<K>
        {
            //first half of the array to merge
            int end1 = Math.Min(start + inc, ins.Length);
            //second half of the array to merge
            int end2 = Math.Min(start + 2 * inc, ins.Length);

            int x = start;
            int y = start + inc;
            int z = start;

            //check if both array's index's haven't reached their respective array lengths
            while (x < end1 && y < end2)
            //if right array value is greater than left array value
                if (comparer.Compare(ins[x], ins[y]) < 0)
                //move left array value into output array
                    outs[z++] = ins[x++];
                else
                //otherwise move right array value into output array
                    outs[z++] = ins[y++];
            //if left array value was moved that array size reduced
            //and sent back for next iteration
            if (x < end1)
                Array.Copy(ins, x, outs, z, end1 - x);
            //otherwise the right array
            else if (y < end2)
                Array.Copy(ins, y, outs, z, end2 - y);
        }
    }
}