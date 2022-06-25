using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonInterview
{
    //Given an array of meeting time intervals consisting of start and end times {[start1, end1], [start2,end2],...}
    //find the minimum number of conference rooms required.

    /*
     *  int numberOfMeetingRoomsNeeded(List listOfIntervals)
        listOfIntervals.sortByStartTime()
        foreach (interval : listOfIntervals)
            if interval.startTime < meetingWithEarliestEndTime
                numberOfMeetingRoomsUsed++
            else
                update meetingWithEarliestEndTime
        return numberOfMeetingRoomsUsed
     */


    //.net 6 has priority queue class
    public class MeetingRoomScheduling
    {
        public int ScheduleMeetingRoom(int[][] lectures)
        {
            if (lectures == null || lectures.Length == 0)
                return 0;

            Sort<int>(lectures, 0);

            PriorityQueue queue = new PriorityQueue();
            int numberOfMeetingRoomsUsed = 1;
            queue.Enqueue(lectures[0][1]);

            for (int i = 1; i < lectures.Length; i++)
            {
                if (lectures[i][0] < queue.Peek())
                    numberOfMeetingRoomsUsed++;
                else
                    queue.Dequeue();

                queue.Enqueue(lectures[i][0]);
            }

            return numberOfMeetingRoomsUsed;

        }

        private static void Sort<T>(T[][] data, int col)
        {
            Comparer<T> comparer = Comparer<T>.Default;
            Array.Sort<T[]>(data, (x, y) => comparer.Compare(x[col], y[col]));
        }
    }

    class PriorityQueue
    {
        public List<int> list;
        public int Count { get { return list.Count; } }

        public PriorityQueue()
        {
            list = new List<int>();
        }

        public PriorityQueue(int count)
        {
            list = new List<int>(count);
        }


        public void Enqueue(int x)
        {
            list.Add(x);
            int i = Count - 1;

            while (i > 0)
            {
                int p = (i - 1) / 2;
                if (list[p] <= x) break;

                list[i] = list[p];
                i = p;
            }

            if (Count > 0) list[i] = x;
        }

        public int Dequeue()
        {
            int min = Peek();
            int root = list[Count - 1];
            list.RemoveAt(Count - 1);

            int i = 0;
            while (i * 2 + 1 < Count)
            {
                int a = i * 2 + 1;
                int b = i * 2 + 2;
                int c = b < Count && list[b] < list[a] ? b : a;

                if (list[c] >= root) break;
                list[i] = list[c];
                i = c;
            }

            if (Count > 0) list[i] = root;
            return min;
        }

        public int Peek()
        {
            if (Count == 0) throw new InvalidOperationException("Queue is empty.");
            return list[0];
        }

        public void Clear()
        {
            list.Clear();
        }
    }
}
