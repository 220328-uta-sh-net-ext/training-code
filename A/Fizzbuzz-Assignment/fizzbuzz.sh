#! /usr/bin/bash

read -p "What is your number: " number
if (($number%5 == 0 )) && (($number%3 == 0))
then
    echo "Fizzbuzz!"

elif (($number % 5 == 0))
then
    echo "Buzz!"
        

elif (($number % 3 == 0))
then
    echo "Fizz!"
    
elif ((!$number % 3 == 0)) || ((!$number % 5 == 0))
then
    echo "Nothing!"
    
fi
