//Merge Intervals
/*Problem Description

You have a set of non-overlapping intervals. You are given a new interval [start, end], insert this new interval into the set of intervals (merge if necessary).

You may assume that the intervals were initially sorted according to their start times.



Problem Constraints

0 <= |intervals| <= 105



Input Format

First argument is the vector of intervals

second argument is the new interval to be merged



Output Format

Return the vector of intervals after merging



Example Input

Input 1:

Given intervals [1, 3], [6, 9] insert and merge [2, 5] .
Input 2:

Given intervals [1, 3], [6, 9] insert and merge [2, 6] .


Example Output

Output 1:

 [ [1, 5], [6, 9] ]
Output 2:

 [ [1, 9] ]


Example Explanation

Explanation 1:

(2,5) does not completely merge the given intervals
Explanation 2:

(2,6) completely merges the given intervals
 */
namespace MergeIntervals
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
            intervals.Add(new Interval(6, 9));

            List<Interval> mergedIntervals = Insert(intervals, new Interval(2, 5));

            Console.WriteLine("Merged Intervals:");

            foreach (Interval interval in mergedIntervals)
            {
                Console.WriteLine($"[{interval.start}, {interval.end}]");
            }
        }

        public static List<Interval> Insert(List<Interval> intervals, Interval newInterval)
        {
            List<Interval> ans = new List<Interval>();
            for (int i = 0; i < intervals.Count(); i++)
            {
                if (intervals[i].end < newInterval.start)
                {
                    ans.Add(intervals[i]);
                }
                else if (newInterval.end < intervals[i].start)
                {
                    ans.Add(newInterval);
                    while (i < intervals.Count())
                    {
                        ans.Add(intervals[i]);
                        i++;
                    }
                    return (ans);
                }
                else
                {
                    newInterval.start = Math.Min(intervals[i].start, newInterval.start);
                    newInterval.end = Math.Max(intervals[i].end, newInterval.end);
                }
            }
            ans.Add(newInterval);
            return (ans);
        }
    }
}