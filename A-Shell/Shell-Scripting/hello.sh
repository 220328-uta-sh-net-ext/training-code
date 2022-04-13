# Single line comment

: '
this is
multi-line
Comment
'

#Shebang/hash bang -> mentions which shell to be used and its location in OS
#! /usr/bin/bash 

# print Hello world when this file is run
echo "Hello world"

# System defined variables
# we can use " " after echo command but it is not necessary 
echo "My shell name is $BASH"
echo "My shell version is $BASH_VERSION"
echo My current directory is $PWD
echo My home directory is $HOME

# User defined variables, use A-Z, a-z, 0-9 or _
_USD=10
echo "The value is $_USD"

_USD=20
echo "The changed value is $_USD"

readonly pi=3.14
#readonly pi # this will lock the value and it cannot be changed or unset
##unset pi # unset is use to remove a value but with readonly variables it cannot be unset
#pi=22.7
echo "the value of pi is $pi"