using System;
using System.Collections.Generic;
using System.Linq;

namespace BashSoft
{
    public static class RepositoryFilters
    {
        public static void FilterAndTake(Dictionary<string, List<int>> wantedData, string wantedFilter,
            int studentsToTake)
        {
            if (wantedFilter.Equals("excellent"))
            {
                FilterAndTake(wantedData, x => x >= 5, studentsToTake);
            }
            else if (wantedFilter.Equals("average"))
            {
                FilterAndTake(wantedData, x => x < 5 && x >= 3.5, studentsToTake);
            }
            else if (wantedFilter.Equals("poor"))
            {
                FilterAndTake(wantedData, x => x < 3.5, studentsToTake);
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidStudentsFilter);
            }
        }

        private static void FilterAndTake(Dictionary<string, List<int>> wantedData, Predicate<double> givenFilter,
            int studentsToTake)
        {
            var counterForPrinted = 0;
            foreach (var userName_Points in wantedData)
            {
                if (counterForPrinted == studentsToTake)
                {
                    break;
                }

                var averageScore = userName_Points.Value.Average();
                var percentageOfFullfillments = averageScore / 100;
                var mark = percentageOfFullfillments * 4 + 2;
                if (givenFilter(mark))
                {
                    OutputWriter.PrintStudent(userName_Points);
                    counterForPrinted++;
                }
            }
        }
    }
}
