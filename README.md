# Assignment #4: Week 38

## Introduction to Software Engineering

### Exercise 1

Question...

## C&#35;

Fork this repository and implement the code required for the assignments below.

### Slot Car Tournament

![](images/Ninco_JGTC_Fahrerfeld.jpg "Modern commercially made slot cars and track. Ninco, 1:32 scale - source: https://en.wikipedia.org/wiki/Slot_car")

You are required to implement a model using Entity Framework Core for a slot car tournament.

The tournament needs the following entities:

- Track (name, length in meters, best time, max cars)
- Car (name, driver name)
- Race (track, number of laps, planned start time, actual start time, planned end time, actual end time)
- CarInRace (race, car, end position, best lap, total race time)

Create the *POCOs* and `DBContext` required for the model above.

Implement and test the `IRaceRepository` interface.

```csharp
public interface IRaceRepository : IDisposable
{
    int Create(RaceCreateDTO race);
    IEnumerable<RaceListDTO> Read();
    RaceCreateDTO Read(int raceId);
    (bool ok, string error) Update(RaceCreateDTO race);
    (bool ok, string error) AddCarToRace(int carId, int raceId);
    (bool ok, string error) RemoveCarFromRace(int carId, int raceId);
    (bool ok, string error) Delete(int raceId);
}
```

with the following rules:

- Once a race is started (actual start time != `null`) it cannot be deleted.
- Cars can only be added or removed from a race before start.
- You cannot add more cars to a race than the track supports.

Your code should not throw exceptions. Instead, if for instance someone is trying to add a car which does exist to a race which does not exist:

```csharp
return (false, "race not found");
```

## Submitting the assignment

To submit the assignment you need to create a .pdf document using LaTeX containing the answers to the questions and a link to a public repository containing your fork of the completed code.
Upload the document to Peergrade.
