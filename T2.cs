/*

function exampleJavaScript(arr) {
	let newArr = [];
  for(let i = 0; i < arr.length; i++){
    let largest = arr[i][0];
    for(let j = 0; j < arr[i].length; j++){
      if(arr[i][j] > largest) {
        largest = arr[i][j]
      }
    }
    newArr.push(largest)
  }
  return newArr
}

console.log(exampleJavaScript([[4, 2, 7, 1], [20, 70, 40, 90], [1, 2, 0]])) // outcome [7, 90, 2]

*/
class Convert //Instancing the class "Convert"
{
    static void Arr() //setting up the function strictly within Convert class
    {
         int[,] NewArray; //The input data being pushed through the function, setup as a multidimentional array of  arrays
        {
            new int[,] {{4, 2, 7, 1}, {20, 70, 40, 90}, {1, 2, 0}};
        };

        for (int i = 0; i < NewArray.Length; i++) //The method for passing through each array
        {
            let BigArray = new arr[i,0];

            for (int j = 0; j < NewArray[i].Lenght; j++) //The method for passing through each value of each array
            {
                if(BigArray[i,j] > BigArray[i, 0]) //The method for finding the max value within each array
                {
                    MaxArray[i,j] = BigArray[i][j]; //Creating a new array equal to the array of max values from the function
                };
            };
        };
            Console.WriteLine(MaxArray[i,j]); //Telling the compiler to produce the values of MaxArray 
               /*
               This was the only place where the code didn't hate the Console.WriteLine
               method so I presume it is correct for now...
               I'm under the assumption that I'm still using some JS syntax in a C# environment. It seems decently similar however, so I'm not too concerned. 
               language I was not expecting to learn, I am then made to learn another in a quarter of the time make them interchangeable. Brilliant.
               */
    }
}