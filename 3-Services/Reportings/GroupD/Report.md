# LINQ 
## What is LINQ
- LINQ = Language-Integrated Query
- Uniform querry syntax Integrated in C# & VB.NET to Query Data Sources
- **LINQ returns queries as objects**
## Process of Using LINQ
- Obtain Datasource
- Create a query
- Execute a query
## Used to Query(Different Data Source):
- Collections
- ADO.Net Datasets
- XML Docs
- Web Services
- SQL Database
- Other Data sources
## Example
- Data source
	 
	 	string[] names = {"Bill", "Steve", "James", "Mohan" };

- LINQ Query 
	
		var myLinqQuery = from name in names
                where name.Contains('a')
                select name;
    
- Query execution
	
		foreach(var name in myLinqQuery)
    		Console.Write(name + " ");
## Why LINQ
- Allows for looking through data sources with much more compact and readable code 
- The building blocks of LINQ are:
	- the extension method
	- lambda expression
	- expression tree
	- anonymous type
	- query expression
- These building blocks allow LINQ to query different types of collections and get the desired results
- Has Signficant Advantages
	- Same language
	- Less coding
	- More Readable 
	- Standardizes querying multiple data sources 
	- Provides type checking at Compile time
	- Can retrieve data in different forms
## LINQ API
- Any class that impliments IEnumerable<T> or IQueryable<T> interfaces can be queried 
- LINQ api includes two main static class: Enumerable and Queryable.
- Enumerable class includes extension methods for in memory collection like: List, Dictionary, Hashset, Queue, etc.
- There are a lot of extension methods from the [Enumerable class](https://www.tutorialsteacher.com/linq/linq-api)
- Queryable class includes extension methods for remote queries like: LINQ to SQL, Amazon, or LDAP, PLINQ, and EntityFramework
- Also has many extension [methods](https://www.tutorialsteacher.com/linq/linq-api).
## LINQ Query Syntax
- LINQ Query Syntax written as:
	- 1. from range_variable in <IEnumerable<T> or IQueryable<T> Collection>
	- 2. <Standard Query Operators> lambda expression
	- 3. select or groupBy operator result formation
- Line 1 sets up the query to look through every object in the collection, similar to a foreach loop
- Line 2 dictates what condition is used to deteremine what you are looking for using [lambda expressions](https://www.tutorialsteacher.com/linq/linq-lambda-expression)
	- Can also filter, join, group, sort, or do more to create desired result 
- Line 3 is the select line, which all LINQ Queries end with if they do not end with a group clause. This is used to shape the data.
## LINQ Method Syntax
- Method Syntax uses extension methods from the Enumerable or Queryable static classes
- The complier converts query syntax into method syntax at compile time
- in this example: var result = stringList.Where(s => s.Contains("Tutorials"));
	- .Where is the extension method
	- (s => s.Contains("Tutorials") is the lambda expression
- Implicty typed variable can hold the result of the LINQ Query
## Lambda Expression
- Lambda Expression is a shorter way of representing the anonymous method
	- replaces the delegate and parameter type with a '=>'
	- doesn't need {}, return or a semicolon depending on if there is more than 1 return value
	- doesn't need () if there is only 1 parameter
- VB.Net doesn't support '=>'
## Standard Query Operators
- Extension methods for IEnumerable<T> and IQueryable<T>
- Provide different functionalities like filtering, sorting, grouping, aggregation, concatenation, etc.
	- Where
		- Filtering operation
		- Returns values from the collection based on a predicate function
	- Oftype
		- Filtering operation
		- Returns values from the collection based on a specified type
		- Bases off of element's type
	- OrderBy
		- Sorts the values of a collection in ascending or descending order
		- Default is ascending
		- Only valid in method syntax
	- OrderByDescending
		- Same as OrderBy, but only descending order
	- ThenBy
		- Used for second level sorting in ascending order.
		- Only valid in method syntax
		- Allows for sorting by 1 aspect first, then a 2nd aspect w/ ThenBy
	- ThenByDescending
		- Same as ThenBy, but only descending order
	- Reverse
		- Sorts the collection in reverse order.
		- Only valid in method syntax
	- GroupBy
		- Returns groups of elements based on some key value
		- The execution of GroupBy is deferred
	- ToLookup
		- Execution is immediate.
		- Otherwise, same as GroupBy
	- Join
		- Combines two collections based on a key and returns the resulted collection.
		- Same as inner join from SQL
		- var innerJoin = strList1.Join(strList2,
		-                  str1 => str1, 
		-                  str2 => str2, 
		-                  (str1, str2) => str1);
			- strList1 = outer sequence
			- strList2 = inner sequence
			- str1 => str1 = outer key selector
			- str2 => str2 = inner key selector
			- (str1, str2) => str1 = result selector
		- different in query syntax:
			- var var_name = from outer_search_by in outerSequence
			-		join inner_search_by in innerSequence 
			-		on  outerKey equals innerKey
			-		select result
	- GroupJoin
		- Combines two collections based on keys and returns groups of collections
		- Similer to left join from SQL
	- Select
		- returns a collection of anonymous types
	- All
		- Checks if all the elements in a sequence satisfies the specified condition
		- returns true if yes, false if no
	- Any
		- Checks if any of the elements in a sequence satisfies the specified condition
		- returns true if yes, false if no
	- Contains
		- Checks if the sequence contains a specific element
		- returns true if yes, false if no

	- Aggregate	
		- Performs a custom aggregation operation on the values in the collection.
		- Performs an accumulation operation
		- Cannot be used in query syntax
	- Average	
		- Calculates the average of the numeric items in the collection.
		- Int, decimal, double or float can be specified
		- Cannot be used in query syntax in C#
	- Count	
		- Counts the elements in a collection.
	- Max	
		- Finds the largest value in the collection.
	- Min	
		- Finds the smallest value in the collection.
	- Sum	
		- Calculates sum of the values in the collection.
	- ElementAt	
		- Returns the element at a specified index in a collection
	- ElementAtOrDefault	
		- Returns the element at a specified index in a collection or a default value if the index is out of range.
	- First	
		- Returns the first element of a collection, or the first element that satisfies a condition.
	- FirstOrDefault	
		- Same as First but
		- Returns a default value if index is out of range.
	- Last	
		- Returns the last element of a collection, or the last element that satisfies a condition
	- LastOrDefault	
		- Same as Last but 
		- Returns a default value if no such element exists.
	- Single	
		- Returns the only element of a collection, or the only element that satisfies a condition.
	- SingleOrDefault	
		- Same as Single but
		- Returns a default value if no such element exists or the collection does not contain exactly one element.
	- SequenceEqual
		- Checks whether the number of elements, value of each element and order of elements in two collections are equal or not
		- Returns true if yes, false if no
	- Concat
		- Takes in 2 data collections of the same type
		- Returns a new data collection of the two combined together
		- Data type within the Concat is added to the end of the one outside of the Concat
	- DefaultIfEmpty
		- Returns a new collection with the default value if the given collection is empty.
	- Empty	
		- Returns an empty collection
		- Static method from Enumerable static class
	- Range	
		- Generates collection of IEnumerable<T> type with specified number of elements with sequential values, starting from first element.
	- Repeat	
		- Generates a collection of IEnumerable<T> type with specified number of elements and each element contains same specified value.
	- Distinct	
		- Returns distinct values from a data collection.
	- Except	
		- Returns the difference between two sequences, which means the elements of one collection that do not appear in the second collection.
	- Intersect	
		- Returns the intersection of two sequences, which means elements that appear in both the collections.
	- Union	
		- Returns unique elements from two sequences, which means unique elements that appear in either of the two sequences.
	- Skip	
		- Skips elements up to a specified position starting from the first element in a sequence.
	- SkipWhile	
		- Skips elements based on a condition until an element does not satisfy the condition. If the first element itself doesn't satisfy the condition, it then skips 0 elements and returns all the elements in the sequence.
	- Take	
		- Takes elements up to a specified position starting from the first element in a sequence.
	- TakeWhile	
		- Returns elements from the first element until an element does not satisfy the condition. 
		- If the first element itself doesn't satisfy the condition then returns an empty collection.
	- ConversionOperators
		- Converts data types 
			- AsEnumerable: Returns the input sequence as IEnumerable<t>
			- AsQueryable: Converts IEnumerable to IQueryable, to simulate a remote query provider
			- Cast: Coverts a non-generic collection to a generic collection (IEnumerable to IEnumerable<T>)
			- OfType: Filters a collection based on a specified type
			- ToArray: Converts a collection to an array
			- ToDictionary: Puts elements into a Dictionary based on key selector function
			- ToList: Converts collection to List
			- ToLookup: Groups elements into an Lookup<TKey,TElement>
- Expression
	- Expressions can be assigned to the Func or Action type delegates to process over in-memory collection
	- Lambda expression can also be assigned to Expression<TDelegate> type
- Expression Tree
	- Expressions arranged in a tree-like data structure
	- An in-memory representation of a lambda expression
	- Holds the actual elements of the query, not the result of the query.
	- Expression trees are used by remote LINQ query providers as a data structure to build a runtime query out of them
- Deffered Execution
	- The expression isn't used until the value is used elsewhere in the program.
	- Always gives lasted data. If dataset is modified, the query will use the modified data
	- can create custom methods with the yield keyword to get the adv of deffered execution
- Immediate Execution
	- Reverse of deferred execution 
	- Forces the LINQ query to execute and gets the result immediately
	- ToList(), ToArray() and ToDictionary() are examples
- let keyword
	- Allows defining a new variable within a query (similar functionality in ocaml)
- into keyword
	- Allows nested queries
	- Can form a group
	
##Reference
	- https://www.tutorialsteacher.com/linq/what-is-linq
LinQNotes.md
11 KB
