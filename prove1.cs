// This is like print("") in python

Console.WriteLine("Hello World!");
Console.Write("There will not be a newline after this.");

// This is like color = input("What is your favorite color")
Console.Write("What is your favorite color?");
string color = Console.Readline();


// python    if x > y:
//              print("greater")

if (x > y)
{
    Console.WriteLine("greater");
}

// python     school = "BYU-Idaho"
//             print (f"I am studying at {school}.")

string school = "BYUI-Idaho";
Console.WriteLine($"I am studying at {school}.")



// python
// input = "yes"

// while input == yes:
    // input = prompt("Do you want to continue? ");


string input = "yes";
while (input == "yes")
{
    Console.Write("Do you want to continue? ");
    input = Console.ReadLine();
}



// This is a do-while loop
// the only difference is that it will run the loop once
// no matter what before it starts looping or if it doesn't loop

string input;

do
{
    Console.Write("Do you want to continue? ");
    input = Console.ReadLine();
} while (input == "yes");


// for loops in cs

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

for (int i = 2; i <= 20; i = i + 2)
{
    Console.WriteLine(i);
}
