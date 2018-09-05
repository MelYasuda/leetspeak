# Specifications

1. The program gets a string as an input and input string must not be an empty string.
  input > ""
  output > "Enter non-empty value"

2. The program splits the input string to letters and put them in an array.
  input > "Hello"
  output > ["H", "e", "l", "l", "o"]

3. The program makes a new result array to store translated letters.
  output > ["", "", "", "", ""]

4. The program concatenates items in translated letters array to make a new string and returns the string as an output.

5. The program should replace "e" with 3.
  input > "e"
  output > "3"

6. The program should replace "o" with 0.
  input > "o"
  output > "0"

7. The program should replace I with 1.
  input > "I"
  output > "1"

8. The program should replace t with 7.
  input > "t"
  output > "7"

9. The program should replace s with z unless it is the first letter of the string.
  input > "Es"
  output > "Ez"
  input > "s"
  output > "s"
