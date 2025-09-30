# Coding Problem Notes

- [ ] sliding window
- [ ] two pointers
- [ ] fast/slow pointers
- [ ] binary search variants
- [ ] Common approach patterns

## C# Array Syntax Reference

## C# Array Syntax Reference

**Declaration & Initialization**
```csharp
int[] arr = new int[5];                    // [0,0,0,0,0]
int[] arr = new int[] {1, 2, 3};           // explicit
int[] arr = {1, 2, 3};                     // implicit
int[] arr = new int[5] {1, 2, 3, 4, 5};    // size + values
```

**Access & Modification**
```csharp
int x = arr[0];                            // get element
arr[0] = 10;                               // set element
int len = arr.Length;                      // length property
```

**Common Operations**
```csharp
Array.Sort(arr);                           // sort ascending
Array.Reverse(arr);                        // reverse in-place
Array.Fill(arr, value);                    // fill with value
Array.Clear(arr);                          // set all to default (0/null)
Array.Copy(source, dest, length);          // copy elements
int[] copy = (int[])arr.Clone();           // shallow copy

int index = Array.IndexOf(arr, value);     // find index (-1 if not found)
bool exists = Array.Exists(arr, x => x > 5);
int found = Array.Find(arr, x => x > 5);   // first match
int[] filtered = Array.FindAll(arr, x => x > 5);
```

**Iteration**
```csharp
for (int i = 0; i < arr.Length; i++) { }
foreach (int num in arr) { }
```

**2D Arrays**
```csharp
int[,] matrix = new int[3, 4];             // rectangular
matrix[0, 0] = 1;
int rows = matrix.GetLength(0);
int cols = matrix.GetLength(1);

int[][] jagged = new int[3][];            // jagged array
jagged[0] = new int[] {1, 2};
jagged[1] = new int[] {3, 4, 5};
```

**LINQ (creates new array/enumerable)**
```csharp
int[] sorted = arr.OrderBy(x => x).ToArray();
int[] filtered = arr.Where(x => x > 5).ToArray();
int[] mapped = arr.Select(x => x * 2).ToArray();
int sum = arr.Sum();
int max = arr.Max();
int min = arr.Min();
bool any = arr.Any(x => x > 5);
bool all = arr.All(x => x > 0);
int[] distinct = arr.Distinct().ToArray();
int[] skipped = arr.Skip(2).ToArray();
int[] taken = arr.Take(3).ToArray();
```

**Slicing (.NET Core/5+)**
```csharp
int[] slice = arr[1..4];                   // elements 1,2,3
int[] last3 = arr[^3..];                   // last 3 elements
int[] allButLast = arr[..^1];              // all except last
```

**Comparison**
```csharp
bool equal = arr1.SequenceEqual(arr2);     // element-wise comparison
```