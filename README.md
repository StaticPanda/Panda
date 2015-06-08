# Panda

Dump for my C# utilities/experiments.

### `IUnion`

`IUnion` interface allows for easier writing [discriminated unions in C#](http://gsscoder.github.io/2013/04/23/discriminated-unions-in-c/). The ideas behind this implementation are:

* compiler should check if every possible option is matched
* readability - the specific union type and its' options should have declared names
* there should be minimum amount of boilerplate, both while declaring specific union and while using it

### Usage

Example usage - implementing `Meeting` discriminated union. `Meeting` is one of three possibilities: `OneTimeMeeting`, `MultipleTimesMeeting` and `PeriodicMeeting`.

```c#
// Discriminated union base class should implement (empty) interface IUnion with all options. 
// It should also be abstract.
public abstract class Meeting : IUnion<OneTimeMeeting, MultipleTimesMeeting, PeriodicMeeting>
{
}

// Options classes should inherit from discriminated union base class.
public sealed class OneTimeMeeting : Meeting
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

public sealed class MultipleTimesMeeting : Meeting
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

public sealed class PeriodicMeeting : Meeting
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

```

Sample usage - utilizing Match function:

```c#
public static class MeetingExtensions
{
    // Could be as well member of Meeting class
    public static DateTime StartDateTime(this Meeting meeting)
    {
        return meeting.Match(
            oneTime => oneTime.Occurrence,
            multiple => multiple.Occurrences.First(),
            periodic => periodic.FirstOccurrence);
    }
}

```
