using System;
using static System.Console;

Clear();

string[] GetArray() {
    Write("Введите значения через пробел: ");
    return ReadLine().Split(" ");
}

int FindItem(string[] inarray, int c) {
    int count = 0;

    for(int n = 0; n < inarray.Length; n++) {
        if(inarray[n].Length <= c) {
            count++;
        }
    }

    return count;
}

string[] GetNewArr(string[] inarray, int c) {
    string[] outarray = new string[FindItem(inarray, c)];

    for(int n = 0, m = 0; n < inarray.Length; n++) {
        if(inarray[n].Length <= c) {
            outarray[m] = inarray[n];
            m++;
        }
    }

    return outarray;
}


string[] array = GetArray();
string[] result = GetNewArr(array, 3);
WriteLine($"{string.Join(" ", result)}");

