# Codility-MaxCounters
You are given N counters, initially set to 0, and you have two possible operations on them:</br>
increase(X) − counter X is increased by 1,</br>
max counter − all counters are set to the maximum value of any counter.</br>
A non-empty array A of M integers is given. This array represents consecutive operations:</br>
if A[K] = X, such that 1 ≤ X ≤ N, then operation K is increase(X),</br>
if A[K] = N + 1 then operation K is max counter.</br>
For example, given integer N = 5 and array A such that:</br>
A[0] = 3</br>
A[1] = 4</br>
A[2] = 4</br>
A[3] = 6</br>
A[4] = 1</br>
A[5] = 4</br>
A[6] = 4</br>
the values of the counters after each consecutive operation will be:</br>
(0, 0, 1, 0, 0)</br>
(0, 0, 1, 1, 0)</br>
(0, 0, 1, 2, 0)</br>
(2, 2, 2, 2, 2)</br>
(3, 2, 2, 2, 2)</br>
(3, 2, 2, 3, 2)</br>
(3, 2, 2, 4, 2)</br>
The goal is to calculate the value of every counter after all operations.</br>

Write a function:</br>
class Solution { public int[] solution(int N, int[] A); }</br>
that, given an integer N and a non-empty array A consisting of M integers,</br>
returns a sequence of integers representing the values of the counters.

Result array should be returned as an array of integers.</br>
For example, given:</br>
A[0] = 3</br>
A[1] = 4</br>
A[2] = 4</br>
A[3] = 6</br>
A[4] = 1</br>
A[5] = 4</br>
A[6] = 4</br>
the function should return [3, 2, 2, 4, 2], as explained above.</br>

Write an efficient algorithm for the following assumptions:</br>
N and M are integers within the range [1..100,000];</br>
each element of array A is an integer within the range [1..N + 1].
