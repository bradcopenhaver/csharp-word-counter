# Word Counter

#### This web app counts the number of times a given word appears in a series of words. {December 2016}

#### By **Brad Copenhaver**

## Description



### Specifications

_This program will..._
1. Return "0" if the search term is not present in the given text.
 * Input: "spoon", "fork"
 * Output: 0
 * Why this is simple: No comparison or change in output is necessary if the search term is not present.


2. Return "1" if the search term matches the given text.
 * Input: "spoon", "spoon"
 * Output: 1
 * Why this is simple: Only one comparison of search term to text is necessary to determine a match and change the output.


3. Return "1" if the search term is present in the given text.
 * Input: "spoon", "there is no spoon"
 * Output: 1
 * Why this is simple: The search term must be compared to each word in the text until one match is found and changes the output.


4. Return the number of instances of the search term in the given text.
 * Input: "rose", "a rose is a rose"
 * Output: 2
 * Why this is simple: The search term must continue to be compared to each word in the text even after one match is found, and the output must be changed with each successful match.


5. Match the search term regardless of case.
 * Input: "buffalo", "Buffalo buffalo Buffalo buffalo buffalo buffalo Buffalo buffalo"
 * Output: 8
 * Why this is simple: The search term must match instances that are the same word but not equivalent strings.

6. Ignore punctuation.
 * Input: "round", "The wheels on the bus go round and round. Round and round. Round and round."
 * Output: 6
 * Why this is simple: Certain parts of the text must be ignored before comparison.

## Setup/Installation Requirements



## Known Bugs



## Possible future version features



## Support and contact details

If you have questions or comments, contact the author at bradcopenhaver@gmail.com

## Technologies Used

* C#
* Nancy framework
* Razor view engine
* html/css
* Bootstrap

### License

This project is licensed under the MIT license.

Copyright (c) 2016 **Brad Copenhaver**
