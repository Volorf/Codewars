// Add the namespace to make List works
using System.Collections.Generic;

public class Kata
{
  public static int[] SortArray(int[] array)
  {
    // A list of odd numbers
    var sortedOddNumbers = new List<int>();
    // A list of odd number's indices
    var oddIndices = new List<int>();
    // A final array
    var newArray = new int[array.Length];
    
    // Fill out the sortedOddNumbers list with odd numbers 
    // and put its indices into the oddIndices list
    for (int i = 0; i < array.Length; i++) {
      if(array[i] % 2 == 1) {
        sortedOddNumbers.Add(array[i]);
        oddIndices.Add(i);
      } 
      else 
      {
        // Add existing even numbers to its previous index position
        newArray[i] = array[i];
      }
    }
    
    // Sort the odd numbers
    sortedOddNumbers.Sort();
    
    // Make the newArray 
    for(int j = 0; j < sortedOddNumbers.Count; j++) {
      var oddNumber = sortedOddNumbers[j];
      var oddIndex = oddIndices[j];
      // Even numbers are already in the array.
      // It's time to add sorted odd numbers to the array
      newArray[oddIndex] = oddNumber;
    }
    return newArray;
  }
  
}