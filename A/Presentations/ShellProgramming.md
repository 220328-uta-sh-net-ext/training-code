Getting started with Shell Programming
===
The first thing to know about shell programming, is that shell programs are `interpreted` everytime they run.

## What is a shell program

In its most basic form, a shell program is one or more shell commands.
For example, 


```
cd home && ls -l

```
This simple program traverses into the directory called 'home' and then lists the contents of that directory showing in long listing format.  The glue for this program is `&&`. This says 

> and while you are at it shell...do something else for me

That's one way you can run a shell program. The more common way is using a file with a `.sh` extention. Though honestly, you really don't need the extention, you can just add the `interpreted` script line at the top of the file: 

`#!/usr/bin/env bash`
This line is a common idiom used by the shell to interpret a bash script.

Though if you did use the shell scripting syntax it would look like:

`#!/usr/bin/env sh`

The hash and exclaimation are known as `shebang`. (I don't know why)

For example, you can run the HelloWorld program as follows. Assume the starter line is included and the following code is inside a file named
`helloworld`

```
echo "Hello World";

```
That's it. That is the whole program. To execute it, you must either make the file executable or prefix the command `bash` with a space and then the filename. 

`bash helloworld` 
