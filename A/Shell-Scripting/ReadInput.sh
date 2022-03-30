#! /usr/bin/bash

#ctrl+k+C to comment the selection
#ctrl+k+U to uncomment the selection
# echo "Enter your name: "
# read name  #take input from user and the also save its value in the variable mentioned
# echo "Hello $name"

# echo "enter your names: "
# read name1 name2 name3
# echo "Hello $name3"

# Arrays - multi collection of values placed one after another (indexed)
# echo "Enter names: "
# read -a names 
# echo "The names are: ${names[0]}, ${names[1]}, ${names[2]}"
# echo "The names are: ${names}"

# echo "Hello put some text and see results: "
# read
# echo "results: $REPLY"

read -p "Username: " username
read -sp 'Password: ' password
echo
echo "username is $username"
echo "password is $password"