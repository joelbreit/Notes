var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var people = new List<Person>
{
    new Person
    {
        Name = "Alice",
        Age = 30,
        City = "NYC",
    },
    new Person
    {
        Name = "Bob",
        Age = 25,
        City = "LA",
    },
    new Person
    {
        Name = "Charlie",
        Age = 35,
        City = "NYC",
    },
};

// Filtering
var evens = numbers.Where(n => n % 2 == 0); // [2,4,6,8,10]
var first = numbers.First(); // 1
var firstEven = numbers.First(n => n % 2 == 0); // 2
var lastOrDefault = numbers.LastOrDefault(n => n > 100); // 0 (default)
var single = numbers.Single(n => n == 5); // 5 (throws if 0 or 2+)

// Projection
var squared = numbers.Select(n => n * n); // [1,4,9,16,25...]
var names = people.Select(p => p.Name); // ["Alice","Bob","Charlie"]
var anonymous = people.Select(p => new { p.Name, p.Age });

// Ordering
var sorted = numbers.OrderBy(n => n);
var descending = numbers.OrderByDescending(n => n);
var byAgeThenName = people.OrderBy(p => p.Age).ThenBy(p => p.Name);

// Aggregation
var count = numbers.Count(); // 10
var sum = numbers.Sum(); // 55
var avg = numbers.Average(); // 5.5
var max = numbers.Max(); // 10
var min = numbers.Min(); // 1

// Quantifiers
var anyOver5 = numbers.Any(n => n > 5); // true
var allPositive = numbers.All(n => n > 0); // true

// Set operations
var list1 = new[] { 1, 2, 3, 4 };
var list2 = new[] { 3, 4, 5, 6 };
var distinct = list1.Concat(list1).Distinct(); // [1,2,3,4]
var union = list1.Union(list2); // [1,2,3,4,5,6]
var intersect = list1.Intersect(list2); // [3,4]
var except = list1.Except(list2); // [1,2]

// Partitioning
var first3 = numbers.Take(3); // [1,2,3]
var skip2 = numbers.Skip(2); // [3,4,5,6,7,8,9,10]
var takeWhile = numbers.TakeWhile(n => n < 5); // [1,2,3,4]

// Grouping
var byCity = people.GroupBy(p => p.City);
foreach (var group in byCity)
{
    Console.WriteLine($"{group.Key}: {group.Count()}");
    // NYC: 2, LA: 1
}

// Joining
var orders = new[]
{
    new { PersonName = "Alice", Item = "Book" },
    new { PersonName = "Bob", Item = "Laptop" },
};
var joined = people.Join(
    orders,
    p => p.Name,
    o => o.PersonName,
    (p, o) =>
        new
        {
            p.Name,
            p.Age,
            o.Item,
        }
);

// Element at position
var third = numbers.ElementAt(2); // 3
var safe = numbers.ElementAtOrDefault(100); // 0

// Conversion
var array = numbers.ToArray();
var list = numbers.ToList();
var dict = people.ToDictionary(p => p.Name);
var lookup = people.ToLookup(p => p.City);
