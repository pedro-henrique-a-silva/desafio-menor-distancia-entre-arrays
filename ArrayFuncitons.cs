namespace ordenador;


public class ArrayFunctions
{
    public static void Sort(int[] lista)
    {
        for (int i = 1; i < lista.Length; i++)
        {
            int atual = lista[i];
            int idx = i - 1;
            while (idx >= 0 && lista[idx] > atual)
            {
                lista[idx + 1] = lista[idx];
                idx--;
            }
            lista[idx + 1] = atual;
        }
    }

    public static int[] LowerDistance(int[] arr1, int[] arr2)
    {
        int idx1 = 0;
        int idx2 = 0;
        int numArr1Found = arr1[0];
        int numArr2Found = arr1[0];

        int smallest = Math.Abs(arr1[0] - arr2[0]);
        int current = Math.Abs(arr1[0] - arr2[0]);

        while (idx1 < arr1.Length && idx2 < arr2.Length)
        {
            int numArr1 = arr1[idx1];
            int numArr2 = arr2[idx2];

            if (numArr1 < numArr2)
            {
              current = numArr2 - numArr1;
              idx1 += 1;  
            }
            else if (numArr1 > numArr2)
            {
                current = numArr1 - numArr2;
                idx2 += 1;
            }
            else
            {
                return new int[] {numArr1, numArr2};
            }

            if (current < smallest)
            {
                smallest = current;
                numArr1Found = numArr1;
                numArr2Found = numArr2;
            }
        }

        return new int[] {numArr1Found, numArr2Found};
    }
}