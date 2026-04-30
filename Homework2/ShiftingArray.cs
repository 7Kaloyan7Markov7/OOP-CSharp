using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Homework2
{

    internal class ShiftingArray
    {
        internal enum RotationDirection
        {
            Left,
            Right
        }

        private readonly int[] _arr;


        public int Size 
        { 
            get => _arr.Length; 
        }

        public int[] Arr
        {
            get => _arr;
        }

        public ShiftingArray(int size)
        {
            _arr = new int[size];
        }

        public void FillArray()
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                _arr[i] = int.Parse(Console.ReadLine());
            }
        }

        public void PrintArray()
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                Console.Write($"{_arr[i]} ");
            }
        }

        public void Rotate(int k, RotationDirection direction)
        {
            if (_arr.Length == 0) return;

            k %= _arr.Length;

            if (k == 0) return;
            if (k < 0) k += _arr.Length;

            Span<int> span = _arr.AsSpan();

            if (direction == RotationDirection.Right) RotateRight(span, k);
            else RotateLeft(span, k);
        }

        public void RotateLeft(Span<int> span, int k)
        {
            Reverse(span[..k]);
            Reverse(span[k..]);
            Reverse(span);
        }

        public void RotateRight(Span<int> span, int k)
        {
            Reverse(span);
            Reverse(span[..k]);
            Reverse(span[k..]);
        }

        private void Reverse(Span<int> span)
        {
            int left = 0;
            int right = span.Length - 1;

            while (left < right)
            {
                int temp = span[left];
                span[left] = span[right];
                span[right] = temp;

                left++;
                right--; //right
            }
        }
    }
}
