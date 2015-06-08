using System;
using System.Collections.Generic;
using System.Linq;

namespace Panda.Samples.Union
{
    internal abstract class Meeting : IUnion<OneTimeMeeting, MultipleTimesMeeting, PeriodicMeeting>
    {
    }

    internal static class MeetingExtensions
    {
        public static DateTime StartDateTime(this Meeting meeting)
        {
            return meeting.Match(
                oneTime => oneTime.Occurrence,
                multiple => multiple.Occurrences.First(),
                periodic => periodic.FirstOccurrence);
        }
    }

    internal sealed class PeriodicMeeting : Meeting
    {
        private readonly DateTime _firstOccurrence;
        private readonly TimeSpan _period;

        public PeriodicMeeting(DateTime firstOccurrence, TimeSpan period)
        {
            _firstOccurrence = firstOccurrence;
            _period = period;
        }

        public DateTime FirstOccurrence
        {
            get { return _firstOccurrence; }
        }

        public TimeSpan Period
        {
            get { return _period; }
        }
    }

    internal sealed class MultipleTimesMeeting : Meeting
    {
        private readonly List<DateTime> _occurrences;

        public MultipleTimesMeeting(IEnumerable<DateTime> occurrences)
        {
            _occurrences = occurrences.ToList();
        }

        public IReadOnlyList<DateTime> Occurrences
        {
            get { return _occurrences.AsReadOnly(); }
        }
    }

    internal sealed class OneTimeMeeting : Meeting
    {
        private readonly DateTime _occurrence;

        public OneTimeMeeting(DateTime occurrence)
        {
            _occurrence = occurrence;
        }

        public DateTime Occurrence
        {
            get { return _occurrence; }
        }
    }
}