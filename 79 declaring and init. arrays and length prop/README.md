# 79-Arrays
79 Arrays in c#

////Structure of an Array

Array with length of 6 containes 6 values in index order.

Example:
length = 6 // Indexes 0-5
values  13  15  5  7  8  1
indexes 0   1   2  3  4  5

Example:
Element at index #4 has a vlues of 8.


/// Declaring an array
dataType [] arrayName;

Example:
int [] grades;



//// Initializing ARRAY Data Type
dataType [] arrayName = new dataType [amount of entries]
Example:
int [] grades = new int [5];



/// Assigning values to an array

arrayName[index] = value;
Example:
grades[0]=15;
grades[1] = 12;


// three ways to declare arrays
int[] scores = new int[3]{6,10,20};

int[] scores = new int[]{6,10,20};

int[] score = {6,10,20};
