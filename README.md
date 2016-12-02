# Word Counter

#### This web app counts the number of times a given word appears in a series of words. {December 2016}

#### By **Brad Copenhaver**

## Description
This program accepts a search term from the user as well as a block of text to search through. The search term is then compared to each word in the block of text, ignoring any punctuation at the beginning or end of each word, and ignoring differences in capitalization. Punctuation that is part of a word (i.e. the "-" in "thirty-five") is not ignored. The program then displays a statement to the user indicating how many times the search term is present in the text block.

### Specifications
_This program will..._

1. Return "0" if the search term is not present in the given text.
 * Input: "spoon", "fork"
 * Output: 0
 * Why this is simple: No comparison or change in output is necessary if the search term is not present.


2. Return "1" if the search term matches the given text.
 * Input: "spoon", "spoon"
 * Output: 1
 * Why this is slightly more complex: Only one comparison of search term to text is necessary to determine a match and change the output.


3. Return "1" if the search term is present in the given text.
 * Input: "spoon", "there is no spoon"
 * Output: 1
 * Why this is slightly more complex: The search term must be compared to each word in the text until one match is found and changes the output.


4. Return the number of instances of the search term in the given text.
 * Input: "rose", "rose is a rose"
 * Output: 2
 * Why this is slightly more complex: The search term must continue to be compared to each word in the text even after one match is found, and the output must be changed with each successful match.


5. Match the search term regardless of case.
 * Input: "buffalo", "Buffalo buffalo Buffalo buffalo buffalo buffalo Buffalo buffalo"
 * Output: 8
 * Why this is slightly more complex: The search term must match instances that are the same word but not equivalent strings.


6. Ignore punctuation at the beginning and end of each word in the given text.
 * Input: "can't", "He said, 'I can't.'"
 * Output: 1
 * Why this is slightly more complex: Certain parts of the text must be ignored before comparison.

## Setup/Installation Requirements

1. Clone this GitHub repository.
2. Navigate to the repository in terminal and run the command >dnu restore
3. In the same location, create a local server by running the command >dnx kestrel
4. Open a web browser and navigate to localhost:5004 to view the app.

## Known Bugs

If the block of text to be searched includes a line break, only the text before the break will be searched.

## Possible future version features

On the result screen, highlight each occurrence of the search term in the original text block.

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
