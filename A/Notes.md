# Shell Scripting 
- Bourne Shell, C-Shell, Powershell etc...
- A computer program which is a command line interpreter (not compiled).
- A shell script includes operations to be performed like file manipulation, program execution and priting text.
- A shell file has an extension .sh
- sh - Bourne shell which was used for Unix
- BASH - Bourne Again Shell
- check your bash location : `which bash`,  outputs to `/usr/bin/bash`

## Variables 
- A memory block to hold a value.
- There are 2 types of variables that are created in Shell:
	- **System variables** : Predefined variables by BASH, maanged by Shell/OS and they are Created in UPPERCASE.
		- Ex - $BASH, $BASH_VERSION, $HOME, $PWD

	- **User Defined (UDV) Variables**
		- A-Z, a-z, 0-9, _
		- A variable name should either start with an alphabet or _

## Read Input 
- **Read command** - The read command allows you to prompt for input and store it in a variable. Shell allows to prompt for user input.
- Syntax: 
	- `read varname [more vars]` 
			or
	- `read –p "prompt" varname [more vars]`
- words entered by user are assigned to varname and “more vars”
- last variable gets rest of input line.

## Arguments in Shell Script
- Any shell script you run has access to (inherits) the environment variables accessible to its parent shell. In addition, any arguments you type after the script name on the shell command line are passed to the script as a series of variables.
- The following parameters are recognized:
	- `$*` Returns a single string `("$1, $2 ... $n")` comprising all of the positional parameters separated by the internal field separator character (defined by the IFS environment variable).
	- `$@` Returns a sequence of strings `("$1", "$2", ... "$n")` wherein each positional parameter remains separate from the others.
	- `$1, $2 ... $n` Refers to a numbered argument to the script, where n is the position of the argument on the command line. In the Korn shell you can refer directly to arguments where n is greater than 9 using braces. For example, to refer to the 57th positional parameter, use the notation ${57}. In the other shells, to refer to parameters with numbers greater than 9, use the shift command; this shifts the parameter list to the left. $1 is lost, while $2 becomes $1, $3 becomes $2, and so on. The inaccessible tenth parameter becomes $9 and can then be referred to.
	- `$0` Refers to the name of the script itself.
	- `$#` Refers to the number of arguments specified on a command line.

## Conditionals
- Conditionals let us decide whether to perform an action or not, this decision is taken by evaluating an expression.

### Expressions 
An expression can be: String comparison, Numeric comparison, Boolean comparison, File operators and Logical operators and it is represented by [expression]:
#### String Comparisons:  
---------------------------------
- =  compare if two strings are equal
- !=  compare if two strings are not equal
- -n  evaluate if string length is greater than zero
- -z  evaluate if string length is equal to zero 

#### Examples: 
- `[ s1 = s2 ]`  (true if s1 same as s2, else false)
- `[ s1 != s2 ]`  (true if s1 not same as s2, else false)
- `[ s1 ]`   (true if s1 is not empty, else false)
- `[ -n s1 ]`   (true if s1 has a length greater then 0, else false)
- `[ -z s2 ]`   (true if s2 has a length of 0, otherwise false)

#### Number Comparisons: 
------------------------------------
- `-eq` compare if two numbers are equal
- `-ge` compare if one number is greater than or equal to a number
- `-le`  compare if one number is less than or equal to a number
- `-ne`  compare if two numbers are not equal
- `-gt`  compare if one number is greater than another number
- `-lt`  compare if one number is less than another number 

#### Examples: 
- `[ n1 -eq n2 ]`  (true if n1 same as n2, else false)
- `[ n1 -ge n2 ]`  (true if n1 greater than or equal to n2, else false)
- `[ n1 -le n2 ]`  (true if n1 less than or equal to n2, else false)
- `[ n1 -ne n2 ]`  (true if n1 is not same as n2, else false)
- `[ n1 -gt n2 ]`  (true if n1 greater than n2, else false)
- `[ n1 -lt n2 ]`  (true if n1 less than n2, else false)

## Arrays
- An array is a variable containing multiple values. 
- Any variable may be used as an array. 
- There is no maximum limit to the size of an array, nor any requirement that member variables be indexed or assigned contiguously. 
- Arrays are zero-based: the first element is indexed with the number 0.

## Looping
- Loop is a block of code that is repeated a number of times. 
- The repeating is performed either a pre-determined number of times until a particular condition is satisfied ( `while` and `until` loops)
- To provide flexibility to the loop constructs there are also two statements namely `break` and `continue` are provided.
- The `until` structure is very similar to the while structure. The until structure loops until the condition is true. So basically it is “until this condition is true, do this” or “when the resulting value is false, given statement(s) are executed”.
- `for` Loops: Sometimes we want to run a command (or group of commands) over and over. This is called *iteration, repetition, or looping*. The most commonly used shell repetition structure is the for loop, which has the general form:
``` 
for variable in list
do
  command(s) 
done
```
- `select` Constructs simple menu from word list. It Allows user to enter a number instead of a word. So User enters sequence number corresponding to the word.
Syntax:
```
select WORD in LIST     
do           
	statements
done 
```
Loops until end of input, i.e. ^d  (or ^c)



## References 
1. https://bash.cyberciti.biz/guide/Main_Page
2. https://www.tutorialspoint.com/unix/shell_scripting.htm
3. If you are video person : https://www.youtube.com/playlist?list=PLS1QulWo1RIYmaxcEqw5JhK3b-6rgdWO_
