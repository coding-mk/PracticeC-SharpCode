//Merge Overlapping Intervals
/*Problem Description

Given a collection of intervals, merge all overlapping intervals.



Problem Constraints

1 <= Total number of intervals <= 100000.



Input Format

First argument is a list of intervals.



Output Format

Return the sorted list of intervals after merging all the overlapping intervals.



Example Input

Input 1:

[1,3],[2,6],[8,10],[15,18]


Example Output

Output 1:

[1,6],[8,10],[15,18]


Example Explanation

Explanation 1:

Merge intervals [1,3] and [2,6] -> [1,6].
so, the required answer after merging is [1,6],[8,10],[15,18].
No more overlapping intervals present.
 */
using System;
using System.Collections.Generic;

namespace MergeOverlappingIntervals
{
    public class Program
    {
        public class Interval
        {
            public int start;
            public int end;

            public Interval()
            {
                start = 0;
                end = 0;
            }

            public Interval(int s, int e)
            {
                start = s;
                end = e;
            }
        }

        public static void Main(string[] args)
        {
            List<Interval> intervals = new List<Interval>();

            intervals.Add(new Interval(1, 3));
            intervals.Add(new Interval(2, 6));
            intervals.Add(new Interval(8, 10));
            intervals.Add(new Interval(15, 18));

            List<Interval> mergedIntervals = MergeIntervals(intervals);

            Console.WriteLine("Merged Intervals:");

            foreach (Interval interval in mergedIntervals)
            {
                Console.WriteLine($"[{interval.start}, {interval.end}]");
            }
        }

        public static List<Interval> MergeIntervals(List<Interval> intervals)
        {
            if (intervals == null || intervals.Count <= 1)
            {
                return intervals;
            }

            // Sort by start time
            intervals.Sort((a, b) => a.start.CompareTo(b.start));

            List<Interval> result = new List<Interval>();

            Interval current = new Interval(intervals[0].start, intervals[0].end);

            for (int i = 1; i < intervals.Count; i++)
            {
                Interval next = intervals[i];

                // Overlapping intervals
                if (current.end >= next.start)
                {
                    current.end = Math.Max(current.end, next.end);
                }
                else
                {
                    // No overlap
                    result.Add(current);
                    current = new Interval(next.start, next.end);
                }
            }

            // Add the last merged interval
            result.Add(current);

            return result;
        }
    }
}