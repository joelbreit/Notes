# KQL

KQL (Kusto Query Language) is a read-only query language used to explore and analyze large volumes of structured, semi-structured, and log data. It is used by Azure Data Explorer, Azure Monitor Log Analytics, Application Insights, Microsoft Sentinel, Microsoft Defender, and Microsoft Fabric Real-Time Intelligence.

Queries are written as a data flow: a tabular data source is piped (`|`) through a sequence of operators, each of which transforms the table produced by the previous step.

```kql
StormEvents
| where StartTime > ago(7d)
| where State == "TEXAS"
| summarize EventCount = count() by EventType
| order by EventCount desc
| take 10
```

## Terms

- **Kusto**: The engine behind Azure Data Explorer; KQL is its query language
- **Cluster**: *A set of compute nodes that hosts one or more databases*
- **Database**: *A logical container of tables, functions, and materialized views*
- **Table**: *A named collection of rows with a strongly typed schema*
- **Tabular Expression**: *An expression that produces a table; the core unit of a query*
- **Pipe (`|`)**: *Passes the output of one operator as the input of the next*
- **Tabular Operator**: *An operator that takes a table as input and produces a table, e.g. `where`, `project`, `summarize`*
- **Scalar Function**: *A function that returns a single value per row, e.g. `strlen()`, `tolower()`*
- **Aggregation Function**: *A function used in `summarize` that computes one value from a group of rows, e.g. `count()`, `avg()`*
- **Let Statement**: *Binds a name to an expression (scalar, tabular, or function) for reuse later in the query*
- **Management Command**: *A command beginning with `.` that changes or inspects metadata, e.g. `.create table`, `.show tables`*
- **Materialized View**: *A precomputed aggregation over a source table that is kept up to date automatically*
- **Update Policy**: *A rule that transforms data on ingestion into one table and writes the result into another*
- **Ingestion**: *The process of loading data into a table*
- **Extent**: *A data shard; the internal storage unit of a table*

## Syntax Basics

- Comments use `//`
- Statements are separated by `;`
- Table, column, operator, and function names are **case-sensitive**
- String literals use `"..."` or `'...'`; verbatim strings use `@"C:\path"`
- Multi-line strings use triple backticks
- Names with spaces or reserved words are escaped with `['name']`
- Time spans are written as literals: `1d`, `2h`, `30m`, `10s`, `100ms`
- Datetimes are written as `datetime(2026-10-02)` or `datetime(2026-10-02 13:45:00)`

## Data Types

1. **bool**: `true` / `false`
2. **int**: 32-bit integer
3. **long**: 64-bit integer
4. **real**: 64-bit floating point (alias **double**)
5. **decimal**: 128-bit decimal
6. **string**: UTF-8 text
7. **datetime**: an instant in time (alias **date**), always UTC
8. **timespan**: a time interval (alias **time**)
9. **guid**: a 128-bit globally unique identifier
10. **dynamic**: a JSON-like value; can hold an array, a property bag, or a primitive

## Tabular Operators

### Filtering and Limiting

1. **where**: filters rows by a predicate (alias **filter**)
2. **take**: returns up to N arbitrary rows (alias **limit**)
3. **top**: returns the first N rows sorted by a column
4. **distinct**: returns unique combinations of the given columns
5. **sample**: returns N random rows
6. **search**: full-text search across columns and tables

### Shaping Columns

1. **project**: selects, renames, or computes columns (like SQL `SELECT`)
2. **project-away**: removes the listed columns
3. **project-keep**: keeps only the listed columns, preserving order
4. **project-rename**: renames columns
5. **project-reorder**: changes column order
6. **extend**: adds computed columns while keeping the existing ones

### Sorting

1. **sort by**: sorts rows (alias **order by**); descending by default
   1. Use `asc` / `desc` to set direction and `nulls first` / `nulls last` for null placement

### Aggregating

1. **summarize**: groups rows and computes aggregations (like SQL `GROUP BY`)
   1. `summarize count() by Category`
   2. `summarize avg(Duration) by bin(Timestamp, 1h)` groups into time buckets
2. **count**: returns the number of rows in the input table
3. **make-series**: creates a series of aggregated values along an axis (usually time), filling gaps with a default
4. **top-nested**: produces hierarchical top-N results

### Combining Tables

1. **join**: merges rows of two tables on matching key columns
2. **union**: combines rows from two or more tables
3. **lookup**: extends a fact table with values from a dimension table (optimized left outer join)
4. **as**: names the current tabular result so it can be referenced later

### Expanding and Parsing

1. **mv-expand**: expands a dynamic array or property bag into multiple rows
2. **mv-apply**: applies a subquery to each record's expanded array
3. **parse**: extracts columns from a string using a pattern
4. **parse-where**: like `parse`, but drops rows that don't match
5. **evaluate**: invokes a plugin, e.g. `bag_unpack`, `pivot`, `autocluster`

### Output

1. **render**: tells the client to visualize results as a chart, e.g. `render timechart`, `render barchart`, `render piechart`
2. **getschema**: returns the schema of the input table
3. **invoke**: calls a function that takes a table as input

## Join Kinds

The default kind is `innerunique`, which deduplicates the left table on the join key before joining. This differs from SQL and is a common source of surprises; specify `kind=inner` for SQL-style behavior.

1. **innerunique** (default): inner join with the left side deduplicated
2. **inner**: standard inner join
3. **leftouter** / **rightouter** / **fullouter**: outer joins
4. **leftanti** / **rightanti**: rows from one side with no match on the other
5. **leftsemi** / **rightsemi**: rows from one side that have a match, without columns from the other

```kql
Requests
| join kind=leftouter (Exceptions) on OperationId
```

## Common Functions

### Aggregation

1. **count()**, **countif(predicate)**
2. **dcount(column)**: approximate distinct count; **dcountif()**
3. **sum()**, **sumif()**, **avg()**, **avgif()**, **min()**, **max()**
4. **percentile(column, p)**, **percentiles(column, p1, p2, ...)**
5. **arg_max(column, *)** / **arg_min(column, *)**: returns the row with the max/min value, useful for "latest record per key"
6. **make_list()**, **make_set()**, **make_bag()**: collect values into dynamic arrays/bags
7. **any()** / **take_any()**: an arbitrary value from the group

### String

1. **strlen()**, **substring()**, **tolower()**, **toupper()**, **trim()**
2. **strcat()**, **strcat_delim()**
3. **split()**: returns a dynamic array
4. **replace_string()**, **replace_regex()**
5. **extract(regex, captureGroup, source)**
6. **parse_json()** (alias **todynamic()**): converts a JSON string to `dynamic`
7. **isempty()** / **isnotempty()**

### Date and Time

1. **now()**: current UTC time
2. **ago(timespan)**: `now()` minus the given timespan, e.g. `ago(1h)`
3. **bin(value, size)**: rounds down to a bucket, e.g. `bin(Timestamp, 5m)` (alias **floor()**)
4. **startofday()**, **startofweek()**, **startofmonth()**, **endofday()**, ...
5. **datetime_diff(unit, dt1, dt2)**, **datetime_add(unit, amount, dt)**
6. **format_datetime(dt, format)**
7. **dayofweek()**, **hourofday()**, **getmonth()**, **getyear()**

### Conditional and Null Handling

1. **iff(condition, ifTrue, ifFalse)**: inline if (alias **iif()**)
2. **case(cond1, val1, cond2, val2, ..., default)**
3. **coalesce(a, b, ...)**: first non-null value
4. **isnull()** / **isnotnull()**

### Type Conversion

1. **tostring()**, **toint()**, **tolong()**, **toreal()**, **todatetime()**, **totimespan()**, **tobool()**, **toguid()**

## String Operators

Operators with `has` match whole terms (indexed and fast); operators with `contains` match any substring (slower). Prefer `has` when possible.

| Operator                  | Meaning                               | Case-Sensitive |
| ------------------------- | ------------------------------------- | -------------- |
| `==` / `!=`               | Equals / not equals                   | Yes            |
| `=~` / `!~`               | Equals / not equals                   | No             |
| `has` / `!has`            | Contains whole term                   | No             |
| `has_cs`                  | Contains whole term                   | Yes            |
| `has_any` / `has_all`     | Contains any / all of a list of terms | No             |
| `contains` / `!contains`  | Contains substring                    | No             |
| `contains_cs`             | Contains substring                    | Yes            |
| `startswith` / `endswith` | Starts / ends with substring          | No             |
| `in` / `!in`              | Equals any element of a list          | Yes            |
| `in~` / `!in~`            | Equals any element of a list          | No             |
| `matches regex`           | Matches a regular expression          | Yes            |

## Let Statements

```kql
let startTime = ago(1d);
let threshold = 500;
let SlowRequests = Requests
    | where Timestamp > startTime and Duration > threshold;
let GetByName = (name: string) { Requests | where Name == name };
SlowRequests
| summarize count() by Name
```

## Management Commands

Management commands start with a `.` and cannot be combined with queries in the same request.

1. **.show tables** / **.show databases**: list objects
2. **.show table T schema as json**: show a table's schema
3. **.create table T (Col1: string, Col2: datetime)**: create a table
4. **.alter table** / **.alter-merge table**: change a table's schema
5. **.drop table T**: delete a table
6. **.set**, **.append**, **.set-or-replace**: ingest the results of a query into a table
7. **.ingest into table T (h'...')**: ingest data from storage
8. **.create function** / **.create-or-alter function**: define a stored function
9. **.show queries** / **.show commands**: inspect recent activity

## KQL vs. SQL

| SQL                           | KQL                                            |
| ----------------------------- | ---------------------------------------------- |
| `SELECT * FROM T`             | `T`                                            |
| `SELECT a, b FROM T`          | `T \| project a, b`                            |
| `SELECT a, b + 1 AS c FROM T` | `T \| extend c = b + 1 \| project a, c`        |
| `WHERE x = 1`                 | `\| where x == 1`                              |
| `WHERE x LIKE '%abc%'`        | `\| where x contains "abc"`                    |
| `WHERE x IS NULL`             | `\| where isnull(x)`                           |
| `GROUP BY a` with `COUNT(*)`  | `\| summarize count() by a`                    |
| `HAVING COUNT(*) > 5`         | `\| summarize n = count() by a \| where n > 5` |
| `ORDER BY a DESC`             | `\| order by a desc`                           |
| `SELECT TOP 10` / `LIMIT 10`  | `\| take 10`                                   |
| `SELECT DISTINCT a`           | `\| distinct a`                                |
| `UNION ALL`                   | `\| union`                                     |
| `CASE WHEN ... END`           | `case(...)` or `iff(...)`                      |

Kusto also accepts a subset of T-SQL directly, and prefixing a SQL query with `EXPLAIN` translates it into KQL.

## Performance Tips

1. Filter early: put `where` clauses (especially time filters) as close to the source table as possible
2. Filter on datetime columns first; data is partitioned by ingestion time
3. Prefer `has` over `contains`, and case-sensitive operators (`==`, `has_cs`) over case-insensitive ones
4. Use `project` to drop columns you don't need before expensive operators
5. Put the smaller table on the left side of a `join`
6. Use `materialize()` when the same subquery is referenced multiple times
7. Use `take` while exploring instead of returning entire tables

## Common Patterns

Latest record per key:

```kql
Heartbeat
| summarize arg_max(TimeGenerated, *) by Computer
```

Count over time, charted:

```kql
Requests
| where Timestamp > ago(1d)
| summarize count() by bin(Timestamp, 15m), ResultCode
| render timechart
```

Expand a JSON array column:

```kql
Events
| extend Props = parse_json(Properties)
| mv-expand Tag = Props.tags
| summarize count() by tostring(Tag)
```
